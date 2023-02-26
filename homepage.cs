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
    public partial class homepage : Form
    {
        string name,no;
        public homepage()
        {
            InitializeComponent();
        }

        private void btndoctor_Click(object sender, EventArgs e)
        {
            doctordenglu doctordenglu = new doctordenglu();
            doctordenglu.Show();    
        }

        private void btnjiangka_Click(object sender, EventArgs e)
        {
            jianka jianka = new jianka();
            jianka.Show();
        }

        private void btnpillmanage_Click(object sender, EventArgs e)
        {
            Phymanagersdenglu phymanagersdenglu = new Phymanagersdenglu();
            phymanagersdenglu.Show();
        }

        private void btnguahao_Click(object sender, EventArgs e)
        {
            SqlConnection sqlConnection = new SqlConnection();
            sqlConnection.ConnectionString =
                ConfigurationManager.ConnectionStrings["Sql"].ConnectionString;             //在字符串变量中，描述连接字符串所需的服务器地址、数据库名称、集成安全性（即是否使用Windows验证）；
            SqlCommand sqlCommand = new SqlCommand();                                       //声明并实例化SQL命令；
            sqlCommand.Connection = sqlConnection;                                          //将SQL命令的属性Connection指向SQL连接；
            sqlCommand.CommandText = "SELECT * " +
                "FROM tb_patient " +
                "WHERE No=@no";
            sqlCommand.Parameters.AddWithValue("@no", this.txtpatientno.Text.Trim());
            sqlConnection.Open();                                                           //打开SQL连接；
            int rowCount = (int)sqlCommand.ExecuteScalar();                                 //调用SQL命令的方法ExecuteScalar来执行命令，并接受单个结果（即标量）；                                                                                            //执行标量的返回结果类型为object，可通过强制类型转换，转为整型；
            sqlCommand.CommandText = "SELECT * " +
                "FROM tb_patient " +
                "WHERE No=@no";
            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
            if (sqlDataReader.Read())
            {
                name = sqlDataReader["Name"].ToString();
                no = sqlDataReader["No"].ToString();
            }
            sqlDataReader.Close();
            sqlConnection.Close();                                                          //关闭SQL连接；
            if (rowCount == 1)                                                              //若查得所输用户号相应的1行记录；
            {
                MessageBox.Show("登录成功。");												//给出正确提示；
                paientxx paientxx = new paientxx(name,no);
                paientxx.Show();
            }
            else                                                                            //否则；
            {
                MessageBox.Show("卡号有误，请重新输入！");								//给出错误提示；
                this.txtpatientno.Focus();                                                  //密码文本框获得焦点；
                this.txtpatientno.SelectAll();                                              //密码文本框内所有文本被选中；
            }
        }
    }
}
