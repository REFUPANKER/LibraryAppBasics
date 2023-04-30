using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using LibraryAppCore.Managers.TableLayouts;
using System.Diagnostics.Metrics;
using System.Diagnostics.CodeAnalysis;

namespace LibraryAppCore
{
    public class DbAuthManager
    {
        OleDbConnection dbCon = new OleDbConnection();
        /// <summary>
        /// <u><b>Requires</b></u><br></br>
        /// Database connection string
        /// <param name="dbConString"></param>
        /// </summary>
        public DbAuthManager(string dbConString)
        {
            dbCon.ConnectionString = dbConString;
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
                MessageBox.Show(e+"");
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
        /// trys to select MemberMail from database<br></br>
        /// <u>If DbCon returns</u><br></br>
        /// <b>Error </b>=> returns false<br></br>
        /// <b>null </b> => returns true<br></br>
        /// </summary>
        /// <param name="memberMail"></param>
        /// <returns></returns>
        public bool MemberExists(string memberMail)
        {
            bool result = true;
            UseDbConnection(() =>
            {
                OleDbCommand command = new OleDbCommand(
                    "Select MemberMail from " + TableNames.Members.ToString() + " where MemberMail='" + memberMail.ToString() + "'"
                    , dbCon);
                command.ExecuteNonQuery();
                OleDbDataReader reader = command.ExecuteReader();
                result = reader.Read();
                reader.Close();
            }); 
            return result;
        }
        /// <summary>
        /// Inserts member into database <br></br>
        /// <b>Dont forget to check database</b><br></br>
        /// Use <b><see cref="MemberExists(string)"/> </b><br></br>
        /// for checking is member existing
        /// </summary>
        /// <param name="member"></param>
        /// <returns>bool(true/false)</returns>
        public bool AddMember(Member member)
        {
            if (MemberExists(member.Mail) == false)
            {
                UseDbConnection(() =>
                {
                    OleDbCommand command = new OleDbCommand(
                         "Insert into " +
                         TableNames.Members.ToString() + " " +
                         member.TableColumnNames + " values " +
                         member.TableColumnValues
                        , connection: dbCon);
                    command.ExecuteNonQuery();
                });
                return true;
            }
            else
            {
                return false;
            }
        }
        /// <summary>
        /// Finds member with memberMail<br></br>
        /// </summary>
        /// <param name="memberMail"></param>
        /// <returns>Member<br></br>Null</returns>
        public Member? GetMember(string memberMail)
        {
            if (MemberExists(memberMail))
            {
                Member member = new Member();
                UseDbConnection(() =>
                {
                    OleDbCommand cmd = new OleDbCommand(
                        "Select * from " + TableNames.Members.ToString() + " where MemberMail='" + memberMail.ToString() + "'"
                        , dbCon);
                    cmd.ExecuteNonQuery();
                    OleDbDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        member.ID = (int)reader[0];
                        member.Name = reader[1] + "";
                        member.Mail = reader[2] + "";
                        member.Password = reader[3] + "";
                        member.ActiveBook = (int)reader[4];
                    }
                    reader.Close();
                });
                return member;
            }
            else
            {
                return null;
            }
        }
    }
}
