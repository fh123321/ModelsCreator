using ModelHalper.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ModelHalper.Dao
{
    public class Dao
    {
        private IDao sql = null;
        public IDao SQL { 
            get { return this.sql; }
            set { this.sql = value; }
        }
        public IEnumerable<ColumnModel> GetColumn(CommonModel param){
            if (sql == null)
            {
                throw new ArgumentException("Obj","Object Can Not Be Null");
            }
            return sql.GetModel(param);
        }
        public Boolean TestSql(CommonModel param)
        {
            if (sql == null)
            {
                throw new ArgumentException("Obj", "Object Can Not Be Null");
            }
            return sql.TestConn(param);
        }
        public IEnumerable<TableModel> GetTable(CommonModel param)
        {
            if (sql == null)
            {
                throw new ArgumentException("Obj", "Object Can Not Be Null");
            }
            return sql.GetTable(param);
        }
    }
}
