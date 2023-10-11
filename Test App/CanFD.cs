using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Kvaser.CanLib;

namespace Test_App
{
    public class CanFD
    {
        // Open CAN communication channel.
        public int CanFD_open(int ChannelNum)
        {
            int handle;
            Canlib.canStatus status;
            try
            {
                handle = Canlib.canOpenChannel(ChannelNum, Canlib.canOPEN_CAN_FD | Canlib.canOPEN_REQUIRE_EXTENDED);    // Open CAN channel.
                if (handle < 0) { throw new Exception("CanFD handle is not connected."); }
                status = Canlib.canSetBusParams(handle, Canlib.canFD_BITRATE_1M_80P, 63, 16, 16, 3);                    // Define arbitration phase parameters.
                status = Canlib.canSetBusParamsFd(handle, Canlib.canFD_BITRATE_4M_80P, 15, 4, 4);                       // Define data phase parameters.
                status = Canlib.canBusOn(handle);                                                                       // Go onto bus.
                return handle;
            }
            catch (Exception e) { MessageBox.Show(e.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); return handle = -1; }
        }

        // Close CAN communication channel.
        public void CanFD_close(int handle)
        {
            Canlib.canStatus status;
            status = Canlib.canBusOff(handle);  // Go off bus.
            status = Canlib.canClose(handle);   // Close CAN channel.
        }

        // Write CAN message to destination.
        public void CanFD_write(int handle, int identifier, byte[] sendMssg, int DLC)
        {
            Canlib.canStatus status;
            try { status = Canlib.canWrite(handle, identifier, sendMssg, DLC, Canlib.canFDMSG_FDF | Canlib.canMSG_EXT); }
            catch (Exception ex) { throw ex; }
        }

        // Read CAN message from destination.
        public byte[] CanFD_read(int handle, int identifier)
        {
            Canlib.canStatus status;
            byte[] receivedMssg = new byte[64];
            try { status = Canlib.canReadSpecificSkip(handle, identifier, receivedMssg, out int DLC, out int flag, out long time); }
            catch (Exception ex) { throw ex; }
            return (receivedMssg);
        }
    }
}
