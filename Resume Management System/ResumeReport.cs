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
using System.Data.SqlClient;

namespace Resume_Management_System
{
    public partial class ResumeReport : Form
    {
        int idd;
        public ResumeReport(int a)
        {
            idd = a;
            InitializeComponent();
        }



        private void ResumeReport_Load(object sender, EventArgs e)
        {

            SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename='C:\\Users\\Shreyas\\Documents\\Projects\\Resume Management System\\Resume Management System\\Resume_Management_DB.mdf';Integrated Security=True");

            SqlDataAdapter adepter = new SqlDataAdapter("select * from ResumeTable where ResumeID = "+idd+"" , con );
            DataSet Ds = new DataSet();
            adepter.Fill(Ds);  // Adapter fills in Ds

            reportViewer1.ProcessingMode = ProcessingMode.Local;
            reportViewer1.LocalReport.ReportPath = @"S:\Visual Studio\Projects\Resume Management System\Resume Management System\Report1.rdlc";

            if(Ds.Tables[0].Rows.Count > 0)
            {
                ReportDataSource rds = new ReportDataSource("Resumes" , Ds.Tables[0]);
                reportViewer1.LocalReport.DataSources.Clear();
                reportViewer1.LocalReport.DataSources.Add(rds);
                reportViewer1.LocalReport.Refresh();
                reportViewer1.RefreshReport();
            }
            this.reportViewer1.RefreshReport();
        }




        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }
    }
}
