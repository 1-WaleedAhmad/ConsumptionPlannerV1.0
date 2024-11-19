namespace ConsumptionPlannerV1._0
{
    partial class Form7_PeakHour
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
            dateTimePickerStart = new DateTimePicker();
            tableLayoutPanel1 = new TableLayoutPanel();
            labelStartTime = new Label();
            labelEndTime = new Label();
            dateTimePickerEnd = new DateTimePicker();
            buttonUpdate = new Button();
            buttonBack = new Button();
            dataGridViewPeakHours = new DataGridView();
            panel1.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewPeakHours).BeginInit();
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
            panel1.Size = new Size(954, 82);
            panel1.TabIndex = 4;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top;
            label1.AutoSize = true;
            label1.Font = new Font("Cambria", 36F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            label1.Location = new Point(335, 9);
            label1.Name = "label1";
            label1.Size = new Size(314, 57);
            label1.TabIndex = 0;
            label1.Text = "PEAK HOURS";
            // 
            // dateTimePickerStart
            // 
            dateTimePickerStart.Anchor = AnchorStyles.Left;
            dateTimePickerStart.CalendarFont = new Font("Cambria", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dateTimePickerStart.CustomFormat = "hh:mm";
            dateTimePickerStart.Font = new Font("Cambria", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dateTimePickerStart.Format = DateTimePickerFormat.Custom;
            dateTimePickerStart.Location = new Point(404, 112);
            dateTimePickerStart.Name = "dateTimePickerStart";
            dateTimePickerStart.ShowUpDown = true;
            dateTimePickerStart.Size = new Size(153, 36);
            dateTimePickerStart.TabIndex = 5;
            dateTimePickerStart.Value = new DateTime(2024, 11, 19, 5, 0, 0, 0);
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 42.0335426F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 57.9664574F));
            tableLayoutPanel1.Controls.Add(dateTimePickerStart, 1, 1);
            tableLayoutPanel1.Controls.Add(labelStartTime, 0, 1);
            tableLayoutPanel1.Controls.Add(labelEndTime, 0, 2);
            tableLayoutPanel1.Controls.Add(dateTimePickerEnd, 1, 2);
            tableLayoutPanel1.Controls.Add(buttonUpdate, 1, 3);
            tableLayoutPanel1.Controls.Add(buttonBack, 0, 4);
            tableLayoutPanel1.Controls.Add(dataGridViewPeakHours, 0, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 82);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 5;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 15F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 24F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 23F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 23F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 15F));
            tableLayoutPanel1.Size = new Size(954, 485);
            tableLayoutPanel1.TabIndex = 5;
            // 
            // labelStartTime
            // 
            labelStartTime.Anchor = AnchorStyles.None;
            labelStartTime.AutoSize = true;
            labelStartTime.Font = new Font("Cambria", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelStartTime.Location = new Point(127, 114);
            labelStartTime.Name = "labelStartTime";
            labelStartTime.Size = new Size(147, 32);
            labelStartTime.TabIndex = 7;
            labelStartTime.Text = "Start Time :";
            // 
            // labelEndTime
            // 
            labelEndTime.Anchor = AnchorStyles.None;
            labelEndTime.AutoSize = true;
            labelEndTime.Font = new Font("Cambria", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelEndTime.Location = new Point(131, 227);
            labelEndTime.Name = "labelEndTime";
            labelEndTime.Size = new Size(138, 32);
            labelEndTime.TabIndex = 7;
            labelEndTime.Text = "End Time :";
            // 
            // dateTimePickerEnd
            // 
            dateTimePickerEnd.Anchor = AnchorStyles.Left;
            dateTimePickerEnd.CalendarFont = new Font("Cambria", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dateTimePickerEnd.CustomFormat = "hh:mm";
            dateTimePickerEnd.Font = new Font("Cambria", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dateTimePickerEnd.Format = DateTimePickerFormat.Custom;
            dateTimePickerEnd.Location = new Point(404, 225);
            dateTimePickerEnd.Name = "dateTimePickerEnd";
            dateTimePickerEnd.ShowUpDown = true;
            dateTimePickerEnd.Size = new Size(153, 36);
            dateTimePickerEnd.TabIndex = 5;
            dateTimePickerEnd.Value = new DateTime(2024, 11, 19, 5, 0, 0, 0);
            // 
            // buttonUpdate
            // 
            buttonUpdate.BackColor = Color.DodgerBlue;
            buttonUpdate.FlatStyle = FlatStyle.Popup;
            buttonUpdate.Font = new Font("Cambria", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonUpdate.ForeColor = SystemColors.ButtonHighlight;
            buttonUpdate.Location = new Point(404, 302);
            buttonUpdate.Name = "buttonUpdate";
            buttonUpdate.Size = new Size(140, 46);
            buttonUpdate.TabIndex = 9;
            buttonUpdate.Text = "Update";
            buttonUpdate.UseVisualStyleBackColor = false;
            buttonUpdate.Click += buttonUpdate_Click;
            buttonUpdate.MouseLeave += buttonUpdate_MouseLeave;
            buttonUpdate.MouseHover += buttonUpdate_MouseHover;
            // 
            // buttonBack
            // 
            buttonBack.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            buttonBack.BackColor = Color.DodgerBlue;
            buttonBack.FlatStyle = FlatStyle.Popup;
            buttonBack.Font = new Font("Cambria", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonBack.ForeColor = SystemColors.ButtonHighlight;
            buttonBack.Location = new Point(15, 428);
            buttonBack.Margin = new Padding(15, 13, 13, 13);
            buttonBack.Name = "buttonBack";
            buttonBack.Size = new Size(140, 44);
            buttonBack.TabIndex = 10;
            buttonBack.Text = "Back";
            buttonBack.UseVisualStyleBackColor = false;
            buttonBack.Click += buttonBack_Click;
            buttonBack.MouseLeave += buttonBack_MouseLeave;
            buttonBack.MouseHover += buttonBack_MouseHover;
            // 
            // dataGridViewPeakHours
            // 
            dataGridViewPeakHours.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            tableLayoutPanel1.SetColumnSpan(dataGridViewPeakHours, 2);
            dataGridViewPeakHours.Dock = DockStyle.Fill;
            dataGridViewPeakHours.Location = new Point(3, 3);
            dataGridViewPeakHours.Name = "dataGridViewPeakHours";
            dataGridViewPeakHours.Size = new Size(948, 66);
            dataGridViewPeakHours.TabIndex = 11;
            // 
            // Form7_PeakHour
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(954, 567);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(panel1);
            Name = "Form7_PeakHour";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form7_PeakHour";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewPeakHours).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private DateTimePicker dateTimePickerStart;
        private TableLayoutPanel tableLayoutPanel1;
        private Label labelStartTime;
        private Label labelEndTime;
        private DateTimePicker dateTimePickerEnd;
        private Button buttonUpdate;
        private Button buttonBack;
        private DataGridView dataGridViewPeakHours;
    }
}