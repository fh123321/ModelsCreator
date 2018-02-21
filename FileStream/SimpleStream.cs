using Newtonsoft.Json;
using System;
using System.IO;
using ModelHalper.Model;
using System.Collections.Generic;

namespace ModelHalper.FileStream
{
    public class SimpleStream
    {
        public Boolean IsFileExist(String FilePath) {
            if (System.IO.File.Exists(FilePath))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        /// <summary>
        /// 讀取JSON 設定檔事件
        /// </summary>
        /// <param name="FilePath">JSON 檔案路徑</param>
        /// <returns></returns>
        public List<DbModel> LoadSetting(String FilePath)
        {
            List<DbModel> comm = null;
            using (StreamReader r = new StreamReader(FilePath))
            {
                try
                {
                    string json = r.ReadToEnd();
                    comm = JsonConvert.DeserializeObject<List<DbModel>>(json);
                }
                catch (Exception exp) {
                    throw exp;
                }
            }
            return comm;
        }
        /// <summary>
        /// 儲存文字檔案事件 回傳true 成功 false 失敗
        /// </summary>
        /// <param name="FilePath">檔案路徑</param>
        /// <param name="Text">檔案內容</param>
        /// <returns></returns>
        public bool Save(String FilePath, String Text)
        {
            try
            {
                using (StreamWriter r = new StreamWriter(FilePath, false))
                {
                    r.Write(Text);
                }
            }
            catch (Exception exp)
            {
                return false;
            }
            return true;

        }

    }
}
