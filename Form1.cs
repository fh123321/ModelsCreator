using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ModelHalper.Dao;
using ModelHalper.Model;
using ModelHalper.FileStream;
using Newtonsoft.Json;

namespace ModelHalper
{
    public partial class Form1 : Form
    {
        CommonModel param = new CommonModel();
        String SettingPath = System.Environment.CurrentDirectory + "\\DbSetting.json";


        public Form1()
        {
            InitializeComponent();
            ShowSetting();
            
        }
        /// <summary>
        /// 連線按鈕事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Connect_Click(object sender, EventArgs e)
        {
            txtConnError.Text = "";

            //LEVEL 1 CHECK SELECT
            if (DbSelect.SelectedItem == null || String.IsNullOrEmpty(DbSelect.SelectedItem.ToString()))
            {
                MessageBox.Show("您尚未選擇資料庫型態", "Error");
            }
            else
            {
                param.DBType = DbSelect.SelectedItem.ToString();
                //LEVEL 2 CHECK DB TEST
                if (String.IsNullOrEmpty(ConnStr.Text))
                {
                    MessageBox.Show("您沒有輸入資料庫連線字串", "Error");
                }
                else
                {
                    param.ConnectionString = ConnStr.Text;
                    //Using DI INJECT INTO
                    Dao.Dao testconn = new Dao.Dao();
                    Type type = Type.GetType("ModelHalper.Dao.Dao" + param.DBType);
                    testconn.SQL = (IDao)Activator.CreateInstance(type);
                    //IF CONNECTION ERROR
                    if (!testconn.TestSql(param))
                    {
                        txtConnError.Text = "您的連線字串有誤";
                    }
                    else
                    {
                        Connect.Enabled = false;
                        DbSelect.Enabled = false;
                        ConnStr.Enabled = false;
                        ConnName.Enabled = false;
                        SettingSelect.Enabled = false;
                        SaveConn.Enabled = false;
                        DisConnect.Enabled = true;
                        tablesearch.Enabled = true;
                        CrtClass.Enabled = true;
                        OutClass.Enabled = true;
                        txtConnError.Text = "連線成功";
                        var tables = testconn.GetTable(param);
                        foreach (TableModel table in tables)
                        {
                            TableSelect.Items.Add(table.Owner + "-" + table.Table_Name);
                        }
                    }
                }
            }
        }
        /// <summary>
        /// 取消連線按鈕事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DisConnect_Click(object sender, EventArgs e)
        {
            Connect.Enabled = true;
            DbSelect.Enabled = true;
            ConnStr.Enabled = true;
            ConnName.Enabled = true;
            SettingSelect.Enabled = true;
            SaveConn.Enabled = true;
            DisConnect.Enabled = false;
            tablesearch.Enabled = false;
            CrtClass.Enabled = false;
            OutClass.Enabled = false;
            TableSelect.Items.Clear();
            txtConnError.Text = "";
        }
        /// <summary>
        /// 搜尋表單按鈕事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tablesearch_Click(object sender, EventArgs e)
        {
            //clear all
            TableSelect.Items.Clear();

            param.Table_Name = TableName.Text;
            param.Owner = Owner.Text;

            Dao.Dao testconn = new Dao.Dao();
            Type type = Type.GetType("ModelHelper.Dao.Dao" + param.DBType);
            testconn.SQL = (IDao)Activator.CreateInstance(type);
            var tables = testconn.GetTable(param);
            foreach (TableModel table in tables)
            {
                TableSelect.Items.Add(table.Owner + "-" + table.Table_Name);
            }
        }
        /// <summary>
        /// 產生class 表單事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CrtClass_Click(object sender, EventArgs e)
        {

            if (TableSelect.SelectedItem == null || String.IsNullOrEmpty(TableSelect.SelectedItem.ToString()))
            {
                MessageBox.Show("您尚未選擇資料表", "Error");
            }
            else
            {
                if (String.IsNullOrEmpty(ClassName.Text))
                {
                    MessageBox.Show("您的類別名稱不能為空", "Error");
                }
                else
                {
                    param.Table_Name = TableSelect.SelectedItem.ToString().Split('-')[1];
                    param.ClassName = ClassName.Text;
                    param.NameSpace = NameSpace.Text;
                    String error = "";
                    ModelHalper.SQLT4.ModelT4 mod = new ModelHalper.SQLT4.ModelT4(param, ref error);
                    outputTxt.Text = mod.TransformText();
                }
            }

        }
        /// <summary>
        /// 選擇輸出路徑事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ForderSelect_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog path = new FolderBrowserDialog();
            path.SelectedPath = (String.IsNullOrEmpty(OutPath.Text)) ? @"C:\" : OutPath.Text;
            path.ShowDialog();
            OutPath.Text = path.SelectedPath;

        }
        /// <summary>
        /// 輸出class 事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OutClass_Click(object sender, EventArgs e)
        {
            bool IsOK = true;
            String FileName = FileTitle.Text + FileTail.Text;
            if (String.IsNullOrEmpty(FileName))
            {
                IsOK = false;
                MessageBox.Show("檔案名稱不可為空", "Error");
            }
            if (FileName.IndexOf('.') == -1)
            {
                IsOK = false;
                MessageBox.Show("檔尾未偵測到您的副檔名", "Error");
            }
            if (String.IsNullOrEmpty(OutPath.Text))
            {
                IsOK = false;
                MessageBox.Show("您尚未選擇輸出路徑", "Error");
            }
            if (IsOK)
            {
                param.FilePath = OutPath.Text;
                SimpleStream stream = new SimpleStream();
                stream.Save(param.FilePath + "\\" + FileName, outputTxt.Text);
                MessageBox.Show("以輸出到:" + param.FilePath + "\\" + FileName, "Success");
            }
        }
        /// <summary>
        /// 讓檔名開頭等於類別名稱的事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void IsSameClassName_CheckedChanged(object sender, EventArgs e)
        {
            if (IsSameClassName.Checked)
            {
                FileTitle.Text = ClassName.Text;
                FileTitle.Enabled = false;
            }
            else
            {
                FileTitle.Enabled = true;
            }
        }
        /// <summary>
        /// 當類別名稱修改時同時改黨頭
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ClassName_TextChanged(object sender, EventArgs e)
        {
            if (IsSameClassName.Checked)
            {
                FileTitle.Text = ClassName.Text;
            }
        }
        /// <summary>
        /// 儲存設定按鈕事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SaveConn_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(ConnName.Text))
            {
                MessageBox.Show("您的名稱不能為空", "Error");
            }
            else
            {
                if (DbSelect.SelectedItem == null || String.IsNullOrEmpty(DbSelect.SelectedItem.ToString()))
                {
                    MessageBox.Show("您尚未選擇資料庫型態", "Error");
                }
                else
                {
                    if (String.IsNullOrEmpty(ConnStr.Text))
                    {
                        MessageBox.Show("您沒有輸入資料庫連線字串", "Error");
                    }
                    else
                    {
                        SimpleStream sim = new SimpleStream();

                        if (sim.IsFileExist(SettingPath))
                        {
                            var val = sim.LoadSetting(SettingPath);
                            var num = val.FindIndex(x => x.Name == ConnName.Text);
                            if (num != -1)
                            {
                                val[num] = new DbModel
                                {
                                    ConnString = ConnStr.Text,
                                    DbType = DbSelect.SelectedItem.ToString(),
                                    Name = ConnName.Text
                                };
                            }
                            else
                            {
                                val.Add(new DbModel
                                {
                                    ConnString = ConnStr.Text,
                                    DbType = DbSelect.SelectedItem.ToString(),
                                    Name = ConnName.Text
                                });
                            }
                            String saveJson = JsonConvert.SerializeObject(val);
                            sim.Save(SettingPath, saveJson);
                        }
                        else
                        {
                            List<DbModel> com = new List<DbModel>();
                            com.Add(new DbModel
                            {
                                ConnString = ConnStr.Text,
                                DbType = DbSelect.SelectedItem.ToString(),
                                Name = ConnName.Text
                            });
                            String saveJson = JsonConvert.SerializeObject(com);
                            sim.Save(SettingPath, saveJson);
                        }
                        ShowSetting();
                        MessageBox.Show("以新增到設定上", "Success");

                    }
                }
            }
        }
        /// <summary>
        /// 秀出設定清單
        /// </summary>
        public void ShowSetting()
        {
            SettingSelect.Items.Clear();
            SimpleStream sim = new SimpleStream();
            if (sim.IsFileExist(SettingPath))
            {
                try
                {
                    var val = sim.LoadSetting(SettingPath);
                    foreach (var v in val)
                    {
                        SettingSelect.Items.Add(v.Name + '-' + v.DbType);
                    }
                }
                catch (Exception exp) {
                    MessageBox.Show("您的設定檔有誤請修正或刪除DbSetting.json", "Error");
                }
                
            }
        }
        /// <summary>
        /// 設定選單切換
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SettingSelect_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (SettingSelect.SelectedItem != null && !String.IsNullOrEmpty(SettingSelect.SelectedItem.ToString())) {
                SimpleStream sim = new SimpleStream();
                var val = sim.LoadSetting(SettingPath);
                var name = SettingSelect.SelectedItem.ToString().Split('-')[0];
                var dbmod = val.Where(t => t.Name == name).ToList()[0];
                ConnStr.Text = dbmod.ConnString;
                DbSelect.SelectedItem = dbmod.DbType;
            }
        }
    }
    
}