using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using IS_Attendance_Machine_Project;

namespace IS_Attendance_Machine_Project
{
    public partial class audittrails : System.Web.UI.Page
    {
        Businesslogic businessLogic = new Businesslogic();
        protected void Page_Load(object sender, EventArgs e)
        {
            SqlDataReader drListAuditTrail = businessLogic.ListAuditTrail();
            GridView1.DataSource = drListAuditTrail;
            GridView1.DataBind();
            drListAuditTrail.Close();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("reports.aspx");
        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}