using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using FoodChoice;
namespace FoodChoice
{
    public class FoodDal
    {

        SqlConnection _connection = new SqlConnection(@"Data Source = (localdb)\MSSQLLocalDB; Initial Catalog = FoodChoice");

        private void ConnectionControl()
        {
            if (_connection.State == ConnectionState.Closed)
            {
                _connection.Open();
            }
        }
        public List<Food> GetAll()
        {
            ConnectionControl();
            SqlCommand command = new SqlCommand("Select * from Foods", _connection);
            SqlDataReader reader = command.ExecuteReader();
            List<Food> foods = new List<Food>();
            while (reader.Read())
            {
                Food food = new Food
                {
                    Id = Convert.ToInt32(reader["ID"]),
                    Name = Convert.ToString(reader["Name"]),

                };
                foods.Add(food);


            }
            reader.Close();
            _connection.Close();
            return foods;


        }
    }
    
}
