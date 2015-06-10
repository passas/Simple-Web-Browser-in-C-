using System;using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Threading;
using System.Net;
using System.IO;

namespace Snow
{
    class TabsHandler : TabPage 
    {
#region old code 
    //    //Declare thread variable 
    //    private Thread thread = null;
    //    //Declare Containers
    //    private TextBox txtbox = new TextBox();

    //    public string url = "";

    //    //Constructor
    //    public TabsHandler()
    //    {
    //        //RichTextBox to fill the tab and not editable
    //        this.txtbox.ReadOnly = true;
    //        this.txtbox.Dock = DockStyle.Fill;

    //        // add split container to the tab
    //        base.Controls.Add(txtbox);
    //        //Set the name of the New Tab
    //        base.Text = "New Tab";
    //    }

    //    public void GoToPage(string url)
    //    {
    //        this.url = url;

    //        //Start new Thread
    //        this.thread = new Thread(new ThreadStart(this.Http));
    //        this.thread.Start();
 
    //    }

    //    //method to handle HttpRequests and HttpResponses 
    //    private void Http()
    //    { 

    //        HttpWebRequest req;
    //        HttpWebResponse resp;
    //        string msg;

    //        try
    //        {
    //            req = (HttpWebRequest)WebRequest.Create(this.url);

    //            try
    //            {
    //                resp = (HttpWebResponse)req.GetResponse();      
    //            }
    //            catch (WebException e)
    //            {

    //                resp = e.Response as HttpWebResponse;
    //            }
    //            int code = (int)resp.StatusCode;

    //            if (code == 200)
    //            {
    //                msg = new StreamReader(resp.GetResponseStream()).ReadToEnd();
    //            }
    //            else if (code == 400)
    //                msg = "Bad Request";
    //            else if (code == 403)
    //                msg = "Forbidden";
    //            else if (code == 404)
    //                msg = "Not Found";
    //            else
    //                msg = "An error occured: " + code;
    //        }
    //        catch (Exception e)
    //        {
                
    //            throw e;
    //        }

    //        AppendTextBox(msg);
    //    }





    //    //http://stackoverflow.com/questions/519233/writing-to-a-textbox-from-another-thread
    //    //http://www.codeproject.com/Articles/37642/Avoiding-InvokeRequired
    //    public void AppendTextBox(string value)
    //    {
    //        if (InvokeRequired)
    //        {
    //            this.Invoke(new Action<string>(AppendTextBox), new object[] { value });
    //            return;
    //        }
    //        this.txtbox.Text = value;
    //    }
    //}
#endregion

        private Thread workerThread = null;
        private RichTextBox txt = new RichTextBox();

        public string url = "";

        //Constructor
        public TabsHandler()
        {
            //Make Textbox filling the tab and not editable
            this.txt.Dock = DockStyle.Fill;
            this.txt.ReadOnly = true;

            // add split container to the tab
            base.Controls.Add(txt);

            // set new tabs name as "New Tab"
            base.Text = "New Tab";
        }

 //----------------------Http Requests and Responses------------------------

        public void GoToPage(string url)
        {
            
            this.url = url;
            if (url != "")
            {
                base.Text = url;
                // Start a new thread
                this.workerThread = new Thread(new ThreadStart(this.Http));
                this.workerThread.Start();
            }
        }


        //Http Requests and Responses
        private void Http()
        {              
            HttpWebRequest req;
            HttpWebResponse resp;
            string msg;
            try
            {
                req = (HttpWebRequest)WebRequest.Create(this.url);
                try
                {
                    resp = (HttpWebResponse)req.GetResponse();
                }
                catch (WebException e)
                {
                    resp = e.Response as HttpWebResponse;
                }
                int code = (int)resp.StatusCode;

                if (code == 200)
                {
                    msg = new StreamReader(resp.GetResponseStream()).ReadToEnd();
                }
                else if (code == 400)
                    msg = "Bad Request";
                else if (code == 403)
                    msg = "Forbidden";
                else if (code == 404)
                    msg = "Not Found";
                else
                    msg = "An error occured: " + code;
            }
            catch (Exception e)
            {
                msg = "Cannot Connect";
            }
            AppendTextBox(msg);
        }

        //Method to append the HTTP responses and cast it somewhere else
        //http://stackoverflow.com/questions/519233/writing-to-a-textbox-from-another-thread
        public void AppendTextBox(string value)
        {
            if (InvokeRequired)
            {
                this.Invoke(new Action<string>(AppendTextBox), new object[] { value });
                return;
            }
            txt.Text = value;
        }
    }
}
