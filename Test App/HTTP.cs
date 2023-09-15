using System;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test_App
{
    public class HTTP
    {
        // curl request input for reference:
        // curl -X POST -H "Content-Type: application/json" -d "{\"cmd\": \"get_state\"}" http://100.100.100.100:80/slide1/command
        public async Task<string> HTTPSend(string userCommand, string BoxURL, string Box)
        {
            using (var httpClient = new HttpClient())
            {
                var url = BoxURL + "/" + Box + "/command";

                try
                {
                    if (userCommand == null) { return "Command cannot be null. Try again."; }
                    else
                    {
                        var jsonPayload = userCommand;
                        var content = new StringContent(jsonPayload, Encoding.UTF8, "application/json");
                        var contentLength = Encoding.UTF8.GetByteCount(jsonPayload).ToString();
                        content.Headers.Add("Content-Length", contentLength);
                        var response = await httpClient.PostAsync(url, content);
                        if (response.IsSuccessStatusCode)
                        {
                            String responseContent = await response.Content.ReadAsStringAsync();
                            return responseContent;
                        }
                        else
                        {
                            string responseError = "HTTP Error: " + (int)response.StatusCode + " " + response.ReasonPhrase;
                            return responseError;
                        }
                    }
                }
                catch (Exception ex) { MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); return null; }
            }
        }

        public async Task<string> GetState(string BoxURL, string Box)
        {
            string sendMssg = "{\"cmd\": \"get_state\"}";
            String Response = await HTTPSend(sendMssg, BoxURL, Box);

            if (Response.Contains("STARVING")) { return "STARVING"; }
            else if (Response.Contains("OPEN")) { return "OPEN"; }
            else if (Response.Contains("OFF")) { return "OFF"; }
            else if (Response.Contains("BLOCKED")) { return "BLOCKED"; }
            else if (Response.Contains("CRITICAL")) { return "CRITICAL"; }
            else { return "ERROR"; }
        }
    }
}
