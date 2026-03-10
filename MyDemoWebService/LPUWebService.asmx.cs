using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace MyDemoWebService
{
    /// <summary>
    /// Summary description for LPUWebService
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class LPUWebService : System.Web.Services.WebService
    {

        [WebMethod]
        public string HelloWorld()
        {
            return "Hello World";
        }

        [WebMethod]
        public int Add(int a, int b)
        {
            return a + b;
        }

        [WebMethod]
        public Product[] ShowAllProducts()
        {
            //Connection
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = "Data Source=MANISH-PC\\SQLEXPRESS;Initial Catalog=LPU_Db;Integrated Security=True;";
            conn.Open();

            //Command
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "SELECT * FROM Product";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = conn;

            //DataReader
            SqlDataReader dr = cmd.ExecuteReader();

            Product[] prodList = null;

            DataTable dt = new DataTable();
            dt.Load(dr);
            if (dt.Rows.Count > 0)
            {
                prodList = new Product[dt.Rows.Count];
            }

            int i = 0;
            foreach(DataRow item in dt.Rows)
            {
                Product pObj = new Product();
                pObj.ProdId = (int)item[0];
                pObj.Name = item[1].ToString();
                pObj.Category = item[2].ToString();
                pObj.Price = float.Parse(item[3].ToString());
                pObj.Description = item[4].ToString();

                prodList[i] = pObj;
                i++;
            }

            conn.Close();

            return prodList;
        }
    }
}
