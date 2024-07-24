using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RecapDemo1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            int top = 0;
            int left = 0;
            Button[,] button = new Button[8,8];
            for (int i = 0; i <= button.GetUpperBound(0); i++)
            {
                for (int j = 0; j <= button.GetUpperBound(1); j++)
                {
                    button[i, j] = new Button();
                    button[i, j].Width = 100;
                    button[i, j].Height = 100;                 
                    button[i, j].Top = top;
                    button[i, j].Left = left;                 
                    left = left + 100;
                    if ((i+j)% 2 ==1)
                    {
                        button[i, j].BackColor = Color.Black;
                    }
                    else
                    {
                        button[i,j].BackColor = Color.White;
                    }
                    this.Controls.Add(button[i, j]);
                }
                top = top + 100;
                left = 0;
            }
            
            
            
        }
    }
}
 