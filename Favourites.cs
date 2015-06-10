using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Xml;
using System.Xml.Linq;
using System.IO;

namespace Snow
{
    class Favourites
    {

        public string Url;
        public string Name;
        

        //Constructor
        public Favourites(string url, string name)
        {
            this.Url = url;
            this.Name = name;
            
        }
    }

    class FavouritesList 
    {
        string favXmlPath; 
        //Create favourites List of <Favourites> objects
        public List<Favourites> favList = new List<Favourites>();

        public FavouritesList()
        {
            favXmlPath = Environment.CurrentDirectory + "\\favourites.xml";
        }
      
        public void AddFavourite(string url, string name)
        {
            favList.Add(new Favourites(url, name));
        }

//--------------Filling and Loading Lists from XML----------------------

        //Loads the contents of the Xml on a list
        public void FavXmlToList()
        {
            if (File.Exists(favXmlPath))
            {
                XDocument doc = XDocument.Load(favXmlPath);
                var list = doc.Root.Elements("webPage");

                //Load list with Xml Contents
                foreach (XElement favourites in list)
                {
                    string url = favourites.Element("url").Value;
                    string name = favourites.Element("name").Value;
                    favList.Add(new Favourites(url, name));
                }               
            }
        }

        //Saves Favourites List to an Xml
        public void FavListToXml()
        {
            XmlTextWriter writer = new XmlTextWriter(favXmlPath, System.Text.Encoding.UTF8);
            writer.WriteStartDocument(true);
            writer.Formatting = Formatting.Indented;
            writer.Indentation = 2;

            writer.WriteStartElement("favourites");
            //For each Favourites element on the list create an identical xml Element
            foreach (Favourites fav in favList)
            {
                writer.WriteStartElement("webPage");
                writer.WriteElementString("url", fav.Url);
                writer.WriteElementString("name", fav.Name);
                writer.WriteEndElement();
            }
            writer.WriteEndElement();
            writer.WriteEndDocument();
            writer.Close();
        }
    }
}
