using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using login.Connection;

namespace login
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {          
            InitializeComponent();
        }       
        private void LoginForm_Load(object sender, EventArgs e)
        {
            useridTextBox.Select();
        }

        private void cancelbutton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void openregisterfromlinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            RegisterForm register = new RegisterForm();
            register.ShowDialog();
        }

        private void showpdcheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (showpdcheckBox.Checked == true)
            {
                userpdtextBox.UseSystemPasswordChar = false;
            }
            else
            {
                userpdtextBox.UseSystemPasswordChar = true;
            }
        }

        private void Loginbutton_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(useridTextBox.Text) && !string.IsNullOrEmpty(userpdtextBox.Text))
            {
                string mySQL = string.Empty;
                mySQL += "SELECT * FROM logindata";
                mySQL += " where Id = '" +  useridTextBox.Text + "'";
                mySQL += "AND Pd = '" + userpdtextBox.Text + "'";
                DataTable userdata = SQLServerConnection.executeSQL(mySQL);

                if (userdata.Rows.Count > 0)
                {
                    useridTextBox.Clear();
                    userpdtextBox.Clear();
                    showpdcheckBox.Checked = false;
                    this.Hide();
                    MainForm formMain = new MainForm();
                    formMain.ShowDialog();
                    formMain = null;

                    this.Show();
                    this.useridTextBox.Select();

                }
                else
                {
                    MessageBox.Show("您輸入的帳號或密碼不正確，請重新輸入", "c# Login From : iBasskung Tutorial", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    useridTextBox.Focus();
                    useridTextBox.SelectAll();
                }
            }
            else
            {
                MessageBox.Show("請輸入您的帳號及密碼", "c# Login From : iBasskung Tutorial", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                useridTextBox.Select();
            }
        }
    }
}
