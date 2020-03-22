using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SqlForm
{
    public partial class MysqlForm : Form
    {
        //当前状态：FREE(空闲)、ADD（添加）、UPDATE（修改）
        private string state = "FREE";
        //当前表的总行数
        private int rows;
        //当前数据库
        private string dbName;
        //当前表
        private string tbName;
        //改变的数据的行号
        private HashSet<int> updateRows;


        public MysqlForm()
        {
            InitializeComponent();
            dataView.AllowUserToAddRows = false;
            updateRows = new HashSet<int>();
        }


        /// <summary>
        /// 连接测试，并更新
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ConnBtn_Click(object sender, EventArgs e)
        {
            string dataSource = dataSourceInput.Text;
            string port = portInput.Text;
            string user = userInput.Text;
            string pwd = pwdInput.Text;

            MysqlUtil.Config(dataSource, port, user, pwd);//配置基本信息
            List<string> dataBases = MysqlUtil.GetDataBases();//获取连接下所有的数据库名

            DataBase.Items.Clear();
            DataBase.Text = "选择数据库";
            DataTable.Text = "选择表";
            foreach (string db in dataBases)
            {
                DataBase.Items.Add(db);
            }
            MessageBox.Show("连接成功！请选择数据库");
        }

        /// <summary>
        /// 当选中某一个数据库时，读取该数据库下的所有表
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DataBase_SelectedIndexChanged(object sender, EventArgs e)
        {
            dbName = DataBase.Text;//选择的数据库的名字
            if (dbName.Equals("选择数据库"))
                return;
            List<string> tables = MysqlUtil.GetTablesByDB(dbName);

            DataTable.Items.Clear();
            DataTable.Text = "选择表";
            foreach (string table in tables)
            {
                DataTable.Items.Add(table);
            }
        }

        /// <summary>
        /// 选中表时，执行查询全部语句
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DataTable_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            dbName = DataBase.Text;//选择的数据库的名字
            tbName = DataTable.Text;//选择的表的名字
            if (tbName.Equals("选择表"))
                return;
            DataTable dt = MysqlUtil.ExecuteAll(dbName, tbName);
            dataView.DataSource = dt;

            rows = dataView.RowCount;
        }


        /// <summary>
        /// 添加数据
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddBtn_Click(object sender, EventArgs e)
        {
            //如果状态不是FREE（空闲），则退出
            if (!state.Equals("FREE"))
                return;

            //允许修改数据
            dataView.AllowUserToAddRows = true;
            //状态修改为添加
            state = "ADD";
        }


        //结束添加
        private void EndAddBtn_Click(object sender, EventArgs e)
        {
            if(dbName.Equals("请选择数据库") || tbName.Equals("选择表"))
            {
                MessageBox.Show("请选择数据库和表");
                return;
            }
            //如果不是添加状态，退出
            if (!state.Equals("ADD"))
                return;
            else
            {
                for (int i = rows; i < dataView.RowCount; i++)
                {
                    List<string> args = new List<string>();//所有的列值
                    for (int j = 0; j < dataView.ColumnCount; j++)
                    {

                        args.Add(Convert.ToString(dataView.Rows[i].Cells[j].Value));
                    }
                    try
                    {
                        //插入
                        MysqlUtil.Insert(dbName, tbName, args);
                        MessageBox.Show("插入成功！");
                    }
                    catch (Exception ee)
                    {
                        MessageBox.Show("插入失败！\n"+ee.Message);
                    }
                    
                }
            }
            state = "FREE";
            DataTable dt = MysqlUtil.ExecuteAll(dbName, tbName);
            dataView.DataSource = dt;
            

            rows = dataView.RowCount;

        }

        /// <summary>
        /// 删除选中数据
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DelBtn_Click(object sender, EventArgs e)
        {
            //弹出删除提示框
            DialogResult dr = MessageBox.Show("你确定要删除一条记录吗？", "确认删除", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (dr == DialogResult.OK)
            {
                dbName = DataBase.Text;//选择的数据库的名字
                tbName = DataTable.Text;//选择的表的名字
                if (dbName.Equals("请选择数据库") || tbName.Equals("选择表"))
                {
                    MessageBox.Show("请选择数据库和表");
                    return;
                }
                string idName = dataView.Columns[0].HeaderText;//主键名
                string id = dataView.CurrentRow.Cells[0].Value.ToString();//主键值
                try {
                    //删除数据
                    MysqlUtil.DelById(dbName, tbName, idName, id);
                }catch(Exception ee)
                {
                    MessageBox.Show(ee.Message);
                }
               
                DataTable dt = MysqlUtil.ExecuteAll(dbName, tbName);
                dataView.DataSource = dt;
                rows = dataView.RowCount;
            }

        }

        /// <summary>
        /// 确认修改，将数据写回数据库
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OKBtn_Click(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// 开始修改时，不准新添加行
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dataView_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            dataView.AllowUserToAddRows = false;

        }


        /// <summary>
        /// 开始更新
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BeginUpdateBtn_Click(object sender, EventArgs e)
        {
            if (dbName.Equals("请选择数据库") || tbName.Equals("选择表"))
            {
                MessageBox.Show("请选择数据库和表");
                return;
            }
            if (!state.Equals("FREE"))
                MessageBox.Show("当前状态为" + state + "，不能更新！！！");
            else
            {
                DialogResult dr = MessageBox.Show("你确定要进入更新状态吗？", "确认更新", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if(dr == DialogResult.OK)
                    state = "UPDATE";
            }
                
        }


        /// <summary>
        /// 单元格改变后变成其他颜色
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dataView_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            
        }




        private void EndUpdateBtn_Click(object sender, EventArgs e)
        {
            if (dbName.Equals("请选择数据库") || tbName.Equals("选择表"))
            {
                MessageBox.Show("请选择数据库和表");
                return;
            }
            if (!state.Equals("UPDATE"))
                return;
            else
            {
                //将修改的行进行更新
                foreach (int i in updateRows)
                {
                    List<string> args = new List<string>();//所有的列值
                    for (int j = 0; j < dataView.ColumnCount; j++)
                    {
                        args.Add(Convert.ToString(dataView.Rows[i].Cells[j].Value));
                    }
                    try
                    {
                        MysqlUtil.Update(dbName, tbName, args);
                        MessageBox.Show("更新成功！");
                    }
                    catch(Exception ee)
                    {
                        MessageBox.Show("更新失败！"+ee.Message);
                    }
                    
                }
                updateRows.Clear();
                state = "FREE";
                DataTable dt = MysqlUtil.ExecuteAll(dbName, tbName);
                dataView.DataSource = dt;
                

            }
        }


        /// <summary>
        /// 记录修改的行号
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dataView_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            int row = dataView.CurrentRow.Index;
            updateRows.Add(row);
        }

        private void dataView_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            MessageBox.Show(e.Exception.Message);
        }
    }
        
}
