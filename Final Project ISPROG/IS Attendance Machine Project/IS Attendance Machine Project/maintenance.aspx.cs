using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using IS_Attendance_Machine_Project;
using System.IO;
using System.Data;

namespace IS_Attendance_Machine_Project
{
    public partial class maintenance : System.Web.UI.Page
    {
        Businesslogic businessLogic = new Businesslogic();
        protected void Page_Load(object sender, EventArgs e)
        {
            SqlDataReader drViewStudentList = businessLogic.ListStudents();
            gridviewstudent.DataSource = drViewStudentList;
            gridviewstudent.DataBind();
            drViewStudentList.Close();

            SqlDataReader drViewSubjectList = businessLogic.ListSubjects();
            gridviewsubject.DataSource = drViewSubjectList;
            gridviewsubject.DataBind();
            drViewSubjectList.Close();

            SqlDataReader drViewProfList = businessLogic.ListProfessor();
            gridviewfaculty.DataSource = drViewProfList;
            gridviewfaculty.DataBind();
            drViewProfList.Close();

            SqlDataReader drViewProfSubject = businessLogic.ListProfSubject();
            GridView1.DataSource = drViewProfSubject;
            GridView1.DataBind();
            drViewProfSubject.Close();

            SqlDataReader drListStudentSubject = businessLogic.ListStudentSubject();
            GridView2.DataSource = drListStudentSubject;
            GridView2.DataBind();
            drListStudentSubject.Close();
        }

        protected void gridviewstudent_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtboxid.Text = gridviewstudent.SelectedRow.Cells[1].Text;
            txtboxfirstn.Text = gridviewstudent.SelectedRow.Cells[2].Text;
            txtboxlastn.Text = gridviewstudent.SelectedRow.Cells[3].Text;
            txtboxcourse.Text = gridviewstudent.SelectedRow.Cells[4].Text;
        }

        protected void gridviewsubject_SelectedIndexChanged(object sender, EventArgs e)
        {
            //tbxprofsubjid.Text = gridviewsubject.SelectedRow.Cells[1].Text;
            txtboxcode.Text = gridviewsubject.SelectedRow.Cells[1].Text;
            txtboxsection.Text = gridviewsubject.SelectedRow.Cells[2].Text;
            //TextBox1.Text = gridviewsubject.SelectedRow.Cells[1].Text;
        }

