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
    public partial class attendance : System.Web.UI.Page
    {
        Businesslogic businessLogic = new Businesslogic();
        public static string ConnString = @"Data Source=JOP-PC\SQLEXPRESS;Initial Catalog=ISAttandaceManagementSystem;Integrated Security=SSPI";
        SqlConnection conn = new SqlConnection(ConnString);
        protected void Page_Load(object sender, EventArgs e)
        {
            //IsPostBack = false;
            Label4.Text = Session["username"].ToString();
            Label5.Text = Session["subject"].ToString();
            Label7.Text = Session["section"].ToString();
            txtboxdate.Text = DateTime.Now.ToString("yyyy-MM-dd");
            businessLogic.DateNow = DateTime.Now.ToString("yyyy-MM-dd");
            
            businessLogic.SubjectCode = Label5.Text;
            businessLogic.Section = Label7.Text;
            SqlDataReader drViewStudentList = businessLogic.ListStudentsSubject();
            gridviewstud.DataSource = drViewStudentList;
            gridviewstud.DataBind();
            drViewStudentList.Close();
            //businessLogic.Date = DateTime.Parse(DateTime.Now.ToString("yyyy-mm-dd"));
            SqlDataReader drListStudentAttendance = businessLogic.ListStudentAttendance();
            gridviewattendance.DataSource = drListStudentAttendance;
            gridviewattendance.DataBind();
            drListStudentAttendance.Close();
            /* SqlDataReader drViewStudentList = businessLogic.ListStudents();
            gridviewstud.DataSource = drViewStudentList;
            gridviewstud.DataBind();
            drViewStudentList.Close(); 
            businessLogic.Username = Label4.Text;
            SqlDataReader drGetSubjID = businessLogic.GetSubjID();
            gridviewsubjectid.DataSource = drGetSubjID;
            gridviewsubjectid.DataBind();
            gridviewsubjectid.SelectRow(1);*/
            //Label5.Text = gridviewsubjectid.SelectedRow.Cells[0].Text;
            //Label5.Text =
        }

        protected void btnpresent_Click(object sender, EventArgs e)
        {
            try
            {
                if (tbxattendancestatus.Text == "Present" || tbxattendancestatus.Text == "Absent" || tbxattendancestatus.Text == "Late")
                {
                    string attendanceStatus = "Present";
                    businessLogic.Status = attendanceStatus;
                    businessLogic.IDNo = int.Parse(txtboxforid.Text);
                    businessLogic.UpdateStudentAttendance();
                    string StrActivity = "Update Attendance Status";
                    businessLogic.Username = Label4.Text;
                    businessLogic.AuditDate = System.DateTime.Now;
                    businessLogic.Activity = StrActivity;
                    businessLogic.AuditTrail();
                    Label6.Text = "Attandace database successfully updated!";
                    SqlDataReader drListStudentAttendance = businessLogic.ListStudentAttendance();
                    gridviewattendance.DataSource = drListStudentAttendance;
                    gridviewattendance.DataBind();
                    drListStudentAttendance.Close();
                }
                else
                {
                    string attendanceStatus = "Present";
                    //businessLogic.Username = Label4.Text;
                    businessLogic.DateNow = txtboxdate.Text;
                    businessLogic.IDNo = int.Parse(txtboxforid.Text);
                    businessLogic.SubjectCode = Label5.Text;
                    businessLogic.Section = Label7.Text;
                    businessLogic.Status = attendanceStatus;
                    businessLogic.Date = DateTime.Parse(txtboxdate.Text);
                    //businessLogic.SubjectID = int.Parse(Label5.Text);
                    businessLogic.AddToAttendanceSheet();
                    string StrActivity = "Checked Attendance";
                    businessLogic.Username = Label4.Text;
                    businessLogic.AuditDate = System.DateTime.Now;
                    businessLogic.Activity = StrActivity;
                    businessLogic.AuditTrail();
                    Label6.Text = "Attandace database successfully updated!";
                    SqlDataReader drListStudentAttendance = businessLogic.ListStudentAttendance();
                    gridviewattendance.DataSource = drListStudentAttendance;
                    gridviewattendance.DataBind();
                    drListStudentAttendance.Close();
                }
            }
            catch (Exception ex)
            {
                Label6.Text = ex.Message;
            }

        }

        protected void gridviewstud_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtboxforid.Text = gridviewstud.SelectedRow.Cells[4].Text;
        }

        protected void btnabsent_Click(object sender, EventArgs e)
        {
            try
            {
                if (tbxattendancestatus.Text == "Present" || tbxattendancestatus.Text == "Absent" || tbxattendancestatus.Text == "Late")
                {
                    string attendanceStatus = "Absent";
                    businessLogic.Status = attendanceStatus;
                    businessLogic.IDNo = int.Parse(txtboxforid.Text);
                    businessLogic.UpdateStudentAttendance();
                    string StrActivity = "Update Attendance Status";
                    businessLogic.Username = Label4.Text;
                    businessLogic.AuditDate = System.DateTime.Now;
                    businessLogic.Activity = StrActivity;
                    businessLogic.AuditTrail();
                    Label6.Text = "Attandace database successfully updated!";
                    SqlDataReader drListStudentAttendance = businessLogic.ListStudentAttendance();
                    gridviewattendance.DataSource = drListStudentAttendance;
                    gridviewattendance.DataBind();
                    drListStudentAttendance.Close();
                }
                else
                {
                    string attendanceStatus = "Absent";
                    //businessLogic.Username = Label4.Text;
                    businessLogic.DateNow = txtboxdate.Text;
                    businessLogic.IDNo = int.Parse(txtboxforid.Text);
                    businessLogic.SubjectCode = Label5.Text;
                    businessLogic.Section = Label7.Text;
                    businessLogic.Status = attendanceStatus;
                    businessLogic.Date = DateTime.Parse(txtboxdate.Text);
                    //businessLogic.SubjectID = int.Parse(Label5.Text);
                    businessLogic.AddToAttendanceSheet();
                    string StrActivity = "Checked Attendance";
                    businessLogic.Username = Label4.Text;
                    businessLogic.AuditDate = System.DateTime.Now;
                    businessLogic.Activity = StrActivity;
                    businessLogic.AuditTrail();
                    Label6.Text = "Attandace database successfully updated!";
                    SqlDataReader drListStudentAttendance = businessLogic.ListStudentAttendance();
                    gridviewattendance.DataSource = drListStudentAttendance;
                    gridviewattendance.DataBind();
                    drListStudentAttendance.Close();
                }
            }
            catch (Exception ex)
            {
                Label6.Text = ex.Message;
            }
        }

        protected void gridviewattendance_SelectedIndexChanged(object sender, EventArgs e)
        {
            tbxattendancestatus.Text = gridviewattendance.SelectedRow.Cells[6].Text;
            tbxidnumber.Text = gridviewattendance.SelectedRow.Cells[3].Text;
        }

        protected void btnlate_Click(object sender, EventArgs e)
        {
            try
            {
                if (tbxattendancestatus.Text == "Present" || tbxattendancestatus.Text == "Absent" || tbxattendancestatus.Text == "Late")
                {
                    string attendanceStatus = "Late";
                    businessLogic.Status = attendanceStatus;
                    businessLogic.IDNo = int.Parse(txtboxforid.Text);
                    businessLogic.UpdateStudentAttendance();
                    string StrActivity = "Update Attendance Status";
                    businessLogic.Username = Label4.Text;
                    businessLogic.AuditDate = System.DateTime.Now;
                    businessLogic.Activity = StrActivity;
                    businessLogic.AuditTrail();
                    Label6.Text = "Attandace database successfully updated!";
                    SqlDataReader drListStudentAttendance = businessLogic.ListStudentAttendance();
                    gridviewattendance.DataSource = drListStudentAttendance;
                    gridviewattendance.DataBind();
                    drListStudentAttendance.Close();
                }
                else
                {
                    string attendanceStatus = "Late";
                    //businessLogic.Username = Label4.Text;
                    businessLogic.DateNow = txtboxdate.Text;
                    businessLogic.IDNo = int.Parse(txtboxforid.Text);
                    businessLogic.SubjectCode = Label5.Text;
                    businessLogic.Section = Label7.Text;
                    businessLogic.Status = attendanceStatus;
                    businessLogic.Date = DateTime.Parse(txtboxdate.Text);
                    //businessLogic.SubjectID = int.Parse(Label5.Text);
                    businessLogic.AddToAttendanceSheet();
                    string StrActivity = "Checked Attendance";
                    businessLogic.Username = Label4.Text;
                    businessLogic.AuditDate = System.DateTime.Now;
                    businessLogic.Activity = StrActivity;
                    businessLogic.AuditTrail();
                    Label6.Text = "Attandace database successfully updated!";
                    SqlDataReader drListStudentAttendance = businessLogic.ListStudentAttendance();
                    gridviewattendance.DataSource = drListStudentAttendance;
                    gridviewattendance.DataBind();
                    drListStudentAttendance.Close();
                }
            }
            catch (Exception ex)
            {
                Label6.Text = ex.Message;
            }
        }

        protected void btnlogout_Click(object sender, EventArgs e)
        {
            Response.Redirect("login.aspx");
        }

        protected void btnreports_Click(object sender, EventArgs e)
        {
            Response.Redirect("reports.aspx");
        }

        protected void btnattendance_Click(object sender, EventArgs e)
        {
            Response.Redirect("attendance.aspx");
        }

        protected void btnmaintenance_Click(object sender, EventArgs e)
        {
            Response.Redirect("maintenance.aspx");
        }
    }
}
