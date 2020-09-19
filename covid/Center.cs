using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace covid
{
    public partial class Center : Form
    {
        public Center()
        {
            InitializeComponent();
        }


        private void addUserToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void notiButton_Click(object sender, EventArgs e)
        {
            NotificationForm nForm = new NotificationForm();
            nForm.Show();
        }

        private void sendSMSButton_Click(object sender, EventArgs e)
        {
            addUser aUser = new addUser();
            aUser.ShowDialog();
        }



        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }
        private void genUserButton_Click(object sender, EventArgs e)
        {

        }

        private void dtbbtn_Click(object sender, EventArgs e)
        {
            if (waitbtn.Visible == false)
            {
                waitbtn.Visible = true;
                compbtn.Visible = true;
                inbtn.Visible = true;
            }
            else
            {
                waitbtn.Visible = false;
                compbtn.Visible = false;
                inbtn.Visible = false;
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
