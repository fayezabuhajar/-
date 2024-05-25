using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

      

        private void dateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            DateTime dateDelevery = dateTimePicker.Value;
            if ((dateDelevery.DayOfWeek == DayOfWeek.Friday) ||
                (dateDelevery.DayOfWeek == DayOfWeek.Saturday) ||
                (dateDelevery.DayOfWeek == DayOfWeek.Sunday))
            {
                deleveryLabel.Text = dateDelevery.AddDays(3).ToLongDateString();

            }
            else deleveryLabel.Text = dateDelevery.AddDays(2).ToLongDateString();
            
            

        }
    }
}
