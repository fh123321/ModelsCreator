using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Dapper;
using System.Data.OracleClient;
using ModelHalper.Model;

namespace ModelHalper.Dao
{
    public class DaoOracle:IDao
    {
   
        /// <summary>
        /// 取得oracle table 的column 相關資訊
        /// </summary>
        /// <param name="tablename">表單名稱</param>
        /// <returns></returns>
        public IEnumerable<ColumnModel> GetModel(CommonModel param)
        {
            String strcmd = "SELECT t.Table_Name ,t.column_name,t.Data_Type,t.Data_Length  FROM all_tab_cols t WHERE 1=1 ";
            strcmd += (String.IsNullOrEmpty(param.Table_Name))?"":" and table_name = :table_name ";
            using (OracleConnection conn = new OracleConnection(param.ConnectionString)) {
                try
                {
                 return conn.Query<ColumnModel>(strcmd, param);
                }
                catch (Exception exp){
                    throw exp;
                }
            }
        }
        /// <summary>
        /// 測試Oracle連線是否正確
        /// </summary>
        /// <param name="param">用來取得連線字串</param>
        /// <returns></returns>
        public Boolean TestConn(CommonModel param) {
            using (OracleConnection conn = new OracleConnection(param.ConnectionString))
            {
                try
                {
                    conn.Open();
                    conn.Close();
                    return true;
                }
                catch (Exception exp)
                {
                    return false;
                }
            }
        }
        /// <summary>
        /// 取得owner所有的表
        /// </summary>
        /// <param name="param"></param>
        /// <returns></returns>
        public IEnumerable<TableModel> GetTable(CommonModel param)
        {

            String strcmd = "SELECT owner, table_name FROM all_tables Where 1 = 1";
                   strcmd += (String.IsNullOrEmpty(param.Owner))?"":" AND OWNER =:owner ";
                   strcmd += (String.IsNullOrEmpty(param.Table_Name)) ? "" : " AND TABLE_NAME =:Table_Name ";
            using (OracleConnection conn = new OracleConnection(param.ConnectionString))
            {
                try
                {
                    return conn.Query<TableModel>(strcmd, param);
                }
                catch (Exception exp)
                {
                    throw exp;
                }
            }
        }

    }
}
