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
    public partial class CheckInOutForm : Form
    {
        public CheckInOutForm()
        {
            InitializeComponent();
        }
        private MainForm mainForm = null;
        public CheckInOutForm(Form callingForm)
        {
            mainForm = callingForm as MainForm;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            mainForm.Show();
            this.Hide();
        }

        private void btn_openScanner_Click(object sender, EventArgs e)
        {
            try
            {
                //Check if scanner is connected
                //if connected:
                //check if scanner isnt open already, if not, open scanner and notify
                //else give a notification that scanner is already opened
                //else
                //ask user to connect
            }
            catch
            {

            }
        }
    }
}
