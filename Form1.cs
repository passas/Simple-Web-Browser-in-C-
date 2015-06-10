using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Net;
using System.IO;
using System.Xml;
using System.Xml.Linq;
using System.Threading;

namespace Snow
{
    public partial class Form1 : Form
    {
        public FavouritesForm favForm;
        public Form1()
        {
            InitializeComponent();
            Load += new EventHandler(Form1_Load);


        }

        public void Form1_Load(object sender, EventArgs e)
        {
            //Load History from Xml
            HistoryList hist = new HistoryList();
            hist.HistoryXmlToList();

            foreach (string h in hist.hList)
            {
                historyToolStrip.DropDownItems.Add(new HistoryToolStrip(h, this));
            }



            //Load Favourites from Xml
            FavouritesList f = new FavouritesList();
            f.FavXmlToList();
            foreach (Favourites fav in f.favList)
            {
                FavouritesToolStrip.DropDownItems.Add(new FavouritesToolStrip(fav.Name, fav.Url, this));
            }

            favForm = new FavouritesForm(this);
            tabControl2.TabPages.Add(new TabsHandler());
           
        }



            //-----------------------------------------------------------------------------
            #region oldCode
            //    try
            //    {
            //        string url = homePage;
            //        Uri myUri = new Uri(url);
            //        //Create HttpWebRequest for the above url.
            //        HttpWebRequest req = (HttpWebRequest)WebRequest.Create(myUri);


            //        // Assign the response object of 'HttpWebRequest' to a 'HttpWebResponse' variable.
            //        HttpWebResponse myHttpWebResponse = (HttpWebResponse)req.GetResponse();


            //        // Display the contents of the page to the console.
            //        Stream receiveStream = myHttpWebResponse.GetResponseStream();
            //        Encoding encode = System.Text.Encoding.GetEncoding("utf-8");

            //        // Get stream object
            //        StreamReader readStream = new StreamReader(receiveStream, encode);
            //        Char[] read = new Char[256];

            //        // Read from buffer
            //        int count = readStream.Read(read, 0, 256);
            //        while (count > 0)
            //        {
            //            // get string
            //            String resultData = new String(read, 0, count);

            //            // Write the data
            //            richTextBox1.Text += (resultData);

            //            // Read from buffer
            //            count = readStream.Read(read, 0, 256);
            //        }
            //        // Releases the resources of the response.
            //        myHttpWebResponse.Close();
            //        // Release the resource of the Stream.
            //        readStream.Close();


            //    }
            //    catch (WebException ex)
            //    {
            //        HttpWebResponse errorResponse = ex.Response as HttpWebResponse;
            //        if (errorResponse.StatusCode == HttpStatusCode.NotFound)
            //            //404 - Not Found
            //            richTextBox1.Text = "Page Not Found!!!";
            //        else if (errorResponse.StatusCode == HttpStatusCode.BadRequest)
            //            //400 - Bad Request
            //            richTextBox1.Text = "Bad Request!!!";
            //        else if (errorResponse.StatusCode == HttpStatusCode.Forbidden)
            //            //403 - Forbidden
            //            richTextBox1.Text = "Forbidden!!!";
            //    }

            //}

            //private void go_Click(object sender, EventArgs e)
            //{
            //    string url = this.url.Text;
            //    this.url.Text = url;

            //    historyList.Add(new History() { url = this.url.Text, dateSaved = DateTime.Now });

            //    ////Add new link to History.Xml
            //    //historyXml.addToXml(historyXmlPath, this.url.Text, Convert.ToString(DateTime.Now));
            //    ////Load new History List from Xml
            //    //historyList = historyXml.XmlToList(historyXmlPath, historyList, "History");
            //    this.listBox2.DataSource = historyList;
            //    this.listBox2.DisplayMember = "Url";
            //    listBox2.Refresh();

            //    richTextBox1.Text = "";
            //    //HttpHandler req = new HttpHandler();
            //    //richTextBox1.Text = req.HttpRequestResponse(url.Text);

            //    try
            //    {

            //        Uri myUri = new Uri(url);
            //        //Create HttpWebRequest for the above url.
            //        HttpWebRequest req = (HttpWebRequest)WebRequest.Create(myUri);


            //        // Assign the response object of 'HttpWebRequest' to a 'HttpWebResponse' variable.
            //        HttpWebResponse myHttpWebResponse = (HttpWebResponse)req.GetResponse();
            //        if (myHttpWebResponse.StatusCode == HttpStatusCode.OK)
            //        {
            //            // Display the contents of the page to the console.
            //            Stream receiveStream = myHttpWebResponse.GetResponseStream();
            //            Encoding encode = System.Text.Encoding.GetEncoding("utf-8");

            //            // Get stream object
            //            StreamReader readStream = new StreamReader(receiveStream, encode);
            //            Char[] read = new Char[256];

