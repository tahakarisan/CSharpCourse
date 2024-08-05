
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodChoice
{
    public class FoodChoiceContext : DbContext
    {
        public FoodChoiceContext()
        {
            Database.SetInitializer<FoodChoiceContext>(new DropCreateDatabaseIfModelChanges<FoodChoiceContext>());
        }
        public DbSet<Food> Foods { get; set; }
        public DbSet<Company> Companies { get; set; }
        public DbSet<Employee> Employees { get; set; }

    }
}
