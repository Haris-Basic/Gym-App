using Microsoft.ReportingServices.Diagnostics.Internal;
using MyGyM.Helppers;
using MyGyM.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Entity;

namespace MyGyM.Forms
{
    public partial class frm_ChangeAdminData : Form
    {
        private MyContext _connection;
        private Admin _admin;
        public frm_ChangeAdminData()
        {
            InitializeComponent();
            _connection = DBMyGyM.DB;
        }
        public frm_ChangeAdminData(Admin admin) : this()
        {
            this._admin = admin;
        }

        private void frm_ChangeAdminData_Load(object sender, EventArgs e)
        {

        }

        private void btn_LogIn_Click(object sender, EventArgs e)
        {
            if(Valid() && CheckPass())
            {
                _admin.UserName = txt_UserName.Text;
                _admin.Password = txt_Password.Text;

                _connection.Entry(_admin).State = EntityState.Modified;
                _connection.SaveChanges();

                MessageBox.Show("Successfully saved.");
                Close();
            }    
        }

        private bool CheckPass()
        {
            if (string.Compare(txt_Password.Text, txt_Password2.Text) != 0)
            {
                MessageBox.Show("Passwords do not match.");
                return false;
            }
            return true;
        }

        private bool Valid()
        {
            if(string.IsNullOrEmpty(txt_UserName.Text) &&
               string.IsNullOrEmpty(txt_Password.Text) &&
               string.IsNullOrEmpty(txt_Password2.Text))
            {
                MessageBox.Show("All field is required.");
                return false;
            }
            return true;
        }
    }
}
