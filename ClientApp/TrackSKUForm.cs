using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClientApp
{
    public partial class TrackSKUForm : Form
    {
        // create the list of the item
        private List<ItemsForSell> items;
        private Event Aevent;
        public TrackSKUForm()
        {
            InitializeComponent();
            // initialize the items
            items = new List<ItemsForSell>();
            // show all the items from database

            // find the items which is not enough quantity
            // and show them on the listView

            // initialize the event

            // calculate the number of users

            
        }
        private MainForm mainForm = null;
        public TrackSKUForm(Form callingForm)
        {
            mainForm = callingForm as MainForm;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            mainForm.Show();
            this.Hide();
        }

        private void BTfill_Click(object sender, EventArgs e)
        {
            int Quantity = Convert.ToInt16(TBQuantity.Text);
            try
            {
                // select the item from reminder

                // find the item form the list items
                
                // increase the stock of the item

                // display the item in the listview
            }
            catch (Exception)
            {
                
                throw;
            }
        }



    }
}
