namespace ConsumptionPlannerV1._0
{
    partial class Form12_MonthlySchedule
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
            dataGridViewMonthlySchedule = new DataGridView();
            panel1.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewMonthlySchedule).BeginInit();
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
            panel1.Size = new Size(1145, 82);
            panel1.TabIndex = 5;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Cambria", 36F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            label1.Location = new Point(323, 20);
            label1.Name = "label1";
            label1.Size = new Size(495, 57);
            label1.TabIndex = 0;
            label1.Text = "MONTHLY SCHEDULE";
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(buttonBack, 0, 1);
            tableLayoutPanel1.Controls.Add(dataGridViewMonthlySchedule, 0, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 82);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 77.0197449F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 22.9802513F));
            tableLayoutPanel1.Size = new Size(1145, 556);
            tableLayoutPanel1.TabIndex = 6;
            // 
            // buttonBack
            // 
            buttonBack.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            buttonBack.BackColor = Color.DodgerBlue;
            buttonBack.FlatStyle = FlatStyle.Popup;
            buttonBack.Font = new Font("Cambria", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonBack.ForeColor = SystemColors.ButtonHighlight;
            buttonBack.Location = new Point(15, 497);
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
            // dataGridViewMonthlySchedule
            // 
            dataGridViewMonthlySchedule.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewMonthlySchedule.Dock = DockStyle.Fill;
            dataGridViewMonthlySchedule.Location = new Point(3, 3);
            dataGridViewMonthlySchedule.Name = "dataGridViewMonthlySchedule";
            dataGridViewMonthlySchedule.Size = new Size(1139, 422);
            dataGridViewMonthlySchedule.TabIndex = 0;
            // 
            // Form12_MonthlySchedule
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1145, 638);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(panel1);
            Name = "Form12_MonthlySchedule";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form12_MonthlySchedule";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewMonthlySchedule).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private TableLayoutPanel tableLayoutPanel1;
        private Button buttonBack;
        private DataGridView dataGridViewMonthlySchedule;
    }
}