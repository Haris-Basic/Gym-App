using MyGyM.Helppers;
using MyGyM.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyGyM.Forms
{
    public partial class frm_Admin : Form
    {
        MyContext connection = DBMyGyM.DB;
        InterchangeableData interData;

        public frm_Admin()
        {
            InitializeComponent();
        }
        private void frm_Admin_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            DialogResult = DialogResult.OK;
            Close();
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txt_Currency.Text) && 
                !string.IsNullOrEmpty(txt_Price.Text))
            {
                interData.Price = float.Parse(txt_Price.Text);
                interData.Currency = txt_Currency.Text;

                connection.Entry(interData).State = EntityState.Modified;
                connection.SaveChanges();
                MessageBox.Show("Successfully added.");
                LoadData();
            }
        }

        private void LoadData()
        {
            foreach (var item in connection.interchangeableDatas)
            {
                interData = item;
                txt_Price.Text = item.Price.ToString();
                txt_Currency.Text = item.Currency;
            }
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Admin admin = new Admin();
            foreach (var adm in connection.Admin)
            {
                if (adm.Id == 1)
                {
                    admin = adm;
                    break;
                }
            }
            this.Hide();
            Form form = new frm_ChangeAdminData(admin);
            form.ShowDialog();
        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form frm = new frm_DeleteMember();
            frm.ShowDialog();
        }
    }
}
