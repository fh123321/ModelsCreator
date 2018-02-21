using ModelHalper.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ModelHalper.Dao
{
    public interface IDao
    {
        IEnumerable<ColumnModel> GetModel(CommonModel param);
        Boolean TestConn(CommonModel param);
        IEnumerable<TableModel> GetTable(CommonModel param);
    }
}
