using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 医院门诊
{
    public partial class jianka : Form
    {
        string no;
        public jianka()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btnjiaka_Click(object sender, EventArgs e)
        {
            if (this.txtname.Text.Trim() == "")                                                      //若用户号文本框为空；
            {
                MessageBox.Show("姓名不能为空！");														//给出错误提示；
                this.txtname.Focus();                                                                //用户号文本框获得焦点；
                return;                                                                                 //返回；
            }
            if (rdbmale.Checked == false && rdbfamale.Checked == false)
            {
                MessageBox.Show("性别还未选择！");
                return;
            }
            if (this.txtphone.Text.Trim() == "")
            {
                MessageBox.Show("电话号码不能为空！");
                this.txtphone.Focus();
                return;
            }
            SqlConnection sqlConnection = new SqlConnection();
            sqlConnection.ConnectionString =
                ConfigurationManager.ConnectionStrings["Sql"].ConnectionString;             //在字符串变量中，描述连接字符串所需的服务器地址、数据库名称、集成安全性（即是否使用Windows验证）；
            SqlCommand sqlCommand = new SqlCommand();                                       //声明并实例化SQL命令；
            sqlCommand.Connection = sqlConnection;
            sqlCommand.CommandText = "INSERT tb_patient(Name,Gender,phone) " +
                "VALUES (@name,@gender,@phone)";
            sqlCommand.Parameters.AddWithValue("@name",this.txtname.Text.Trim());
            sqlCommand.Parameters.AddWithValue("@phone", this.txtphone.Text.Trim());
            if(rdbmale.Checked)
            {
                sqlCommand.Parameters.AddWithValue("@gender", '男');
            }
            if (rdbfamale.Checked)
            {
                sqlCommand.Parameters.AddWithValue("@gender", '女');
            }
            int rowAffected = 0;
            try
            {
                sqlConnection.Open();
                rowAffected = sqlCommand.ExecuteNonQuery();
            }
            catch 
            {
                MessageBox.Show("建卡失败。请联系管理员！");
            }
            finally                                                                                     //结束；
            {
                sqlConnection.Close();                                                                  //关闭SQL连接；
            }
            if (rowAffected == 1)                                                                       //若成功写入1行记录；
            {
                sqlCommand.CommandText = "SELECT No " +
                                         "FROM tb_patient " +
                                        "where Name=@n";
                sqlCommand.Parameters.AddWithValue("@n", this.txtname.Text.Trim());
                sqlConnection.Open();
                SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
                if (sqlDataReader.Read())
                {
                    no = sqlDataReader["No"].ToString();
                }
                sqlDataReader.Close();
                sqlConnection.Close();
                MessageBox.Show("建卡成功,您的卡号是"+no+"!");                                                           //显示正确提示；
            }
            else                                                                                        //否则；
            {
                MessageBox.Show("建卡失败！");															//显示错误提示；
            }
        }
    }
}
