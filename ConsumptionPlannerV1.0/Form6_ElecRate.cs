using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;
using System.Xml;

namespace ConsumptionPlannerV1._0
{
    public partial class Form6_ElecRate : Form
    {
        private string connectionString = "Data Source=DESKTOP-8TGLPR9\\MSSQLSERVER01;Initial Catalog=CONSUMPTION_PLANNER_V1;Integrated Security=True;Encrypt=False;Trust Server Certificate=True";
        private SqlConnection con;

        public Form6_ElecRate()
        {
            InitializeComponent();
            con = new SqlConnection(connectionString); // Initialize connection here

            // Set the Dock property to make the DataGridView take the full width
            dataGridView1.Dock = DockStyle.Fill;

            // Load the electric rates when the form is initialized
            button1_Click(null, null);
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
        //Login Button Functionality
        //=================================================================================================================

        private void button1_Click(object sender, EventArgs e)
        {
            con.Open();

            // Prepare SQL query
            string Query = "SELECT * FROM ElectricRates";
            SqlCommand cmd = new SqlCommand(Query, con);

            // Execute Query
            var reader = cmd.ExecuteReader();

            // Clear previous rows
            dataGridView1.Rows.Clear();
            while (reader.Read())
            {
                dataGridView1.Rows.Add(reader["ID"], reader["RateType"], reader["RatePerUnit"], "Edit");
            }

            // Adjust column widths
            foreach (DataGridViewColumn column in dataGridView1.Columns)
            {
                column.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }

            con.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 3 && e.RowIndex > -1)
            {
                textBoxRate.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString(); // Assuming "Rate Per Unit" is in the 3rd column (index 2).
                labelType.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
                labelType.Visible = true;
                buttonUpdate.Enabled = true;
            }
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            string rate = textBoxRate.Text;
            string rateType = labelType.Text; // Get the text from the label

            string query = "UPDATE ElectricRates SET RatePerUnit = @rate WHERE RateType = @rateType";

            using (SqlCommand cmd = new SqlCommand(query, con))
            {
                cmd.Parameters.AddWithValue("@rate", rate); // Use the value from textBoxRate
                cmd.Parameters.AddWithValue("@rateType", rateType); // Use the text from labelType

                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
            }

            // Clear the inputs and disable the update button after successful update
            textBoxRate.Text = "";
            buttonUpdate.Enabled = false;
            labelType.Visible = false;

            button1_Click(null, null); // Refresh the data grid view
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
