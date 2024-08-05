using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FoodChoice
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
            LoadFoods();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }
        FoodDal _foodDal = new FoodDal();
        private void LoadFoods()
        {
            dgwFoods.DataSource = _foodDal.GetAll();
        }

        private void dgwFoods_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
           
        }

        private void tabPageDailyFoodList_Click(object sender, EventArgs e)
        {

        }
    }
}
