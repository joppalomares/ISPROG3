using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using IS_Attendance_Machine_Project;

namespace IS_Attendance_Machine_Project
{
    public class Businesslogic
    {
        DAT dataAccess = new DAT();
        public static string ConnString = @"Data Source=JOP-PC\SQLEXPRESS;Initial Catalog=ISAttandaceManagementSystem;Integrated Security=SSPI";
        #region Properties
        #region Professor

        string username;
        public string Username
        {
            get { return username; }
            set { username = value; }
        }

        string password;
        public string Password
        {
            get { return password; }
            set 
            {
                if (value.Length >= 8)
                    password = value;
                else
                    throw new Exception("Password should be at least 8 characters long.");
            }
        }

        string fnameprof;
        public string Fnameprof
        {
            get { return fnameprof; }
            set { fnameprof = value; }
        }

        string lnameprof;
        public string Lnameprof
        {
            get { return lnameprof; }
            set { lnameprof = value; }
        }

        string usertype;
        public string Usertype
        {
            get { return usertype; }
            set { usertype = value; }
        }

        int profid;
        public int ProfID
        {
            get { return profid; }
            set { profid = value; }
        }

        #endregion
        //----
        #region Student

        int idno;
        public int IDNo
        {
            get { return idno; }
            set { idno = value; }
        }

        string fnamestud;
        public string Fnamestud
        {
            get { return fnamestud; }
            set { fnamestud = value; }
        }

        string lnamestud;
        public string Lnamestud
        {
            get { return lnamestud; }
            set { lnamestud = value; }
        }
        string datenow;
        public string DateNow
        {
            get { return datenow; }
            set { datenow = value; }
        }
        string course;
        public string Course
        {
            get { return course; }
            set { course = value; }
        }

        #endregion
        //----
        #region Subject

        int subjectid;
        public int SubjectID
        {
            get { return subjectid; }
            set { subjectid = value; }
        }

        string subjectcode;
        public string SubjectCode
        {
            get { return subjectcode; }
            set 
            {
                if (value.Length == 7)
                    subjectcode = value;
                else
                    throw new Exception("Course Codes should be 7 characters long.");
            }
        }

        string section;
        public string Section
        {
            get { return section; }
            set { section = value; }
        }

        #endregion
        //---
        #region Attendance

        int studentattendanceid;
        public int StudentAttendanceID
        {
            get { return studentattendanceid; }
            set { studentattendanceid = value; }
        }

        // IDNo - FK
        // ProfID - FK
        // SubjectID - FK

        string status;
        public string Status
        {
            get { return status; }
            set { status = value; }
        }

        DateTime date;
        public DateTime Date
        {
            get { return date; }
            set { date = value; }
        }

        #endregion
        #region AuditTrail
        DateTime auditdate;
        public DateTime AuditDate
        {
            get { return auditdate; }
            set { auditdate = value; }
        }
        string activity;
        public string Activity
        {
            get { return activity; }
            set { activity = value; }
        }
        #endregion
        #endregion
        #region Methods

