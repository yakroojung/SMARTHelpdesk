using Common.SecurityManager.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Common.SecurityManager.BLL.GlobalVariableBLL.ConnectionStringSys = @"Data Source=43.255.243.87;Initial Catalog=SMARTHelpdesk;Persist Security Info=True;User ID=IRPC;Password=P@ssw0rd;";
        }

        private void bttLogOn_Click(object sender, EventArgs e)
        {
            try
            {
                var entRe = new ResultEntity();
                this.Cursor = Cursors.WaitCursor;
               string UserName = this.txtUserName.Text;
                //BLL.GlobalVariableBLL.app_id = this.GuidValue;
               string Password = this.txtPassword.Text;
                entRe = Common.SecurityManager.BLL.Authentication.AuthenticationBLL.Instance.Login(UserName, Password, "1", Environment.MachineName, "WINDOWS");
                this.Cursor = Cursors.Default;
                if (entRe.ResultCode == 0)
                {
                    var dtMenuParent = entRe.Data.Tables["MenuParent"];
                    var dtMenuChild = entRe.Data.Tables["MenuChild"];
                    var dtAuthenUserGroup = entRe.Data.Tables["AuthenUserGroup"];
                    var dtApplication = entRe.Data.Tables["Application"];
                    dgvMenuParent.DataSource = dtMenuParent;
                    dgvMenuChild.DataSource = dtMenuChild;
                    dgvAuthenUserGroup.DataSource = dtAuthenUserGroup;
       
                }
                if (entRe.ResultCode == 1)
                {
                    //frmMassages msg = new frmMassages();
                    //msg.ShowDialog();//
                    MessageBox.Show(entRe.MessageText);
                    this.txtPassword.Focus();
                    this.txtPassword.SelectAll();
                }
                else if (entRe.ResultCode == 2)
                {
                    MessageBox.Show(entRe.MessageText);
                    this.txtUserName.Focus();
                    this.txtUserName.SelectAll();
                }
                else
                {
                    MessageBox.Show(entRe.MessageText);

                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
    }
}
