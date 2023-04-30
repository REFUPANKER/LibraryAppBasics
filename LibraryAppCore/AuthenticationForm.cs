using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LibraryAppCore.Managers.TableLayouts;
using System.Diagnostics;
using System.Diagnostics.Metrics;

namespace LibraryAppCore
{
    public partial class AuthenticationForm : Form
    {

        public AuthenticationForm()
        {
            InitializeComponent();
        }
        DbAuthManager dbAuth = new DbAuthManager("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Resources\\Library.mdb");
        private void AuthenticationForm_Load(object sender, EventArgs e)
        {
            this.DoubleBuffered = true;
            LoginPanel1.Left = SignUpPanel.Right;
        }
        Point movement;
        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            movement = e.Location;
        }


        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                if (e.X <= movement.X && this.Left >= 0 || e.X >= movement.X && this.Left + this.Width <= Screen.PrimaryScreen.Bounds.Width)
                {
                    this.Left += e.X - movement.X;
                }
                if (e.Y <= movement.Y && this.Top >= 0 || e.Y >= movement.Y && this.Top + this.Height <= Screen.PrimaryScreen.WorkingArea.Height)
                {
                    this.Top += e.Y - movement.Y;
                }
            }
        }
        private void button6_Click(object sender, EventArgs e)
        {
            if (textBox2.PasswordChar != '\0')
            {
                textBox2.PasswordChar = '\0';
            }
            else
            {
                textBox2.PasswordChar = '*';
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SignUpPanel.Focus();
            while (SignUpPanel.Right > 0)
            {
                SignUpPanel.Left -= 1;
                LoginPanel1.Left -= 1;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            LoginPanel1.Focus();
            while (LoginPanel1.Left < panel2.Width)
            {
                SignUpPanel.Left += 1;
                LoginPanel1.Left += 1;
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (textBox4.PasswordChar != '\0')
            {
                textBox4.PasswordChar = '\0';
                textBox5.PasswordChar = '\0';
            }
            else
            {
                textBox4.PasswordChar = '*';
                textBox5.PasswordChar = '*';
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            // signup
            if (string.IsNullOrEmpty(textBox6.Text) || string.IsNullOrEmpty(textBox3.Text))
            {
                MessageBox.Show("Cant sign up to system\nAll boxes must be filled", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (textBox4.Text != textBox5.Text || string.IsNullOrEmpty(textBox4.Text))
            {
                MessageBox.Show("Cant sign up to system\nPasswords isn't matching", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Member member = new Member()
                {
                    Name = textBox6.Text,
                    Mail = textBox3.Text,
                    Password = textBox4.Text
                };
                if (dbAuth.AddMember(member) == false)
                {
                    MessageBox.Show("Cant sign up to system\nMember might existing", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MainForm mainForm = new MainForm();
                    mainForm.Login(member, dbAuth);
                    mainForm.Show();
                    this.Hide();
                }
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            // login
            if (string.IsNullOrEmpty(textBox1.Text) || string.IsNullOrEmpty(textBox1.Text))
            {
                MessageBox.Show("Cant login to system\nAll boxes must be filled", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Member? member = dbAuth.GetMember(textBox1.Text);
                if (member == null)
                {
                    MessageBox.Show("Cant login to system\nMember not existing", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (member.Password == textBox2.Text)
                {
                    MainForm mainForm = new MainForm();
                    mainForm.Login(member, dbAuth);
                    mainForm.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Cant login to system\nPassword isn't matching", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void PasswordEntryCheck(object sender, EventArgs e)
        {
            if (textBox4.Text == textBox5.Text)
            {
                textBox4.BackColor = Color.FromArgb(200, 250, 200);
                textBox5.BackColor = Color.FromArgb(200, 250, 200);
            }
            else
            {
                textBox4.BackColor = Color.FromArgb(250, 200, 200);
                textBox5.BackColor = Color.FromArgb(250, 200, 200);
            }
        }
        private void OpenURL(string path)
        {
            try
            {
                ProcessStartInfo psinf = new ProcessStartInfo()
                {
                    FileName = "cmd",
                    Arguments = " /c start " + path,
                    UseShellExecute = true,
                    CreateNoWindow = true,
                };
                Process.Start(psinf);
            }
            catch
            {
                MessageBox.Show("We cant activating web browser", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void label11_Click(object sender, EventArgs e)
        {
            OpenURL("https://github.com/REFUPANKER");
        }

        private void label12_Click(object sender, EventArgs e)
        {
            OpenURL("https://www.youtube.com/channel/UC11WUmFGWJZV1gw9H_KVg0g");
        }
    }
}