        public SqlDataReader ProfLogin()
        {
            string profLogin = "Login'" + Username + "','" + Password + "'";
            dataAccess.ExecuteCommand(profLogin);
            SqlDataReader dr = dataAccess.getData(profLogin);
            return dr;

        }
        public SqlDataReader ListAuditTrail()
        {
            string commListAuditTrail = "ListAuditTrail";
            dataAccess.ExecuteCommand(commListAuditTrail);
            SqlDataReader dr = dataAccess.getData(commListAuditTrail);
            return dr;
        }
        public SqlDataReader SelectMySubjects() 
        {
            string commSelectMySubjects = "SelectMySubjects'"+username+"'";
            //dataAccess.ExecuteCommand(commSelectMySubjects);
            SqlDataReader drSelectMySubjects = dataAccess.getData(commSelectMySubjects);
            return drSelectMySubjects;
        }
        public SqlDataReader ListStudents()
        {
            string commListStudents = "ListStudents";
            SqlDataReader drListStudents = dataAccess.getData(commListStudents);
            return drListStudents;
        }
        public SqlDataReader ListProfSubject()
        {
            string commListProfSubject = "ListProfessorSubject";
            SqlDataReader drListProfSubject = dataAccess.getData(commListProfSubject);
            return drListProfSubject;
        }
        public SqlDataReader ListStudentSubject()
        {
            string commListStudentSubject = "ListStudentSubject";
            SqlDataReader drListStudentSubject = dataAccess.getData(commListStudentSubject);
            return drListStudentSubject;
        }
        public SqlDataReader ListStudentsSubject()
        {
            string commListStudentsSubject = "ListStudentsSubject'"+ subjectcode+"','"+section+"'";
            SqlDataReader drListStudentsSubject = dataAccess.getData(commListStudentsSubject);
            return drListStudentsSubject;
        }
        public SqlDataReader ListStudentAttendance()
        {
            string commListStudentAttendance = "ListStudentAttendance'"+subjectcode+"','"+section+"','"+datenow+"'";
            SqlDataReader drListStudentAttendance = dataAccess.getData(commListStudentAttendance);
            return drListStudentAttendance;
        }
        public void UpdateStudentAttendance()
        { 
            string commUpdateStudentAttendance = "UpdateStudentAttendance'"+status+"','"+idno+"'";
            dataAccess.ExecuteCommand(commUpdateStudentAttendance);
        }
        public void AddToAttendanceSheet()
        {
            string addToAttendanceSheet = "AddToAttendanceSheet'" + datenow + "','" + idno+ "','" + subjectcode+ "','" + section+ "','" + status+ "'";
            dataAccess.ExecuteCommand(addToAttendanceSheet);
        }
        public SqlDataReader GetSubjID()
        {
            string strForSubjID = "select subjectid from tableProfessor where username='" + Username + "'";
            SqlDataReader drGetSubjID = dataAccess.getData(strForSubjID);
            return drGetSubjID;
        }
        public SqlDataReader ListSubjects()
        {
            string commListSubjects = "ListSubject";
            SqlDataReader drListSubjects = dataAccess.getData(commListSubjects);
            return drListSubjects;

        }
        public SqlDataReader ListProfessor()
        {
            string commListProfessors = "ListProfessor";
            SqlDataReader drListProfessors = dataAccess.getData(commListProfessors);
            return drListProfessors;

        }
        public void AddStudent() 
        {
            string commAddStudent = "Insertstudent'"+fnamestud+"','"+ lnamestud+"','"+ course+"'";
            dataAccess.ExecuteCommand(commAddStudent);
        }
        public void EditStudent()
        {
            string commEditStudent = "UpdateStudent'" + idno + "','" + fnamestud + "','" + lnamestud + "','" + course + "'";
            dataAccess.ExecuteCommand(commEditStudent);
        }
        public void DeleteStudent()
        {
            string commDeleteStudent = "UDeleteStudent'" + idno + "'";
            dataAccess.ExecuteCommand(commDeleteStudent);
        }

        public void AddSubject()
        {
            string commAddSubject = "InsertSubject'" + subjectcode+ "','" + section+ "'";
            dataAccess.ExecuteCommand(commAddSubject);
        }
        public void EditSubject()
        {
            string commEditSubject = "UpdateSubject'" + subjectcode+ "','" + section+ "'";
            dataAccess.ExecuteCommand(commEditSubject);
        }
        public void DeleteSubject()
        {
            string commDeleteSubject = "DeleteSubject'" + subjectcode + "'";
            dataAccess.ExecuteCommand(commDeleteSubject);
        }


        public void AddProfessor()
        {
            string commAddProfessor = "InsertProfessor'" + username + "','" + password+ "','"+ fnameprof+"','"+lnameprof+"','"+usertype+"'";
            dataAccess.ExecuteCommand(commAddProfessor);
        }
        public void EditProfessor()
        {
            string commEditProfessor = "UpdateProfessor'"+ password + "','" + fnameprof + "','" + lnameprof + "','" + usertype + "'," + username + "'";
            dataAccess.ExecuteCommand(commEditProfessor);
        }
        public void DeleteProfessor()
        {
            string commDeleteProfessor = "DeleteStudent'" + username+ "'";
            dataAccess.ExecuteCommand(commDeleteProfessor);
        }

        public void AddProfessorSubject()
        {
            string commAddProfessorSubject = "AddProfessorSubject'" + subjectcode+"','"+section+"','"+username+"'";
            dataAccess.ExecuteCommand(commAddProfessorSubject);
        }
        public void AddStudentSubject()
        {
            string commAddStudentSubject = "AddStudentSubject'"+ subjectcode+"','"+section+"','"+idno+"'";
            dataAccess.ExecuteCommand(commAddStudentSubject);
        }

        public void AuditTrail()
        {
            string commAuditTrail = "AuditTrail'"+username+"','"+auditdate+"','"+activity+"'";
            dataAccess.ExecuteCommand(commAuditTrail);
        }
        #endregion

    }
} 