using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinDiscArchDemo
{
    public class ProductUtility : IProductRepo
    {
        SqlConnection con;
        SqlDataAdapter adap1;
        DataSet ds;
        List<Product> prodList = null;
        SqlCommandBuilder bldr = null;

        public ProductUtility()
        {
            con = new SqlConnection();
            con.ConnectionString = "Server=.;Integrated Security=True;Database=LPU_Db;TrustServerCertificate=true";
            

        }

        public bool AddDatata(Product obj)
        {
            throw new NotImplementedException();
        }

        public bool DeleteData(int id)
        {
            throw new NotImplementedException();
        }

        public List<Product> GetTop3BudgetProduct()
        {
            throw new NotImplementedException();
        }

        public List<Product> GetTop3CostlyProduct()
        {
            throw new NotImplementedException();
        }

        public Product SearchByID(int id)
        {
            throw new NotImplementedException();
        }

        public List<Product> ShowAll()
        {
            adap1 = new SqlDataAdapter("Select * From Product",con);
            adap1.MissingSchemaAction = MissingSchemaAction.AddWithKey;

            ds = new DataSet();
            adap1.Fill(ds, "Product");

            if (ds.Tables[0].Rows.Count > 0)
            {
                prodList = new List<Product>();
                foreach(DataRow drow in ds.Tables["Product"].Rows)
                {
                    Product p1 = new Product()
                    {
                        ProdID = Int32.Parse(drow[0].ToString()),
                        ProdName = drow[1].ToString(),
                        Category = drow[2].ToString(),
                        Price = Single.Parse(drow[3].ToString()),
                        Desc = drow[4].ToString(),

                    };
                    prodList.Add(p1);
                }

            }
            return prodList;
        }

        public List<Product> ShowAllProductByCategory(int catID)
        {
            throw new NotImplementedException();
        }

        public List<Product> SortProductByPriceAsc()
        {
            throw new NotImplementedException();
        }

        public List<Product> SortProductByPriceDesc()
        {
            throw new NotImplementedException();
        }

        public bool UpdateData(int id, Product obj)
        {
            SqlCommand updateCmd = new SqlCommand();
            SqlParameter[] param = new SqlParameter[4];

            param[0] = new SqlParameter("@ProdID", obj.ProdID);
            param[1] = new SqlParameter("@ProdName", obj.ProdName);
            param[2] = new SqlParameter("@Price", obj.Price);
            param[3] = new SqlParameter("@Desc", obj.Desc);

            updateCmd.CommandText = "Update Products set ProdName=@ProdName,Price=@Price,Description=@Desc where ProdID=@ProdID";
            updateCmd.Connection = con;
            updateCmd.CommandType = CommandType.Text;

            updateCmd.Parameters.AddRange(param);

            adap1.UpdateCommand = updateCmd;
            bldr.DataAdapter = adap1;

            adap1.Update(ds);
            return true;
        }

        public DataTable GetAllData()
        {
            adap1 = new SqlDataAdapter("Select * From Product", con);
            adap1.MissingSchemaAction = MissingSchemaAction.AddWithKey;

            bldr = new SqlCommandBuilder(adap1);

            ds = new DataSet();
            adap1.Fill(ds, "Product");

            return ds.Tables[0];

        }
    }
}
