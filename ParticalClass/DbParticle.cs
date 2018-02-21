using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ModelHalper.Model;
using ModelHalper.Dao;


namespace ModelHalper.SQLT4
{
    public partial class ModelT4
    {
        public IEnumerable<ColumnModel> col = null;
        public CommonModel modelcommon { get; set; }
        public ModelT4(CommonModel model, ref string err)
        {
            this.modelcommon = model;
            try
            {
                Dao.Dao testconn = new Dao.Dao();
                Type type = Type.GetType("ModelHalper.Dao.Dao" + model.DBType);
                testconn.SQL = (IDao)Activator.CreateInstance(type);
                col =testconn.GetColumn(model);
            }
            catch (Exception exp)
            {
                err = "" + exp;
            }
        }
      

        public String GetType(String DbType, ColumnModel mod)
        {
            String coltype = "";
            switch (DbType.ToUpper())
            {
                case "ORACLE":
                    switch (mod.Data_Type.ToUpper())
                    {
                        case "NCHAR":case "VARCHAR2":case "NVARCHAR2":case "CHAR":
                        case "LONG":case "CLOB":case "NCLOB":case "ROWID":
                            coltype = "string";
                            break;
                        case "NUMBER":case "INTEGER":case "FLOAT":
                            coltype = "Decimal";
                            break;
                        case "DATE":case "TIMESTAMP":
                        case "TIMESTAMP WITH LOCAL TIME ZONE":
                        case "TIMESTAMP WITH TIME ZONE":
                            coltype = "DateTime";
                            break;
                        case "INTERVAL DAY TO SECOND":
                            coltype = "TimeSpan";
                            break;
                        case "BFILE":case "BLOB":case "LONG RAW":case "RAW":
                            coltype = "Byte[]";
                            break;
                        default: coltype = "string"; break;
                    };
                break;
                case "SQLSERVER":
                    switch (mod.Data_Type.ToUpper())
                    {
                        case "BIT":
                            coltype = "Boolean";
                            break;
                        case "TINYINT":
                            coltype = "Byte";
                            break;
                        case "IMAGE": case "VARBINARY":case "BINARY":case "ROWVERSION":
                        case "TIMESTAMP":
                            coltype = "Byte[]";
                            break;
                        case "NVARCHAR":case "NCHAR":case"VARCHAR":case "CHAR":case "TEXT": case "NTEXT":
                            coltype = "string";
                            break;
                        case "NUMBERIC":case "DECIMAL":case "MONEY":case "SMALLMONEY":
                            coltype = "Decimal";
                            break;
                        case "DATETIME":case "DATE":case "DATETIME2":case "SMALLDATETIME":
                            coltype = "DateTime";
                            break;
                        case "FLOAT":
                            coltype = "Double";
                            break;
                        case "UNIQUEIDENTIFIER":
                            coltype = "Guid";
                            break;
                        case "INT":case "SMALLINT":
                            coltype = "int";
                            break;
                        case "BIGINT":
                            coltype = "Int64";
                            break;
                        case "TIME":
                            coltype = "TimeSpan";
                            break;
                        default: coltype = "string"; break;

                    }; 
                break;
            }
            return coltype;
        }
    }
}
