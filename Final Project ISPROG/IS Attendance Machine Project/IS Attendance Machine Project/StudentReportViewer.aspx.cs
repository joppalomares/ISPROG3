using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;
using System.IO;
using System.Data.SqlClient;
using System.Data;

namespace IS_Attendance_Machine_Project
{
    public partial class StudentReportViewer : System.Web.UI.Page
    {
        public static string ConnString = @"Data Source=JOP-PC\SQLEXPRESS;Initial Catalog=ISAttandaceManagementSystem;Integrated Security=SSPI";
        SqlConnection conn = new SqlConnection(ConnString);

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                DataTable dt;

                String sql = "Select * FROM tableStudent";

                SqlCommand com = new SqlCommand(sql, conn);

                conn.Open();

                SqlDataAdapter da = new SqlDataAdapter(com);
                dt = new DataTable("dt");
                da.Fill(dt);

                ReportDocument rpt = new ReportDocument();
                rpt.Load(Server.MapPath("StudentReport.rpt"));
                rpt.SetDatabaseLogon("sa", "yugioh", @"JOP-PC\SQLEXPRESS", "ISAttandaceManagementSystem");

                rpt.SetDataSource(dt);

                crvStudent.ReportSource = rpt;
                MemoryStream oStream;
                oStream = (MemoryStream)
                rpt.ExportToStream(CrystalDecisions.Shared.ExportFormatType.PortableDocFormat);
                //rpt.ExportToHttpResponse(ExportFormatType.PortableDocFormat, Response, true, "Appointment");
                Response.Clear();
                Response.Buffer = true;
                Response.ContentType = "application/pdf";
                Response.BinaryWrite(oStream.ToArray());
                Response.End();
                rpt.Export();

                conn.Close();
                conn.Dispose();
            }
        }
    }
}