using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ModelHalper.Model
{
    public class ColumnModel
    {
        public String Table_Name { get; set; }
        public String Column_Name { get; set; }
        public String Data_Type { get; set; }
        public int Data_Length { get; set; }
    }
}
