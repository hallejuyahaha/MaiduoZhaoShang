using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace ZS
{
    public partial class LoginForm : Form
    {
        DateClass.MyClass MyClass = new DateClass.MyClass();
        public LoginForm()
        {
            InitializeComponent();
        }

        private void btLogin_Click(object sender, EventArgs e)
        {
            if(tbUsername.Text.Trim() != "" & tbPassword.Text.Trim() !="")
            {
                string username = tbUsername.Text.Trim().ToString();
                string password = tbPassword.Text.Trim().ToString();
                string str = "select * from userr where username = '" + username + "' and password = '" + password + "'";
                SqlDataReader sr = MyClass.getcom(str);
                bool ifcom = sr.Read();
                if (ifcom)
                {
                    MessageBox.Show("登陆成功");
                    Form1 fm1 = new Form1();
                    fm1.ShowDialog();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("用户名密码错误");
                    tbUsername.Text = "";
                    tbPassword.Text = "";
                }
            }
            else 
            {
                MessageBox.Show("用户名和密码都不能为空");
            }
        }

        private void btClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
