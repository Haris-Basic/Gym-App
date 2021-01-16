using MyGyM.Helppers;
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
    public partial class frm_DeleteMember : Form
    {
        private MyContext _connection;
        public frm_DeleteMember()
        {
            InitializeComponent();
            dgv_Members.AutoGenerateColumns = false;
            _connection = DBMyGyM.DB;
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            if (Valid(txt_Search.Text))
            {
                var member = new Members();
                foreach (var mem in _connection.Members)
                {
                    if (string.Compare(txt_Search.Text, mem.JMBG) == 0)
                    {
                        _connection.Members.Remove(mem);
                        _connection.SaveChanges();
                        MessageBox.Show("Successfully deleted.");
                        txt_Search.Clear();
                        RefreshGrid();
                        break;
                    }

                }
            }
        }

        private void RefreshGrid(List<Members> list = null)
        {
            dgv_Members.DataSource = null;
            dgv_Members.DataSource = list ?? _connection.Members.ToList();
        }

        private bool Valid(string text)
        {
            bool valid = true;
            if(string.IsNullOrEmpty(text) || text.Length != 13)
            {
                valid = false;
            }            
            return valid;
        }

        private void frm_DeleteMember_Load(object sender, EventArgs e)
        {
            RefreshGrid();
        }

        private void txt_Search_TextChanged(object sender, EventArgs e)
        {
            List<Members> result = new List<Members>();
            string filter = txt_Search.Text;

            foreach (var item in _connection.Members)
            {
                if (item.JMBG.Contains(filter))
                {
                    result.Add(item);
                    RefreshGrid(result);
                }
            }
        }

        private void dgv_Members_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_Search.Text = (dgv_Members.SelectedRows[0].DataBoundItem as Members).JMBG;
        }
    }
}
