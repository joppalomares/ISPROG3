using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace IS_Attendance_Machine_Project
{
    public partial class reports : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
        
        }

        protected void btnreportforattendance_Click(object sender, EventArgs e)
        {
            Response.Redirect("attendancereportviewer.aspx");
        }

        protected void btnreportforstudent_Click(object sender, EventArgs e)
        {
            Response.Redirect("StudentReportViewer.aspx");
        }

        protected void btnreportforprof_Click(object sender, EventArgs e)
        {
            Response.Redirect("professorreportviewer.aspx");
        }

        protected void btnreportforsubj_Click(object sender, EventArgs e)
        {
            Response.Redirect("Subjectreportviewer.aspx");
        }

        protected void btnreports_Click(object sender, EventArgs e)
        {
            Response.Redirect("reports.aspx");
        }

        protected void btnmaintenance_Click(object sender, EventArgs e)
        {
            Response.Redirect("maintenance.aspx");
        }

        protected void btnattendance_Click(object sender, EventArgs e)
        {
            Response.Redirect("attendance.aspx");
        }

        protected void btnlogout_Click(object sender, EventArgs e)
        {
            Response.Redirect("login.aspx");
        }
    }
}