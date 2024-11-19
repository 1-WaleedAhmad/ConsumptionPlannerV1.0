namespace ConsumptionPlannerV1._0
{
    partial class Form6_ElecRate
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
            dataGridView1 = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Edit = new DataGridViewButtonColumn();
            panel2 = new Panel();
            label2 = new Label();
            labelType = new Label();
            textBoxRate = new TextBox();
            buttonUpdate = new Button();
            button1 = new Button();
            panel1.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel2.SuspendLayout();
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
            panel1.Size = new Size(1183, 82);
            panel1.TabIndex = 3;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top;
            label1.AutoSize = true;
            label1.Font = new Font("Cambria", 36F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            label1.Location = new Point(346, 9);
            label1.Name = "label1";
            label1.Size = new Size(474, 57);
            label1.TabIndex = 0;
            label1.Text = "ELECTRICITY RATES";
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(buttonBack, 0, 3);
            tableLayoutPanel1.Controls.Add(dataGridView1, 0, 0);
            tableLayoutPanel1.Controls.Add(panel2, 0, 1);
            tableLayoutPanel1.Controls.Add(textBoxRate, 1, 1);
            tableLayoutPanel1.Controls.Add(buttonUpdate, 1, 2);
            tableLayoutPanel1.Controls.Add(button1, 1, 3);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 82);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 4;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 43.369175F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 56.630825F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 128F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 81F));
            tableLayoutPanel1.Size = new Size(1183, 489);
            tableLayoutPanel1.TabIndex = 4;
            // 
            // buttonBack
            // 
            buttonBack.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            buttonBack.BackColor = Color.DodgerBlue;
            buttonBack.FlatStyle = FlatStyle.Popup;
            buttonBack.Font = new Font("Cambria", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonBack.ForeColor = SystemColors.ButtonHighlight;
            buttonBack.Location = new Point(15, 436);
            buttonBack.Margin = new Padding(15, 13, 13, 13);
            buttonBack.Name = "buttonBack";
            buttonBack.Size = new Size(140, 40);
            buttonBack.TabIndex = 4;
            buttonBack.Text = "Back";
            buttonBack.UseVisualStyleBackColor = false;
            buttonBack.Click += buttonBack_Click;
            buttonBack.MouseLeave += buttonBack_MouseLeave;
            buttonBack.MouseHover += buttonBack_MouseHover;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Edit });
            tableLayoutPanel1.SetColumnSpan(dataGridView1, 2);
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(3, 3);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(1177, 115);
            dataGridView1.TabIndex = 1;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // Column1
            // 
            Column1.HeaderText = "ID";
            Column1.Name = "Column1";
            // 
            // Column2
            // 
            Column2.HeaderText = "Rate Type";
            Column2.Name = "Column2";
            // 
            // Column3
            // 
            Column3.HeaderText = "Rate Per Unit";
            Column3.Name = "Column3";
            // 
            // Edit
            // 
            Edit.HeaderText = "Column4";
            Edit.Name = "Edit";
            // 
            // panel2
            // 
            panel2.Controls.Add(label2);
            panel2.Controls.Add(labelType);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(3, 124);
            panel2.Name = "panel2";
            panel2.Size = new Size(585, 152);
            panel2.TabIndex = 9;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.Font = new Font("Cambria", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(222, 56);
            label2.Name = "label2";
            label2.Size = new Size(137, 32);
            label2.TabIndex = 6;
            label2.Text = "New Rate :";
            // 
            // labelType
            // 
            labelType.AutoSize = true;
            labelType.Font = new Font("Cambria", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelType.Location = new Point(251, 109);
            labelType.Name = "labelType";
            labelType.Size = new Size(51, 19);
            labelType.TabIndex = 8;
            labelType.Text = "label3";
            // 
            // textBoxRate
            // 
            textBoxRate.Anchor = AnchorStyles.Left;
            textBoxRate.Font = new Font("Cambria", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxRate.Location = new Point(594, 180);
            textBoxRate.Name = "textBoxRate";
            textBoxRate.Size = new Size(207, 39);
            textBoxRate.TabIndex = 7;
            // 
            // buttonUpdate
            // 
            buttonUpdate.BackColor = Color.DodgerBlue;
            buttonUpdate.Enabled = false;
            buttonUpdate.FlatStyle = FlatStyle.Popup;
            buttonUpdate.Font = new Font("Cambria", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonUpdate.ForeColor = SystemColors.ButtonHighlight;
            buttonUpdate.Location = new Point(594, 282);
            buttonUpdate.Name = "buttonUpdate";
            buttonUpdate.Size = new Size(140, 46);
            buttonUpdate.TabIndex = 8;
            buttonUpdate.Text = "Update";
            buttonUpdate.UseVisualStyleBackColor = false;
            buttonUpdate.Click += buttonUpdate_Click;
            // 
            // button1
            // 
            button1.Font = new Font("Cambria", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(594, 410);
            button1.Name = "button1";
            button1.Size = new Size(140, 42);
            button1.TabIndex = 5;
            button1.Text = "Refresh Data";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form6_ElecRate
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1183, 571);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(panel1);
            Name = "Form6_ElecRate";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form6_ElecRate";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private TableLayoutPanel tableLayoutPanel1;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewButtonColumn Edit;
        private Button buttonBack;
        private Button button1;
        private Button buttonUpdate;
        private Panel panel2;
        private Label label2;
        private Label labelType;
        private TextBox textBoxRate;
    }
}