            //            // Read from buffer
            //            int count = readStream.Read(read, 0, 256);
            //            while (count > 0)
            //            {
            //                // get string
            //                String resultData = new String(read, 0, count);

            //                // Write the data
            //                richTextBox1.Text += (resultData);

            //                // Read from buffer
            //                count = readStream.Read(read, 0, 256);
            //            }
            //            // Releases the resources of the response.
            //            myHttpWebResponse.Close();
            //            // Release the resource of the Stream.
            //            readStream.Close();
            //        }
            //        else if (myHttpWebResponse.StatusCode == HttpStatusCode.NotFound)
            //            richTextBox1.Text = "Page Not Found!!!";
            //        else if (myHttpWebResponse.StatusCode == HttpStatusCode.BadRequest)
            //            richTextBox1.Text = "Bad Request!!!";
            //        else if (myHttpWebResponse.StatusCode == HttpStatusCode.Forbidden)
            //            richTextBox1.Text = "Forbidden!!!";
            //    }
            //    catch (WebException ex)
            //    {
            //        HttpWebResponse errorResponse = ex.Response as HttpWebResponse;
            //        if (errorResponse.StatusCode == HttpStatusCode.NotFound)
            //            //404 - Not Found
            //            richTextBox1.Text = "Page Not Found!!!";
            //        else if (errorResponse.StatusCode == HttpStatusCode.BadRequest)
            //            //400 - Bad Request
            //            richTextBox1.Text = "Bad Request!!!";
            //        else if (errorResponse.StatusCode == HttpStatusCode.Forbidden)
            //            //403 - Forbidden
            //            richTextBox1.Text = "Forbidden!!!";
            //    }


            //}



            //private void favourite_Click(object sender, EventArgs e)
            //{
            //    ////-------------Save List Content to Xml and refresh listbox--------------------     

            //    favouritesList.Add(new Favourites() { url = this.url.Text, dateSaved = DateTime.Now });

            //    //favouritesList = favouritesXml.XmlToList(favouritesXmlPath,favouritesList,"Favourites");
            //    this.listBox1.DataSource = favouritesList;
            //    this.listBox1.DisplayMember = "";
            //    this.listBox1.DisplayMember = "Url";
            //    this.listBox1.Refresh();

            //}

            //private void home_Click(object sender, EventArgs e)
            //{

            //    richTextBox1.Text = "";
            //    string url = homePage;
            //    this.url.Text = "url";
            //    //HttpHandler req = new HttpHandler();
            //    //richTextBox1.Text = req.HttpRequestResponse(url.Text);

            //    try
            //    {
            //        Uri myUri = new Uri(url);
            //        //Create HttpWebRequest for the above url.
            //        HttpWebRequest req = (HttpWebRequest)WebRequest.Create(myUri);


            //        // Assign the response object of 'HttpWebRequest' to a 'HttpWebResponse' variable.
            //        HttpWebResponse myHttpWebResponse = (HttpWebResponse)req.GetResponse();
            //        if (myHttpWebResponse.StatusCode == HttpStatusCode.OK)
            //        {
            //            // Display the contents of the page to the console.
            //            Stream receiveStream = myHttpWebResponse.GetResponseStream();
            //            Encoding encode = System.Text.Encoding.GetEncoding("utf-8");

            //            // Get stream object
            //            StreamReader readStream = new StreamReader(receiveStream, encode);
            //            Char[] read = new Char[256];

            //            // Read from buffer
            //            int count = readStream.Read(read, 0, 256);
            //            while (count > 0)
            //            {
            //                // get string
            //                String resultData = new String(read, 0, count);

            //                // Write the data
            //                richTextBox1.Text += (resultData);

            //                // Read from buffer
            //                count = readStream.Read(read, 0, 256);
            //            }
            //            // Releases the resources of the response.
            //            myHttpWebResponse.Close();
            //            // Release the resource of the Stream.
            //            readStream.Close();
            //        }
            //        else if (myHttpWebResponse.StatusCode == HttpStatusCode.NotFound)
            //            richTextBox1.Text = "Page Not Found!!!";
            //        else if (myHttpWebResponse.StatusCode == HttpStatusCode.BadRequest)
            //            richTextBox1.Text = "Bad Request!!!";
            //        else if (myHttpWebResponse.StatusCode == HttpStatusCode.Forbidden)
            //            richTextBox1.Text = "Forbidden!!!";
            //    }
            //    catch (WebException ex)
            //    {
            //        HttpWebResponse errorResponse = ex.Response as HttpWebResponse;
            //        if (errorResponse.StatusCode == HttpStatusCode.NotFound)
            //            //404 - Not Found
            //            richTextBox1.Text = "Page Not Found!!!";
            //        else if (errorResponse.StatusCode == HttpStatusCode.BadRequest)
            //            //400 - Bad Request
            //            richTextBox1.Text = "Bad Request!!!";
            //        else if (errorResponse.StatusCode == HttpStatusCode.Forbidden)
            //            //403 - Forbidden
            //            richTextBox1.Text = "Forbidden!!!";
            //    }

