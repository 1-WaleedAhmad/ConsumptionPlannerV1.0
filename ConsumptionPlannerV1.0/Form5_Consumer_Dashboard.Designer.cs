namespace ConsumptionPlannerV1._0
{
    partial class Form5_Consumer_Dashboard
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
            buttonAppliances = new Button();
            buttonEstimateBill = new Button();
            buttonWeeklyPlan = new Button();
            buttonDailyPlan = new Button();
            buttonBack = new Button();
            buttonMonthlyPlan = new Button();
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
            panel1.Size = new Size(1075, 82);
            panel1.TabIndex = 3;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top;
            label1.AutoSize = true;
            label1.Font = new Font("Cambria", 36F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            label1.Location = new Point(250, 9);
            label1.Name = "label1";
            label1.Size = new Size(568, 57);
            label1.TabIndex = 0;
            label1.Text = "CONSUMER DASHBOARD";
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.BackColor = Color.White;
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(buttonAppliances, 0, 0);
            tableLayoutPanel1.Controls.Add(buttonEstimateBill, 0, 1);
            tableLayoutPanel1.Controls.Add(buttonWeeklyPlan, 0, 3);
            tableLayoutPanel1.Controls.Add(buttonDailyPlan, 0, 2);
            tableLayoutPanel1.Controls.Add(buttonBack, 0, 5);
            tableLayoutPanel1.Controls.Add(buttonMonthlyPlan, 0, 4);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 82);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.Padding = new Padding(10);
            tableLayoutPanel1.RowCount = 6;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 18F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 18F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 18F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 18F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 18F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tableLayoutPanel1.Size = new Size(1075, 619);
            tableLayoutPanel1.TabIndex = 4;
            // 
            // buttonAppliances
            // 
            buttonAppliances.Anchor = AnchorStyles.None;
            buttonAppliances.BackColor = Color.DodgerBlue;
            buttonAppliances.FlatStyle = FlatStyle.Popup;
            buttonAppliances.Font = new Font("Cambria", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonAppliances.ForeColor = SystemColors.ButtonHighlight;
            buttonAppliances.Location = new Point(242, 26);
            buttonAppliances.Name = "buttonAppliances";
            buttonAppliances.Size = new Size(590, 75);
            buttonAppliances.TabIndex = 0;
            buttonAppliances.Text = "Appliances";
            buttonAppliances.UseVisualStyleBackColor = false;
            buttonAppliances.Click += buttonAppliances_Click;
            buttonAppliances.MouseLeave += buttonAppliances_MouseLeave;
            buttonAppliances.MouseHover += buttonAppliances_MouseHover;
            // 
            // buttonEstimateBill
            // 
            buttonEstimateBill.Anchor = AnchorStyles.None;
            buttonEstimateBill.BackColor = Color.DodgerBlue;
            buttonEstimateBill.FlatStyle = FlatStyle.Popup;
            buttonEstimateBill.Font = new Font("Cambria", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonEstimateBill.ForeColor = SystemColors.ButtonHighlight;
            buttonEstimateBill.Location = new Point(242, 133);
            buttonEstimateBill.Name = "buttonEstimateBill";
            buttonEstimateBill.Size = new Size(590, 74);
            buttonEstimateBill.TabIndex = 0;
            buttonEstimateBill.Text = "Estimate Bill";
            buttonEstimateBill.UseVisualStyleBackColor = false;
            buttonEstimateBill.MouseLeave += buttonEstimateBill_MouseLeave;
            buttonEstimateBill.MouseHover += buttonEstimateBill_MouseHover;
            // 
            // buttonWeeklyPlan
            // 
            buttonWeeklyPlan.Anchor = AnchorStyles.None;
            buttonWeeklyPlan.BackColor = Color.DodgerBlue;
            buttonWeeklyPlan.FlatStyle = FlatStyle.Popup;
            buttonWeeklyPlan.Font = new Font("Cambria", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonWeeklyPlan.ForeColor = SystemColors.ButtonHighlight;
            buttonWeeklyPlan.Location = new Point(242, 347);
            buttonWeeklyPlan.Name = "buttonWeeklyPlan";
            buttonWeeklyPlan.Size = new Size(590, 74);
            buttonWeeklyPlan.TabIndex = 0;
            buttonWeeklyPlan.Text = "Weekly Plan";
            buttonWeeklyPlan.UseVisualStyleBackColor = false;
            buttonWeeklyPlan.Click += buttonWeeklyPlan_Click;
            buttonWeeklyPlan.MouseLeave += buttonWeeklyPlan_MouseLeave;
            buttonWeeklyPlan.MouseHover += buttonWeeklyPlan_MouseHover;
            // 
            // buttonDailyPlan
            // 
            buttonDailyPlan.Anchor = AnchorStyles.None;
            buttonDailyPlan.BackColor = Color.DodgerBlue;
            buttonDailyPlan.FlatStyle = FlatStyle.Popup;
            buttonDailyPlan.Font = new Font("Cambria", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonDailyPlan.ForeColor = SystemColors.ButtonHighlight;
            buttonDailyPlan.Location = new Point(242, 240);
            buttonDailyPlan.Name = "buttonDailyPlan";
            buttonDailyPlan.Size = new Size(590, 74);
            buttonDailyPlan.TabIndex = 0;
            buttonDailyPlan.Text = "Daily Plan";
            buttonDailyPlan.UseVisualStyleBackColor = false;
            buttonDailyPlan.Click += buttonDailyPlan_Click;
            buttonDailyPlan.MouseLeave += buttonDailyPlan_MouseLeave;
            buttonDailyPlan.MouseHover += buttonDailyPlan_MouseHover;
            // 
            // buttonBack
            // 
            buttonBack.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            buttonBack.BackColor = Color.DodgerBlue;
            buttonBack.FlatStyle = FlatStyle.Popup;
            buttonBack.Font = new Font("Cambria", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonBack.ForeColor = SystemColors.ButtonHighlight;
            buttonBack.Location = new Point(25, 558);
            buttonBack.Margin = new Padding(15, 13, 13, 13);
            buttonBack.Name = "buttonBack";
            buttonBack.Size = new Size(123, 38);
            buttonBack.TabIndex = 5;
            buttonBack.Text = "Back";
            buttonBack.UseVisualStyleBackColor = false;
            buttonBack.Click += buttonBack_Click_1;
            buttonBack.MouseLeave += buttonBack_MouseLeave;
            buttonBack.MouseHover += buttonBack_MouseHover;
            // 
            // buttonMonthlyPlan
            // 
            buttonMonthlyPlan.Anchor = AnchorStyles.None;
            buttonMonthlyPlan.BackColor = Color.DodgerBlue;
            buttonMonthlyPlan.FlatStyle = FlatStyle.Popup;
            buttonMonthlyPlan.Font = new Font("Cambria", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonMonthlyPlan.ForeColor = SystemColors.ButtonHighlight;
            buttonMonthlyPlan.Location = new Point(242, 454);
            buttonMonthlyPlan.Name = "buttonMonthlyPlan";
            buttonMonthlyPlan.Size = new Size(590, 74);
            buttonMonthlyPlan.TabIndex = 0;
            buttonMonthlyPlan.Text = "Monthly Plan";
            buttonMonthlyPlan.UseVisualStyleBackColor = false;
            buttonMonthlyPlan.Click += buttonMonthlyPlan_Click;
            buttonMonthlyPlan.MouseLeave += buttonMonthlyPlan_MouseLeave;
            buttonMonthlyPlan.MouseHover += buttonMonthlyPlan_MouseHover;
            // 
            // Form5_Consumer_Dashboard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1075, 701);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(panel1);
            Name = "Form5_Consumer_Dashboard";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form5_Consumer_Dashboard";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            tableLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private TableLayoutPanel tableLayoutPanel1;
        private Button buttonAppliances;
        private Button buttonBack;
        private Button buttonEstimateBill;
        private Button buttonWeeklyPlan;
        private Button buttonDailyPlan;
        private Button buttonMonthlyPlan;
    }
}