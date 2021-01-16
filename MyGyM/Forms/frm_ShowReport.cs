using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;
using MyGyM.Helppers;

namespace MyGyM.Forms
{
    public partial class frm_ShowReport : Form
    {
        MyContext connection = DBMyGyM.DB;

        private Members member;
        public frm_ShowReport()
        {
            InitializeComponent();
        }
        public frm_ShowReport(Members member) : this()
        {
            this.member = member;
        }
        private void frm_ShowReport_Load(object sender, EventArgs e)
        {
            ReportParameterCollection rpc = new ReportParameterCollection();
            rpc.Add(new ReportParameter("FName", member.FName));
            rpc.Add(new ReportParameter("LName", member.LName));

            List<object> list = new List<object>();

            foreach (var item in connection.Payments)
            {
                if (item.Memeber.Id == member.Id)
                    list.Add(new
                    {
                        Amount = item.Amount,
                        Currency = item.Currency,
                        Date = DateTime.Parse(item.Date).Date.ToString()
                    });
            }

            ReportDataSource rds = new ReportDataSource();
            rds.Name = "MyGyM_Payments";
            rds.Value = list;

            reportViewer1.LocalReport.SetParameters(rpc);
            reportViewer1.LocalReport.DataSources.Add(rds);
            this.reportViewer1.RefreshReport();
        }
    }
}
