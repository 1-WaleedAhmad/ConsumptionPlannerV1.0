namespace ConsumptionPlannerV1._0
{
    partial class Form9_AddAppliances
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
            dateTimePickerPreferredTime = new DateTimePicker();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            textBoxName = new TextBox();
            textBoxWatts = new TextBox();
            dateTimePickerAvgTime = new DateTimePicker();
            comboBoxCategory = new ComboBox();
            groupBox1 = new GroupBox();
            radioButtonNo = new RadioButton();
            radioButtonYes = new RadioButton();
            buttonSave = new Button();
            panel1.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            groupBox1.SuspendLayout();
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
            panel1.Size = new Size(1152, 82);
            panel1.TabIndex = 4;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top;
            label1.AutoSize = true;
            label1.Font = new Font("Cambria", 36F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            label1.Location = new Point(379, 9);
            label1.Name = "label1";
            label1.Size = new Size(387, 57);
            label1.TabIndex = 0;
            label1.Text = "ADD APPLIANCE";
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 40.1041679F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 59.8958321F));
            tableLayoutPanel1.Controls.Add(buttonBack, 0, 6);
            tableLayoutPanel1.Controls.Add(dateTimePickerPreferredTime, 1, 3);
            tableLayoutPanel1.Controls.Add(label2, 0, 0);
            tableLayoutPanel1.Controls.Add(label3, 0, 1);
            tableLayoutPanel1.Controls.Add(label4, 0, 2);
            tableLayoutPanel1.Controls.Add(label5, 0, 3);
            tableLayoutPanel1.Controls.Add(label6, 0, 4);
            tableLayoutPanel1.Controls.Add(label7, 0, 5);
            tableLayoutPanel1.Controls.Add(textBoxName, 1, 0);
            tableLayoutPanel1.Controls.Add(textBoxWatts, 1, 1);
            tableLayoutPanel1.Controls.Add(dateTimePickerAvgTime, 1, 5);
            tableLayoutPanel1.Controls.Add(comboBoxCategory, 1, 2);
            tableLayoutPanel1.Controls.Add(groupBox1, 1, 4);
            tableLayoutPanel1.Controls.Add(buttonSave, 1, 6);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 82);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 7;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 15F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 15F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 15F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 15F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 15F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 15F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tableLayoutPanel1.Size = new Size(1152, 553);
            tableLayoutPanel1.TabIndex = 5;
            // 
            // buttonBack
            // 
            buttonBack.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            buttonBack.BackColor = Color.DodgerBlue;
            buttonBack.FlatStyle = FlatStyle.Popup;
            buttonBack.Font = new Font("Cambria", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonBack.ForeColor = SystemColors.ButtonHighlight;
            buttonBack.Location = new Point(15, 505);
            buttonBack.Margin = new Padding(15, 13, 13, 13);
            buttonBack.Name = "buttonBack";
            buttonBack.Size = new Size(123, 35);
            buttonBack.TabIndex = 11;
            buttonBack.Text = "Back";
            buttonBack.UseVisualStyleBackColor = false;
            buttonBack.Click += buttonBack_Click;
            buttonBack.MouseLeave += buttonBack_MouseLeave;
            buttonBack.MouseHover += buttonBack_MouseHover;
            // 
            // dateTimePickerPreferredTime
            // 
            dateTimePickerPreferredTime.Anchor = AnchorStyles.Left;
            dateTimePickerPreferredTime.CalendarFont = new Font("Cambria", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dateTimePickerPreferredTime.CustomFormat = "HH:mm";
            dateTimePickerPreferredTime.Font = new Font("Cambria", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dateTimePickerPreferredTime.Format = DateTimePickerFormat.Custom;
            dateTimePickerPreferredTime.Location = new Point(465, 269);
            dateTimePickerPreferredTime.Name = "dateTimePickerPreferredTime";
            dateTimePickerPreferredTime.ShowUpDown = true;
            dateTimePickerPreferredTime.Size = new Size(153, 36);
            dateTimePickerPreferredTime.TabIndex = 9;
            dateTimePickerPreferredTime.Value = new DateTime(2024, 11, 19, 5, 0, 0, 0);
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.Font = new Font("Cambria", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(184, 25);
            label2.Name = "label2";
            label2.Size = new Size(93, 32);
            label2.TabIndex = 1;
            label2.Text = "Name :";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.AutoSize = true;
            label3.Font = new Font("Cambria", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(134, 107);
            label3.Name = "label3";
            label3.Size = new Size(193, 32);
            label3.TabIndex = 1;
            label3.Text = "Power (Watts) :";
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.None;
            label4.AutoSize = true;
            label4.Font = new Font("Cambria", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(166, 189);
            label4.Name = "label4";
            label4.Size = new Size(129, 32);
            label4.TabIndex = 1;
            label4.Text = "Category :";
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.None;
            label5.AutoSize = true;
            label5.Font = new Font("Cambria", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(131, 271);
            label5.Name = "label5";
            label5.Size = new Size(199, 32);
            label5.TabIndex = 1;
            label5.Text = "Preffered Time :";
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.None;
            label6.AutoSize = true;
            label6.Font = new Font("Cambria", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(159, 353);
            label6.Name = "label6";
            label6.Size = new Size(143, 32);
            label6.TabIndex = 1;
            label6.Text = "Flexibility :";
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.None;
            label7.AutoSize = true;
            label7.Font = new Font("Cambria", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(139, 435);
            label7.Name = "label7";
            label7.Size = new Size(184, 32);
            label7.TabIndex = 1;
            label7.Text = "Average Time :";
            // 
            // textBoxName
            // 
            textBoxName.Anchor = AnchorStyles.Left;
            textBoxName.Font = new Font("Cambria", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxName.Location = new Point(465, 21);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(282, 39);
            textBoxName.TabIndex = 2;
            // 
            // textBoxWatts
            // 
            textBoxWatts.Anchor = AnchorStyles.Left;
            textBoxWatts.Font = new Font("Cambria", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxWatts.Location = new Point(465, 103);
            textBoxWatts.Name = "textBoxWatts";
            textBoxWatts.Size = new Size(282, 39);
            textBoxWatts.TabIndex = 2;
            // 
            // dateTimePickerAvgTime
            // 
            dateTimePickerAvgTime.Anchor = AnchorStyles.Left;
            dateTimePickerAvgTime.CalendarFont = new Font("Cambria", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dateTimePickerAvgTime.CustomFormat = "HH:mm";
            dateTimePickerAvgTime.Font = new Font("Cambria", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dateTimePickerAvgTime.Format = DateTimePickerFormat.Custom;
            dateTimePickerAvgTime.Location = new Point(465, 433);
            dateTimePickerAvgTime.Name = "dateTimePickerAvgTime";
            dateTimePickerAvgTime.ShowUpDown = true;
            dateTimePickerAvgTime.Size = new Size(153, 36);
            dateTimePickerAvgTime.TabIndex = 6;
            dateTimePickerAvgTime.Value = new DateTime(2024, 11, 19, 5, 0, 0, 0);
            // 
            // comboBoxCategory
            // 
            comboBoxCategory.Anchor = AnchorStyles.Left;
            comboBoxCategory.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            comboBoxCategory.AutoCompleteSource = AutoCompleteSource.ListItems;
            comboBoxCategory.Font = new Font("Cambria", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            comboBoxCategory.FormattingEnabled = true;
            comboBoxCategory.Items.AddRange(new object[] { "Daily", "Weekly", "Monthly", "24H" });
            comboBoxCategory.Location = new Point(465, 185);
            comboBoxCategory.Name = "comboBoxCategory";
            comboBoxCategory.Size = new Size(282, 40);
            comboBoxCategory.TabIndex = 7;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(radioButtonNo);
            groupBox1.Controls.Add(radioButtonYes);
            groupBox1.Location = new Point(465, 331);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(301, 76);
            groupBox1.TabIndex = 8;
            groupBox1.TabStop = false;
            groupBox1.Text = "groupBox1";
            // 
            // radioButtonNo
            // 
            radioButtonNo.AutoSize = true;
            radioButtonNo.Font = new Font("Cambria", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            radioButtonNo.Location = new Point(135, 32);
            radioButtonNo.Name = "radioButtonNo";
            radioButtonNo.Size = new Size(55, 29);
            radioButtonNo.TabIndex = 0;
            radioButtonNo.TabStop = true;
            radioButtonNo.Text = "No";
            radioButtonNo.UseVisualStyleBackColor = true;
            // 
            // radioButtonYes
            // 
            radioButtonYes.AutoSize = true;
            radioButtonYes.Font = new Font("Cambria", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            radioButtonYes.Location = new Point(23, 32);
            radioButtonYes.Name = "radioButtonYes";
            radioButtonYes.Size = new Size(59, 29);
            radioButtonYes.TabIndex = 0;
            radioButtonYes.TabStop = true;
            radioButtonYes.Text = "Yes";
            radioButtonYes.UseVisualStyleBackColor = true;
            // 
            // buttonSave
            // 
            buttonSave.BackColor = Color.DodgerBlue;
            buttonSave.FlatStyle = FlatStyle.Popup;
            buttonSave.Font = new Font("Cambria", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonSave.ForeColor = SystemColors.ButtonHighlight;
            buttonSave.Location = new Point(465, 495);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(140, 46);
            buttonSave.TabIndex = 10;
            buttonSave.Text = "Save";
            buttonSave.UseVisualStyleBackColor = false;
            buttonSave.Click += buttonSave_Click;
            buttonSave.MouseLeave += buttonSave_MouseLeave;
            buttonSave.MouseHover += buttonSave_MouseHover;
            // 
            // Form9_AddAppliances
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1152, 635);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(panel1);
            Name = "Form9_AddAppliances";
            StartPosition = FormStartPosition.CenterScreen;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private TableLayoutPanel tableLayoutPanel1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private TextBox textBoxName;
        private TextBox textBoxWatts;
        private DateTimePicker dateTimePickerAvgTime;
        private ComboBox comboBoxCategory;
        private GroupBox groupBox1;
        private RadioButton radioButtonNo;
        private RadioButton radioButtonYes;
        private DateTimePicker dateTimePickerPreferredTime;
        private Button buttonSave;
        private Button buttonBack;
    }
}