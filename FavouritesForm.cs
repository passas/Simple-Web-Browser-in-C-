using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Snow
{
    public partial class FavouritesForm : Form
    {
       private Form1 fm;
       private FavouritesToolStrip favouriteItem = null;

        //Constructor
        //Use form 1 as guide
        public FavouritesForm(Form1 form)
        {
            fm = form;
            InitializeComponent();
        }


        public void editFavourite(FavouritesToolStrip favorite)
        {
            favouriteItem = favorite;
            textBox1.Text = favorite.Text;
            textBox2.Text = favorite.url;
            ShowDialog();
        }


        //When clicking "OK" button
        private void button1_Click_1(object sender, EventArgs e)
        {
            //If there is no favourite item
            if (favouriteItem == null)
            {
                //Create a new FavouritesToolStrip and add the favourite's name and url and then add it to the ToolStrip
                favouriteItem = new FavouritesToolStrip(textBox1.Text, textBox2.Text, fm);
                fm.FavouritesToolStrip.DropDownItems.Add(favouriteItem);
            }
            else
            {
                favouriteItem.Text = textBox1.Text;
                favouriteItem.url = textBox2.Text;
            }
            //Hide the form afterwards
            this.Hide();
            favouriteItem = null;
            textBox1.Text = "";
            textBox2.Text = "";
        }
        
    }
}
