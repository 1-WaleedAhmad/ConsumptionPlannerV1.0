using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.DataFormats;
using Microsoft.Data.SqlClient;
using System.Xml;

namespace ConsumptionPlannerV1._0
{
    public partial class Form2_Admin_Login : Form
    {
        private string connectionString = "Data Source=DESKTOP-8TGLPR9\\MSSQLSERVER01;Initial Catalog=CONSUMPTION_PLANNER_V1;Integrated Security=True;Encrypt=False;Trust Server Certificate=True";
        private SqlConnection con;

        public Form2_Admin_Login()
        {
            InitializeComponent();
            con = new SqlConnection(connectionString); // Initialize connection here
        }

        //=================================================================================================================
        //All Buttons Functionality + All buttons UI
        //=================================================================================================================
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

            //Checking For Empty Fields
            if (textBoxUsername.Text == "" || textBoxPassword.Text == "") {
                MessageBox.Show("PLease Enter All Fields!", "Empty Fields", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else
            {
                //Storing data from textbox into variables
                string name = textBoxUsername.Text.ToString();
                string password = textBoxPassword.Text.ToString();

                //Open Con
                con.Open();


                //Maikng Query
                string Query = "SELECT * FROM ADMIN WHERE Name = '" + name + "' AND Password = '" + password + "'";

                //Execute Query
                SqlCommand cmd = new SqlCommand(Query, con);
                SqlDataReader reader = cmd.ExecuteReader();


                if(reader.HasRows==true)
                {
                    MessageBox.Show("Login Successful!", "Successfull Authentication", MessageBoxButtons.OK, MessageBoxIcon.Information);


                    this.Hide(); // Hide Form

                    using (Form4_Admin_Dashboard form4 = new Form4_Admin_Dashboard())
                    {
                        form4.ShowDialog(); // Show Form4_Admin_Dashboard as a modal dialog
                    }

                    this.Close(); // Close Form after Form4_Admin_Dashboard closes
                }

                else
                {
                    MessageBox.Show("Login Failed!", "Authentication Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                //Close Con
                con.Close();

            }
           
          
        }
    }
}
