using System;
using System.Linq;
using System.Windows.Forms;
using WindowApp.Controller;
using WindowApp.Model;

namespace WindowApp.View
{
    public partial class Register : Form
    {

        bool idFlag = false;

        public Login login { get; }

        public Register(Login login)
        {
            InitializeComponent();
            this.login = login;
        }

        private void addInfoBtn_Click(object sender, EventArgs e)
        {
            using (var context = new mssqlDBContext())
            {

                string uid = newId.Text;
                string upw = newPwd.Text;

                var des = new DES(Properties.Resources.DesKey);
                var encrypt = des.result(DesType.Encrypt, upw);

                var loginInfo = new tb_logininfo()
                {
                    userid = uid,
                    userpassword = encrypt
                };

                context.logininfo.Add(loginInfo);
                context.SaveChanges();
            }

            formExit();
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            formExit();
        }

        private void overlapCheck_Click(object sender, EventArgs e)
        {
            using (var ctx = new mssqlDBContext())
            {
                string uid = newId.Text;
                var item = ctx.logininfo.SingleOrDefault(p => p.userid == uid);

                if (item == null)
                {
                    idFlag = true;
                    warn.Text = "사용가능한 아이디입니다.";
                    addInfoBtn.Enabled = true;
                } else
                {
                    warn.Text = "중복된 아이디입니다.";
                }
            }
        }

        private void formExit()
        {
            this.Hide();
            login.Show();
        }

        private void Register_FormClosed(object sender, FormClosedEventArgs e)
        {
            formExit();
        }
    }
}
