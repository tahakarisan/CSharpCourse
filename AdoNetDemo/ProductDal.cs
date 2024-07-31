using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdoNetDemo
{
    public class ProductDal
    {
        public DataTable GetAll()
    {
        SqlConnection connection = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=ETrade;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
        if (connection.State == ConnectionState.Closed)
        {
            connection.Open();
        }
        SqlCommand command = new SqlCommand("Select * from products", connection);
        SqlDataReader reader = command.ExecuteReader();
        DataTable dataTable = new DataTable();
        dataTable.Load(reader);
        reader.Close();
        connection.Close();
        return dataTable;
    }
}
}


