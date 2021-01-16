using MyGyM.Forms;
using MyGyM.Helppers;
using MyGyM.Models;
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Migrations.Model;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyGyM
{
    public partial class Form1 : Form
    {
        private MyContext _connection;

        public List<Members> ListOfActiveMembers = new List<Members>();
        public Form1()
        {
            InitializeComponent();
            dgv_ActiveMembers.AutoGenerateColumns = false;
            dgv_ActiveMembers.DefaultCellStyle.Font = new Font("Century Gothic", 12);
            _connection = DBMyGyM.DB;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            RefreshGrid();
            RefreshComboBox();
        }
        private void RefreshComboBox(List<Members> list = null)
        {            
            try
            {
                cmb_AddActiveM.DataSource = null;
                cmb_AddActiveM.DataSource = list ?? _connection.Members.ToList();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message + " " + ex.InnerException?.Message);}
            
        }
        private void RefreshGrid(List<Members> list = null)
        {
            dgv_ActiveMembers.DataSource = null;
            dgv_ActiveMembers.DataSource = list ?? ListOfActiveMembers.ToList();
        }
        private void btnAllMembers_Click(object sender, EventArgs e)
        {
            try
            {
                Form form = new frm_AllMembers();
                form.ShowDialog();
                RefreshComboBox();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message + " " + ex.InnerException?.Message); }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (Vali())
            {
                foreach (var item in _connection.Members)
                {
                    Members temp = cmb_AddActiveM.SelectedItem as Members;

                    if (temp.Id == item.Id && !IsThere(temp.Id, true))
                    {
                        if (PaidMonth(temp))
                            ListOfActiveMembers.Add(item);
                        else
                        {
                            MessageBox.Show("No membership fee has been paid for this month.");
                            Form frm = new frm_AddPayment(item);
                            frm.ShowDialog();
                        }
                    }
                    RefreshGrid();
                }
            }
        }
        private bool Vali()
        {
            if (cmb_AddActiveM.SelectedIndex >= 0)
                return true;
            return false;
        }
        private bool PaidMonth(Members temp)
        {
            foreach (var item in _connection.Payments)
            {
                if (item.Memeber.Id == temp.Id &&
                    DateTime.Parse(item.Date).Month == DateTime.Now.Month)
                    return true;
            }
            return false;
        }
        public bool IsThere(int id, bool message)
        {
            foreach (var item in ListOfActiveMembers)
            {
                if (id == item.Id)
                {
                    if (message)
                        MessageBox.Show("Already exists");
                    return true;
                }
            }
            return false;
        }
        private void dgv_ActiveMembers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Members tempMember = dgv_ActiveMembers.SelectedRows[0].DataBoundItem as Members;

            if (e.ColumnIndex == 2)
            {
                if (IsThere(tempMember.Id, false))
                    ListOfActiveMembers.Remove(tempMember);
            }
            else
            {
                Form form = new frm_ShowReport(tempMember);
                form.ShowDialog();
            }
            RefreshGrid();
        }

        private void btn_AddNew_Click(object sender, EventArgs e)
        {
            Form form = new frm_AddNewMember();
            form.ShowDialog();
            RefreshGrid();
            RefreshComboBox();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Form frm = new frm_LogIn();
            if (frm.ShowDialog() == DialogResult.OK)
                frm.Close();
            RefreshGrid();
        }
    }
}
