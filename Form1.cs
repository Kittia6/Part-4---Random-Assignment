using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Part_4___Random_Assignment
{
    public partial class RandomNumbers : Form
    {
        Random generator = new Random();
        int maxInt,minInt;
        

        public RandomNumbers()
        {
            InitializeComponent();
        }

        private void btnInt_Click(object sender, EventArgs e)
        {
            maxInt = Convert.ToInt32(txtMax.Text);
            minInt = Convert.ToInt32(txtMin.Text);
            generator.Next(minInt, maxInt);
            
        }

        private void btnDouble_Click(object sender, EventArgs e)
        {
            maxInt = Convert.ToInt32(txtMax.Text);
            minInt = Convert.ToInt32(txtMin.Text);
           Convert.ToDouble(generator.Next(minInt, maxInt));
        }
    }
}
