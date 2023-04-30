using LibraryAppCore.Managers.TableLayouts;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace LibraryAppCore.Managers
{
    public class DbBooksManager
    {
        OleDbConnection dbCon = new OleDbConnection();

        /// <summary>
        /// Must be logged in<br></br>
        /// <seealso cref="Login(Member)"/>
        /// </summary>
        /// <param name="ConnectionString"></param>
        public DbBooksManager(string ConnectionString)
        {
            dbCon.ConnectionString = ConnectionString;
        }
        
        /// <summary>
        /// Table names for Library System
        /// </summary>
        public enum TableNames
        {
            Members,
            Books,
            BookComments,
            BookHistory
        }
        /// <summary>
        /// Runs action in try-catch blocks with active database connection<br></br>
        /// If something causes to error, <b>returns </b><see cref="Exception"/><br></br>
        /// If action runs successfully , <b>returns </b>null<br></br>
        /// </summary>
        /// <param name="act"></param>
        /// <returns></returns>
        private Exception? UseDbConnection(Action act)
        {
            try
            {
                dbCon.Close();
                dbCon.Open();
                act.Invoke();
            }
            catch (Exception e)
            {
                MessageBox.Show(e + "");
                return e;
            }
            finally
            {
                dbCon.Close();
            }
            return null;
        }

        /// <summary>
        /// returns result from UseDbConnection <br></br>
        /// trys to select BookName from database<br></br>
        /// <u>If DbCon returns</u><br></br>
        /// <b>Error </b>=> returns false<br></br>
        /// <b>null </b> => returns true<br></br>
        /// </summary>
        /// <param name="bookName"></param>
        /// <returns></returns>
        public bool BookExists(string bookName)
        {
            bool result = true;
            UseDbConnection(() =>
            {
                OleDbCommand command = new OleDbCommand(
                    "Select BookName from " + TableNames.Books.ToString() +
                    " where BookName='" + bookName.ToString() + "' OR " +
                    "BookName='" + ToCamelCase(bookName) + "'"
                    , dbCon);
                command.ExecuteNonQuery();
                OleDbDataReader reader = command.ExecuteReader();
                result = reader.Read();
            });
            return result;
        }
        public string ToCamelCase(string text)
        {
            string[] words = text.Split(" ");
            string result = "";
            try
            {
                for (int i = 0; i < words.Length; i++)
                {
                    words[i] = (words[i][0] + "").ToUpper() + words[i].Substring(1, words[i].Length - 1);
                    result += words[i];
                    if (i != words.Length - 1)
                    {
                        result += " ";
                    }
                }
            }
            catch { }
            return result;
        }
        public Book? GetBook(string bookName)
        {
            Book book = new Book();
            if (UseDbConnection(() =>
            {
                OleDbCommand command = new OleDbCommand(
                    "Select * from " + TableNames.Books.ToString() + " where BookName='" + bookName + "'"
                    , dbCon);
                command.ExecuteNonQuery();
                OleDbDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    book.ID = (int)reader[0];
                    book.Name = reader[1] + "";
                    book.Author = reader[2] + "";
                    book.Description = reader[3] + "";
                }
                reader.Close();
                
            }) == null) // Successfully selected book {No Error -> returns null}
            {
                return book;
            }
            else
            {
                return null;
            }
        }

        public Book? GetBook(int bookID)
        {
            Book book = new Book();
            if (UseDbConnection(() =>
            {
                OleDbCommand command = new OleDbCommand(
                    "Select * from " + TableNames.Books.ToString() + " where BookID=" + bookID.ToString() + ""
                    , dbCon);
                command.ExecuteNonQuery();
                OleDbDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    book.ID = (int)reader[0];
                    book.Name = reader[1] + "";
                    book.Author = reader[2] + "";
                    book.Description = reader[3] + "";
                }
                reader.Close();
                
            }) == null) // Successfully selected book {No Error -> returns null}
            {
                return book;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// -1 : not exists or liked and disliked
        /// 0  : false> dislike
        /// 1  : true > like
        /// </summary>
        /// <param name="book"></param>
        /// <returns></returns>
        public int GetBookLikeDislikeStatus(Member member, Book book)
        {
            int result = -1;
            var t = Task.Run(async () =>
            {
                try
                {
                    if (dbCon.State == ConnectionState.Closed)
                    {
                        await dbCon.OpenAsync();
                    }
                    OleDbCommand command = new OleDbCommand();
                    command.Connection = dbCon;
                    command.CommandText = "select * from " + TableNames.BookHistory.ToString() + " where MemberId=" + member.ID + " and BookId=" + book.ID;
                    await command.ExecuteNonQueryAsync();
                    OleDbDataReader reader = command.ExecuteReader();
                    await reader.ReadAsync();
                    result = ((bool)reader[2] == true && (bool)reader[3] == false) ? 1
                    : ((bool)reader[3] == true && (bool)reader[2] == false) ? 0 : -1;
                    reader.Close();
                }
                catch
                {
                    result = -1;
                }
                finally
                {
                    await dbCon.CloseAsync();
                }
            });
            t.Wait();
            return result;
        }
        /// <summary>
        /// Currently disabled 
        /// </summary>
        /// <param name="book"></param>
        /// <returns></returns>
        public Book SetLikeDislikeCount(Book book)
        {
            UseDbConnection(() =>
            {
                OleDbCommand command = new OleDbCommand();
                command.Connection = dbCon;
                command.CommandText = "select * from " + TableNames.BookHistory.ToString() + " where BookId=" + book.ID;
                command.ExecuteNonQuery();
                book.LikeCount = 0;
                book.DislikeCount = 0;
                OleDbDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    if ((bool)reader[2] == true)
                    {
                        book.LikeCount += 1;
                    }
                    if ((bool)reader[3] == true)
                    {
                        book.DislikeCount += 1;
                    }
                }
                reader.Close();
            });
            return book;
        }
        public Book[] GetBooks(int startIndex, int endIndex)
        {
#pragma warning disable
            if (startIndex > endIndex)
            {
                endIndex += startIndex;
                startIndex -= endIndex;
                endIndex -= startIndex;
            }
            List<Book> books = new List<Book>();
            int indexer = 0;
            if (UseDbConnection(() =>
            {
                OleDbCommand command = new OleDbCommand(
                    "Select * from " + TableNames.Books.ToString() + " where BookID >= " + startIndex.ToString() + " AND BookID <= " + (endIndex + 1).ToString()
                    , dbCon);
                command.ExecuteNonQuery();
                OleDbDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    Book book = new Book();
                    book.ID = (int)reader[0];
                    book.Name = reader[1] + "";
                    book.Author = reader[2] + "";
                    book.Description = reader[3] + "";
                    
                    books.Add(book);
                }
                reader.Close();

            }) == null) // Successfully selected book {No Error -> returns null}
            {
                return books.ToArray();
            }
            else
            {
                return null;
            }
        }
        public void BookLikeDislike(bool Liked, Member member, Book book, BookDisplayElement bookElement)
        {
            Task.Run(async () =>
            {
                try
                {
                    if (dbCon.State == ConnectionState.Closed)
                    {
                        await dbCon.OpenAsync();
                    }
                    OleDbCommand command = new OleDbCommand();
                    command.Connection = dbCon;
                    // check member and book exists in BookHistory table
                    command.CommandText = "select * from " + TableNames.BookHistory.ToString() + " where MemberId=" + member.ID + " and BookId=" + book.ID;
                    await command.ExecuteNonQueryAsync();
                    OleDbDataReader reader = command.ExecuteReader();
                    if (await reader.ReadAsync() == false)
                    {
                        await reader.CloseAsync();
                        // insert book and member into BookHistory table
                        command.CommandText = "insert into " + TableNames.BookHistory.ToString() + " (MemberId, BookId, Liked,Disliked) values (" + member.ID + ", " + book.ID + ", " + ((Liked) ? "1,0" : "0,1") + ")";
                        await command.ExecuteNonQueryAsync();
                    }
                    else
                    {
                        // it means member already exists and you need to update values
                        bool HistoryLiked = (bool)reader[2];
                        bool HistoryDisliked = (bool)reader[3];
                        if (reader.IsClosed == false) { await reader.CloseAsync(); }

                        // Get history liked/disliked , check Liked{true/false} for history{Liked/Disliked} 
                        command.CommandText = "update " + TableNames.BookHistory.ToString() + " set "
                        + ((Liked) ? ((HistoryLiked) ? "Liked=0,Disliked=0" : "Liked=1,Disliked=0") : ((HistoryDisliked) ? "Liked=0,Disliked=0" : "Liked=0,Disliked=1"))
                        + " where MemberId=" + member.ID + " and BookId=" + book.ID;
                        await command.ExecuteNonQueryAsync();
                    }
                    await reader.CloseAsync();
                    bookElement.SetVariables();
                }
                catch (Exception excp) { MessageBox.Show(excp.Message + "\n\n" + excp.ToString()); }
                finally
                {
                    dbCon.CloseAsync();
                }
            });
        }
    }
}
