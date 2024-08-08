using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EntityFrameworkDemo
{
    public partial class Form1 : Form
    {
        

        public Form1()
        {
            InitializeComponent();     
        }
        ProductDal _productDal = new ProductDal();
        private void Form1_Load(object sender, EventArgs e)
        {
            LoadProducts();
            
        }

        private void LoadProducts()
        {
            dgwProducts.DataSource = _productDal.GetAll();
        }
        private void SearchProducts(string key)
        {
            var result = _productDal.GetAll().Where(p=>p.Name.Contains(key)).ToList();
            dgwProducts.DataSource= result;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            
            try
            {
                Add();
            }
            catch (Exception)
            {

                MessageBox.Show("Please make sure you enter the values!! ");
            }
        }

        private void Add()
        {
            _productDal.Add(new Product
            {
                Name = tbxName.Text,
                Price = Convert.ToDecimal(tbxPrice.Text),
                StockAmount = Convert.ToInt32(tbxStock.Text),
            });
            LoadProducts();
            MessageBox.Show("Product Added!");
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                Delete();
            }
            catch (Exception)
            {

                MessageBox.Show("Don't add the ID part yourself.");
            }
        }

        private void Delete()
        {
            _productDal.Delete(new Product
            {
                Id = Convert.ToInt32(tbxId.Text)
            });
            LoadProducts();
            MessageBox.Show("Product Deleted!");
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            
            try
            {
                Update();
            }
            catch (Exception)
            {

                MessageBox.Show("Please make sure you enter the values!!");
            }
        }

        private void Update()
        {
            _productDal.Update(new Product
            {

                Name = tbxName2.Text,
                Price = Convert.ToDecimal(tbxPrice2.Text),
                StockAmount = Convert.ToInt32(tbxStock2.Text),
            });
            LoadProducts();
            MessageBox.Show("Product Updated!");
        }

        private void dgwProducts_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            tbxName2.Text = dgwProducts.CurrentRow.Cells[1].Value.ToString();
            tbxPrice2.Text = dgwProducts.CurrentRow.Cells[2].Value.ToString();
            tbxStock2.Text = dgwProducts.CurrentRow.Cells[3].Value.ToString();
            tbxId.Text = dgwProducts.CurrentRow.Cells[0].Value.ToString();
            tbxIdUpdate.Text = dgwProducts.CurrentRow.Cells[0].Value.ToString();
        }

        private void dgwProducts_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void tbxSearch_TextChanged(object sender, EventArgs e)
        {
            SearchProducts(tbxSearch.Text);
        }
    }
}
