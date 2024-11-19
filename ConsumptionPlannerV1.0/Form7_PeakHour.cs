using Microsoft.Data.SqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace ConsumptionPlannerV1._0
{
    public partial class Form7_PeakHour : Form
    {
        private string connectionString = "Data Source=DESKTOP-8TGLPR9\\MSSQLSERVER01;Initial Catalog=CONSUMPTION_PLANNER_V1;Integrated Security=True;Encrypt=False;Trust Server Certificate=True";
        private SqlConnection con;

        public Form7_PeakHour()
        {
            InitializeComponent();
            con = new SqlConnection(connectionString);
            LoadPeakHoursData();
        }

        private void Form7_PeakHour_Load(object sender, EventArgs e)
        {
            LoadPeakHoursData();
        }

        private void LoadPeakHoursData()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    string query = "SELECT * FROM PeakHours";
                    SqlDataAdapter da = new SqlDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    dataGridViewPeakHours.DataSource = dt;
                    dataGridViewPeakHours.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill; // Make columns take full width
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                // Check if the start and end times are the same
                if (dateTimePickerStart.Value.TimeOfDay == dateTimePickerEnd.Value.TimeOfDay)
                {
                    MessageBox.Show("Start time and end time cannot be the same.");
                    return;
                }

                // Open the database connection
                if (con.State == ConnectionState.Closed)
                    con.Open();

                // SQL query to update the peak hours
                string query = @"
                    IF EXISTS (SELECT 1 FROM PeakHours WHERE Id = 1)
                    BEGIN
                        UPDATE PeakHours 
                        SET StartHour = @StartHour, EndHour = @EndHour 
                        WHERE Id = 1
                    END
                    ELSE
                    BEGIN
                        INSERT INTO PeakHours (Id, StartHour, EndHour) 
                        VALUES (1, @StartHour, @EndHour)
                    END";

                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    // Add parameters with values from the DateTimePicker controls
                    cmd.Parameters.AddWithValue("@StartHour", dateTimePickerStart.Value.TimeOfDay);
                    cmd.Parameters.AddWithValue("@EndHour", dateTimePickerEnd.Value.TimeOfDay);

                    // Execute the query
                    cmd.ExecuteNonQuery();
                }

                // Confirm the save operation
                MessageBox.Show("Peak hours saved successfully.");

                // Reload the data into DataGridView
                LoadPeakHoursData();

                // Close the database connection
                con.Close();
            }
            catch (Exception ex)
            {
                // Handle any errors that might occur
                MessageBox.Show("An error occurred: " + ex.Message);
            }
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

        private void buttonUpdate_MouseHover(object sender, EventArgs e)
        {
            buttonUpdate.Width = 150;
            buttonUpdate.Height = 50;
            buttonUpdate.BackColor = System.Drawing.Color.RoyalBlue;
            buttonUpdate.Font = new Font(buttonUpdate.Font.FontFamily, 22, buttonUpdate.Font.Style);
        }

        private void buttonUpdate_MouseLeave(object sender, EventArgs e)
        {
            buttonUpdate.Width = 140;
            buttonUpdate.Height = 46;
            buttonUpdate.BackColor = System.Drawing.Color.DodgerBlue;
            buttonUpdate.Font = new Font(buttonUpdate.Font.FontFamily, 20, buttonUpdate.Font.Style);
        }


        //=================================================================================================================
        // All buttons where Functionality == Routing
        //==================================================================================================================
        private void buttonBack_Click(object sender, EventArgs e)
        {
            this.Hide(); // Hide this Form

            using (Form4_Admin_Dashboard form4 = new Form4_Admin_Dashboard())
            {
                form4.ShowDialog(); // Show Admin Dashboard
            }

            this.Close(); // Close Form
        }


    }
}
