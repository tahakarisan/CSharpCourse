using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace AdoNetDemo
{
    public class ProductDal
    {
        
        SqlConnection _connection = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=ETrade;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
        public List<Product> GetAll()
        {
            ConnectionControl();
            SqlCommand command = new SqlCommand("Select * from products", _connection);
            SqlDataReader reader = command.ExecuteReader();
            List<Product> products = new List<Product>();
            DataTable dataTable = new DataTable();
           
            
            while (reader.Read())
            {
                Product product = new Product
                {
                    Id = Convert.ToInt32(reader["ID"]),
                    Name = Convert.ToString(reader["Name"]),
                    Price = Convert.ToDecimal(reader["Price"]),
                    StockAmount = Convert.ToInt32(reader["StockAmount"])
                };
                products.Add(product);


            }
            reader.Close();
            _connection.Close();
            return products;

        }

        private void ConnectionControl()
        {
            if (_connection.State == ConnectionState.Closed)
            {
                _connection.Open();
            }
        }
        public void Add(Product product)
        {
            ConnectionControl();
            SqlCommand command = new SqlCommand("Insert into products values(@name,@price,@stockAmount)", _connection);
            command.Parameters.AddWithValue("@name",product.Name);
            command.Parameters.AddWithValue("@price",product.Price);
            command.Parameters.AddWithValue("@stockAmount",product.StockAmount);
            
            command.ExecuteNonQuery();

            
            _connection.Close();
        }
        public void Delete(int id)
        {
            ConnectionControl();
            SqlCommand command = new SqlCommand("Delete from products where id=@id", _connection);
            command.Parameters.AddWithValue("@id", id);

            command.ExecuteNonQuery();


            _connection.Close();
        }
        public void Update(Product product)
        {
            ConnectionControl();
            SqlCommand command = new SqlCommand("Update  products set name=@name,price=@price,stockamount=@stockAmount where id=@id", _connection);

            command.Parameters.AddWithValue("@name",product.Name);
            command.Parameters.AddWithValue("@id",product.Id);
            command.Parameters.AddWithValue("@price", product.Price);
            command.Parameters.AddWithValue("@stockAmount", product.StockAmount);

            command.ExecuteNonQuery();


            _connection.Close();
        }
    }
}


