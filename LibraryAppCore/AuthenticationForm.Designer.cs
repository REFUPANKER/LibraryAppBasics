namespace LibraryAppCore
{
    partial class AuthenticationForm
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
            button3 = new Button();
            button1 = new Button();
            label1 = new Label();
            button2 = new Button();
            button4 = new Button();
            panel2 = new Panel();
            SignUpPanel = new Panel();
            label9 = new Label();
            textBox6 = new TextBox();
            label8 = new Label();
            textBox5 = new TextBox();
            label5 = new Label();
            button7 = new Button();
            button8 = new Button();
            label6 = new Label();
            label7 = new Label();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            LoginPanel1 = new Panel();
            label4 = new Label();
            button6 = new Button();
            button5 = new Button();
            label3 = new Label();
            label2 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            label10 = new Label();
            label11 = new Label();
            label12 = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SignUpPanel.SuspendLayout();
            LoginPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(60, 60, 60);
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(button3);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(500, 40);
            panel1.TabIndex = 1;
            panel1.MouseDown += panel1_MouseDown;
            panel1.MouseMove += panel1_MouseMove;
            // 
            // button3
            // 
            button3.Dock = DockStyle.Right;
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatAppearance.MouseDownBackColor = Color.FromArgb(64, 64, 64);
            button3.FlatAppearance.MouseOverBackColor = Color.Gray;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Microsoft Sans Serif", 15F, FontStyle.Regular, GraphicsUnit.Point);
            button3.ForeColor = Color.White;
            button3.Location = new Point(418, 0);
            button3.Name = "button3";
            button3.Size = new Size(40, 38);
            button3.TabIndex = 4;
            button3.Text = "—";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button1
            // 
            button1.Dock = DockStyle.Right;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatAppearance.MouseDownBackColor = Color.FromArgb(64, 64, 64);
            button1.FlatAppearance.MouseOverBackColor = Color.Gray;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Microsoft Sans Serif", 15F, FontStyle.Regular, GraphicsUnit.Point);
            button1.ForeColor = Color.White;
            button1.Location = new Point(458, 0);
            button1.Name = "button1";
            button1.Size = new Size(40, 38);
            button1.TabIndex = 2;
            button1.Text = "X";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.Font = new Font("Microsoft Sans Serif", 24F, FontStyle.Regular, GraphicsUnit.Pixel);
            label1.ForeColor = Color.White;
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(219, 38);
            label1.TabIndex = 1;
            label1.Text = "Library System";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            label1.MouseDown += panel1_MouseDown;
            label1.MouseMove += panel1_MouseMove;
            // 
            // button2
            // 
            button2.FlatAppearance.BorderColor = Color.FromArgb(64, 64, 64);
            button2.FlatAppearance.MouseDownBackColor = Color.Gray;
            button2.FlatAppearance.MouseOverBackColor = Color.FromArgb(224, 224, 224);
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button2.Location = new Point(118, 46);
            button2.Name = "button2";
            button2.Size = new Size(100, 40);
            button2.TabIndex = 2;
            button2.Text = "Login";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button4
            // 
            button4.FlatAppearance.BorderColor = Color.FromArgb(64, 64, 64);
            button4.FlatAppearance.MouseDownBackColor = Color.Gray;
            button4.FlatAppearance.MouseOverBackColor = Color.FromArgb(224, 224, 224);
            button4.FlatStyle = FlatStyle.Flat;
            button4.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button4.Location = new Point(12, 46);
            button4.Name = "button4";
            button4.Size = new Size(100, 40);
            button4.TabIndex = 3;
            button4.Text = "Sign Up";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(SignUpPanel);
            panel2.Controls.Add(LoginPanel1);
            panel2.Location = new Point(12, 129);
            panel2.Name = "panel2";
            panel2.Size = new Size(476, 388);
            panel2.TabIndex = 4;
            // 
            // SignUpPanel
            // 
            SignUpPanel.Controls.Add(label9);
            SignUpPanel.Controls.Add(textBox6);
            SignUpPanel.Controls.Add(label8);
            SignUpPanel.Controls.Add(textBox5);
            SignUpPanel.Controls.Add(label5);
            SignUpPanel.Controls.Add(button7);
            SignUpPanel.Controls.Add(button8);
            SignUpPanel.Controls.Add(label6);
            SignUpPanel.Controls.Add(label7);
            SignUpPanel.Controls.Add(textBox3);
            SignUpPanel.Controls.Add(textBox4);
            SignUpPanel.Location = new Point(0, 0);
            SignUpPanel.Name = "SignUpPanel";
            SignUpPanel.Size = new Size(476, 388);
            SignUpPanel.TabIndex = 7;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label9.Location = new Point(129, 55);
            label9.Name = "label9";
            label9.Size = new Size(53, 20);
            label9.TabIndex = 10;
            label9.Text = "Name";
            // 
            // textBox6
            // 
            textBox6.BorderStyle = BorderStyle.FixedSingle;
            textBox6.Font = new Font("Microsoft Sans Serif", 13F, FontStyle.Regular, GraphicsUnit.Point);
            textBox6.Location = new Point(120, 78);
            textBox6.MaxLength = 32;
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(240, 32);
            textBox6.TabIndex = 0;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(129, 233);
            label8.Name = "label8";
            label8.Size = new Size(147, 20);
            label8.TabIndex = 8;
            label8.Text = "Confirm Password";
            // 
            // textBox5
            // 
            textBox5.BorderStyle = BorderStyle.FixedSingle;
            textBox5.Font = new Font("Microsoft Sans Serif", 13F, FontStyle.Regular, GraphicsUnit.Point);
            textBox5.Location = new Point(120, 256);
            textBox5.MaxLength = 32;
            textBox5.Name = "textBox5";
            textBox5.PasswordChar = '*';
            textBox5.Size = new Size(240, 32);
            textBox5.TabIndex = 3;
            textBox5.TextChanged += PasswordEntryCheck;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(18, 15);
            label5.Name = "label5";
            label5.Size = new Size(93, 29);
            label5.TabIndex = 6;
            label5.Text = "SignUp";
            // 
            // button7
            // 
            button7.FlatAppearance.BorderColor = Color.FromArgb(64, 64, 64);
            button7.FlatAppearance.MouseDownBackColor = Color.FromArgb(224, 224, 224);
            button7.FlatAppearance.MouseOverBackColor = Color.Gray;
            button7.FlatStyle = FlatStyle.Flat;
            button7.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point);
            button7.Location = new Point(366, 198);
            button7.Name = "button7";
            button7.Size = new Size(32, 32);
            button7.TabIndex = 5;
            button7.Text = "🔓";
            button7.UseVisualStyleBackColor = true;
            button7.Click += button7_Click;
            // 
            // button8
            // 
            button8.FlatAppearance.BorderColor = Color.FromArgb(64, 64, 64);
            button8.FlatAppearance.MouseDownBackColor = Color.FromArgb(224, 224, 224);
            button8.FlatAppearance.MouseOverBackColor = Color.Gray;
            button8.FlatStyle = FlatStyle.Flat;
            button8.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point);
            button8.Location = new Point(168, 306);
            button8.Name = "button8";
            button8.Size = new Size(134, 73);
            button8.TabIndex = 4;
            button8.Text = "SignUp";
            button8.UseVisualStyleBackColor = true;
            button8.Click += button8_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(129, 176);
            label6.Name = "label6";
            label6.Size = new Size(83, 20);
            label6.TabIndex = 3;
            label6.Text = "Password";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(129, 116);
            label7.Name = "label7";
            label7.Size = new Size(40, 20);
            label7.TabIndex = 2;
            label7.Text = "Mail";
            // 
            // textBox3
            // 
            textBox3.BorderStyle = BorderStyle.FixedSingle;
            textBox3.Font = new Font("Microsoft Sans Serif", 13F, FontStyle.Regular, GraphicsUnit.Point);
            textBox3.Location = new Point(120, 139);
            textBox3.MaxLength = 32;
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(240, 32);
            textBox3.TabIndex = 1;
            // 
            // textBox4
            // 
            textBox4.BorderStyle = BorderStyle.FixedSingle;
            textBox4.Font = new Font("Microsoft Sans Serif", 13F, FontStyle.Regular, GraphicsUnit.Point);
            textBox4.Location = new Point(120, 198);
            textBox4.MaxLength = 32;
            textBox4.Name = "textBox4";
            textBox4.PasswordChar = '*';
            textBox4.Size = new Size(240, 32);
            textBox4.TabIndex = 2;
            textBox4.TextChanged += PasswordEntryCheck;
            // 
            // LoginPanel1
            // 
            LoginPanel1.Controls.Add(label4);
            LoginPanel1.Controls.Add(button6);
            LoginPanel1.Controls.Add(button5);
            LoginPanel1.Controls.Add(label3);
            LoginPanel1.Controls.Add(label2);
            LoginPanel1.Controls.Add(textBox1);
            LoginPanel1.Controls.Add(textBox2);
            LoginPanel1.Location = new Point(470, 0);
            LoginPanel1.Name = "LoginPanel1";
            LoginPanel1.Size = new Size(476, 388);
            LoginPanel1.TabIndex = 2;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(18, 15);
            label4.Name = "label4";
            label4.Size = new Size(73, 29);
            label4.TabIndex = 6;
            label4.Text = "Login";
            // 
            // button6
            // 
            button6.FlatAppearance.BorderColor = Color.FromArgb(64, 64, 64);
            button6.FlatAppearance.MouseDownBackColor = Color.FromArgb(224, 224, 224);
            button6.FlatAppearance.MouseOverBackColor = Color.Gray;
            button6.FlatStyle = FlatStyle.Flat;
            button6.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point);
            button6.Location = new Point(366, 199);
            button6.Name = "button6";
            button6.Size = new Size(32, 32);
            button6.TabIndex = 5;
            button6.Text = "🔓";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // button5
            // 
            button5.FlatAppearance.BorderColor = Color.FromArgb(64, 64, 64);
            button5.FlatAppearance.MouseDownBackColor = Color.FromArgb(224, 224, 224);
            button5.FlatAppearance.MouseOverBackColor = Color.Gray;
            button5.FlatStyle = FlatStyle.Flat;
            button5.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point);
            button5.Location = new Point(168, 268);
            button5.Name = "button5";
            button5.Size = new Size(134, 73);
            button5.TabIndex = 4;
            button5.Text = "Login";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(129, 176);
            label3.Name = "label3";
            label3.Size = new Size(83, 20);
            label3.TabIndex = 3;
            label3.Text = "Password";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(129, 85);
            label2.Name = "label2";
            label2.Size = new Size(40, 20);
            label2.TabIndex = 2;
            label2.Text = "Mail";
            // 
            // textBox1
            // 
            textBox1.BorderStyle = BorderStyle.FixedSingle;
            textBox1.Font = new Font("Microsoft Sans Serif", 13F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.Location = new Point(120, 108);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(240, 32);
            textBox1.TabIndex = 0;
            // 
            // textBox2
            // 
            textBox2.BorderStyle = BorderStyle.FixedSingle;
            textBox2.Font = new Font("Microsoft Sans Serif", 13F, FontStyle.Regular, GraphicsUnit.Point);
            textBox2.Location = new Point(120, 199);
            textBox2.Name = "textBox2";
            textBox2.PasswordChar = '*';
            textBox2.Size = new Size(240, 32);
            textBox2.TabIndex = 1;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Consolas", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label10.Location = new Point(12, 571);
            label10.Name = "label10";
            label10.Size = new Size(176, 18);
            label10.TabIndex = 5;
            label10.Text = "Made By Refupanker | ";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Cursor = Cursors.Hand;
            label11.Font = new Font("Consolas", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label11.ForeColor = Color.FromArgb(16, 4, 62);
            label11.Location = new Point(180, 571);
            label11.Name = "label11";
            label11.Size = new Size(56, 18);
            label11.TabIndex = 6;
            label11.Text = "GitHub";
            label11.Click += label11_Click;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Cursor = Cursors.Hand;
            label12.Font = new Font("Consolas", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label12.ForeColor = Color.FromArgb(16, 4, 62);
            label12.Location = new Point(242, 571);
            label12.Name = "label12";
            label12.Size = new Size(64, 18);
            label12.TabIndex = 7;
            label12.Text = "YouTube";
            label12.Click += label12_Click;
            // 
            // AuthenticationForm
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackColor = Color.Gainsboro;
            ClientSize = new Size(500, 600);
            Controls.Add(label12);
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(panel2);
            Controls.Add(button4);
            Controls.Add(button2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "AuthenticationForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AuthenticationForm";
            Load += AuthenticationForm_Load;
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            SignUpPanel.ResumeLayout(false);
            SignUpPanel.PerformLayout();
            LoginPanel1.ResumeLayout(false);
            LoginPanel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Panel LoginPanel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel SignUpPanel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBox6;
        private Label label10;
        private Label label11;
        private Label label12;
    }
}