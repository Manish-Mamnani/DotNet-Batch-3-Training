using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace ConArcDemo
{
    /// <summary>
    /// Demo code for connected architecture in studentDAO class
    /// </summary>
    public class StudentDAO
    {

        SqlConnection con = null;
        SqlCommand cmd = null;
        SqlDataReader sdr = null;

        public StudentDAO()
        {
            con = new SqlConnection();
            con.ConnectionString = "Server=.\\sqlexpress;Integrated Security=SSPI;Databse=LPU_DB";
        }

        public List<Student> ShowAllStudents()
        {
            List<Student> studList = null;

            try
            {
                con.Open();

                cmd = new SqlCommand();
                cmd.CommandText = "Select * FROM StudentInfo";
                cmd.Connection = con;
                cmd.CommandType = CommandType.Text;

                //Holding data via Reader
                sdr = cmd.ExecuteReader();

                DataTable myDt = new DataTable();
                myDt.Load(sdr);

                //Convert Table into List
                foreach (DataRow drow in myDt.Rows)
                {
                    Student sObj = new Student()
                    {
                        RollNo = (int)drow[0],
                        Name = drow[1].ToString(),
                        Address = drow[2].ToString()

                    };

                }

            }
            catch (Exception e) {
            {
                    
            }
            finally 
            {
                
            }

            return studList;
        }

        public List<Student> SearchByName(string name)
        {
            List<Student> studList = null;
            return studList;
        }

        public Student SearchByRollNo(int rollNo)
        {
            Student student = null;
            return student;
        }


    }
}
