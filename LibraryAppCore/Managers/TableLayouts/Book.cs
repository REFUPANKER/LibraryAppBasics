using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryAppCore.Managers.TableLayouts
{
    public class Book
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Author { get; set; }
        public string Description { get; set; }
        public int LikeCount { get; set; }
        public int DislikeCount { get; set; }
        public string ValueString { get {
                return "("+ID+",'"+Name+"','"+Author+"','"+Description+"',"+LikeCount+","+DislikeCount+")";
            } }
    }
}
