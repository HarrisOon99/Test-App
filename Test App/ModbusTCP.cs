using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace Test_App
{
    public class ModbusTCP
    {
        public ModbusTCP() { }

        // Creating TCP connection
        public Socket modbusTCP_open ()
        {
            // Setting up TCP connection through ethernet port.
            int TCPPort = 502;
            IPAddress IpAddr = new IPAddress(new byte[] { Convert.ToByte("10"), Convert.ToByte("123"), Convert.ToByte("162"), Convert.ToByte("10") });
            IPEndPoint IpEndPnt = new IPEndPoint(IpAddr, TCPPort);
            Socket client = new Socket(IpAddr.AddressFamily, SocketType.Stream, ProtocolType.Tcp);

            // Trying to connect to a PLC to ensure that it is the correct device.
            try { client.Connect(IpEndPnt); } 
            catch (Exception ex) { Console.WriteLine(ex.ToString()); return null; }
            return client;
        }

        // Build TCP message.
        public static byte[] BuildMssg(byte slaveAddr, ushort startAddr, byte function, uint NoP)
        {
            int TransactionID = 0;
            byte[] frame = new byte[12];

            frame[0] = (byte)(TransactionID >> 8);  // Transaction Identifier High Byte
            frame[1] = (byte)(TransactionID);       // Transaction Identifier Low Byte
            frame[2] = 0;                           // Protocol Identifier High Byte
            frame[3] = 0;                           // Protocol Identifier Low Byte
            frame[4] = 0;                           // Message Length High Byte
            frame[5] = 6;                           // Message Length Low Byte (6 bytes to follow)
            frame[6] = slaveAddr;                   // Slave address
            frame[7] = function;                    // Function code
            frame[8] = (byte)(startAddr >> 8);      // Starting Address High Byte
            frame[9] = (byte)(startAddr);           // Starting Address low Byte
            frame[10] = (byte)(NoP >> 8);           // Quantity of Registers High Byte
            frame[11] = (byte)(NoP);                // Quantity of Registers Low Byte

            TransactionID += 1;
            return frame;
        }

        // Send TCP message.
        public int TCP_Mssg_Send(Socket client, byte slaveAddr, int startAddr, byte function, uint NoP = 1)
        {
            byte[] frame = new byte[12];
            ushort reply = 0xFFFF;
            ushort newStartAddr = Convert.ToUInt16(startAddr - 1);

            if (function == 5)
            {
                if (NoP == 1) { NoP = 65280; }
                else { NoP = 0; }
            }

            frame = BuildMssg(slaveAddr, newStartAddr, function, NoP);
            try { client.Send(frame); } catch (Exception ex) { Console.WriteLine(ex.ToString()); }
            check_respnd(client, ref reply);
            return reply;
        }

        // Check TCP response.
        static void check_respnd(Socket client, ref ushort reply)
        {
            byte[] returnValue = new byte[12];                      // For returning value from socket.
            try { client.Receive(returnValue); } catch (TimeoutException ex) { throw ex; }
            int function = returnValue[7];                          // Function code.
            int RegisterValue = returnValue[8];                     // Response for function 3.
            int coilState = returnValue[9];                         // Response for function 1 & 2.

            if (function == 1 || function == 2)
            {
                if (coilState < 2) { reply = (ushort)coilState; }   // First two coils will always output its coil state.
                else if (coilState % 2 == 0) { reply = 0; }         // After the first two coils, coil is high (1) if response is an odd number.
                else { reply = 1; }                                 // coil is low (0) if response is an even number.
            }
            else if (function == 3)
            {
                byte[] tmpArray = returnValue.Skip(9).Take(RegisterValue).ToArray();
                Array.Reverse(tmpArray);
                reply = BitConverter.ToUInt16(tmpArray, 0);
            }
        }

        // Close TCP connection.
        public void ModbusTCP_close(Socket client)
        {
            try { client.Shutdown(SocketShutdown.Both); } catch { }
            try { client.Close(); } catch { }
        }
    }
}