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
    public partial class RegisterForm : Form
    {
        string hostname = Environment.MachineName;
        public RegisterForm()
        {
            InitializeComponent();
        }

        private void cancelbutton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void clearbutton_Click(object sender, EventArgs e)
        {
            clearControls();
            idtextBox.Select();
        }

        private void clearControls()
        {
            foreach (TextBox tb in this.Controls.OfType<TextBox>())
            {
                tb.Text = string.Empty;
            }
        }

        private void RegisterForm_Load(object sender, EventArgs e)
        {
            loadUserData();
            idtextBox.Select();
        }

        private void loadUserData()
        {            
            string mySQL = string.Empty;
            mySQL += "SELECT id,Department,HostName,Protecter FROM logindata";
            mySQL += "  where HostName = '" + hostname + "'";
            DataTable userdata = SQLServerConnection.executeSQL(mySQL);
            dataGridView1.DataSource = userdata;
            dataGridView1.Columns[0].HeaderText = "Id";
            dataGridView1.Columns[1].HeaderText = "Department";
            dataGridView1.Columns[2].HeaderText = "HostName";
            dataGridView1.Columns[3].HeaderText = "Protecter";
            dataGridView1.Columns[0].Width = 100;
            dataGridView1.Columns[1].Width = 100;
            dataGridView1.Columns[2].Width = 100;
            dataGridView1.Columns[3].Width = 100;
            if (userdata.Rows.Count > 0)
            {
                MessageBox.Show("本機電腦已註冊過");
            }
            else
            {
                MessageBox.Show("本機電腦尚未註冊");
            }
        }

        private void deletebutton_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("確定要刪除紀錄嗎?", "Delete Data : iBasskung Tutorial",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                    MessageBoxDefaultButton.Button1) == DialogResult.Yes)
                {
                    SQLServerConnection.executeSQL("DELETE FROM logindata where id = '" + dataGridView1.CurrentRow.Cells[1].Value + "'");
                    loadUserData();
                    MessageBox.Show("此紀錄已刪除",
                       "Delete Data : iBasskung Tutorial", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    return;
                }
            }
            catch
            {

            }
        }

        private void savebutton_Click(object sender, EventArgs e)
        {
            MessageBoxButtons btn = MessageBoxButtons.OK;
            MessageBoxIcon ico = MessageBoxIcon.Information;
            string caption = " save data = iBasskung Tutorial";

            if (string.IsNullOrEmpty(idtextBox.Text))
            {
                MessageBox.Show("尚未輸入帳號", caption, btn, ico);
                idtextBox.Select();
                return;
            }
            if (string.IsNullOrEmpty(pdtextBox.Text))
            {
                MessageBox.Show("尚未輸入密碼", caption, btn, ico);
                pdtextBox.Select();
                return;
            }
            if (string.IsNullOrEmpty(departmentcomboBox.Text))
            {
                MessageBox.Show("尚未輸入部門及科別", caption, btn, ico);
                departmentcomboBox.Select();
                return;
            }
            if (string.IsNullOrEmpty(nametextBox.Text))
            {
                MessageBox.Show("尚未輸入姓名", caption, btn, ico);
                nametextBox.Select();
                return;
            }

            string checkmySQL = string.Empty;
            checkmySQL += "SELECT id FROM logindata where HostName = '" + hostname + "'";
            DataTable checkDuplicates = SQLServerConnection.executeSQL(checkmySQL);

            if (checkDuplicates.Rows.Count > 0)
            {
                MessageBox.Show("此帳號已設定過，請使用別的帳號","c# Register From : iBsaakung Tutorial",
                    MessageBoxButtons.OK,MessageBoxIcon.Information);
                idtextBox.SelectAll();
                return;
            }
            DialogResult result;
            result = MessageBox.Show("你確定要儲存此帳戶", "Save Data = iBasskung Tutorial",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                string savesql = string.Empty;
                savesql += " INSERT INTO logindata (Id,Pd,Department,HostName,Protecter,CreatTime)";
                savesql += "VALUES('" + idtextBox.Text + "','" + pdtextBox.Text + "','" + departmentcomboBox.Text + "','" + hostname + "','" + nametextBox.Text + "','" + DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss") + "')";
                SQLServerConnection.executeSQL(savesql);
                MessageBox.Show("帳號已設定完畢", "Save Data : iBsaakung Tutorial",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                loadUserData();
                clearControls();
            }
        }
    }
}
