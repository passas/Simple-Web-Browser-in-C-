using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Snow
{
    //Creates a ToolStripMenuItem which displays the added Favourites in a dropDown menu
    public class FavouritesToolStrip : ToolStripMenuItem
    {
        ContextMenuStrip menu = new ContextMenuStrip();
        private Form1 fm;
        public string url;


        //Constructor
        public FavouritesToolStrip(string name, string url, Form1 fm1) : base(name)
        {
            fm = fm1;
            this.url = url;

            ToolStripMenuItem Edit = new ToolStripMenuItem("Edit");
            ToolStripMenuItem Delete = new ToolStripMenuItem("Delete");


            //Load events on button clicks
            Edit.Click += new System.EventHandler(EditMenuItem_Click);
            Delete.Click += new System.EventHandler(DeleteMenuItem_Click);

            //Add items Delete and Edit on favourites menu
            menu.Items.Add(Edit);
            menu.Items.Add(Delete);
        }
        private void DeleteMenuItem_Click(object sender, EventArgs e)
        {
            // Remove item from favouritesToolStrip
            fm.FavouritesToolStrip.DropDownItems.Remove(this);
        }
            //Edit item 
        private void EditMenuItem_Click(object sender, EventArgs e)
        {
            fm.favForm.editFavourite(this);
        }

        //Method that indicates the events stated on contructor
        protected override void OnMouseDown(MouseEventArgs e)
        {
            base.OnMouseDown(e);
            switch (e.Button)
            {
                case MouseButtons.Right:
                    {
                        //Places the menu at the pointer position
                        menu.Show(fm, e.X, e.Y);
                        menu.Show(Cursor.Position);                      
                    }
                    break;
                case MouseButtons.Left:
                    {
                        
                        //Select active tab and visit URL
                        TabsHandler active_tab = (TabsHandler)fm.tabControl2.TabPages[fm.tabControl2.SelectedIndex];
                        active_tab.GoToPage(url);
                    }
                    break;
            }


        }
    }
}
