using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryAppCore.Managers.TableLayouts
{
    public class Member
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Mail { get; set; }
        public string Password { get; set; }
        public int ActiveBook { get; set; }

        public string TableColumnNames { get {
                return "(MemberName,MemberMail,MemberPassword,ActiveBook)";
            } }
        public string TableColumnValues { get {
                return "('"+Name+"','" + Mail + "','"+Password + "'," +ActiveBook + ")";
            }
        }

    }
}
