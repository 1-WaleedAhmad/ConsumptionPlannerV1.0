using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConsumptionPlannerV1._0
{
    public partial class Form4_Admin_Dashboard : Form
    {
        public Form4_Admin_Dashboard()
        {
            InitializeComponent();
        }


        //=================================================================================================================
        //All Buttons Functionality + All buttons UI
        //==================================================================================================================

        private void buttonBack_MouseHover(object sender, EventArgs e)
        {
            buttonBack.Width = 150;
            buttonBack.Height = 50;
            buttonBack.BackColor = System.Drawing.Color.RoyalBlue;
            buttonBack.Font = new Font(buttonBack.Font.FontFamily, 22, buttonBack.Font.Style);
        }

        private void buttonBack_MouseLeave(object sender, EventArgs e)
        {
            buttonBack.Width = 140;
            buttonBack.Height = 46;
            buttonBack.BackColor = System.Drawing.Color.DodgerBlue;
            buttonBack.Font = new Font(buttonBack.Font.FontFamily, 20, buttonBack.Font.Style);
        }


        private void buttonBack_Click(object sender, EventArgs e)
        {
            this.Hide(); // Hide Form4

            using (Form2_Admin_Login form2 = new Form2_Admin_Login())
            {
                form2.ShowDialog(); // Show Form2 as a modal dialog
            }

            this.Close(); // Close Form4
        }

        private void buttonSetPeakHours_MouseHover(object sender, EventArgs e)
        {
            buttonSetPeakHours.Width = 595;
            buttonSetPeakHours.Height = 120;
            buttonSetPeakHours.BackColor = System.Drawing.Color.RoyalBlue;
            buttonSetPeakHours.Font = new Font(buttonSetPeakHours.Font.FontFamily, 28, buttonSetPeakHours.Font.Style);
        }

        private void buttonSetPeakHours_MouseLeave(object sender, EventArgs e)
        {
            buttonSetPeakHours.Width = 550;
            buttonSetPeakHours.Height = 112;
            buttonSetPeakHours.BackColor = System.Drawing.Color.DodgerBlue;
            buttonSetPeakHours.Font = new Font(buttonSetPeakHours.Font.FontFamily, 26, buttonSetPeakHours.Font.Style);
        }

        private void buttonSetRate_MouseHover(object sender, EventArgs e)
        {
            buttonSetRate.Width = 595;
            buttonSetRate.Height = 120;
            buttonSetRate.BackColor = System.Drawing.Color.RoyalBlue;
            buttonSetRate.Font = new Font(buttonSetRate.Font.FontFamily, 28, buttonSetRate.Font.Style);
        }

        private void buttonSetRate_MouseLeave(object sender, EventArgs e)
        {
            buttonSetRate.Width = 550;
            buttonSetRate.Height = 112;
            buttonSetRate.BackColor = System.Drawing.Color.DodgerBlue;
            buttonSetRate.Font = new Font(buttonSetRate.Font.FontFamily, 26, buttonSetRate.Font.Style);
        }

        private void buttonSetRate_Click(object sender, EventArgs e)
        {
            this.Hide(); // Hide Form4

            using (Form6_ElecRate form6 = new Form6_ElecRate())
            {
                form6.ShowDialog(); // Show form6 as a modal dialog
            }

            this.Close(); // Close Form4
        }

        private void buttonSetPeakHours_Click(object sender, EventArgs e)
        {
            this.Hide(); // Hide Form4

            using (Form7_PeakHour form7 = new Form7_PeakHour())
            {
                form7.ShowDialog(); // Show form7 as a modal dialog
            }

            this.Close(); // Close Form4
        }
    }
}
