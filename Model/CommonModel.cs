using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ModelHalper.Model
{
    public class CommonModel
    {
        public String Owner { get; set; }
        public String Table_Name { get; set; }
        public String NameSpace { get; set; }
        public String ClassName { get; set; }
        public String DBType { get; set; }
        public String ConnectionString { get; set; }
        public String FilePath { get; set; }
    }
}
