using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.CodeAnalysis;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LibraryAppCore.Managers;
using LibraryAppCore.Managers.TableLayouts;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace LibraryAppCore
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            this.MaximumSize = new Size(Screen.PrimaryScreen.WorkingArea.Width, Screen.PrimaryScreen.WorkingArea.Height);
            ReLocateResizer();
        }

        Point movement;
        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            movement = e.Location;
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - movement.X;
                this.Top += e.Y - movement.Y;
            }
        }
        Point resizer;
        private void label2_MouseDown(object sender, MouseEventArgs e)
        {
            resizer = e.Location;
        }
        private void ReLocateResizer()
        {
            label2.Left = label2.Parent.Width - label2.Width;
            label2.Top = label2.Parent.Height - label2.Height;
        }
        private void label2_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                if (this.Width > this.MinimumSize.Width || e.X > resizer.X)
                {
                    this.Width += e.X - resizer.X;
                }
                if (this.Height > this.MinimumSize.Height || e.Y > resizer.Y)
                {
                    this.Height += e.Y - resizer.Y;
                }
                ReLocateResizer();
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        private void button2_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Maximized)
            {
                this.WindowState = FormWindowState.Normal;
                this.Left = (Screen.PrimaryScreen.WorkingArea.Width / 2) - (this.Width / 2);
                this.Top = (Screen.PrimaryScreen.WorkingArea.Height / 2) - (this.Height / 2);
                label2.Visible = true;
            }
            else
            {
                this.WindowState = FormWindowState.Maximized;
                label2.Visible = false;
            }
            ReLocateResizer();
        }
        private void SideBarButtonsMouseMove(object sender, MouseEventArgs e)
        {
#pragma warning disable
            Button btnx = sender as Button;
            btnx.FlatAppearance.BorderSize = 2;
        }
        private void SideBarButtonsMouseLeave(object sender, EventArgs e)
        {
#pragma warning disable
            Button btnx = sender as Button;
            btnx.FlatAppearance.BorderSize = 0;
        }

        private void RefreshMemberFormValues()
        {
            label3.Text = sMember.Name;
        }
        private void AddBooksToView(int startIndex, int endIndex)
        {
            flowLayoutPanel1.Controls.Clear();
            if (Math.Abs(endIndex-startIndex)>20)
            {
                startIndex = 0;
                endIndex = 20;
                numericUpDown1.Value = 0;
                numericUpDown2.Value = 20;
                MessageBox.Show("Limit is 20","Book Listing Limit",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
            label4.Text = "Books Listing " + startIndex + "/" + endIndex;
            Book[] books = dbBooks.GetBooks(startIndex, endIndex);
            foreach (Book item in books)
            {
                flowLayoutPanel1.Controls.Add(new BookDisplayElement(item, sMember, dbBooks));
                //flowLayoutPanel1.Controls.Add(new BookDisplayElement(item, new Member()
                //{
                //    ID = 10,
                //    Name = "testing"
                //}, dbBooks));
            }
        }

        /// <summary>
        /// Session Member
        /// sent from auth form
        /// </summary>
        [AllowNull]
        Member sMember;

        /// <summary>
        /// Session Database CRUD object<br></br>
        /// sent from auth form
        /// </summary>
        [AllowNull]
        DbAuthManager dbAuth;

        /// <summary>
        /// Session Database CRUD object<br></br>
        /// created in MainForm<br></br>
        /// Connection string set from MainForm
        /// </summary>
        DbBooksManager dbBooks = new DbBooksManager("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Resources\\Library.mdb");

        /// <summary>
        /// Access from Auth. Form with member and dbAuthManager parameters
        /// </summary>
        /// <param name="member"></param>
        /// <param name="dbAuthManager"></param>
        public void Login(Member member, DbAuthManager dbAuthManager)
        {
            sMember = member;
            dbAuth = dbAuthManager;
            RefreshMemberFormValues();
            AddBooksToView(((int)numericUpDown1.Value), ((int)numericUpDown2.Value));
        }

        private void button6_Click(object sender, EventArgs e)
        {
            AddBooksToView(((int)numericUpDown1.Value), ((int)numericUpDown2.Value));
        }
    }
}
