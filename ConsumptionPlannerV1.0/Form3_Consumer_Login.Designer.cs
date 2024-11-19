namespace ConsumptionPlannerV1._0
{
    partial class Form3_Consumer_Login
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
            label2 = new Label();
            textBoxConsumerID = new TextBox();
            buttonLogin = new Button();
            buttonBack = new Button();
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
            panel1.Size = new Size(923, 82);
            panel1.TabIndex = 2;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Cambria", 36F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            label1.Location = new Point(239, 9);
            label1.Name = "label1";
            label1.Size = new Size(426, 57);
            label1.TabIndex = 0;
            label1.Text = "CONSUMER LOGIN";
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 35F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 65F));
            tableLayoutPanel1.Controls.Add(label2, 0, 0);
            tableLayoutPanel1.Controls.Add(textBoxConsumerID, 1, 0);
            tableLayoutPanel1.Controls.Add(buttonLogin, 1, 1);
            tableLayoutPanel1.Controls.Add(buttonBack, 0, 1);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 82);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.Padding = new Padding(5);
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 41.6666679F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 58.3333321F));
            tableLayoutPanel1.Size = new Size(923, 550);
            tableLayoutPanel1.TabIndex = 3;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.Font = new Font("Cambria", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(76, 101);
            label2.Name = "label2";
            label2.Size = new Size(177, 32);
            label2.TabIndex = 0;
            label2.Text = "Consumer ID :";
            // 
            // textBoxConsumerID
            // 
            textBoxConsumerID.Anchor = AnchorStyles.Left;
            textBoxConsumerID.Font = new Font("Cambria", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxConsumerID.Location = new Point(327, 98);
            textBoxConsumerID.Name = "textBoxConsumerID";
            textBoxConsumerID.Size = new Size(282, 39);
            textBoxConsumerID.TabIndex = 0;
            // 
            // buttonLogin
            // 
            buttonLogin.BackColor = Color.DodgerBlue;
            buttonLogin.FlatStyle = FlatStyle.Popup;
            buttonLogin.Font = new Font("Cambria", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonLogin.ForeColor = SystemColors.ButtonHighlight;
            buttonLogin.Location = new Point(327, 233);
            buttonLogin.Name = "buttonLogin";
            buttonLogin.Size = new Size(140, 46);
            buttonLogin.TabIndex = 2;
            buttonLogin.Text = "Login";
            buttonLogin.UseVisualStyleBackColor = false;
            buttonLogin.Click += buttonLogin_Click;
            buttonLogin.MouseLeave += buttonLogin_MouseLeave;
            buttonLogin.MouseHover += buttonLogin_MouseHover;
            // 
            // buttonBack
            // 
            buttonBack.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            buttonBack.BackColor = Color.DodgerBlue;
            buttonBack.FlatStyle = FlatStyle.Popup;
            buttonBack.Font = new Font("Cambria", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonBack.ForeColor = SystemColors.ButtonHighlight;
            buttonBack.Location = new Point(20, 486);
            buttonBack.Margin = new Padding(15, 13, 13, 13);
            buttonBack.Name = "buttonBack";
            buttonBack.Size = new Size(140, 46);
            buttonBack.TabIndex = 2;
            buttonBack.Text = "Back";
            buttonBack.UseVisualStyleBackColor = false;
            buttonBack.Click += buttonBack_Click;
            buttonBack.MouseLeave += buttonBack_MouseLeave;
            buttonBack.MouseHover += buttonBack_MouseHover;
            // 
            // Form3_Consumer_Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(923, 632);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(panel1);
            Name = "Form3_Consumer_Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form3_Consumer_Login";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private TableLayoutPanel tableLayoutPanel1;
        private Label label2;
        private TextBox textBoxConsumerID;
        private Button buttonLogin;
        private Button buttonBack;
    }
}