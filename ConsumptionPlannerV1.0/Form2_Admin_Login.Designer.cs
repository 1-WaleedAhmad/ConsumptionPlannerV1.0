namespace ConsumptionPlannerV1._0
{
    partial class Form2_Admin_Login
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
            label3 = new Label();
            textBoxPassword = new TextBox();
            textBoxUsername = new TextBox();
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
            panel1.Size = new Size(1003, 82);
            panel1.TabIndex = 1;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Cambria", 36F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            label1.Location = new Point(339, 9);
            label1.Name = "label1";
            label1.Size = new Size(331, 57);
            label1.TabIndex = 0;
            label1.Text = "ADMIN LOGIN";
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 40F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 60F));
            tableLayoutPanel1.Controls.Add(label2, 0, 0);
            tableLayoutPanel1.Controls.Add(label3, 0, 1);
            tableLayoutPanel1.Controls.Add(textBoxPassword, 1, 1);
            tableLayoutPanel1.Controls.Add(textBoxUsername, 1, 0);
            tableLayoutPanel1.Controls.Add(buttonLogin, 1, 2);
            tableLayoutPanel1.Controls.Add(buttonBack, 0, 2);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 82);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.Padding = new Padding(5);
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 22F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 22F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 56F));
            tableLayoutPanel1.Size = new Size(1003, 564);
            tableLayoutPanel1.TabIndex = 2;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.Font = new Font("Cambria", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(131, 49);
            label2.Name = "label2";
            label2.Size = new Size(144, 32);
            label2.TabIndex = 0;
            label2.Text = "Username :";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.AutoSize = true;
            label3.Font = new Font("Cambria", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(134, 170);
            label3.Name = "label3";
            label3.Size = new Size(139, 32);
            label3.TabIndex = 0;
            label3.Text = "Password :";
            // 
            // textBoxPassword
            // 
            textBoxPassword.Anchor = AnchorStyles.Left;
            textBoxPassword.Font = new Font("Cambria", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxPassword.Location = new Point(405, 167);
            textBoxPassword.Name = "textBoxPassword";
            textBoxPassword.PasswordChar = '*';
            textBoxPassword.Size = new Size(282, 39);
            textBoxPassword.TabIndex = 1;
            // 
            // textBoxUsername
            // 
            textBoxUsername.Anchor = AnchorStyles.Left;
            textBoxUsername.Font = new Font("Cambria", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxUsername.Location = new Point(405, 46);
            textBoxUsername.Name = "textBoxUsername";
            textBoxUsername.Size = new Size(282, 39);
            textBoxUsername.TabIndex = 0;
            // 
            // buttonLogin
            // 
            buttonLogin.BackColor = Color.DodgerBlue;
            buttonLogin.FlatStyle = FlatStyle.Popup;
            buttonLogin.Font = new Font("Cambria", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonLogin.ForeColor = SystemColors.ButtonHighlight;
            buttonLogin.Location = new Point(405, 250);
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
            buttonBack.Location = new Point(20, 500);
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
            // Form2_Admin_Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1003, 646);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(panel1);
            Name = "Form2_Admin_Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form2_Admin_Login";
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
        private Label label3;
        private TextBox textBoxPassword;
        private TextBox textBoxUsername;
        private Button buttonBack;
        private Button buttonLogin;
    }
}