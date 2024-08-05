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
            using (FoodChoiceContext context = new FoodChoiceContext())
            {
                return context.Foods.ToList();
            }
        }

    }
}


