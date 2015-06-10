using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.IO;

namespace Snow
{
    public class HttpCommunication
    { 
        private string url;
        private string request;
        private Boolean proxy = false;
        private string proxyServer;
        private int proxyPort;


        public void HttpGet (
        richTextBox1.Text = "";
            try
            {
                string url = this.url.Text;
                Uri myUri = new Uri(url);
                //Create HttpWebRequest for the above url.
                HttpWebRequest req = (HttpWebRequest)WebRequest.Create(myUri);


                // Assign the response object of 'HttpWebRequest' to a 'HttpWebResponse' variable.
                HttpWebResponse myHttpWebResponse = (HttpWebResponse)req.GetResponse();
                if (myHttpWebResponse.StatusCode == HttpStatusCode.OK)
                {
                    // Display the contents of the page to the console.
                    Stream receiveStream = myHttpWebResponse.GetResponseStream();
                    Encoding encode = System.Text.Encoding.GetEncoding("utf-8");

                    // Get stream object
                    StreamReader readStream = new StreamReader(receiveStream, encode);
                    Char[] read = new Char[256];

                    // Read from buffer
                    int count = readStream.Read(read, 0, 256);
                    while (count > 0)
                    {
                        // get string
                        String resultData = new String(read, 0, count);

                        // Write the data
                        richTextBox1.Text += (resultData);

                        // Read from buffer
                        count = readStream.Read(read, 0, 256);
                    }
                    // Releases the resources of the response.
                    myHttpWebResponse.Close();
                    // Release the resource of the Stream.
                    readStream.Close();
                }
                else if (myHttpWebResponse.StatusCode == HttpStatusCode.NotFound)
                    richTextBox1.Text = "Page Not Found!!!";
                else if (myHttpWebResponse.StatusCode == HttpStatusCode.BadRequest)
                    richTextBox1.Text = "Bad Request!!!";
                else if (myHttpWebResponse.StatusCode == HttpStatusCode.Forbidden)
                    richTextBox1.Text = "Forbidden!!!";
            }
            catch (WebException ex)
            {

                richTextBox1.Text = "Exception was raised : " + ex.Status;
            }

           
    }
}
