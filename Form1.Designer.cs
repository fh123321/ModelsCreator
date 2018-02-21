namespace ModelHalper
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置 Managed 資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.txt01 = new System.Windows.Forms.Label();
            this.txt02 = new System.Windows.Forms.Label();
            this.txt03 = new System.Windows.Forms.Label();
            this.txt04 = new System.Windows.Forms.Label();
            this.txtConnError = new System.Windows.Forms.Label();
            this.txt05 = new System.Windows.Forms.Label();
            this.txt06 = new System.Windows.Forms.Label();
            this.ConnStr = new System.Windows.Forms.TextBox();
            this.TableSelect = new System.Windows.Forms.ComboBox();
            this.DbSelect = new System.Windows.Forms.ComboBox();
            this.Connect = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tablesearch = new System.Windows.Forms.Button();
            this.TableName = new System.Windows.Forms.TextBox();
            this.txt12 = new System.Windows.Forms.Label();
            this.Owner = new System.Windows.Forms.TextBox();
            this.txt11 = new System.Windows.Forms.Label();
            this.CrtClass = new System.Windows.Forms.Button();
            this.NameSpace = new System.Windows.Forms.TextBox();
            this.txt07 = new System.Windows.Forms.Label();
            this.ClassName = new System.Windows.Forms.TextBox();
            this.outputTxt = new System.Windows.Forms.TextBox();
            this.OutPath = new System.Windows.Forms.TextBox();
            this.txt08 = new System.Windows.Forms.Label();
            this.txt09 = new System.Windows.Forms.Label();
            this.FileTitle = new System.Windows.Forms.TextBox();
            this.IsSameClassName = new System.Windows.Forms.CheckBox();
            this.txt10 = new System.Windows.Forms.Label();
            this.FileTail = new System.Windows.Forms.TextBox();
            this.OutClass = new System.Windows.Forms.Button();
            this.DisConnect = new System.Windows.Forms.Button();
            this.ForderSelect = new System.Windows.Forms.Button();
            this.txt13 = new System.Windows.Forms.Label();
            this.SettingSelect = new System.Windows.Forms.ComboBox();
            this.txt14 = new System.Windows.Forms.Label();
            this.ConnName = new System.Windows.Forms.TextBox();
            this.SaveConn = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txt01
            // 
            this.txt01.AutoSize = true;
            this.txt01.Location = new System.Drawing.Point(17, 24);
            this.txt01.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.txt01.Name = "txt01";
            this.txt01.Size = new System.Drawing.Size(85, 18);
            this.txt01.TabIndex = 1;
            this.txt01.Text = "連線字串:";
            // 
            // txt02
            // 
            this.txt02.AutoSize = true;
            this.txt02.Location = new System.Drawing.Point(4, 57);
            this.txt02.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.txt02.Name = "txt02";
            this.txt02.Size = new System.Drawing.Size(103, 18);
            this.txt02.TabIndex = 2;
            this.txt02.Text = "資料庫表單:";
            // 
            // txt03
            // 
            this.txt03.AutoSize = true;
            this.txt03.Location = new System.Drawing.Point(538, 27);
            this.txt03.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.txt03.Name = "txt03";
            this.txt03.Size = new System.Drawing.Size(103, 18);
            this.txt03.TabIndex = 3;
            this.txt03.Text = "資料庫類別:";
            // 
            // txt04
            // 
            this.txt04.AutoSize = true;
            this.txt04.Location = new System.Drawing.Point(13, 113);
            this.txt04.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.txt04.Name = "txt04";
            this.txt04.Size = new System.Drawing.Size(72, 18);
            this.txt04.TabIndex = 4;
            this.txt04.Text = "DB資訊:";
            // 
            // txtConnError
            // 
            this.txtConnError.AutoSize = true;
            this.txtConnError.Location = new System.Drawing.Point(94, 113);
            this.txtConnError.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.txtConnError.Name = "txtConnError";
            this.txtConnError.Size = new System.Drawing.Size(0, 18);
            this.txtConnError.TabIndex = 5;
            // 
            // txt05
            // 
            this.txt05.AutoSize = true;
            this.txt05.Location = new System.Drawing.Point(29, 572);
            this.txt05.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.txt05.Name = "txt05";
            this.txt05.Size = new System.Drawing.Size(85, 18);
            this.txt05.TabIndex = 6;
            this.txt05.Text = "匯出位置:";
            // 
            // txt06
            // 
            this.txt06.AutoSize = true;
            this.txt06.Location = new System.Drawing.Point(304, 57);
            this.txt06.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.txt06.Name = "txt06";
            this.txt06.Size = new System.Drawing.Size(85, 18);
            this.txt06.TabIndex = 7;
            this.txt06.Text = "類別名稱:";
            // 
            // ConnStr
            // 
            this.ConnStr.Location = new System.Drawing.Point(110, 21);
            this.ConnStr.Margin = new System.Windows.Forms.Padding(4);
            this.ConnStr.Name = "ConnStr";
            this.ConnStr.Size = new System.Drawing.Size(420, 29);
            this.ConnStr.TabIndex = 8;
            // 
            // TableSelect
            // 
            this.TableSelect.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.TableSelect.FormattingEnabled = true;
            this.TableSelect.Location = new System.Drawing.Point(110, 52);
            this.TableSelect.Margin = new System.Windows.Forms.Padding(4);
            this.TableSelect.Name = "TableSelect";
            this.TableSelect.Size = new System.Drawing.Size(180, 26);
            this.TableSelect.TabIndex = 9;
            // 
            // DbSelect
            // 
            this.DbSelect.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.DbSelect.FormattingEnabled = true;
            this.DbSelect.Items.AddRange(new object[] {
            "",
            "Oracle",
            "SqlServer"});
            this.DbSelect.Location = new System.Drawing.Point(639, 24);
            this.DbSelect.Margin = new System.Windows.Forms.Padding(4);
            this.DbSelect.Name = "DbSelect";
            this.DbSelect.Size = new System.Drawing.Size(180, 26);
            this.DbSelect.TabIndex = 10;
            // 
            // Connect
            // 
            this.Connect.Location = new System.Drawing.Point(844, 24);
            this.Connect.Margin = new System.Windows.Forms.Padding(4);
            this.Connect.Name = "Connect";
            this.Connect.Size = new System.Drawing.Size(88, 34);
            this.Connect.TabIndex = 11;
            this.Connect.Text = "連線";
            this.Connect.UseVisualStyleBackColor = true;
            this.Connect.Click += new System.EventHandler(this.Connect_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.tablesearch);
            this.panel1.Controls.Add(this.TableName);
            this.panel1.Controls.Add(this.txt12);
            this.panel1.Controls.Add(this.Owner);
            this.panel1.Controls.Add(this.txt11);
            this.panel1.Controls.Add(this.CrtClass);
            this.panel1.Controls.Add(this.NameSpace);
            this.panel1.Controls.Add(this.txt07);
            this.panel1.Controls.Add(this.ClassName);
            this.panel1.Controls.Add(this.txt06);
            this.panel1.Controls.Add(this.outputTxt);
            this.panel1.Controls.Add(this.TableSelect);
            this.panel1.Controls.Add(this.txt02);
            this.panel1.Location = new System.Drawing.Point(13, 149);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1054, 396);
            this.panel1.TabIndex = 12;
            // 
            // tablesearch
            // 
            this.tablesearch.Enabled = false;
            this.tablesearch.Location = new System.Drawing.Point(813, 8);
            this.tablesearch.Margin = new System.Windows.Forms.Padding(4);
            this.tablesearch.Name = "tablesearch";
            this.tablesearch.Size = new System.Drawing.Size(136, 34);
            this.tablesearch.TabIndex = 26;
            this.tablesearch.Text = "搜尋";
            this.tablesearch.UseVisualStyleBackColor = true;
            this.tablesearch.Click += new System.EventHandler(this.tablesearch_Click);
            // 
            // TableName
            // 
            this.TableName.Location = new System.Drawing.Point(626, 8);
            this.TableName.Margin = new System.Windows.Forms.Padding(4);
            this.TableName.Name = "TableName";
            this.TableName.Size = new System.Drawing.Size(148, 29);
            this.TableName.TabIndex = 25;
            // 
            // txt12
            // 
            this.txt12.AutoSize = true;
            this.txt12.Location = new System.Drawing.Point(501, 12);
            this.txt12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.txt12.Name = "txt12";
            this.txt12.Size = new System.Drawing.Size(93, 18);
            this.txt12.TabIndex = 24;
            this.txt12.Text = "TableName:";
            // 
            // Owner
            // 
            this.Owner.Location = new System.Drawing.Point(326, 8);
            this.Owner.Margin = new System.Windows.Forms.Padding(4);
            this.Owner.Name = "Owner";
            this.Owner.Size = new System.Drawing.Size(148, 29);
            this.Owner.TabIndex = 23;
            // 
            // txt11
            // 
            this.txt11.AutoSize = true;
            this.txt11.Location = new System.Drawing.Point(51, 12);
            this.txt11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.txt11.Name = "txt11";
            this.txt11.Size = new System.Drawing.Size(267, 18);
            this.txt11.TabIndex = 22;
            this.txt11.Text = "擁有者(Owner or DataBase Name) :";
            // 
            // CrtClass
            // 
            this.CrtClass.Enabled = false;
            this.CrtClass.Location = new System.Drawing.Point(902, 48);
            this.CrtClass.Margin = new System.Windows.Forms.Padding(4);
            this.CrtClass.Name = "CrtClass";
            this.CrtClass.Size = new System.Drawing.Size(136, 34);
            this.CrtClass.TabIndex = 13;
            this.CrtClass.Text = "產生類別";
            this.CrtClass.UseVisualStyleBackColor = true;
            this.CrtClass.Click += new System.EventHandler(this.CrtClass_Click);
            // 
            // NameSpace
            // 
            this.NameSpace.Location = new System.Drawing.Point(696, 50);
            this.NameSpace.Margin = new System.Windows.Forms.Padding(4);
            this.NameSpace.Name = "NameSpace";
            this.NameSpace.Size = new System.Drawing.Size(194, 29);
            this.NameSpace.TabIndex = 14;
            // 
            // txt07
            // 
            this.txt07.AutoSize = true;
            this.txt07.Location = new System.Drawing.Point(603, 57);
            this.txt07.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.txt07.Name = "txt07";
            this.txt07.Size = new System.Drawing.Size(85, 18);
            this.txt07.TabIndex = 14;
            this.txt07.Text = "命名空間:";
            // 
            // ClassName
            // 
            this.ClassName.Location = new System.Drawing.Point(398, 52);
            this.ClassName.Margin = new System.Windows.Forms.Padding(4);
            this.ClassName.Name = "ClassName";
            this.ClassName.Size = new System.Drawing.Size(194, 29);
            this.ClassName.TabIndex = 13;
            this.ClassName.TextChanged += new System.EventHandler(this.ClassName_TextChanged);
            // 
            // outputTxt
            // 
            this.outputTxt.Location = new System.Drawing.Point(7, 99);
            this.outputTxt.Margin = new System.Windows.Forms.Padding(4);
            this.outputTxt.Multiline = true;
            this.outputTxt.Name = "outputTxt";
            this.outputTxt.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.outputTxt.Size = new System.Drawing.Size(1030, 284);
            this.outputTxt.TabIndex = 0;
            // 
            // OutPath
            // 
            this.OutPath.Enabled = false;
            this.OutPath.Location = new System.Drawing.Point(123, 567);
            this.OutPath.Margin = new System.Windows.Forms.Padding(4);
            this.OutPath.Name = "OutPath";
            this.OutPath.Size = new System.Drawing.Size(505, 29);
            this.OutPath.TabIndex = 13;
            // 
            // txt08
            // 
            this.txt08.AutoSize = true;
            this.txt08.Location = new System.Drawing.Point(29, 613);
            this.txt08.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.txt08.Name = "txt08";
            this.txt08.Size = new System.Drawing.Size(246, 18);
            this.txt08.TabIndex = 14;
            this.txt08.Text = "檔名(表頭名稱+固定表尾名稱)";
            // 
            // txt09
            // 
            this.txt09.AutoSize = true;
            this.txt09.Location = new System.Drawing.Point(47, 655);
            this.txt09.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.txt09.Name = "txt09";
            this.txt09.Size = new System.Drawing.Size(121, 18);
            this.txt09.TabIndex = 15;
            this.txt09.Text = "檔案開頭名稱:";
            // 
            // FileTitle
            // 
            this.FileTitle.Location = new System.Drawing.Point(177, 650);
            this.FileTitle.Margin = new System.Windows.Forms.Padding(4);
            this.FileTitle.Name = "FileTitle";
            this.FileTitle.Size = new System.Drawing.Size(148, 29);
            this.FileTitle.TabIndex = 16;
            // 
            // IsSameClassName
            // 
            this.IsSameClassName.AutoSize = true;
            this.IsSameClassName.Location = new System.Drawing.Point(339, 655);
            this.IsSameClassName.Margin = new System.Windows.Forms.Padding(4);
            this.IsSameClassName.Name = "IsSameClassName";
            this.IsSameClassName.Size = new System.Drawing.Size(124, 22);
            this.IsSameClassName.TabIndex = 17;
            this.IsSameClassName.Text = "同類別名稱";
            this.IsSameClassName.UseVisualStyleBackColor = true;
            this.IsSameClassName.CheckedChanged += new System.EventHandler(this.IsSameClassName_CheckedChanged);
            // 
            // txt10
            // 
            this.txt10.AutoSize = true;
            this.txt10.Location = new System.Drawing.Point(521, 655);
            this.txt10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.txt10.Name = "txt10";
            this.txt10.Size = new System.Drawing.Size(85, 18);
            this.txt10.TabIndex = 18;
            this.txt10.Text = "表尾名稱:";
            // 
            // FileTail
            // 
            this.FileTail.Location = new System.Drawing.Point(615, 650);
            this.FileTail.Margin = new System.Windows.Forms.Padding(4);
            this.FileTail.Name = "FileTail";
            this.FileTail.Size = new System.Drawing.Size(148, 29);
            this.FileTail.TabIndex = 19;
            this.FileTail.Text = "Model.cs";
            // 
            // OutClass
            // 
            this.OutClass.Enabled = false;
            this.OutClass.Location = new System.Drawing.Point(826, 644);
            this.OutClass.Margin = new System.Windows.Forms.Padding(4);
            this.OutClass.Name = "OutClass";
            this.OutClass.Size = new System.Drawing.Size(152, 33);
            this.OutClass.TabIndex = 20;
            this.OutClass.Text = "輸出";
            this.OutClass.UseVisualStyleBackColor = true;
            this.OutClass.Click += new System.EventHandler(this.OutClass_Click);
            // 
            // DisConnect
            // 
            this.DisConnect.Enabled = false;
            this.DisConnect.Location = new System.Drawing.Point(951, 24);
            this.DisConnect.Margin = new System.Windows.Forms.Padding(4);
            this.DisConnect.Name = "DisConnect";
            this.DisConnect.Size = new System.Drawing.Size(116, 34);
            this.DisConnect.TabIndex = 21;
            this.DisConnect.Text = "中斷連線";
            this.DisConnect.UseVisualStyleBackColor = true;
            this.DisConnect.Click += new System.EventHandler(this.DisConnect_Click);
            // 
            // ForderSelect
            // 
            this.ForderSelect.Location = new System.Drawing.Point(639, 567);
            this.ForderSelect.Margin = new System.Windows.Forms.Padding(4);
            this.ForderSelect.Name = "ForderSelect";
            this.ForderSelect.Size = new System.Drawing.Size(152, 33);
            this.ForderSelect.TabIndex = 22;
            this.ForderSelect.Text = "選擇料夾";
            this.ForderSelect.UseVisualStyleBackColor = true;
            this.ForderSelect.Click += new System.EventHandler(this.ForderSelect_Click);
            // 
            // txt13
            // 
            this.txt13.AutoSize = true;
            this.txt13.Location = new System.Drawing.Point(461, 70);
            this.txt13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.txt13.Name = "txt13";
            this.txt13.Size = new System.Drawing.Size(121, 18);
            this.txt13.TabIndex = 27;
            this.txt13.Text = "選擇連線資料:";
            // 
            // SettingSelect
            // 
            this.SettingSelect.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.SettingSelect.FormattingEnabled = true;
            this.SettingSelect.Location = new System.Drawing.Point(590, 65);
            this.SettingSelect.Margin = new System.Windows.Forms.Padding(4);
            this.SettingSelect.Name = "SettingSelect";
            this.SettingSelect.Size = new System.Drawing.Size(231, 26);
            this.SettingSelect.TabIndex = 28;
            this.SettingSelect.SelectedIndexChanged += new System.EventHandler(this.SettingSelect_SelectedIndexChanged);
            // 
            // txt14
            // 
            this.txt14.AutoSize = true;
            this.txt14.Location = new System.Drawing.Point(13, 70);
            this.txt14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.txt14.Name = "txt14";
            this.txt14.Size = new System.Drawing.Size(85, 18);
            this.txt14.TabIndex = 29;
            this.txt14.Text = "連線名稱:";
            // 
            // ConnName
            // 
            this.ConnName.Location = new System.Drawing.Point(110, 65);
            this.ConnName.Margin = new System.Windows.Forms.Padding(4);
            this.ConnName.Name = "ConnName";
            this.ConnName.Size = new System.Drawing.Size(206, 29);
            this.ConnName.TabIndex = 30;
            // 
            // SaveConn
            // 
            this.SaveConn.Location = new System.Drawing.Point(324, 62);
            this.SaveConn.Margin = new System.Windows.Forms.Padding(4);
            this.SaveConn.Name = "SaveConn";
            this.SaveConn.Size = new System.Drawing.Size(129, 34);
            this.SaveConn.TabIndex = 31;
            this.SaveConn.Text = "儲存目前連線";
            this.SaveConn.UseVisualStyleBackColor = true;
            this.SaveConn.Click += new System.EventHandler(this.SaveConn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1098, 699);
            this.Controls.Add(this.SaveConn);
            this.Controls.Add(this.ConnName);
            this.Controls.Add(this.txt14);
            this.Controls.Add(this.SettingSelect);
            this.Controls.Add(this.txt13);
            this.Controls.Add(this.ForderSelect);
            this.Controls.Add(this.DisConnect);
            this.Controls.Add(this.OutClass);
            this.Controls.Add(this.FileTail);
            this.Controls.Add(this.txt10);
            this.Controls.Add(this.IsSameClassName);
            this.Controls.Add(this.FileTitle);
            this.Controls.Add(this.txt09);
            this.Controls.Add(this.txt08);
            this.Controls.Add(this.OutPath);
            this.Controls.Add(this.txt05);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txtConnError);
            this.Controls.Add(this.txt04);
            this.Controls.Add(this.Connect);
            this.Controls.Add(this.DbSelect);
            this.Controls.Add(this.ConnStr);
            this.Controls.Add(this.txt03);
            this.Controls.Add(this.txt01);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "ModelHelper";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label txt01;
        private System.Windows.Forms.Label txt02;
        private System.Windows.Forms.Label txt03;
        private System.Windows.Forms.Label txt04;
        private System.Windows.Forms.Label txtConnError;
        private System.Windows.Forms.Label txt05;
        private System.Windows.Forms.Label txt06;
        private System.Windows.Forms.TextBox ConnStr;
        private System.Windows.Forms.ComboBox TableSelect;
        private System.Windows.Forms.ComboBox DbSelect;
        private System.Windows.Forms.Button Connect;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox outputTxt;
        private System.Windows.Forms.TextBox ClassName;
        private System.Windows.Forms.Button CrtClass;
        private System.Windows.Forms.TextBox NameSpace;
        private System.Windows.Forms.Label txt07;
        private System.Windows.Forms.TextBox OutPath;
        private System.Windows.Forms.Label txt08;
        private System.Windows.Forms.Label txt09;
        private System.Windows.Forms.TextBox FileTitle;
        private System.Windows.Forms.CheckBox IsSameClassName;
        private System.Windows.Forms.Label txt10;
        private System.Windows.Forms.TextBox FileTail;
        private System.Windows.Forms.Button OutClass;
        private System.Windows.Forms.Button DisConnect;
        private System.Windows.Forms.TextBox Owner;
        private System.Windows.Forms.Label txt11;
        private System.Windows.Forms.TextBox TableName;
        private System.Windows.Forms.Label txt12;
        private System.Windows.Forms.Button tablesearch;
        private System.Windows.Forms.Button ForderSelect;
        private System.Windows.Forms.Label txt13;
        private System.Windows.Forms.ComboBox SettingSelect;
        private System.Windows.Forms.Label txt14;
        private System.Windows.Forms.TextBox ConnName;
        private System.Windows.Forms.Button SaveConn;
    }
}


