using MyGyM.Helppers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Core.Mapping;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace MyGyM.Forms
{
    public partial class frm_AddNewMember : Form
    {
        private Members _member;
        private MyContext _connection;
        public bool Edit { get; set; }
        public frm_AddNewMember()
        {
            InitializeComponent();
            _connection = DBMyGyM.DB;
        }
        public frm_AddNewMember(Members member) : this()
        {
            _member = member;
            Edit = true;
            LoadMemberData();
        }

        private void LoadMemberData()
        {
            txt_JMBG.Text = _member.JMBG;
            txt_FName.Text = _member.FName;
            txt_LName.Text = _member.LName;
            txt_Phone.Text = _member.Phone;
            txt_Email.Text = _member.Email;
            pb_Image.Image = ImageHelpper.FromByteToImage(_member.Image);
        }
        private void btn_Save_Click(object sender, EventArgs e)
        {
            if (IsValid())
            {
                _member = new Members();
                _member.JMBG = txt_JMBG.Text;
                _member.FName = txt_FName.Text;
                _member.LName = txt_LName.Text;
                _member.Phone = txt_Phone.Text;
                _member.Email = txt_Email.Text;
                _member.Image = ImageHelpper.FromImageToByte(pb_Image.Image);

                if (!Edit)
                {
                    _connection.Members.Add(_member);
                    MessageBox.Show("Successful Saving.");

                }
                else
                {
                    _connection.Entry(_member).State = EntityState.Modified;
                    MessageBox.Show("Successful Editing.");
                }
                _connection.SaveChanges();
                DialogResult = DialogResult.OK;
                Close();
            }
        }
        private bool IsValid()
        {
            if (txt_JMBG.Text.Length != 13)
            {
                MessageBox.Show("JMBG: Must contain 13 digits!");
                return false;
            }
            if (pb_Image.Image == null)
            {
                err.SetError(pb_Image, "Required");
                return false;
            }
            if (!string.IsNullOrEmpty(txt_Email.Text))
            {
                string pattern = @"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$";
                if (Regex.IsMatch(txt_Email.Text, pattern))
                {
                    err.Clear();
                    return true;
                }
                else
                {
                    err.SetError(txt_Email, "Incorrect!");
                    return false;
                }
            }
            else
            {
                err.Clear();
            }
            return Validator.RequiredField(txt_FName, err) &&
                   Validator.RequiredField(txt_LName, err);
        }

        private void btn_AddImage_Click(object sender, EventArgs e)
        {
            try
            {
                if (ofd_Image.ShowDialog() == DialogResult.OK)
                {
                    pb_Image.Image = Image.FromFile(ofd_Image.FileName);
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message + " " + ex.InnerException?.Message); }
        }
        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void txt_JMBG_TextChanged(object sender, EventArgs e)
        {
        }

        private void frm_AddNewMember_Load(object sender, EventArgs e)
        {

        }

        private void txt_Email_Leave(object sender, EventArgs e)
        {
            string pattern = @"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$";
            if (Regex.IsMatch(txt_Email.Text, pattern))
                err.Clear();
            else
                err.SetError(txt_Email, "Incorrect!");
        }
    }
}
