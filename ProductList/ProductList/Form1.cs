using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ProductList
{
    public partial class Form1 : Form
    {
        private List<Product> _productList = new List<Product>();

        public Form1()
        {
            InitializeComponent();
        }

        private void BtnAddToDataGridView_Click(object sender, EventArgs e)
        {
            _productList.Add(new Product(Guid.Parse(TbxId.Text), TbxName.Text, double.Parse(TbxPrice.Text), TbxCountry.Text, double.Parse(TbxSale.Text)));
            DgridProducts.Rows.Add(DgridProducts.RowCount + 1, TbxId.Text, TbxName.Text, TbxPrice.Text, TbxCountry.Text, TbxSale.Text);

            TbxId.Clear();
            TbxName.Clear();
            TbxPrice.Clear();
            TbxCountry.Clear();
            TbxSale.Clear();
        }

        private void BtnClearDataGridView_Click(object sender, EventArgs e)
        {
            DgridProducts.Rows.Clear();
            _productList.Clear();
        }

        private void BtnNewId_Click(object sender, EventArgs e)
        {
            TbxId.Text = Guid.NewGuid().ToString();
            TbxName.Focus();
        }
    }
}