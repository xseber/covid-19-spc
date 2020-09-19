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
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void Signinbutton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Center CenterForm = new Center();
            CenterForm.ShowDialog();
            this.Close();
       
        }
    }
}
