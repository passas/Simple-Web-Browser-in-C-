using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Snow
{
    //Creates a ToolStripMenuItem to include all the history of visited links
    public class HistoryToolStrip : ToolStripMenuItem
    {
        
        private Form1 form;
        //Constructor
        //Accessing the url parameter from the base class
        public HistoryToolStrip(string url, Form1 fm): base(url)
        {
            this.form = fm;
            //Create a new event on mouse click
            Click += new System.EventHandler(History_Click);
        }

        public void History_Click(object sender, EventArgs e)
        {
            //On click visit the selected link
            TabsHandler tab = (TabsHandler)form.tabControl2.TabPages[form.tabControl2.SelectedIndex];
            tab.GoToPage(Text);
        }
    }
}
