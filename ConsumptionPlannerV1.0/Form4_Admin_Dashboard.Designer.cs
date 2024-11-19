namespace ConsumptionPlannerV1._0
{
    partial class Form4_Admin_Dashboard
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            label1 = new Label();
            tableLayoutPanel1 = new TableLayoutPanel();
            buttonBack = new Button();
            buttonSetPeakHours = new Button();
            buttonSetRate = new Button();
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
            panel1.Size = new Size(1022, 82);
            panel1.TabIndex = 2;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top;
            label1.AutoSize = true;
            label1.Font = new Font("Cambria", 36F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            label1.Location = new Point(271, 20);
            label1.Name = "label1";
            label1.Size = new Size(473, 57);
            label1.TabIndex = 0;
            label1.Text = "ADMIN DASHBOARD";
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.BackColor = Color.White;
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(buttonBack, 0, 2);
            tableLayoutPanel1.Controls.Add(buttonSetPeakHours, 0, 0);
            tableLayoutPanel1.Controls.Add(buttonSetRate, 0, 1);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 82);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.Padding = new Padding(10);
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 40F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 40F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.Size = new Size(1022, 564);
            tableLayoutPanel1.TabIndex = 3;
            // 
            // buttonBack
            // 
            buttonBack.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            buttonBack.BackColor = Color.DodgerBlue;
            buttonBack.FlatStyle = FlatStyle.Popup;
            buttonBack.Font = new Font("Cambria", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonBack.ForeColor = SystemColors.ButtonHighlight;
            buttonBack.Location = new Point(25, 495);
            buttonBack.Margin = new Padding(15, 13, 13, 13);
            buttonBack.Name = "buttonBack";
            buttonBack.Size = new Size(140, 46);
            buttonBack.TabIndex = 3;
            buttonBack.Text = "Back";
            buttonBack.UseVisualStyleBackColor = false;
            buttonBack.Click += buttonBack_Click;
            buttonBack.MouseLeave += buttonBack_MouseLeave;
            buttonBack.MouseHover += buttonBack_MouseHover;
            // 
            // buttonSetPeakHours
            // 
            buttonSetPeakHours.Anchor = AnchorStyles.None;
            buttonSetPeakHours.BackColor = Color.DodgerBlue;
            buttonSetPeakHours.FlatStyle = FlatStyle.Popup;
            buttonSetPeakHours.Font = new Font("Cambria", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonSetPeakHours.ForeColor = SystemColors.ButtonHighlight;
            buttonSetPeakHours.Location = new Point(236, 62);
            buttonSetPeakHours.Name = "buttonSetPeakHours";
            buttonSetPeakHours.Size = new Size(550, 112);
            buttonSetPeakHours.TabIndex = 0;
            buttonSetPeakHours.Text = "Set Peak Hours";
            buttonSetPeakHours.UseVisualStyleBackColor = false;
            buttonSetPeakHours.Click += buttonSetPeakHours_Click;
            buttonSetPeakHours.MouseLeave += buttonSetPeakHours_MouseLeave;
            buttonSetPeakHours.MouseHover += buttonSetPeakHours_MouseHover;
            // 
            // buttonSetRate
            // 
            buttonSetRate.Anchor = AnchorStyles.None;
            buttonSetRate.BackColor = Color.DodgerBlue;
            buttonSetRate.FlatStyle = FlatStyle.Popup;
            buttonSetRate.Font = new Font("Cambria", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonSetRate.ForeColor = SystemColors.ButtonHighlight;
            buttonSetRate.Location = new Point(236, 279);
            buttonSetRate.Name = "buttonSetRate";
            buttonSetRate.Size = new Size(550, 112);
            buttonSetRate.TabIndex = 0;
            buttonSetRate.Text = "Set Electricity Rate";
            buttonSetRate.UseVisualStyleBackColor = false;
            buttonSetRate.Click += buttonSetRate_Click;
            buttonSetRate.MouseLeave += buttonSetRate_MouseLeave;
            buttonSetRate.MouseHover += buttonSetRate_MouseHover;
            // 
            // Form4_Admin_Dashboard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1022, 646);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(panel1);
            Name = "Form4_Admin_Dashboard";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form4_Admin_Dashboard";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            tableLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private TableLayoutPanel tableLayoutPanel1;
        private Button buttonSetPeakHours;
        private Button buttonSetRate;
        private Button buttonBack;
    }
}