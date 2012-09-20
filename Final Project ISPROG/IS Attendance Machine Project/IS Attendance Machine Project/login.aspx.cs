using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using IS_Attendance_Machine_Project;
using System.Data.SqlClient;



namespace IS_Attendance_Machine_Project
{
    public partial class login : System.Web.UI.Page
    {
        Businesslogic businessLogic = new Businesslogic();
        public static string ConnString = @"Data Source=JOP-PC\SQLEXPRESS;Initial Catalog=ISAttandaceManagementSystem;Integrated Security=SSPI";
        protected void Page_Load(object sender, EventArgs e)
        {
            Label3.Text = "";
        }

        protected void btnlogin_Click(object sender, EventArgs e)
        {
            try
            {
                businessLogic.Username = txtboxun.Text;
                //Session.Add("username", txtboxun.Text);
                businessLogic.Password = txtboxpw.Text;
                SqlDataReader drProfLogin = businessLogic.ProfLogin();
                if (drProfLogin.HasRows)
                {
                   
                    string LoginActivity = "Logged In";
                    if (businessLogic.Username=="Chairperson")
                    {
                        Session.Add("username", businessLogic.Username.ToString());
                        //string LoginActivity = "Logged In";
                        businessLogic.Username = txtboxun.Text;
                        businessLogic.AuditDate = System.DateTime.Now;
                        businessLogic.Activity = LoginActivity;
                        businessLogic.AuditTrail();
                        Response.Redirect("maintenance.aspx");
                    }
                    else
                    {
                        Session.Add("username", businessLogic.Username.ToString());
                        businessLogic.Username = txtboxun.Text;
                        businessLogic.AuditDate = System.DateTime.Now;
                        businessLogic.Activity = LoginActivity;
                        businessLogic.AuditTrail();
                        Response.Redirect("profcp.aspx");
                    }
                    //Session.Add("subjectid", drProfLogin.GetSqlValue(6));
                }
                else
                {
                    throw new Exception("Username/ Password is incorrect.");
                }
            }
            catch (Exception ex)
            {
                Label3.Text = ex.Message;
            }
        }
    }
}