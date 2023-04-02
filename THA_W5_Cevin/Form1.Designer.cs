namespace THA_W5_Cevin
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
            this.dgProduct = new System.Windows.Forms.DataGridView();
            this.dgCategory = new System.Windows.Forms.DataGridView();
            this.btAll = new System.Windows.Forms.Button();
            this.btFilter = new System.Windows.Forms.Button();
            this.cbFilter = new System.Windows.Forms.ComboBox();
            this.btAddCategory = new System.Windows.Forms.Button();
            this.btRemoveCategory = new System.Windows.Forms.Button();
            this.btAddProduct = new System.Windows.Forms.Button();
            this.btEditProduct = new System.Windows.Forms.Button();
            this.btRemoveProduct = new System.Windows.Forms.Button();
            this.txtNamaProd = new System.Windows.Forms.TextBox();
            this.txtHarga = new System.Windows.Forms.TextBox();
            this.txtStock = new System.Windows.Forms.TextBox();
            this.txtNamaCat = new System.Windows.Forms.TextBox();
            this.cbCategory = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgProduct)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgCategory)).BeginInit();
            this.SuspendLayout();
            // 
            // dgProduct
            // 
            this.dgProduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgProduct.Location = new System.Drawing.Point(39, 63);
            this.dgProduct.Name = "dgProduct";
            this.dgProduct.RowHeadersWidth = 51;
            this.dgProduct.RowTemplate.Height = 24;
            this.dgProduct.Size = new System.Drawing.Size(620, 292);
            this.dgProduct.TabIndex = 0;
            this.dgProduct.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgProduct_CellMouseClick);
            // 
            // dgCategory
            // 
            this.dgCategory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgCategory.Location = new System.Drawing.Point(757, 63);
            this.dgCategory.Name = "dgCategory";
            this.dgCategory.RowHeadersWidth = 51;
            this.dgCategory.RowTemplate.Height = 24;
            this.dgCategory.Size = new System.Drawing.Size(322, 292);
            this.dgCategory.TabIndex = 1;
            this.dgCategory.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgCategory_CellMouseClick);
            // 
            // btAll
            // 
            this.btAll.Location = new System.Drawing.Point(371, 34);
            this.btAll.Name = "btAll";
            this.btAll.Size = new System.Drawing.Size(75, 23);
            this.btAll.TabIndex = 2;
            this.btAll.Text = "All";
            this.btAll.UseVisualStyleBackColor = true;
            this.btAll.Click += new System.EventHandler(this.btAll_Click);
            // 
            // btFilter
            // 
            this.btFilter.Location = new System.Drawing.Point(452, 34);
            this.btFilter.Name = "btFilter";
            this.btFilter.Size = new System.Drawing.Size(75, 23);
            this.btFilter.TabIndex = 3;
            this.btFilter.Text = "Filter";
            this.btFilter.UseVisualStyleBackColor = true;
            this.btFilter.Click += new System.EventHandler(this.btFilter_Click);
            // 
            // cbFilter
            // 
            this.cbFilter.Enabled = false;
            this.cbFilter.FormattingEnabled = true;
            this.cbFilter.Location = new System.Drawing.Point(533, 34);
            this.cbFilter.Name = "cbFilter";
            this.cbFilter.Size = new System.Drawing.Size(121, 24);
            this.cbFilter.TabIndex = 4;
            this.cbFilter.SelectedIndexChanged += new System.EventHandler(this.cbFilter_SelectedIndexChanged);
            // 
            // btAddCategory
            // 
            this.btAddCategory.Location = new System.Drawing.Point(911, 411);
            this.btAddCategory.Name = "btAddCategory";
            this.btAddCategory.Size = new System.Drawing.Size(74, 63);
            this.btAddCategory.TabIndex = 5;
            this.btAddCategory.Text = "Add Category";
            this.btAddCategory.UseVisualStyleBackColor = true;
            this.btAddCategory.Click += new System.EventHandler(this.btAddCategory_Click);
            // 
            // btRemoveCategory
            // 
            this.btRemoveCategory.Location = new System.Drawing.Point(1005, 411);
            this.btRemoveCategory.Name = "btRemoveCategory";
            this.btRemoveCategory.Size = new System.Drawing.Size(74, 63);
            this.btRemoveCategory.TabIndex = 6;
            this.btRemoveCategory.Text = "Remove Category";
            this.btRemoveCategory.UseVisualStyleBackColor = true;
            this.btRemoveCategory.Click += new System.EventHandler(this.btRemoveCategory_Click);
            // 
            // btAddProduct
            // 
            this.btAddProduct.Location = new System.Drawing.Point(373, 411);
            this.btAddProduct.Name = "btAddProduct";
            this.btAddProduct.Size = new System.Drawing.Size(74, 63);
            this.btAddProduct.TabIndex = 7;
            this.btAddProduct.Text = "Add Product";
            this.btAddProduct.UseVisualStyleBackColor = true;
            this.btAddProduct.Click += new System.EventHandler(this.btAddProduct_Click);
            // 
            // btEditProduct
            // 
            this.btEditProduct.Location = new System.Drawing.Point(453, 411);
            this.btEditProduct.Name = "btEditProduct";
            this.btEditProduct.Size = new System.Drawing.Size(74, 63);
            this.btEditProduct.TabIndex = 8;
            this.btEditProduct.Text = "Edit Product";
            this.btEditProduct.UseVisualStyleBackColor = true;
            this.btEditProduct.Click += new System.EventHandler(this.btEditProduct_Click);
            // 
            // btRemoveProduct
            // 
            this.btRemoveProduct.Location = new System.Drawing.Point(533, 411);
            this.btRemoveProduct.Name = "btRemoveProduct";
            this.btRemoveProduct.Size = new System.Drawing.Size(74, 63);
            this.btRemoveProduct.TabIndex = 9;
            this.btRemoveProduct.Text = "Remove Product";
            this.btRemoveProduct.UseVisualStyleBackColor = true;
            this.btRemoveProduct.Click += new System.EventHandler(this.btRemoveProduct_Click);
            // 
            // txtNamaProd
            // 
            this.txtNamaProd.Location = new System.Drawing.Point(92, 393);
            this.txtNamaProd.Name = "txtNamaProd";
            this.txtNamaProd.Size = new System.Drawing.Size(262, 22);
            this.txtNamaProd.TabIndex = 10;
            // 
            // txtHarga
            // 
            this.txtHarga.Location = new System.Drawing.Point(92, 452);
            this.txtHarga.Name = "txtHarga";
            this.txtHarga.Size = new System.Drawing.Size(146, 22);
            this.txtHarga.TabIndex = 11;
            this.txtHarga.TextChanged += new System.EventHandler(this.txtHarga_TextChanged);
            // 
            // txtStock
            // 
            this.txtStock.Location = new System.Drawing.Point(92, 480);
            this.txtStock.Name = "txtStock";
            this.txtStock.Size = new System.Drawing.Size(100, 22);
            this.txtStock.TabIndex = 12;
            this.txtStock.TextChanged += new System.EventHandler(this.txtStock_TextChanged);
            // 
            // txtNamaCat
            // 
            this.txtNamaCat.Location = new System.Drawing.Point(886, 383);
            this.txtNamaCat.Name = "txtNamaCat";
            this.txtNamaCat.Size = new System.Drawing.Size(193, 22);
            this.txtNamaCat.TabIndex = 13;
            // 
            // cbCategory
            // 
            this.cbCategory.FormattingEnabled = true;
            this.cbCategory.Location = new System.Drawing.Point(92, 422);
            this.cbCategory.Name = "cbCategory";
            this.cbCategory.Size = new System.Drawing.Size(121, 24);
            this.cbCategory.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 396);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 16);
            this.label1.TabIndex = 15;
            this.label1.Text = "Nama :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 425);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 16);
            this.label2.TabIndex = 16;
            this.label2.Text = "Category :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(36, 455);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 16);
            this.label3.TabIndex = 17;
            this.label3.Text = "Harga :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(39, 486);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 16);
            this.label4.TabIndex = 18;
            this.label4.Text = "Stock :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(830, 386);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 16);
            this.label5.TabIndex = 19;
            this.label5.Text = "Nama :";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1120, 531);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbCategory);
            this.Controls.Add(this.txtNamaCat);
            this.Controls.Add(this.txtStock);
            this.Controls.Add(this.txtHarga);
            this.Controls.Add(this.txtNamaProd);
            this.Controls.Add(this.btRemoveProduct);
            this.Controls.Add(this.btEditProduct);
            this.Controls.Add(this.btAddProduct);
            this.Controls.Add(this.btRemoveCategory);
            this.Controls.Add(this.btAddCategory);
            this.Controls.Add(this.cbFilter);
            this.Controls.Add(this.btFilter);
            this.Controls.Add(this.btAll);
            this.Controls.Add(this.dgCategory);
            this.Controls.Add(this.dgProduct);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgProduct)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgCategory)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgProduct;
        private System.Windows.Forms.DataGridView dgCategory;
        private System.Windows.Forms.Button btAll;
        private System.Windows.Forms.Button btFilter;
        private System.Windows.Forms.ComboBox cbFilter;
        private System.Windows.Forms.Button btAddCategory;
        private System.Windows.Forms.Button btRemoveCategory;
        private System.Windows.Forms.Button btAddProduct;
        private System.Windows.Forms.Button btEditProduct;
        private System.Windows.Forms.Button btRemoveProduct;
        private System.Windows.Forms.TextBox txtNamaProd;
        private System.Windows.Forms.TextBox txtHarga;
        private System.Windows.Forms.TextBox txtStock;
        private System.Windows.Forms.TextBox txtNamaCat;
        private System.Windows.Forms.ComboBox cbCategory;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}