        protected void gridviewfaculty_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtboxfirstnameforprof.Text = gridviewfaculty.SelectedRow.Cells[3].Text;
            txtboxlastnameforprof.Text = gridviewfaculty.SelectedRow.Cells[4].Text;
            txtboxusername.Text = gridviewfaculty.SelectedRow.Cells[1].Text;
            //txtboxpassword.Text = gridviewfaculty.SelectedRow.Cells[2].Text;
            //tbxprofsubjid.Text = gridviewfaculty.SelectedRow.Cells[6].Text;
            //tbxprofid.Text = gridviewfaculty.SelectedRow.Cells[7].Text;
        }

        protected void btnaddstud_Click(object sender, EventArgs e)
        {
            try
            {
                businessLogic.Fnamestud = txtboxfirstn.Text;
                businessLogic.Lnamestud = txtboxlastn.Text;
                businessLogic.Course = txtboxcourse.Text;
                businessLogic.AddStudent();
                string StrActivity = "Added Student";
                businessLogic.Username = Session["username"].ToString();
                businessLogic.AuditDate = System.DateTime.Now;
                businessLogic.Activity = StrActivity;
                businessLogic.AuditTrail();
                txtboxid.Text = "";
                txtboxfirstn.Text = "";
                txtboxlastn.Text = "";
                txtboxcourse.Text = "";
                SqlDataReader drViewStudentList = businessLogic.ListStudents();
                gridviewstudent.DataSource = drViewStudentList;
                gridviewstudent.DataBind();
                drViewStudentList.Close();
            }
            catch (Exception ex)
            {
                Label19.Text = ex.Message;
                txtboxid.Text = "";
                txtboxfirstn.Text = "";
                txtboxlastn.Text = "";
                txtboxcourse.Text = "";
            }
        }

        protected void btneditstud_Click(object sender, EventArgs e)
        {
            try
            {
                businessLogic.Fnamestud = txtboxfirstn.Text;
                businessLogic.Lnamestud = txtboxlastn.Text;
                businessLogic.Course = txtboxcourse.Text;
                businessLogic.IDNo = int.Parse(txtboxid.Text);
                businessLogic.EditStudent();
                string StrActivity = "Edited Attendance";
                businessLogic.Username = Session["username"].ToString();
                businessLogic.AuditDate = System.DateTime.Now;
                businessLogic.Activity = StrActivity;
                businessLogic.AuditTrail();
                txtboxid.Text = "";
                txtboxfirstn.Text = "";
                txtboxlastn.Text = "";
                txtboxcourse.Text = "";
                SqlDataReader drViewStudentList = businessLogic.ListStudents();
                gridviewstudent.DataSource = drViewStudentList;
                gridviewstudent.DataBind();
                drViewStudentList.Close();
            }
            catch (Exception ex)
            {
                Label19.Text = ex.Message;
                txtboxid.Text = "";
                txtboxfirstn.Text = "";
                txtboxlastn.Text = "";
                txtboxcourse.Text = "";
            }
        }

        protected void btndeletestud_Click(object sender, EventArgs e)
        {
            try
            {
                businessLogic.IDNo = int.Parse(txtboxid.Text);
                businessLogic.DeleteStudent();
                string StrActivity = "Deleted Attendance";
                businessLogic.Username = Session["username"].ToString();
                businessLogic.AuditDate = System.DateTime.Now;
                businessLogic.Activity = StrActivity;
                businessLogic.AuditTrail();
                txtboxid.Text = "";
                txtboxfirstn.Text = "";
                txtboxlastn.Text = "";
                txtboxcourse.Text = "";
                SqlDataReader drViewStudentList = businessLogic.ListStudents();
                gridviewstudent.DataSource = drViewStudentList;
                gridviewstudent.DataBind();
                drViewStudentList.Close();
            }
            catch(Exception ex)
            {
                Label19.Text = ex.Message;
                txtboxid.Text = "";
                txtboxfirstn.Text = "";
                txtboxlastn.Text = "";
                txtboxcourse.Text = "";
            }
        }

        protected void btnsubjadd_Click(object sender, EventArgs e)
        {
            try
            {
                businessLogic.SubjectCode = txtboxcode.Text;
                businessLogic.Section = txtboxsection.Text;
                businessLogic.AddSubject();
                string StrActivity = "Added Subject";
                businessLogic.Username = Session["username"].ToString();
                businessLogic.AuditDate = System.DateTime.Now;
                businessLogic.Activity = StrActivity;
                businessLogic.AuditTrail();
                txtboxcode.Text = "";
                txtboxsection.Text = "";
                SqlDataReader drViewSubjectList = businessLogic.ListSubjects();
                gridviewsubject.DataSource = drViewSubjectList;
                gridviewsubject.DataBind();
                drViewSubjectList.Close();
            }
            catch (Exception ex) 
            {
                Label19.Text = ex.Message;
                txtboxcode.Text = "";
                txtboxsection.Text = "";
            }
        }

        protected void btnsubjedit_Click(object sender, EventArgs e)
        {
            try
            {
                businessLogic.SubjectCode = txtboxcode.Text;
                businessLogic.Section = txtboxsection.Text;
                businessLogic.EditSubject();
                string StrActivity = "Edited Subject";
                businessLogic.Username = Session["username"].ToString();
                businessLogic.AuditDate = System.DateTime.Now;
                businessLogic.Activity = StrActivity;
                businessLogic.AuditTrail();
                txtboxcode.Text = "";
                txtboxsection.Text = "";
                SqlDataReader drViewSubjectList = businessLogic.ListSubjects();
                gridviewsubject.DataSource = drViewSubjectList;
                gridviewsubject.DataBind();
                drViewSubjectList.Close();
            }
            catch (Exception ex)
            {
                Label19.Text = ex.Message;
                txtboxcode.Text = "";
                txtboxsection.Text = "";
            }
        }

        protected void btnsubjdelete_Click(object sender, EventArgs e)
        {
           
            try
            {
                businessLogic.SubjectCode = txtboxcode.Text;
                businessLogic.DeleteSubject();
                string StrActivity = "Deleted Subject";
                businessLogic.Username = Session["username"].ToString();
                businessLogic.AuditDate = System.DateTime.Now;
                businessLogic.Activity = StrActivity;
                businessLogic.AuditTrail();
                txtboxcode.Text = "";
                txtboxsection.Text = "";
                SqlDataReader drViewSubjectList = businessLogic.ListSubjects();
                gridviewsubject.DataSource = drViewSubjectList;
                gridviewsubject.DataBind();
                drViewSubjectList.Close();
            }
            catch (Exception ex)
            {
                Label19.Text = ex.Message;
                txtboxcode.Text = "";
                txtboxsection.Text = "";
            }
        }

        protected void btnfacadd_Click(object sender, EventArgs e)
        {
            try
            {
                businessLogic.Username = txtboxusername.Text;
                businessLogic.Password = txtboxpassword.Text;
                businessLogic.Fnameprof = txtboxfirstnameforprof.Text;
                businessLogic.Lnameprof = txtboxlastnameforprof.Text;
                businessLogic.Usertype = DropDownList1.Text;
                //businessLogic.SubjectID = int.Parse(tbxsubjid.Text);
                businessLogic.AddProfessor();
                string StrActivity = "Added Professor";
                businessLogic.Username = Session["username"].ToString();
                businessLogic.AuditDate = System.DateTime.Now;
                businessLogic.Activity = StrActivity;
                businessLogic.AuditTrail();
                txtboxusername.Text = "";
                txtboxpassword.Text = "";
                txtboxfirstnameforprof.Text = "";
                txtboxlastnameforprof.Text = "";
                SqlDataReader drViewProfList = businessLogic.ListProfessor();
                gridviewfaculty.DataSource = drViewProfList;
                gridviewfaculty.DataBind();
                drViewProfList.Close();
            }
            catch (Exception ex)
            {
                Label19.Text = ex.Message;
                txtboxusername.Text = "";
                txtboxpassword.Text = "";
                txtboxfirstnameforprof.Text = "";
                txtboxlastnameforprof.Text = "";
            }
        }

        protected void btnfacedit_Click(object sender, EventArgs e)
        {
            try
            {
                businessLogic.Username = txtboxusername.Text;
                businessLogic.Password = txtboxpassword.Text;
                businessLogic.Fnameprof = txtboxfirstnameforprof.Text;
                businessLogic.Lnameprof = txtboxlastnameforprof.Text;
                businessLogic.Usertype = DropDownList1.Text;
                //businessLogic.SubjectID = int.Parse(tbxsubjid.Text);
                //businessLogic.ProfID = int.Parse(tbxprofid.Text);
                businessLogic.EditProfessor();
                string StrActivity = "Edited Professor";
                businessLogic.Username = Session["username"].ToString();
                businessLogic.AuditDate = System.DateTime.Now;
                businessLogic.Activity = StrActivity;
                businessLogic.AuditTrail();
                txtboxusername.Text = "";
                txtboxpassword.Text = "";
                txtboxfirstnameforprof.Text = "";
                txtboxlastnameforprof.Text = "";
                SqlDataReader drViewProfList = businessLogic.ListProfessor();
                gridviewfaculty.DataSource = drViewProfList;
                gridviewfaculty.DataBind();
                drViewProfList.Close();
            }
            catch (Exception ex)
            {
                Label19.Text = ex.Message;
                txtboxusername.Text = "";
                txtboxpassword.Text = "";
                txtboxfirstnameforprof.Text = "";
                txtboxlastnameforprof.Text = "";
            }
        }

        protected void btnfacdelete_Click(object sender, EventArgs e)
        {
            try
            {
                //businessLogic.ProfID = int.Parse(tbxprofid.Text);
                businessLogic.Username = txtboxusername.Text;
                businessLogic.DeleteProfessor();
                string StrActivity = "Deleted Professor";
                businessLogic.Username = Session["username"].ToString();
                businessLogic.AuditDate = System.DateTime.Now;
                businessLogic.Activity = StrActivity;
                businessLogic.AuditTrail();
                txtboxusername.Text = "";
                txtboxpassword.Text = "";
                txtboxfirstnameforprof.Text = "";
                txtboxlastnameforprof.Text = "";
                SqlDataReader drViewProfList = businessLogic.ListProfessor();
                gridviewfaculty.DataSource = drViewProfList;
                gridviewfaculty.DataBind();
                drViewProfList.Close();
            }
            catch (Exception ex)
            {
                Label19.Text = ex.Message;
                txtboxusername.Text = "";
                txtboxpassword.Text = "";
                txtboxfirstnameforprof.Text = "";
                txtboxlastnameforprof.Text = "";
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                businessLogic.SubjectCode = txtboxcode.Text;
                businessLogic.Section = txtboxsection.Text;
                businessLogic.Username = txtboxusername.Text;
                businessLogic.AddProfessorSubject();
                string StrActivity = "Added Professor Subject";
                businessLogic.Username = Session["username"].ToString();
                businessLogic.AuditDate = System.DateTime.Now;
                businessLogic.Activity = StrActivity;
                businessLogic.AuditTrail();
                txtboxcode.Text = "";
                txtboxsection.Text="";
                txtboxusername.Text = "";
                txtboxpassword.Text = "";
                txtboxfirstnameforprof.Text = "";
                txtboxlastnameforprof.Text = "";
                SqlDataReader drViewProfSubject = businessLogic.ListProfSubject();
                GridView1.DataSource = drViewProfSubject;
                GridView1.DataBind();
                drViewProfSubject.Close();
            }
            catch (Exception ex)
            {
                Label19.Text = ex.Message;
            }
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            try
            {
                businessLogic.SubjectCode = txtboxcode.Text;
                businessLogic.Section = txtboxsection.Text;
                businessLogic.IDNo = int.Parse(txtboxid.Text);
                businessLogic.AddStudentSubject();
                string StrActivity = "Added Student Subject";
                businessLogic.Username = Session["username"].ToString();
                businessLogic.AuditDate = System.DateTime.Now;
                businessLogic.Activity = StrActivity;
                businessLogic.AuditTrail();
                txtboxcode.Text = "";
                txtboxsection.Text = "";
                txtboxid.Text = "";
                txtboxfirstn.Text = "";
                txtboxlastn.Text = "";
                txtboxcourse.Text = "";
                SqlDataReader drListStudentSubject = businessLogic.ListStudentSubject();
                GridView2.DataSource = drListStudentSubject;
                GridView2.DataBind();
                drListStudentSubject.Close();
            }
            catch (Exception ex)
            {
                Label19.Text = ex.Message;
            }


        }

        protected void btnmaintenance_Click(object sender, EventArgs e)
        {
            Response.Redirect("maintenance.aspx");
        }

        protected void btnattendance_Click(object sender, EventArgs e)
        {
            Response.Redirect("attendance.aspx");
        }

        protected void btnreports_Click(object sender, EventArgs e)
        {
            Response.Redirect("reports.aspx");
        }

        protected void btnlogout_Click(object sender, EventArgs e)
        {
            Response.Redirect("login.aspx");
        }

        protected void btnupload_Click(object sender, EventArgs e)
        {
            string UploadFile = Server.MapPath("~/Upload/");
            UploadFile += FileUpload.FileName;
            FileUpload.PostedFile.SaveAs(UploadFile);

            if (File.Exists(UploadFile))
            {
                DataTable dtbStudents = new DataTable("Students");
                dtbStudents.Columns.Add("StudentID");
                dtbStudents.Columns.Add("StudFN");
                dtbStudents.Columns.Add("StudLN");
                dtbStudents.Columns.Add("StudCourse");

                string InputLine = "";
                using (StreamReader sr = File.OpenText(UploadFile))
                {
                    InputLine = sr.ReadLine();
                    while ((InputLine = sr.ReadLine()) != null)
                    {
                        string tmpStr = InputLine;
                        string strID = tmpStr.Substring(1, tmpStr.IndexOf(",") - 2);

                        tmpStr = tmpStr.Substring(tmpStr.IndexOf(",") + 1); 
                        string strLName = tmpStr.Substring(1, (tmpStr.IndexOf(",") + 1) - 2);

                        tmpStr = tmpStr.Substring(tmpStr.IndexOf(",") + 2);
                        string strFName = tmpStr.Substring(0, tmpStr.IndexOf(",") - 1);

                        tmpStr = tmpStr.Substring(tmpStr.IndexOf(",") + 2);
                        string strCourse = tmpStr.Substring(0, (tmpStr.IndexOf(",") + 2) - 3);

                        DataRow drwStudentID = dtbStudents.NewRow();
                        drwStudentID["StudentID"] = strID;
                        drwStudentID["StudFN"] = strFName;
                        drwStudentID["StudLN"] = strLName;
                        drwStudentID["StudCourse"] = strCourse;

                        dtbStudents.Rows.Add(drwStudentID);
                    }
                    gridviewuploadedfile.DataSource = dtbStudents;
                    gridviewuploadedfile.DataBind();
                }
            }
        }
    }
}
