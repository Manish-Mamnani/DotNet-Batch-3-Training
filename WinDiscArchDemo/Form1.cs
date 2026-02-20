using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinDiscArchDemo
{
    public partial class Form1 : Form
    {

        BindingContext bindObj = null;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnShowAllProd_Click(object sender, EventArgs e)
        {
            ProductUtility prodObj = new ProductUtility();

            dataGridView1.DataSource = prodObj.ShowAll();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ProductUtility prodObj = new ProductUtility();
            dataGridView1.DataSource= prodObj.ShowAll();

            DataTable myDt = prodObj.GetAllData();

            //Binding UI elements with table column

            txtProdID.DataBindings.Add("Text", myDt, myDt.Columns[0].ColumnName);
            txtProdName.DataBindings.Add("Text", myDt, myDt.Columns[1].ColumnName);
            txtPrice.DataBindings.Add("Text", myDt, myDt.Columns[3].ColumnName);
            txtDesc.DataBindings.Add("Text", myDt, myDt.Columns[4].ColumnName);

            //this.DataBinding.Add()


        }

        
    }
}
