using System;
using System.Windows.Forms;

namespace ClientApp
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void BTcheckInOut_Click(object sender, EventArgs e)
        {
            CheckInOutForm frm = new CheckInOutForm(this);
            frm.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            StoreForm storeForm = new StoreForm(this);
            storeForm.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ReceptionForm personalForm = new ReceptionForm(this);
            personalForm.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            TrackSKUForm trackForm = new TrackSKUForm(this);
            trackForm.Show();
            this.Hide();
        }
    }
}
