using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Snow
{
    class XML
    {
           public XML{
           
            }
          
        }
        private void createNode(string url,DateTime Date, XmlTextWriter writer)
        {
            writer.WriteStartElement("WebPage");
            writer.WriteStartElement("URL");
            writer.WriteString(url);
            //end <URL>
            writer.WriteEndElement();
            writer.WriteStartElement("Date Visited");
            writer.WriteString(Convert.ToString(Date));
            //end <Date Visited>
            writer.WriteEndElement();
            //end <Web Page>
            writer.WriteEndElement();
        }
}
