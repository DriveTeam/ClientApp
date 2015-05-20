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
    public partial class StoreForm : Form
    {
        Store mystore;
        public List<Item> tempList = new List<Item>();
        public List<Item> tempList2 = new List<Item>();
        public StoreForm()
        {
            InitializeComponent();
            //mystore = new Store();
            //tempList = mystore.GetAllItems();
            //foreach (var item in tempList)
            //{
            //    string[] row = { item.Name, item.Price.ToString() };
            //    var listitem = new ListViewItem(row);
            //    listView1.Items.Add(listitem);
            //}

        }

        private MainForm mainForm = null;
        public StoreForm(Form callingForm)
        {
            mainForm = callingForm as MainForm;
            InitializeComponent();
            mystore = new Store();
            tempList = mystore.GetAllItems();
            int i = 0;
            foreach (var item in tempList)
            {
                string[] row = { item.ItemId.ToString(), item.Name, item.Type, item.Price.ToString(), item.Quantity.ToString() };
                var listitem = new ListViewItem(row, i);
                listitem.Tag = item;
                i++;
                listView1.Items.Add(listitem);

            }
            listView1.Select();
            listView1.HideSelection = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            mainForm.Show();
            this.Hide();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
        decimal newprice = 0;
        private void BTcheckInOut_Click(object sender, EventArgs e)
        {
            decimal price;
            int quant = int.Parse(textBox2.Text);

            foreach (ListViewItem item in listView1.SelectedItems)
            {
                Item it = (Item)item.Tag;
                Item temp = new Item(it.ItemId, it.Name, it.Type, it.Price, it.Quantity);
                tempList2.Add(temp);
                item.SubItems[4].Text = (it.Quantity -= quant).ToString(); ;
                price = it.Price * quant;
                newprice += price;
                string[] row = { it.Name, quant.ToString(), price.ToString() };
                ListViewItem lvi = new ListViewItem(row);
                listView2.Items.Add(lvi);
                textBox4.Text = newprice.ToString();
            }

        }


        private void button2_Click(object sender, EventArgs e)
        {
            int index = listView2.SelectedIndices[0];

            foreach (ListViewItem item in listView2.SelectedItems) // items in second list
            {
                Item it = (Item)item.Tag;
                int quantt = int.Parse(item.SubItems[1].Text);

                tempList2[index].Quantity -= quantt;


                listView2.Items.Remove(item);
                decimal price = decimal.Parse(textBox4.Text);
                price -= decimal.Parse(item.SubItems[2].Text); // update price
                textBox4.Text = price.ToString();
                foreach (ListViewItem it2 in listView1.Items)
                {
                    Item itemm2 = (Item)it2.Tag;
                    if (itemm2.Name == tempList2[index].Name) // if tags match
                    {

                        it2.SubItems[4].Text = (tempList2[index].Quantity + quantt).ToString();
                        //       // Item ite = new Item(it.ItemId, it.Name, it.Type, it.Price, it.Quantity);
                        //        item2.SubItems[4].Text = (it.Quantity += quant).ToString();
                        //        throw new NullReferenceException();
                    }
                }

            }
        }


        //private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        //{
        //    //     int quant = int.Parse(textBox2.Text);
        //    //    if (listView1.SelectedItems.Count < 0)

        //    //    int i = int.Parse(listView1.SelectedIndices.ToString());
        //    //}
        //}
    }
}


