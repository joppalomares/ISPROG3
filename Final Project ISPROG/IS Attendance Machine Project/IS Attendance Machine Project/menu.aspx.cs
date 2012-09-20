using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace IS_Attendance_Machine_Project
{
    public partial class menu : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnattendance_Click(object sender, EventArgs e)
        {
            Response.Redirect("attendance.aspx");
        }

        protected void btnmaintenance_Click(object sender, EventArgs e)
        {
            Response.Redirect("maintenance.aspx");
        }

        protected void btnreports_Click(object sender, EventArgs e)
        {
            Response.Redirect("reports.aspx");
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            Response.Redirect("login.aspx");
        }
    }
}