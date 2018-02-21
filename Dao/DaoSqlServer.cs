using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using Dapper;
using ModelHalper.Model;

namespace ModelHalper.Dao
{
    public class DaoSqlServer:IDao
    {
        /// <summary>
        /// 取得所有的表
        /// </summary>
        /// <param name="param"></param>
        /// <returns></returns>
        public IEnumerable<TableModel> GetTable(CommonModel param)
        {

            String strcmd = "SELECT t.TABLE_CATALOG AS owner,t.TABLE_NAME FROM ";
            strcmd += (String.IsNullOrEmpty(param.Owner))? " INFORMATION_SCHEMA.TABLES t WHERE 1=1 " : param.Owner + ".INFORMATION_SCHEMA.TABLES t WHERE 1=1 ";
            strcmd += (String.IsNullOrEmpty(param.Table_Name)) ? "" : " AND TABLE_NAME = @Table_Name ";
            using (SqlConnection conn = new SqlConnection(param.ConnectionString))
            {
                try
                {
                    return conn.Query<TableModel>(strcmd,param);
                }
                catch (Exception exp)
                {
                    throw exp;
                }
            }
        }
        /// <summary>
        /// 取得SQLSERVER 的 column 相關資訊
        /// </summary>
        /// <param name="param"></param>
        /// <returns></returns>
        public IEnumerable<ColumnModel> GetModel(CommonModel param)
        {
            String strcmd = "SELECT t.TABLE_NAME,t.COLUMN_NAME,t.DATA_TYPE,t.CHARACTER_MAXIMUM_LENGTH AS DATA_LENGTH FROM ";
            strcmd += (String.IsNullOrEmpty(param.Owner)) ? " INFORMATION_SCHEMA.Columns t Where Table_Name = @Table_Name " : param.Owner+".INFORMATION_SCHEMA.Columns t Where Table_Name = @Table_Name ";
            using (SqlConnection conn = new SqlConnection(param.ConnectionString))
            {
                try
                {
                    return conn.Query<ColumnModel>(strcmd, param);
                }
                catch (Exception exp)
                {
                    throw exp;
                }
            }
        }
        /// <summary>
        /// 測試Sql連線是否正確
        /// </summary>
        /// <param name="param">用來取得連線字串</param>
        /// <returns></returns>
        public Boolean TestConn(CommonModel param)
        {
            using (SqlConnection conn = new SqlConnection(param.ConnectionString))
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


    }
}
