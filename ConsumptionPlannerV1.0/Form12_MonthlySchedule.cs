using Microsoft.Data.SqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace ConsumptionPlannerV1._0
{
    public partial class Form12_MonthlySchedule : Form
    {
        private string connectionString = "Data Source=DESKTOP-8TGLPR9\\MSSQLSERVER01;Initial Catalog=CONSUMPTION_PLANNER_V1;Integrated Security=True;Encrypt=False;Trust Server Certificate=True";
        private int consumerID;

        public Form12_MonthlySchedule(int consumerID)
        {
            InitializeComponent();
            this.consumerID = consumerID;

            // Set the Dock property to make the DataGridView take the full width
            dataGridViewMonthlySchedule.Dock = DockStyle.Fill;

            // Load the monthly schedule when the form is loaded
            this.Load += new System.EventHandler(this.Form12_MonthlySchedule_Load);
        }

        private void Form12_MonthlySchedule_Load(object sender, EventArgs e)
        {
            LoadMonthlySchedule();

            // Adjust column widths after loading the data
            foreach (DataGridViewColumn column in dataGridViewMonthlySchedule.Columns)
            {
                column.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }
        }

        private void LoadMonthlySchedule()
        {
            TimeSpan peakStart = TimeSpan.Zero;
            TimeSpan peakEnd = TimeSpan.Zero;

            // Fetch Peak Hours
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string queryPeakHours = "SELECT StartHour, EndHour FROM PeakHours WHERE Id = 1";
                using (SqlCommand cmd = new SqlCommand(queryPeakHours, conn))
                {
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            peakStart = (TimeSpan)reader["StartHour"];
                            peakEnd = (TimeSpan)reader["EndHour"];
                        }
                    }
                }

                // Fetch Appliances (Daily, Weekly, and Monthly)
                string queryAppliances = "SELECT * FROM Appliances WHERE ConsumerID = @ConsumerID AND Category IN ('Daily', 'Weekly', 'Monthly')";
                using (SqlCommand cmd = new SqlCommand(queryAppliances, conn))
                {
                    cmd.Parameters.AddWithValue("@ConsumerID", consumerID);
                    using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                    {
                        DataTable appliancesTable = new DataTable();
                        adapter.Fill(appliancesTable);

                        // Create Schedule Table
                        DataTable scheduleTable = new DataTable();
                        scheduleTable.Columns.Add("Appliance Name");
                        scheduleTable.Columns.Add("Frequency");
                        scheduleTable.Columns.Add("Start Time");
                        scheduleTable.Columns.Add("End Time");

                        foreach (DataRow appliance in appliancesTable.Rows)
                        {
                            string applianceName = appliance["Name"].ToString();
                            string frequency = appliance["Category"].ToString();
                            TimeSpan preferredTime = (TimeSpan)appliance["PreferredTime"];
                            bool isFlexible = (bool)appliance["Flexibility"];
                            int averageTimeUsed = (int)appliance["AverageTimeUsed"];

                            TimeSpan startTime;
                            if (isFlexible)
                            {
                                // Schedule in non-peak hours
                                startTime = GetClosestNonPeakHour(preferredTime, peakStart, peakEnd);
                            }
                            else
                            {
                                // Schedule in preferred time
                                startTime = preferredTime;
                            }

                            TimeSpan endTime = startTime.Add(TimeSpan.FromMinutes(averageTimeUsed));
                            scheduleTable.Rows.Add(applianceName, frequency, startTime.ToString(@"hh\:mm"), endTime.ToString(@"hh\:mm"));
                        }

                        dataGridViewMonthlySchedule.DataSource = scheduleTable;
                    }
                }
            }
        }

        private TimeSpan GetClosestNonPeakHour(TimeSpan preferredTime, TimeSpan peakStart, TimeSpan peakEnd)
        {
            // Logic to find closest non-peak hour time
            if (preferredTime < peakStart || preferredTime > peakEnd)
                return preferredTime;

            TimeSpan beforePeak = peakStart - TimeSpan.FromMinutes(1);
            TimeSpan afterPeak = peakEnd + TimeSpan.FromMinutes(1);

            return (preferredTime - beforePeak) < (afterPeak - preferredTime) ? beforePeak : afterPeak;
        }



        //=================================================================================================================
        //All Buttons UI
        //=================================================================================================================

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






        //=================================================================================================================
        // All buttons where Functionality == Routing
        //==================================================================================================================
        private void buttonBack_Click(object sender, EventArgs e)
        {
            this.Hide(); // Hide this Form

            using (Form5_Consumer_Dashboard form5 = new Form5_Consumer_Dashboard(consumerID))
            {
                form5.ShowDialog(); // Show Admin Dashboard
            }

            this.Close(); // Close Form
        }
    }
}
