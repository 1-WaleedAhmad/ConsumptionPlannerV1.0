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
    public partial class Form5_Consumer_Dashboard : Form

    {

        private int consumerID;
        public Form5_Consumer_Dashboard(int consumerID)
        {
            InitializeComponent();
            this.consumerID = consumerID;
        }
        //=================================================================================================================
        // All buttons UI
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


        private void buttonAppliances_MouseHover(object sender, EventArgs e)
        {
            buttonAppliances.Width = 610;
            buttonAppliances.Height = 80;
            buttonAppliances.BackColor = System.Drawing.Color.RoyalBlue;
            buttonAppliances.Font = new Font(buttonAppliances.Font.FontFamily, 28, buttonAppliances.Font.Style);
        }

        private void buttonAppliances_MouseLeave(object sender, EventArgs e)
        {
            buttonAppliances.Width = 590;
            buttonAppliances.Height = 75;
            buttonAppliances.BackColor = System.Drawing.Color.DodgerBlue;
            buttonAppliances.Font = new Font(buttonAppliances.Font.FontFamily, 26, buttonAppliances.Font.Style);
        }

        private void buttonEstimateBill_MouseHover(object sender, EventArgs e)
        {
            buttonEstimateBill.Width = 610;
            buttonEstimateBill.Height = 80;
            buttonEstimateBill.BackColor = System.Drawing.Color.RoyalBlue;
            buttonEstimateBill.Font = new Font(buttonEstimateBill.Font.FontFamily, 28, buttonEstimateBill.Font.Style);
        }

        private void buttonEstimateBill_MouseLeave(object sender, EventArgs e)
        {
            buttonEstimateBill.Width = 590;
            buttonEstimateBill.Height = 75;
            buttonEstimateBill.BackColor = System.Drawing.Color.DodgerBlue;
            buttonEstimateBill.Font = new Font(buttonEstimateBill.Font.FontFamily, 26, buttonEstimateBill.Font.Style);
        }

        private void buttonDailyPlan_MouseHover(object sender, EventArgs e)
        {
            buttonDailyPlan.Width = 610;
            buttonDailyPlan.Height = 80;
            buttonDailyPlan.BackColor = System.Drawing.Color.RoyalBlue;
            buttonDailyPlan.Font = new Font(buttonDailyPlan.Font.FontFamily, 28, buttonDailyPlan.Font.Style);
        }

        private void buttonDailyPlan_MouseLeave(object sender, EventArgs e)
        {
            buttonDailyPlan.Width = 590;
            buttonDailyPlan.Height = 75;
            buttonDailyPlan.BackColor = System.Drawing.Color.DodgerBlue;
            buttonDailyPlan.Font = new Font(buttonDailyPlan.Font.FontFamily, 26, buttonDailyPlan.Font.Style);
        }

        private void buttonWeeklyPlan_MouseHover(object sender, EventArgs e)
        {
            buttonWeeklyPlan.Width = 610;
            buttonWeeklyPlan.Height = 80;
            buttonWeeklyPlan.BackColor = System.Drawing.Color.RoyalBlue;
            buttonWeeklyPlan.Font = new Font(buttonWeeklyPlan.Font.FontFamily, 28, buttonWeeklyPlan.Font.Style);
        }

        private void buttonWeeklyPlan_MouseLeave(object sender, EventArgs e)
        {
            buttonWeeklyPlan.Width = 590;
            buttonWeeklyPlan.Height = 75;
            buttonWeeklyPlan.BackColor = System.Drawing.Color.DodgerBlue;
            buttonWeeklyPlan.Font = new Font(buttonWeeklyPlan.Font.FontFamily, 26, buttonWeeklyPlan.Font.Style);
        }

        private void buttonMonthlyPlan_MouseHover(object sender, EventArgs e)
        {
            buttonMonthlyPlan.Width = 610;
            buttonMonthlyPlan.Height = 80;
            buttonMonthlyPlan.BackColor = System.Drawing.Color.RoyalBlue;
            buttonMonthlyPlan.Font = new Font(buttonMonthlyPlan.Font.FontFamily, 28, buttonMonthlyPlan.Font.Style);
        }

        private void buttonMonthlyPlan_MouseLeave(object sender, EventArgs e)
        {
            buttonMonthlyPlan.Width = 590;
            buttonMonthlyPlan.Height = 75;
            buttonMonthlyPlan.BackColor = System.Drawing.Color.DodgerBlue;
            buttonMonthlyPlan.Font = new Font(buttonMonthlyPlan.Font.FontFamily, 26, buttonMonthlyPlan.Font.Style);

        }

        //=================================================================================================================
        // All buttons where Functionality == Routing
        //==================================================================================================================
        private void buttonBack_Click_1(object sender, EventArgs e)
        {
            this.Hide(); // Hide Form5_Consumer_Dashboard

            using (Form3_Consumer_Login form3 = new Form3_Consumer_Login())
            {
                form3.ShowDialog(); // Show Consumer Login Form as a modal dialog
            }

            this.Close(); // Close Form5_Consumer_Dashboard after returning
        }

        private void buttonAppliances_Click(object sender, EventArgs e)
        {
            this.Hide(); // Hide Form5_Consumer_Dashboard

            using (Form9_AddAppliances form9 = new Form9_AddAppliances(consumerID))
            {
                form9.ShowDialog(); // Show Consumer Login Form as a modal dialog
            }

            this.Close(); // Close Form5_Consumer_Dashboard after returning
        }

        private void buttonDailyPlan_Click(object sender, EventArgs e)
        {
            this.Hide(); // Hide Form5_Consumer_Dashboard

            using (Form10_DailySchedule form10 = new Form10_DailySchedule(consumerID))
            {
                form10.ShowDialog(); // Show Consumer Login Form as a modal dialog
            }

            this.Close(); // Close Form5_Consumer_Dashboard after returning
        }

        private void buttonWeeklyPlan_Click(object sender, EventArgs e)
        {
            this.Hide(); // Hide Form5_Consumer_Dashboard

            using (Form11_WeeklySchedule form11 = new Form11_WeeklySchedule(consumerID))
            {
                form11.ShowDialog(); // Show Consumer Login Form as a modal dialog
            }

            this.Close(); // Close Form5_Consumer_Dashboard after returning
        }

        private void buttonMonthlyPlan_Click(object sender, EventArgs e)
        {
            this.Hide(); // Hide Form5_Consumer_Dashboard

            using (Form12_MonthlySchedule form12 = new Form12_MonthlySchedule(consumerID))
            {
                form12.ShowDialog(); // Show Consumer Login Form as a modal dialog
            }

            this.Close(); // Close Form5_Consumer_Dashboard after returning
        }
    }
}
