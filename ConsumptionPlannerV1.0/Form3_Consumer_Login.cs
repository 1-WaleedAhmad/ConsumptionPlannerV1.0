using Microsoft.Data.SqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace ConsumptionPlannerV1._0
{
    public partial class Form3_Consumer_Login : Form
    {
        private string connectionString = "Data Source=DESKTOP-8TGLPR9\\MSSQLSERVER01;Initial Catalog=CONSUMPTION_PLANNER_V1;Integrated Security=True;Encrypt=False;Trust Server Certificate=True";
        private SqlConnection con;

        public Form3_Consumer_Login()
        {
            InitializeComponent();
            con = new SqlConnection(connectionString);
        }

        //=================================================================================================================
        //All Buttons Functionality + All buttons UI
        //==================================================================================================================

        private void buttonLogin_MouseHover(object sender, EventArgs e)
        {
            buttonLogin.Width = 150;
            buttonLogin.Height = 50;
            buttonLogin.BackColor = System.Drawing.Color.RoyalBlue;
            buttonLogin.Font = new Font(buttonLogin.Font.FontFamily, 22, buttonLogin.Font.Style);
        }

        private void buttonLogin_MouseLeave(object sender, EventArgs e)
        {
            buttonLogin.Width = 140;
            buttonLogin.Height = 46;
            buttonLogin.BackColor = System.Drawing.Color.DodgerBlue;
            buttonLogin.Font = new Font(buttonLogin.Font.FontFamily, 20, buttonLogin.Font.Style);
        }

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
            this.Hide(); // Hide Form2_Admin_Login

            using (Form1 form1 = new Form1())
            {
                form1.ShowDialog(); // Show Form1 as a modal dialog
            }

            this.Close(); // Close Form2_Admin_Login after returning to Form1
        }


        //=================================================================================================================
        //Login Button Functionality
        //=================================================================================================================

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            int consumerID;

            if (int.TryParse(textBoxConsumerID.Text, out consumerID))
            {
                if (con.State == ConnectionState.Closed)
                    con.Open();

                // Check if ConsumerID exists
                string queryCheck = "SELECT COUNT(*) FROM Consumers WHERE ConsumerID = @ConsumerID";
                using (SqlCommand cmdCheck = new SqlCommand(queryCheck, con))
                {
                    cmdCheck.Parameters.AddWithValue("@ConsumerID", consumerID);
                    int count = (int)cmdCheck.ExecuteScalar();

                    if (count == 0)
                    {
                        // ConsumerID does not exist, add new consumer
                        string queryInsert = "INSERT INTO Consumers (ConsumerID) VALUES (@ConsumerID)";
                        using (SqlCommand cmdInsert = new SqlCommand(queryInsert, con))
                        {
                            cmdInsert.Parameters.AddWithValue("@ConsumerID", consumerID);
                            cmdInsert.ExecuteNonQuery();
                            MessageBox.Show("New consumer added.");

                            //=====================Showing Consumer DashBoard=================================
                            this.Hide(); // Hide Form4

                            using (Form5_Consumer_Dashboard form5 = new Form5_Consumer_Dashboard(consumerID))
                            {
                                form5.ShowDialog(); // Show form7 as a modal dialog
                            }

                            this.Close(); // Close Form4
                            //===================================================================================

                        }
                    }
                    else
                    {
                        MessageBox.Show("Consumer exists, logged in successfully.");
                        //=====================Showing Consumer DashBoard=================================
                        this.Hide(); // Hide Form4

                        using (Form5_Consumer_Dashboard form5 = new Form5_Consumer_Dashboard(consumerID))
                        {
                            form5.ShowDialog(); // Show form7 as a modal dialog
                        }

                        this.Close(); // Close 
                        //===================================================================================
                    }
                }

                con.Close();
            }
            else
            {
                MessageBox.Show("Please enter a valid Consumer ID.");
            }
        }
    }
}
