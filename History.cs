using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Xml;
using System.Xml.Linq;
using System.IO;

namespace Snow
{
    class History
    {
        public string Url;
        public History(string url)
        {
            this.Url = url;
        }
    }

    class HistoryList
    {
        string historyXmlPath;
        public List<string> hList = new List<string>();

        //Constructor
        public HistoryList()
        {
            //History Xml Location -- Same as executable's
            historyXmlPath = Environment.CurrentDirectory + "\\history.xml";         
        }

        //Add new url to historyList
        public void AddHistory(string url)
        {
            hList.Add(url);
        }

        //Loads the contents of the Xml on a list
        public void HistoryXmlToList()
        {
            if (File.Exists(historyXmlPath))
            {
                XDocument doc = XDocument.Load(historyXmlPath);
                var list = doc.Root.Elements("url").Select(element => element.Value).ToList();
                foreach (string url in list)
                {
                    hList.Add(url);
                }
            }

        }

        //Saves History List to an Xml
        public void hListToXml()
        {
            XmlTextWriter writer = new XmlTextWriter(historyXmlPath, System.Text.Encoding.UTF8);
            writer.WriteStartDocument(true);
            writer.Formatting = Formatting.Indented;
            writer.Indentation = 2;
            writer.WriteStartElement("history");

            foreach (string url in hList)
            {
               writer.WriteElementString("url", url);
            }
            writer.WriteEndElement();
            writer.WriteEndDocument();
            writer.Close();

        }
    }
}
