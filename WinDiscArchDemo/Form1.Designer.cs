namespace WinDiscArchDemo
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtProdID = new System.Windows.Forms.TextBox();
            this.lblProdID = new System.Windows.Forms.Label();
            this.lblProdName = new System.Windows.Forms.Label();
            this.txtProdName = new System.Windows.Forms.TextBox();
            this.lblPrice = new System.Windows.Forms.Label();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.btnAddProd = new System.Windows.Forms.Button();
            this.lblDsc = new System.Windows.Forms.Label();
            this.txtDesc = new System.Windows.Forms.TextBox();
            this.btnUpdateProd = new System.Windows.Forms.Button();
            this.btnSearchByID = new System.Windows.Forms.Button();
            this.btnDeleteProd = new System.Windows.Forms.Button();
            this.btnShowAllProd = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtProdID
            // 
            this.txtProdID.Location = new System.Drawing.Point(174, 61);
            this.txtProdID.Name = "txtProdID";
            this.txtProdID.Size = new System.Drawing.Size(133, 22);
            this.txtProdID.TabIndex = 0;
            // 
            // lblProdID
            // 
            this.lblProdID.AutoSize = true;
            this.lblProdID.Location = new System.Drawing.Point(99, 64);
            this.lblProdID.Name = "lblProdID";
            this.lblProdID.Size = new System.Drawing.Size(69, 16);
            this.lblProdID.TabIndex = 1;
            this.lblProdID.Text = "Product ID";
            this.lblProdID.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblProdName
            // 
            this.lblProdName.AutoSize = true;
            this.lblProdName.Location = new System.Drawing.Point(75, 107);
            this.lblProdName.Name = "lblProdName";
            this.lblProdName.Size = new System.Drawing.Size(93, 16);
            this.lblProdName.TabIndex = 3;
            this.lblProdName.Text = "Product Name";
            // 
            // txtProdName
            // 
            this.txtProdName.Location = new System.Drawing.Point(174, 104);
            this.txtProdName.Name = "txtProdName";
            this.txtProdName.Size = new System.Drawing.Size(133, 22);
            this.txtProdName.TabIndex = 2;
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Location = new System.Drawing.Point(130, 149);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(38, 16);
            this.lblPrice.TabIndex = 5;
            this.lblPrice.Text = "Price";
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(174, 146);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(133, 22);
            this.txtPrice.TabIndex = 4;
            // 
            // btnAddProd
            // 
            this.btnAddProd.Location = new System.Drawing.Point(49, 302);
            this.btnAddProd.Name = "btnAddProd";
            this.btnAddProd.Size = new System.Drawing.Size(127, 42);
            this.btnAddProd.TabIndex = 6;
            this.btnAddProd.Text = "Add Product";
            this.btnAddProd.UseVisualStyleBackColor = true;
            // 
            // lblDsc
            // 
            this.lblDsc.AutoSize = true;
            this.lblDsc.Location = new System.Drawing.Point(93, 197);
            this.lblDsc.Name = "lblDsc";
            this.lblDsc.Size = new System.Drawing.Size(75, 16);
            this.lblDsc.TabIndex = 8;
            this.lblDsc.Text = "Description";
            this.lblDsc.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtDesc
            // 
            this.txtDesc.Location = new System.Drawing.Point(174, 194);
            this.txtDesc.Multiline = true;
            this.txtDesc.Name = "txtDesc";
            this.txtDesc.Size = new System.Drawing.Size(144, 77);
            this.txtDesc.TabIndex = 7;
            // 
            // btnUpdateProd
            // 
            this.btnUpdateProd.Location = new System.Drawing.Point(180, 302);
            this.btnUpdateProd.Name = "btnUpdateProd";
            this.btnUpdateProd.Size = new System.Drawing.Size(127, 42);
            this.btnUpdateProd.TabIndex = 9;
            this.btnUpdateProd.Text = "Update Product";
            this.btnUpdateProd.UseVisualStyleBackColor = true;
            // 
            // btnSearchByID
            // 
            this.btnSearchByID.Location = new System.Drawing.Point(313, 302);
            this.btnSearchByID.Name = "btnSearchByID";
            this.btnSearchByID.Size = new System.Drawing.Size(127, 42);
            this.btnSearchByID.TabIndex = 10;
            this.btnSearchByID.Text = "Search By ID";
            this.btnSearchByID.UseVisualStyleBackColor = true;
            // 
            // btnDeleteProd
            // 
            this.btnDeleteProd.Location = new System.Drawing.Point(49, 375);
            this.btnDeleteProd.Name = "btnDeleteProd";
            this.btnDeleteProd.Size = new System.Drawing.Size(127, 42);
            this.btnDeleteProd.TabIndex = 11;
            this.btnDeleteProd.Text = "Delete Product";
            this.btnDeleteProd.UseVisualStyleBackColor = true;
            // 
            // btnShowAllProd
            // 
            this.btnShowAllProd.Location = new System.Drawing.Point(180, 375);
            this.btnShowAllProd.Name = "btnShowAllProd";
            this.btnShowAllProd.Size = new System.Drawing.Size(127, 42);
            this.btnShowAllProd.TabIndex = 12;
            this.btnShowAllProd.Text = "Show All Products";
            this.btnShowAllProd.UseVisualStyleBackColor = true;
            this.btnShowAllProd.Click += new System.EventHandler(this.btnShowAllProd_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(570, 39);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(357, 231);
            this.dataGridView1.TabIndex = 13;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(570, 321);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 14;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(669, 321);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 15;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(762, 321);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 16;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(852, 321);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 17;
            this.button4.Text = "button4";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(958, 498);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnShowAllProd);
            this.Controls.Add(this.btnDeleteProd);
            this.Controls.Add(this.btnSearchByID);
            this.Controls.Add(this.btnUpdateProd);
            this.Controls.Add(this.lblDsc);
            this.Controls.Add(this.txtDesc);
            this.Controls.Add(this.btnAddProd);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.lblProdName);
            this.Controls.Add(this.txtProdName);
            this.Controls.Add(this.lblProdID);
            this.Controls.Add(this.txtProdID);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtProdID;
        private System.Windows.Forms.Label lblProdID;
        private System.Windows.Forms.Label lblProdName;
        private System.Windows.Forms.TextBox txtProdName;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.Button btnAddProd;
        private System.Windows.Forms.Label lblDsc;
        private System.Windows.Forms.TextBox txtDesc;
        private System.Windows.Forms.Button btnUpdateProd;
        private System.Windows.Forms.Button btnSearchByID;
        private System.Windows.Forms.Button btnDeleteProd;
        private System.Windows.Forms.Button btnShowAllProd;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
    }
}

