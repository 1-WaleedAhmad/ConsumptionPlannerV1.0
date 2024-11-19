using Microsoft.Data.SqlClient;
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
    public partial class Form9_AddAppliances : Form
    {
        private string connectionString = "Data Source=DESKTOP-8TGLPR9\\MSSQLSERVER01;Initial Catalog=CONSUMPTION_PLANNER_V1;Integrated Security=True;Encrypt=False;Trust Server Certificate=True";
        private SqlConnection con;
        private int consumerID;
        public Form9_AddAppliances(int consumerID)
        {
            InitializeComponent();
            this.consumerID = consumerID;
            con = new SqlConnection(connectionString);
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            try
            {
                string name = textBoxName.Text;
                int watts = int.Parse(textBoxWatts.Text);
                string category = comboBoxCategory.SelectedItem.ToString();
                TimeSpan preferredTime = dateTimePickerPreferredTime.Value.TimeOfDay;
                bool flexibility = radioButtonYes.Checked; // If Yes is selected, flexibility is true
                TimeSpan avgTime = dateTimePickerAvgTime.Value.TimeOfDay;

                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    string query = "INSERT INTO Appliances (Name, Watts, Category, PreferredTime, Flexibility, AverageTimeUsed, ConsumerID) VALUES (@Name, @Watts, @Category, @PreferredTime, @Flexibility, @AverageTimeUsed, @ConsumerID)";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@Name", name);
                        cmd.Parameters.AddWithValue("@Watts", watts);
                        cmd.Parameters.AddWithValue("@Category", category);
                        cmd.Parameters.AddWithValue("@PreferredTime", preferredTime);
                        cmd.Parameters.AddWithValue("@Flexibility", flexibility);
                        cmd.Parameters.AddWithValue("@AverageTimeUsed", avgTime.TotalMinutes); // Store Avg Time in minutes
                        cmd.Parameters.AddWithValue("@ConsumerID", consumerID);

                        conn.Open();
                        cmd.ExecuteNonQuery();

                    }
                }

                MessageBox.Show("Appliance added successfully.");
                textBoxName.Text = "";
                textBoxWatts.Text = "";
                dateTimePickerAvgTime = null;

            }
            catch (Exception ex)
            {
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


        private void buttonSave_MouseHover(object sender, EventArgs e)
        {
            buttonSave.Width = 150;
            buttonSave.Height = 50;
            buttonSave.BackColor = System.Drawing.Color.RoyalBlue;
            buttonSave.Font = new Font(buttonBack.Font.FontFamily, 22, buttonBack.Font.Style);
        }

        private void buttonSave_MouseLeave(object sender, EventArgs e)
        {
            buttonSave.Width = 140;
            buttonSave.Height = 46;
            buttonSave.BackColor = System.Drawing.Color.DodgerBlue;
            buttonSave.Font = new Font(buttonBack.Font.FontFamily, 20, buttonBack.Font.Style);
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