            //}

            //private void refresh_Click(object sender, EventArgs e)
            //{
            //    Form.ActiveForm.Refresh();
            //}

            //private void cancel_Click(object sender, EventArgs e)
            //{
            //    Form.ActiveForm.Dispose();
            //}

            //private void forward_Click(object sender, EventArgs e)
            //{
            //    historyList.GetEnumerator();
            //}

            //private void history_Click(object sender, EventArgs e)
            //{
            //    if (!tabControl1.Visible)
            //        tabControl1.Visible = true;
            //    else
            //        tabControl1.Visible = false;
            //}

            //private void button2_Click(object sender, EventArgs e)
            //{
            //    //Remove Item from List

            //}

            //private void Form1_FormClosing_1(object sender, FormClosingEventArgs e)
            //{
            //    #region Update History and Favourites Xml
            //    //---------------Update Xml with new List Contents----------------------------
            //    //for Xml
            //    try
            //    {
            //        var xEle = new XElement("Favourites",
            //                from elem in favouritesList
            //                select new XElement("WebPage",
            //                    new XElement("Url", elem.url),
            //                    new XElement("Date", elem.dateSaved)
            //                    ));
            //        xEle.Save(favouritesXmlPath);

            //    }
            //    catch (Exception ex)
            //    {
            //        Console.WriteLine(ex.Message);
            //    }
            //    //for History
            //    try
            //    {
            //        var xEle = new XElement("History",
            //                from elem in historyList
            //                select new XElement("WebPage",
            //                    new XElement("Url", elem.url),
            //                    new XElement("Date", elem.dateSaved)
            //                    ));
            //        xEle.Save(historyXmlPath);
            //    }
            //    catch (Exception ex)
            //    {
            //        Console.WriteLine(ex.Message);
            //    }

            //}

            //private void button3_Click(object sender, EventArgs e)
            //{
            //    TabPage tab = new TabPage();            
            //    tabControl2.TabPages.Add(tab);
            //    tab.Text = homePage;
            //    tab.Controls.Add(richTextBox1);
            //}
            #endregion


        //Visit Home Page - Set to : www.google.com
        private void home_Click(object sender, EventArgs e)
        {
            TabsHandler active_tab = (TabsHandler)tabControl2.TabPages[tabControl2.SelectedIndex];
            active_tab.GoToPage("http://www.google.com");
        }

        //Go button - Visit the url specified
        private void go_Click(object sender, EventArgs e)
        {
            TabsHandler active_tab = (TabsHandler)tabControl2.TabPages[tabControl2.SelectedIndex];
            active_tab.GoToPage(url.Text);
            historyToolStrip.DropDownItems.Add(new HistoryToolStrip(url.Text,this));         
        }
        //Refresh button, reloads the url inside the textbox
        private void refresh_Click(object sender, EventArgs e)
        {
            TabsHandler active_tab = (TabsHandler)tabControl2.TabPages[tabControl2.SelectedIndex];
            active_tab.GoToPage(url.Text);
            historyToolStrip.DropDownItems.Add(new HistoryToolStrip(url.Text, this));
        }

        //Add url to favourites
        private void addToFavouritesToolStrip_Click(object sender, EventArgs e)
        {
            //Get active tab and place its url it inside favouritesForm
            TabsHandler active_tab = (TabsHandler)tabControl2.TabPages[tabControl2.SelectedIndex];
            favForm.textBox2.Text = url.Text;
            favForm.ShowDialog();
        }

        //On form closing
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {   
            //Update HistoryList and save into an Xml
            HistoryList h = new HistoryList();                
            foreach (HistoryToolStrip history in historyToolStrip.DropDownItems)
            {
                h.AddHistory(history.Text);
            }
            h.hListToXml();

            //Update favouritesList and save into Xml
            FavouritesList f = new FavouritesList();
            foreach (object favourite in FavouritesToolStrip.DropDownItems)
            {
                //Check if its type of FavouritesToolStrip
                if (favourite.GetType() == typeof(FavouritesToolStrip))
                {
                    FavouritesToolStrip favorite_menu_item = (FavouritesToolStrip)favourite;
                    f.AddFavourite(favorite_menu_item.Text, favorite_menu_item.url);
                }
            }
            f.FavListToXml();
        }

        //Add a new Tab
        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            tabControl2.TabPages.Add(new TabsHandler());
            //Bring new tab in front
            tabControl2.SelectedIndex = tabControl2.TabPages.Count - 1;
        }

       

       

       
    }
}




