using MyGyM.Helppers;
using System;
using System.CodeDom.Compiler;
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
    public partial class frm_AllMembers : Form
    {
        MyContext connection = DBMyGyM.DB;
        //private Members SearchMember;
        public frm_AllMembers()
        {
            InitializeComponent();
            dgv_Members.AutoGenerateColumns = false;
            dgv_Members.DefaultCellStyle.Font = new Font("Century Gothic", 10);
        }
        private void frm_AllMembers_Load(object sender, EventArgs e)
        {
            try
            {
                RefreshGrid();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message + " " + ex.InnerException?.Message);}
        }
        /*--------------------------------------------------------------------------------------*/
        private void btn_AddNew_Click(object sender, EventArgs e)
        {
            Form form = new frm_AddNewMember();
            form.ShowDialog();
            RefreshGrid();
        }
        private void txt_Search_TextChanged(object sender, EventArgs e)
        {
            List<Members> result = new List<Members>();
            string filter = txt_Search.Text.ToLower();

            foreach (var item in connection.Members)
            {
                if(item.FName.ToLower().Contains(filter) || 
                    item.LName.ToLower().Contains(filter))
                {
                    result.Add(item);
                    RefreshGrid(result);
                }
            }
        }
        private void dgv_Members_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Members temp = dgv_Members.SelectedRows[0].DataBoundItem as Members;
            Form frm = null;
            if (temp != null)
            {
                if (e.ColumnIndex == 6)
                    frm = new frm_AddPayment(temp);
                else if (e.ColumnIndex == 7)
                    frm = new frm_ShowReport(temp);
                else
                    frm = new frm_AddNewMember(temp);
            }
            frm.ShowDialog();
        }
        /*--------------------------------------------------------------------------------------*/
        private void RefreshGrid(List<Members> list = null)
        {
            try
            {
                dgv_Members.DataSource = null;
                dgv_Members.DataSource = list ?? connection.Members.ToList();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message + " " + ex.InnerException?.Message ); }
        }
        /*--------------------------------------------------------------------------------------*/
        private void dgv_Members_MouseClick(object sender, MouseEventArgs e)
        {
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
