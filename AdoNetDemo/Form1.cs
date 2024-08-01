using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdoNetDemo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadProducts();
        }
        ProductDal _productDal = new ProductDal();
        private void LoadProducts()
        {

            dgwProducts.DataSource = _productDal.GetAll();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            
            try
            {
                Add();
            }
            catch (Exception)
            {

                MessageBox.Show("Please make sure you enter the data correctly");


            }
            LoadProducts();
         


        }

        private void Add()
        {
            _productDal.Add(new Product
            {

                Name = tbxName.Text,
                Price = Convert.ToDecimal(tbxPrice.Text),
                StockAmount = Convert.ToInt32(tbxStock.Text)
            });
            MessageBox.Show("Product Added!");
        }

        public void button1_Click(object sender, EventArgs e)
        {
            //int id3;
            //try
            //{
            //    id3 = Convert.ToInt32(tbxId.Text);
            //}
            //catch (Exception)
            //{
            //    id3 = 0;
            //}


            //int id2 = Convert.ToInt32(tbxId.Text);//SAYI OLMAYAN DEĞER GELİRSE HATA VERİR.

            int.TryParse(tbxId.Text, out int id);//SAYI OLMAYAN DEĞER GELİRSE HATA VERMEZ DEĞERİ 0 YAPAR.


            

            if (id == 0)
            {
                MessageBox.Show("Please make sure you enter the data correctly");
            }
            else
            {
                _productDal.Delete(id);
                LoadProducts();
                MessageBox.Show("Product Deleted!");
            }
        }



        private void dgwProducts_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            tbxName2.Text = dgwProducts.CurrentRow.Cells[1].Value.ToString();
            tbxPrice2.Text = dgwProducts.CurrentRow.Cells[2].Value.ToString();
            tbxStock2.Text = dgwProducts.CurrentRow.Cells[3].Value.ToString();
            tbxId.Text = dgwProducts.CurrentRow.Cells[0].Value.ToString();
            tbxIdUpdate.Text = dgwProducts.CurrentRow.Cells[0].Value.ToString();


        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                Update();
            }
            catch (Exception)
            {

                MessageBox.Show("Please make sure you enter the data correctly");
            }

            
        }

        private void Update()
        {
            _productDal.Update(new Product
            {
                Id = Convert.ToInt32(tbxIdUpdate.Text),
                Name = tbxName2.Text,
                Price = Convert.ToDecimal(tbxPrice2.Text),
                StockAmount = Convert.ToInt32(tbxStock2.Text)
            });
            LoadProducts();
            MessageBox.Show("Product Updated!");
        }

        private void lblId_Click(object sender, EventArgs e)
        {

        }
    }
}
