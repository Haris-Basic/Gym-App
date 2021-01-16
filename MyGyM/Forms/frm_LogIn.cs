using MyGyM.Helppers;
using MyGyM.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyGyM.Forms
{
    public partial class frm_LogIn : Form
    {
        MyContext connection = DBMyGyM.DB;
        public frm_LogIn()
        {
            InitializeComponent();
        }

        private void btn_LogIn_Click(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(txt_UserName.Text) &&
                !string.IsNullOrEmpty(txt_Password.Text))
                {
                    foreach (var admin in connection.Admin)
                    {
                        if (txt_UserName.Text == admin.UserName &&
                        txt_Password.Text == admin.Password)
                        {
                            this.Hide();
                            Form frm = new frm_Admin();
                            frm.ShowDialog();
                        }
                        else
                        {
                            MessageBox.Show("User not found.");
                            txt_UserName.Clear();
                            txt_Password.Clear();
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Enter all fields.");
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message + " " + ex.InnerException?.Message); }
        }

        private void txt_Password_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void txt_UserName_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
