using System.Numerics;

namespace ConsumptionPlannerV1._0
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonAdmin_MouseHover(object sender, EventArgs e)
        {
            buttonAdmin.Width = 595;
            buttonAdmin.Height = 120;
            buttonAdmin.BackColor = System.Drawing.Color.RoyalBlue;
            buttonAdmin.Font = new Font(buttonAdmin.Font.FontFamily, 28, buttonAdmin.Font.Style);
        }

        private void buttonAdmin_MouseLeave(object sender, EventArgs e)
        {
            buttonAdmin.Width = 550;
            buttonAdmin.Height = 112;
            buttonAdmin.BackColor = System.Drawing.Color.DodgerBlue;
            buttonAdmin.Font = new Font(buttonAdmin.Font.FontFamily, 26, buttonAdmin.Font.Style);
        }

        private void buttonConsumer_MouseHover(object sender, EventArgs e)
        {
            buttonConsumer.Width = 595;
            buttonConsumer.Height = 120;
            buttonConsumer.BackColor = System.Drawing.Color.RoyalBlue;
            buttonConsumer.Font = new Font(buttonConsumer.Font.FontFamily, 28, buttonConsumer.Font.Style);
        }

        private void buttonConsumer_MouseLeave(object sender, EventArgs e)
        {
            buttonConsumer.Width = 550;
            buttonConsumer.Height = 112;
            buttonConsumer.BackColor = System.Drawing.Color.DodgerBlue;
            buttonConsumer.Font = new Font(buttonConsumer.Font.FontFamily, 26, buttonConsumer.Font.Style);
        }

        private void buttonAdmin_Click(object sender, EventArgs e)
        {
           
            this.Hide(); // Hide Form1

            using (Form2_Admin_Login form2 = new Form2_Admin_Login())
            {
                form2.ShowDialog(); // Show Form2_Admin_Login as a modal dialog
            }

            this.Close(); // Close Form1 after Form2_Admin_Login closes
        }

        private void buttonConsumer_Click(object sender, EventArgs e)
        {

            this.Hide(); // Hide Form1

            using (Form3_Consumer_Login form3 = new Form3_Consumer_Login())
            {
                form3.ShowDialog(); // Show Form3_Consumer_Login as a modal dialog
            }

            this.Close(); // Close Form1 after Form3_Consumer_Login closes
        }
    }
}
