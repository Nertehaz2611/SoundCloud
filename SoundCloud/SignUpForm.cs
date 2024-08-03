using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;
using BLL;

namespace SoundCloud
{
    public partial class SignUpForm : Form
    {
        AccountBLL accountBLL = new AccountBLL();
        List<Account> accounts = new List<Account>();
        public SignUpForm()
        {
            InitializeComponent();
            accounts = accountBLL.getListAccounts();
        }
        private bool isShow = false;
        private void pbShowHide_Click(object sender, EventArgs e)
        {
            if (isShow)
            {
                pbShowHide.Image = Image.FromFile("D:\\Workspace\\C#\\SoundCloud\\Icons\\show.png");
                txtPassword.UseSystemPasswordChar = false;
            }
            else
            {
                pbShowHide.Image = Image.FromFile("D:\\Workspace\\C#\\SoundCloud\\Icons\\hide.png");
                txtPassword.UseSystemPasswordChar = true;
            }
            isShow = !isShow;
        }
        private void OpenNewForm()
        {
            Application.Run(new LoginForm());
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            Account account = new Account();
            account.username = txtUsername.Text;
            string hassPass = txtPassword.Text.GetHashCode().ToString();
            account.password = hassPass;
            account.email = txtEmail.Text;
            if (txtUsername.Text == "" || txtPassword.Text == "" || txtEmail.Text == "")
            {
                lbNotice.Text = "Please complete all information!";
            }
            else
            {
                bool isExist = false;
                foreach (var i in accounts)
                {
                    if (account.password == i.password)
                    {
                        isExist = true;
                        break;
                    }
                }
                if (isExist)
                {
                    lbNotice.Text = "Username already exist!";
                }
                else
                {
                    accountBLL.AddAccout(account);
                    System.Threading.Thread newTHread = new System.Threading.Thread(new System.Threading.ThreadStart(OpenNewForm));
                    newTHread.Start();

                    this.Close();
                }
            }
            
        }
    }
}
