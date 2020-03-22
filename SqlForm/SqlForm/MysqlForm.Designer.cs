namespace SqlForm
{
    partial class MysqlForm
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.ConnBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pwdInput = new System.Windows.Forms.TextBox();
            this.dataSourceInput = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.userInput = new System.Windows.Forms.TextBox();
            this.portInput = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dataView = new System.Windows.Forms.DataGridView();
            this.panel3 = new System.Windows.Forms.Panel();
            this.EndUpdateBtn = new System.Windows.Forms.Button();
            this.BeginUpdateBtn = new System.Windows.Forms.Button();
            this.EndAddBtn = new System.Windows.Forms.Button();
            this.DelBtn = new System.Windows.Forms.Button();
            this.AddBtn = new System.Windows.Forms.Button();
            this.DataSourceLabel = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.PortLabel = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.UserLabel = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.PassWordLabel = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.DataTable = new System.Windows.Forms.ComboBox();
            this.DataBase = new System.Windows.Forms.ComboBox();
            this.DataPanel = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataView)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.DataPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.ConnBtn);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pwdInput);
            this.panel1.Controls.Add(this.dataSourceInput);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.userInput);
            this.panel1.Controls.Add(this.portInput);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(244, 803);
            this.panel1.TabIndex = 0;
            // 
            // ConnBtn
            // 
            this.ConnBtn.Location = new System.Drawing.Point(26, 477);
            this.ConnBtn.Name = "ConnBtn";
            this.ConnBtn.Size = new System.Drawing.Size(185, 43);
            this.ConnBtn.TabIndex = 8;
            this.ConnBtn.Text = "连接";
            this.ConnBtn.UseVisualStyleBackColor = true;
            this.ConnBtn.Click += new System.EventHandler(this.ConnBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(3, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(154, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "DataSource：";
            // 
            // pwdInput
            // 
            this.pwdInput.Location = new System.Drawing.Point(7, 368);
            this.pwdInput.Name = "pwdInput";
            this.pwdInput.PasswordChar = '*';
            this.pwdInput.Size = new System.Drawing.Size(231, 25);
            this.pwdInput.TabIndex = 7;
            this.pwdInput.Text = "123456";
            // 
            // dataSourceInput
            // 
            this.dataSourceInput.Location = new System.Drawing.Point(7, 53);
            this.dataSourceInput.Name = "dataSourceInput";
            this.dataSourceInput.Size = new System.Drawing.Size(231, 25);
            this.dataSourceInput.TabIndex = 1;
            this.dataSourceInput.Text = "127.0.0.1";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("宋体", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(3, 341);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 24);
            this.label4.TabIndex = 6;
            this.label4.Text = "Pwd：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(3, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 24);
            this.label2.TabIndex = 2;
            this.label2.Text = "Port：";
            // 
            // userInput
            // 
            this.userInput.Location = new System.Drawing.Point(7, 254);
            this.userInput.Name = "userInput";
            this.userInput.Size = new System.Drawing.Size(231, 25);
            this.userInput.TabIndex = 5;
            this.userInput.Text = "root";
            // 
            // portInput
            // 
            this.portInput.Location = new System.Drawing.Point(7, 144);
            this.portInput.Name = "portInput";
            this.portInput.Size = new System.Drawing.Size(231, 25);
            this.portInput.TabIndex = 3;
            this.portInput.Text = "3306";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("宋体", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(3, 218);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 24);
            this.label3.TabIndex = 4;
            this.label3.Text = "User：";
            // 
            // dataView
            // 
            this.dataView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataView.Location = new System.Drawing.Point(0, 0);
            this.dataView.Name = "dataView";
            this.dataView.RowHeadersWidth = 51;
            this.dataView.RowTemplate.Height = 27;
            this.dataView.Size = new System.Drawing.Size(1263, 710);
            this.dataView.TabIndex = 2;
            this.dataView.CellBeginEdit += new System.Windows.Forms.DataGridViewCellCancelEventHandler(this.dataView_CellBeginEdit);
            this.dataView.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataView_CellEndEdit);
            this.dataView.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataView_CellValueChanged);
            this.dataView.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dataView_DataError);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.EndUpdateBtn);
            this.panel3.Controls.Add(this.BeginUpdateBtn);
            this.panel3.Controls.Add(this.EndAddBtn);
            this.panel3.Controls.Add(this.DelBtn);
            this.panel3.Controls.Add(this.AddBtn);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(244, 760);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1263, 43);
            this.panel3.TabIndex = 3;
            // 
            // EndUpdateBtn
            // 
            this.EndUpdateBtn.Location = new System.Drawing.Point(387, 6);
            this.EndUpdateBtn.Name = "EndUpdateBtn";
            this.EndUpdateBtn.Size = new System.Drawing.Size(82, 32);
            this.EndUpdateBtn.TabIndex = 5;
            this.EndUpdateBtn.Text = "结束更新";
            this.EndUpdateBtn.UseVisualStyleBackColor = true;
            this.EndUpdateBtn.Click += new System.EventHandler(this.EndUpdateBtn_Click);
            // 
            // BeginUpdateBtn
            // 
            this.BeginUpdateBtn.Location = new System.Drawing.Point(299, 6);
            this.BeginUpdateBtn.Name = "BeginUpdateBtn";
            this.BeginUpdateBtn.Size = new System.Drawing.Size(82, 32);
            this.BeginUpdateBtn.TabIndex = 4;
            this.BeginUpdateBtn.Text = "开始更新";
            this.BeginUpdateBtn.UseVisualStyleBackColor = true;
            this.BeginUpdateBtn.Click += new System.EventHandler(this.BeginUpdateBtn_Click);
            // 
            // EndAddBtn
            // 
            this.EndAddBtn.Location = new System.Drawing.Point(116, 6);
            this.EndAddBtn.Name = "EndAddBtn";
            this.EndAddBtn.Size = new System.Drawing.Size(85, 32);
            this.EndAddBtn.TabIndex = 3;
            this.EndAddBtn.Text = "结束添加";
            this.EndAddBtn.UseVisualStyleBackColor = true;
            this.EndAddBtn.Click += new System.EventHandler(this.EndAddBtn_Click);
            // 
            // DelBtn
            // 
            this.DelBtn.Location = new System.Drawing.Point(207, 6);
            this.DelBtn.Name = "DelBtn";
            this.DelBtn.Size = new System.Drawing.Size(86, 32);
            this.DelBtn.TabIndex = 1;
            this.DelBtn.Text = "删除";
            this.DelBtn.UseVisualStyleBackColor = true;
            this.DelBtn.Click += new System.EventHandler(this.DelBtn_Click);
            // 
            // AddBtn
            // 
            this.AddBtn.Location = new System.Drawing.Point(19, 6);
            this.AddBtn.Name = "AddBtn";
            this.AddBtn.Size = new System.Drawing.Size(91, 32);
            this.AddBtn.TabIndex = 0;
            this.AddBtn.Text = "开始添加";
            this.AddBtn.UseVisualStyleBackColor = true;
            this.AddBtn.Click += new System.EventHandler(this.AddBtn_Click);
            // 
            // DataSourceLabel
            // 
            this.DataSourceLabel.AutoSize = true;
            this.DataSourceLabel.Location = new System.Drawing.Point(13, 48);
            this.DataSourceLabel.Name = "DataSourceLabel";
            this.DataSourceLabel.Size = new System.Drawing.Size(95, 15);
            this.DataSourceLabel.TabIndex = 0;
            this.DataSourceLabel.Text = "DataSource:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(114, 45);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 25);
            this.textBox1.TabIndex = 1;
            // 
            // PortLabel
            // 
            this.PortLabel.AutoSize = true;
            this.PortLabel.Location = new System.Drawing.Point(234, 48);
            this.PortLabel.Name = "PortLabel";
            this.PortLabel.Size = new System.Drawing.Size(54, 15);
            this.PortLabel.TabIndex = 2;
            this.PortLabel.Text = "Port：";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(284, 44);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 25);
            this.textBox2.TabIndex = 3;
            // 
            // UserLabel
            // 
            this.UserLabel.AutoSize = true;
            this.UserLabel.Location = new System.Drawing.Point(403, 48);
            this.UserLabel.Name = "UserLabel";
            this.UserLabel.Size = new System.Drawing.Size(54, 15);
            this.UserLabel.TabIndex = 4;
            this.UserLabel.Text = "user：";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(454, 44);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 25);
            this.textBox3.TabIndex = 5;
            // 
            // PassWordLabel
            // 
            this.PassWordLabel.AutoSize = true;
            this.PassWordLabel.Location = new System.Drawing.Point(574, 48);
            this.PassWordLabel.Name = "PassWordLabel";
            this.PassWordLabel.Size = new System.Drawing.Size(46, 15);
            this.PassWordLabel.TabIndex = 6;
            this.PassWordLabel.Text = "pwd：";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(612, 44);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 25);
            this.textBox4.TabIndex = 7;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.DataTable);
            this.panel2.Controls.Add(this.DataBase);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(244, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1263, 50);
            this.panel2.TabIndex = 4;
            // 
            // DataTable
            // 
            this.DataTable.FormattingEnabled = true;
            this.DataTable.Location = new System.Drawing.Point(218, 12);
            this.DataTable.Name = "DataTable";
            this.DataTable.Size = new System.Drawing.Size(121, 23);
            this.DataTable.TabIndex = 1;
            this.DataTable.Text = "选择表";
            this.DataTable.SelectedIndexChanged += new System.EventHandler(this.DataTable_SelectedIndexChanged);
            // 
            // DataBase
            // 
            this.DataBase.FormattingEnabled = true;
            this.DataBase.Location = new System.Drawing.Point(52, 13);
            this.DataBase.Name = "DataBase";
            this.DataBase.Size = new System.Drawing.Size(121, 23);
            this.DataBase.TabIndex = 0;
            this.DataBase.Text = "选择数据库";
            this.DataBase.SelectedIndexChanged += new System.EventHandler(this.DataBase_SelectedIndexChanged);
            // 
            // DataPanel
            // 
            this.DataPanel.Controls.Add(this.dataView);
            this.DataPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DataPanel.Location = new System.Drawing.Point(244, 50);
            this.DataPanel.Name = "DataPanel";
            this.DataPanel.Size = new System.Drawing.Size(1263, 710);
            this.DataPanel.TabIndex = 5;
            // 
            // MysqlForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1507, 803);
            this.Controls.Add(this.DataPanel);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MysqlForm";
            this.Text = "MysqlForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataView)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.DataPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataView;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button DelBtn;
        private System.Windows.Forms.Button AddBtn;
        private System.Windows.Forms.Label DataSourceLabel;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label PortLabel;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label PassWordLabel;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label UserLabel;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel DataPanel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox dataSourceInput;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox portInput;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox userInput;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox pwdInput;
        private System.Windows.Forms.Button ConnBtn;
        private System.Windows.Forms.ComboBox DataTable;
        private System.Windows.Forms.ComboBox DataBase;
        private System.Windows.Forms.Button BeginUpdateBtn;
        private System.Windows.Forms.Button EndAddBtn;
        private System.Windows.Forms.Button EndUpdateBtn;
    }
}

