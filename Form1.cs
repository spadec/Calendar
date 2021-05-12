using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calendar
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            DateTime today = DateTime.Today;
            DateTime today2 = DateTime.Today;
            DateTime[] forward = new DateTime[365];
            DateTime[] forward2 = new DateTime[365];
            for (var i = 0; i <= 165; i++){
                forward[i] = today.AddDays(3);
                today = today.AddDays(4);
            }
            for (var j = 0; j<= 165; j++)
            {
                forward2[j] = today2.AddDays(4);
                today2 = today2.AddDays(4);
            }
            monthCalendar1.BoldedDates = forward.Concat(forward2).ToArray();
        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
