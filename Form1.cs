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
            //this.recalculateCalendar(3, 4, -3, -4);
        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            monthCalendar1.BoldedDates = new DateTime[] { };
            if (workFirstDay.Checked)
            {
                this.recalculateCalendar(0, 1, -3, -4);
            }
            if (workSecondDay.Checked)
            {
                this.recalculateCalendar(0, 3, -1, -4);
            }
            if (weekendFirstDay.Checked)
            {
                this.recalculateCalendar(2, 3, -1, -2);
            }
            if (weekendSecondDay.Checked)
            {
                this.recalculateCalendar(1,2,-2,-3);
            }
        }
        private void recalculateCalendar(int firstDate, int secondDate, int firstBack, int secondBack)
        {
            DateTime today = DateTime.Today;
            DateTime today2 = DateTime.Today;
            DateTime b_today = DateTime.Today;
            DateTime b_today2 = DateTime.Today;
            DateTime[] forward = new DateTime[365];
            DateTime[] forward2 = new DateTime[365];
            DateTime[] backward = new DateTime[365];
            DateTime[] backward2 = new DateTime[365];
            for (var i = 0; i <= 165; i++)
            {
                forward[i] = today.AddDays(firstDate);
                today = today.AddDays(4);
            }
            for (var j = 0; j <= 165; j++)
            {
                forward2[j] = today2.AddDays(secondDate);
                today2 = today2.AddDays(4);
            }
            for(var k =0; k<=165; k++)
            {
                backward[k] = b_today.AddDays(firstBack);
                b_today = b_today.AddDays(-4);
            }
            for (var p = 0; p <= 165; p++)
            {
                backward2[p] = b_today2.AddDays(secondBack);
                b_today2 = b_today2.AddDays(-4);
            }
            //monthCalendar1.BoldedDates = forward.Concat(forward2).ToArray();
            DateTime[] fullForward = forward.Concat(forward2).ToArray();
            DateTime[] fullBackward = backward.Concat(backward2).ToArray();
            monthCalendar1.BoldedDates = fullForward.Concat(fullBackward).ToArray();
        }
    }
}
