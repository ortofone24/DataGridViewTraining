namespace ProductList
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.TbxId = new System.Windows.Forms.TextBox();
            this.TbxName = new System.Windows.Forms.TextBox();
            this.TbxPrice = new System.Windows.Forms.TextBox();
            this.TbxCountry = new System.Windows.Forms.TextBox();
            this.TbxSale = new System.Windows.Forms.TextBox();
            this.BtnAddToDataGridView = new System.Windows.Forms.Button();
            this.BtnClearDataGridView = new System.Windows.Forms.Button();
            this.DgridProducts = new System.Windows.Forms.DataGridView();
            this.Index = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductSuperName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Country = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sale = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BtnNewId = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DgridProducts)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 46);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(16, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Id";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 72);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nazwa";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 100);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Cena";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(18, 124);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(25, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Kraj";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(18, 149);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Promocja";
            // 
            // TbxId
            // 
            this.TbxId.Location = new System.Drawing.Point(81, 45);
            this.TbxId.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TbxId.Name = "TbxId";
            this.TbxId.Size = new System.Drawing.Size(294, 20);
            this.TbxId.TabIndex = 6;
            // 
            // TbxName
            // 
            this.TbxName.Location = new System.Drawing.Point(81, 69);
            this.TbxName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TbxName.Name = "TbxName";
            this.TbxName.Size = new System.Drawing.Size(348, 20);
            this.TbxName.TabIndex = 7;
            // 
            // TbxPrice
            // 
            this.TbxPrice.Location = new System.Drawing.Point(81, 98);
            this.TbxPrice.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TbxPrice.Name = "TbxPrice";
            this.TbxPrice.Size = new System.Drawing.Size(348, 20);
            this.TbxPrice.TabIndex = 9;
            // 
            // TbxCountry
            // 
            this.TbxCountry.Location = new System.Drawing.Point(81, 124);
            this.TbxCountry.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TbxCountry.Name = "TbxCountry";
            this.TbxCountry.Size = new System.Drawing.Size(348, 20);
            this.TbxCountry.TabIndex = 10;
            // 
            // TbxSale
            // 
            this.TbxSale.Location = new System.Drawing.Point(81, 149);
            this.TbxSale.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TbxSale.Name = "TbxSale";
            this.TbxSale.Size = new System.Drawing.Size(348, 20);
            this.TbxSale.TabIndex = 11;
            // 
            // BtnAddToDataGridView
            // 
            this.BtnAddToDataGridView.AutoSize = true;
            this.BtnAddToDataGridView.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.BtnAddToDataGridView.Location = new System.Drawing.Point(464, 22);
            this.BtnAddToDataGridView.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BtnAddToDataGridView.Name = "BtnAddToDataGridView";
            this.BtnAddToDataGridView.Size = new System.Drawing.Size(320, 37);
            this.BtnAddToDataGridView.TabIndex = 13;
            this.BtnAddToDataGridView.Text = "Dodaj dane";
            this.BtnAddToDataGridView.UseVisualStyleBackColor = true;
            this.BtnAddToDataGridView.Click += new System.EventHandler(this.BtnAddToDataGridView_Click);
            // 
            // BtnClearDataGridView
            // 
            this.BtnClearDataGridView.AutoSize = true;
            this.BtnClearDataGridView.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.BtnClearDataGridView.Location = new System.Drawing.Point(464, 72);
            this.BtnClearDataGridView.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BtnClearDataGridView.Name = "BtnClearDataGridView";
            this.BtnClearDataGridView.Size = new System.Drawing.Size(320, 37);
            this.BtnClearDataGridView.TabIndex = 14;
            this.BtnClearDataGridView.Text = "Wyczść dane";
            this.BtnClearDataGridView.UseVisualStyleBackColor = true;
            this.BtnClearDataGridView.Click += new System.EventHandler(this.BtnClearDataGridView_Click);
            // 
            // DgridProducts
            // 
            this.DgridProducts.AllowUserToAddRows = false;
            this.DgridProducts.AllowUserToDeleteRows = false;
            this.DgridProducts.AllowUserToResizeColumns = false;
            this.DgridProducts.AllowUserToResizeRows = false;
            this.DgridProducts.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DgridProducts.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.DgridProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgridProducts.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Index,
            this.Id,
            this.ProductSuperName,
            this.Price,
            this.Country,
            this.Sale});
            this.DgridProducts.Location = new System.Drawing.Point(21, 189);
            this.DgridProducts.Name = "DgridProducts";
            this.DgridProducts.ReadOnly = true;
            this.DgridProducts.RowHeadersVisible = false;
            this.DgridProducts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgridProducts.Size = new System.Drawing.Size(763, 164);
            this.DgridProducts.TabIndex = 15;
            // 
            // Index
            // 
            this.Index.FillWeight = 30F;
            this.Index.HeaderText = "";
            this.Index.Name = "Index";
            this.Index.ReadOnly = true;
            // 
            // Id
            // 
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            // 
            // ProductSuperName
            // 
            this.ProductSuperName.HeaderText = "Name";
            this.ProductSuperName.Name = "ProductSuperName";
            this.ProductSuperName.ReadOnly = true;
            // 
            // Price
            // 
            this.Price.HeaderText = "Price";
            this.Price.Name = "Price";
            this.Price.ReadOnly = true;
            // 
            // Country
            // 
            this.Country.HeaderText = "Country";
            this.Country.Name = "Country";
            this.Country.ReadOnly = true;
            // 
            // Sale
            // 
            this.Sale.HeaderText = "Sale";
            this.Sale.Name = "Sale";
            this.Sale.ReadOnly = true;
            // 
            // BtnNewId
            // 
            this.BtnNewId.Location = new System.Drawing.Point(380, 45);
            this.BtnNewId.Name = "BtnNewId";
            this.BtnNewId.Size = new System.Drawing.Size(49, 19);
            this.BtnNewId.TabIndex = 16;
            this.BtnNewId.UseVisualStyleBackColor = true;
            this.BtnNewId.Click += new System.EventHandler(this.BtnNewId_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(804, 365);
            this.Controls.Add(this.BtnNewId);
            this.Controls.Add(this.DgridProducts);
            this.Controls.Add(this.BtnClearDataGridView);
            this.Controls.Add(this.BtnAddToDataGridView);
            this.Controls.Add(this.TbxSale);
            this.Controls.Add(this.TbxCountry);
            this.Controls.Add(this.TbxPrice);
            this.Controls.Add(this.TbxName);
            this.Controls.Add(this.TbxId);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MG";
            ((System.ComponentModel.ISupportInitialize)(this.DgridProducts)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox TbxId;
        private System.Windows.Forms.TextBox TbxName;
        private System.Windows.Forms.TextBox TbxPrice;
        private System.Windows.Forms.TextBox TbxCountry;
        private System.Windows.Forms.TextBox TbxSale;
        private System.Windows.Forms.Button BtnAddToDataGridView;
        private System.Windows.Forms.Button BtnClearDataGridView;
        private System.Windows.Forms.DataGridView DgridProducts;
        private System.Windows.Forms.DataGridViewTextBoxColumn Index;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductSuperName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.DataGridViewTextBoxColumn Country;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sale;
        private System.Windows.Forms.Button BtnNewId;
    }
}

