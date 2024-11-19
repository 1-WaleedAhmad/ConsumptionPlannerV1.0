namespace ConsumptionPlannerV1._0
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            label1 = new Label();
            tableLayoutPanel1 = new TableLayoutPanel();
            buttonAdmin = new Button();
            buttonConsumer = new Button();
            panel1.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Padding = new Padding(5);
            panel1.Size = new Size(1180, 82);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Cambria", 36F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            label1.Location = new Point(206, 20);
            label1.Name = "label1";
            label1.Size = new Size(745, 57);
            label1.TabIndex = 0;
            label1.Text = "Electricity Consumption Planner";
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.BackColor = Color.White;
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(buttonAdmin, 0, 0);
            tableLayoutPanel1.Controls.Add(buttonConsumer, 0, 1);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 82);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.Padding = new Padding(10);
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 40F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 40F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.Size = new Size(1180, 547);
            tableLayoutPanel1.TabIndex = 1;
            // 
            // buttonAdmin
            // 
            buttonAdmin.Anchor = AnchorStyles.None;
            buttonAdmin.BackColor = Color.DodgerBlue;
            buttonAdmin.FlatStyle = FlatStyle.Popup;
            buttonAdmin.Font = new Font("Cambria", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonAdmin.ForeColor = SystemColors.ButtonHighlight;
            buttonAdmin.Location = new Point(315, 59);
            buttonAdmin.Name = "buttonAdmin";
            buttonAdmin.Size = new Size(550, 112);
            buttonAdmin.TabIndex = 0;
            buttonAdmin.Text = "Admin";
            buttonAdmin.UseVisualStyleBackColor = false;
            buttonAdmin.Click += buttonAdmin_Click;
            buttonAdmin.MouseLeave += buttonAdmin_MouseLeave;
            buttonAdmin.MouseHover += buttonAdmin_MouseHover;
            // 
            // buttonConsumer
            // 
            buttonConsumer.Anchor = AnchorStyles.None;
            buttonConsumer.BackColor = Color.DodgerBlue;
            buttonConsumer.FlatStyle = FlatStyle.Popup;
            buttonConsumer.Font = new Font("Cambria", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonConsumer.ForeColor = SystemColors.ButtonHighlight;
            buttonConsumer.Location = new Point(315, 269);
            buttonConsumer.Name = "buttonConsumer";
            buttonConsumer.Size = new Size(550, 112);
            buttonConsumer.TabIndex = 0;
            buttonConsumer.Text = "Consumer";
            buttonConsumer.UseVisualStyleBackColor = false;
            buttonConsumer.Click += buttonConsumer_Click;
            buttonConsumer.MouseLeave += buttonConsumer_MouseLeave;
            buttonConsumer.MouseHover += buttonConsumer_MouseHover;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LavenderBlush;
            ClientSize = new Size(1180, 629);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(panel1);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            tableLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private TableLayoutPanel tableLayoutPanel1;
        private Label label1;
        private Button buttonAdmin;
        private Button buttonConsumer;
    }
}
