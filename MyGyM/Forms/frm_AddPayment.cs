using MyGyM.Helppers;
using MyGyM.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyGyM.Forms
{
    public partial class frm_AddPayment : Form
    {
        private Members member;

        public MyContext connection = DBMyGyM.DB;
        public float price { get; set; }
        public string Currency { get; set; }

        public frm_AddPayment()
        {
            InitializeComponent();
            dgv_Payment.AutoGenerateColumns = false;
            dgv_Payment.DefaultCellStyle.Font = new Font("Century Gothic", 12);
        }
        public frm_AddPayment(Members member) : this()
        {
            this.member = member;
            RefreshGrid(member);
        }
        private void frm_AddPayment_Load(object sender, EventArgs e)
        {
            LoadData();
        }
        /*--------------------------------------------------------------------------------------*/
        private void RefreshGrid(Members m)
        {
            try
            {
                List<Payments> list = new List<Payments>();
                foreach (var p in connection.Payments)
                {
                    if (p.Memeber.Id == m.Id)
                        list.Add(p);
                }
                dgv_Payment.DataSource = list;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + " " + ex.InnerException?.Message);
            }
        }
        private void LoadData()
        {            
            foreach (var item in connection.interchangeableDatas)
            {
                txt_Currency.Text = item.Currency ?? "KM";
                price = item.Price;
                txt_Amount.Text = item.Price.ToString();
            }

            txt_Member.Text = $"{member.FName} {member.LName}";
        }

        /*--------------------------------------------------------------------------------------*/
        private void btn_AddPayment_Click(object sender, EventArgs e)
        {
            try
            {
                if (Enough(float.Parse(txt_Amount.Text),price) && !IsPaidMonth(member)) // uneseni iznos mora da bude jednak cijeni ili veci i taj mjesec ne smije biti uplacen ranije
                {
                    Payments p = new Payments();
                    p.Memeber = member;
                    p.Amount = float.Parse(txt_Amount.Text) - (float.Parse(txt_Amount.Text) - price);
                    p.Currency = txt_Currency.Text;
                    p.Date = dtp_DateOfPayment.Value.ToString();

                    connection.Payments.Add(p);
                    connection.SaveChanges();
                    MessageBox.Show("Successfully added.");

                    RefreshGrid(member);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + " " + ex.InnerException?.Message);
            }
        }

        private bool IsPaidMonth(Members member) // ako postoji vec postoji neka uplata u istom mjesecu kao nova vrati true
        {
            try
            {
                foreach (var item in connection.Payments)
                {
                    if (member.Id == item.Memeber.Id && DateTime.Parse(item.Date).Month == dtp_DateOfPayment.Value.Month)
                    {
                        MessageBox.Show("Payment alredy exist.");
                        return true;
                    } 
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message + " " + ex.InnerException?.Message); }
            return false;
        }

        private bool Enough(float v, float price)
        {
            if (float.Parse(txt_Amount.Text) >= price)
            {
                return true;
            }
            MessageBox.Show($"The monthly price is {price}.");
            return false;
        }

        /*--------------------------------------------------------------------------------------*/
        private void txt_Amount_TextChanged(object sender, EventArgs e)
        {

        }
        private void txt_Member_TextChanged(object sender, EventArgs e)
        {

        }

        private void dgv_Payment_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
