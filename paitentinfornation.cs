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
    public partial class paitentinfornation : Form
    {
        string No;
        public paitentinfornation()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }
        public paitentinfornation(string xm,string no):this()
        {
            this.txtxm.Text = xm;
            No= no;
            form();
        }
        public void form()
        {
            SqlConnection sqlConnection = new SqlConnection();
            sqlConnection.ConnectionString =
                ConfigurationManager.ConnectionStrings["Sql"].ConnectionString;             //在字符串变量中，描述连接字符串所需的服务器地址、数据库名称、集成安全性（即是否使用Windows验证）；
            SqlCommand sqlCommand = new SqlCommand();                                       //声明并实例化SQL命令；
            sqlCommand.Connection = sqlConnection;                                         //将SQL命令的属性Connection指向SQL连接；
            sqlCommand.CommandText = "SELECT * " +
                                    "FROM tb_patient " +
                                    "WHERE No=@no";
            sqlCommand.Parameters.AddWithValue("@no",No);
            sqlConnection.Open();
            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
            if (sqlDataReader.Read())
            {
                this.txtphone.Text = sqlDataReader["phone"].ToString();
                this.rdbmale.Checked = (sqlDataReader["Gender"].ToString() == "男");
                this.rdbfemale.Checked = !rdbmale.Checked;
            }
            sqlDataReader.Close();
        }

        private void btnxiugai_Click(object sender, EventArgs e)
        {
            SqlConnection sqlConnection = new SqlConnection();
            sqlConnection.ConnectionString =
                ConfigurationManager.ConnectionStrings["Sql"].ConnectionString;             //在字符串变量中，描述连接字符串所需的服务器地址、数据库名称、集成安全性（即是否使用Windows验证）；
            SqlCommand sqlCommand = new SqlCommand();                                       //声明并实例化SQL命令；
            sqlCommand.Connection = sqlConnection;                                         //将SQL命令的属性Connection指向SQL连接；
            sqlCommand.CommandText = "UPDATE tb_patient " +
                                    "SET Name=@Name,Gender=@Gender,Phone=@Phone " +
                                    "WHERE No=@ID;";
            if (rdbmale.Checked)
            {
                sqlCommand.Parameters.AddWithValue("@Gender", '男');
            }
            else
            {
                sqlCommand.Parameters.AddWithValue("@Gender", '女');
            }
            sqlCommand.Parameters.AddWithValue("@Name", txtxm.Text.Trim());
            sqlCommand.Parameters.AddWithValue("@Phone", txtphone.Text.Trim());
            sqlCommand.Parameters.AddWithValue("@ID", No);
            sqlConnection.Open();
            int rowAffected = sqlCommand.ExecuteNonQuery();
            sqlConnection.Close();
            if (rowAffected > 0)
            {
                MessageBox.Show("修改成功");
            }
            else
            {
                MessageBox.Show("未进行任何修改");
            }
        }
    }
}
