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
    public partial class profcp : System.Web.UI.Page
    {
        public static string ConnString = @"Data Source=JOP-PC\SQLEXPRESS;Initial Catalog=ISAttandaceManagementSystem;Integrated Security=SSPI";
        Businesslogic businessLogic = new Businesslogic();
        protected void Page_Load(object sender, EventArgs e)
        {
            Label1.Text= Session["username"].ToString();
            businessLogic.Username = Label1.Text;
            SqlDataReader drSelectMySubjects = businessLogic.SelectMySubjects();
            GridView1.DataSource = drSelectMySubjects;
            GridView1.DataBind();
            drSelectMySubjects.Close();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Session.Add("subject", TextBox1.Text);
            Session.Add("section", TextBox2.Text);
            string StrActivity = "Initiate Attendance Checking";
            businessLogic.Username = Session["username"].ToString();
            businessLogic.AuditDate = System.DateTime.Now;
            businessLogic.Activity = StrActivity;
            businessLogic.AuditTrail();
            Response.Redirect("attendance.aspx");
        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            TextBox1.Text = GridView1.SelectedRow.Cells[1].Text;
            TextBox2.Text = GridView1.SelectedRow.Cells[2].Text;
        }
    }
}