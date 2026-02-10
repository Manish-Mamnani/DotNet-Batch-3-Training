using ConArcDemo;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConArcDemo
{
    /// <summary>
    /// Demo for connected ARCHITECTURE in DAO class
    /// </summary>
    public class StudentDAO
    {
        SqlConnection conn = null;
        SqlCommand cmd = null;
        SqlDataReader sdr = null;

        public StudentDAO()
        {
            conn = new SqlConnection();
            conn.ConnectionString = "Server=.\\Sqlexpress;Integrated Security = SSPI;Database = LPU_DB;TrustServerCertificate=true";
        }
        public List<Student> ShowAllStudent()
        {
            List<Student> studList = null;
            //Code for Connected Architecture below
            try
            {
                conn.Open();

                cmd = new SqlCommand();
                cmd.CommandText = "Select * from StudentInfo";
                cmd.Connection = conn;
                cmd.CommandType = CommandType.Text;
                //holding data via reader(forward only control)
                sdr = cmd.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(sdr);

                //convert Table into List
                if (dt.Rows.Count > 0)
                {
                    studList = new List<Student>();
                }
                foreach (DataRow drow in dt.Rows)
                {
                    Student student = new Student()
                    {
                        RollNo = Convert.ToInt32(drow[0].ToString()),
                        Name = drow[1].ToString(),
                        Address = drow[2].ToString(),
                    };
                    if (student != null)
                    {
                        studList.Add(student);
                    }

                }

                ///
                //older way ---------------------
                //foreach (DataRow row in sdr)
                //{
                //    dt.Rows.Add(row);
                //}
                ///

                //while (sdr.Read())
                //{
                //    Console.WriteLine();
                //}
            }
            catch (SqlException ex)
            {
                throw ex;
            }
            finally
            {
                conn.Close();
            }

            return studList;
        }

        public List<Student> ShowStudentbyName(string name)
        {
            List<Student> studList = null;
            SqlParameter param1 = new SqlParameter("@Name",name);
            //Code for Connected Architecture below
            try
            {
                conn.Open();

                cmd = new SqlCommand();
                cmd.CommandText = $"Select * from StudentInfo where StudentName = @Name";
                                // "Select * from StudentInfo where StudentName = '"+name+"'";
                                // $"Select * from StudentInfo where StudentName = '{name}'";

                cmd.Connection = conn;
                cmd.CommandType = CommandType.Text;

                //Parameter is to be added to the command
                cmd.Parameters.Add(param1);


                //holding data via reader(forward only control)
                sdr = cmd.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(sdr);

                //convert Table into List
                if (dt.Rows.Count > 0)
                {
                    studList = new List<Student>();
                }
                foreach (DataRow drow in dt.Rows)
                {
                    Student student = new Student()
                    {
                        RollNo = Convert.ToInt32(drow[0].ToString()),
                        Name = drow[1].ToString(),
                        Address = drow[2].ToString(),
                    };
                    if (student != null)
                    {
                        studList.Add(student);
                    }

                }

                ///
                //older way ---------------------
                //foreach (DataRow row in sdr)
                //{
                //    dt.Rows.Add(row);
                //}
                ///

                //while (sdr.Read())
                //{
                //    Console.WriteLine();
                //}
            }
            catch (SqlException ex)
            {
                throw ex;
            }
            finally
            {
                conn.Close();
            }

            return studList;
        }

        public Student ShowStudentbyID(int rollNo)
        {
            Student temObj = null;

            return temObj;
        }

        public bool AddStudent(Student student)
        {
            bool flag = false;

            conn.Open();

            SqlParameter[] param2 = new SqlParameter[4];

            for(int i=0;i<param2.Length;i++)
            {
                param2[i] = new SqlParameter();
            }

            param2[0].ParameterName = "@RollNo";
            param2[0].Value = student.RollNo;

            param2[1].ParameterName = "@Name";
            param2[1].Value = student.Name;

            param2[2].ParameterName = "@Address";
            param2[2].Value = student.Address;

            param2[3].ParameterName = "@Age";
            param2[3].Value = student.Age;

            cmd = new SqlCommand();
            
            cmd.Connection = conn;

            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "Insert into StudentInfo(StudentID,StudentName,StudentAddress,Age) vales(@RollNo,@Name,@Address,@Age)";

            cmd.Parameters.AddRange(param2);

            int rowsAffected = cmd.ExecuteNonQuery();

            if(rowsAffected < 1)
            {
                return false;
            }
            
            return true;
        }

    }
}