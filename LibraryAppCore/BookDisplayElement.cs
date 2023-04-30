using LibraryAppCore.Managers;
using LibraryAppCore.Managers.TableLayouts;
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

namespace LibraryAppCore
{
#pragma warning disable
    public partial class BookDisplayElement : UserControl
    {
        /// <summary>
        /// Book display element<br></br>
        /// Connects Book to Member with like/dislike events<br></br>
        /// this is why requires <br></br>
        /// •<seealso cref="DbAuthManager"/><br></br>
        /// •<seealso cref="DbBooksManager"/>
        /// </summary>
        /// <param name="book"></param>
        /// <param name="sessionManager"></param>
        /// <param name="bookManager"></param>
        public BookDisplayElement(Book book, Member member, DbBooksManager bookManager)
        {
            InitializeComponent();
            this.BookData = book;
            this.SessionMember = member;
            this.BookManager = bookManager;
            SetVariables();
        }
        public Book BookData;
        public Member SessionMember;
        public DbBooksManager BookManager;

        public void SetVariables()
        {
            try
            {
                //this.BookData = BookManager.SetLikeDislikeCount(this.BookData);
                switch (BookManager.GetBookLikeDislikeStatus(SessionMember, BookData))
                {
                    case 1:
                        DislikeButton.FlatAppearance.BorderSize = 0;
                        LikeButton.FlatAppearance.BorderSize = 3;
                        break;
                    case 0:
                        LikeButton.FlatAppearance.BorderSize = 0;
                        DislikeButton.FlatAppearance.BorderSize = 3;
                        break;
                    case -1:
                        LikeButton.FlatAppearance.BorderSize = 0;
                        DislikeButton.FlatAppearance.BorderSize = 0;
                        break;
                }
                this.Name = BookData.Name;
                BookName.Text = BookData.Name + "\n" + BookData.Description;
                if (BookData.Description.Length * (BookName.Font.Size * 0.75f) >= this.Width)
                {
                    BookName.Text = BookData.Name + "\n" + BookData.Description.Substring(0, Convert.ToInt32(BookData.Description.Length * 0.55f)) + " •••";
                }
            }
            catch { }
        }

        private void LikeButton_Click(object sender, EventArgs e)
        {
            BookManager.BookLikeDislike(true, SessionMember, BookData, this);
        }

        private void DislikeButton_Click(object sender, EventArgs e)
        {
            BookManager.BookLikeDislike(false, SessionMember, BookData, this);
        }
    }
}
