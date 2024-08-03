using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
using DTO;

namespace SoundCloud
{
    public partial class LoginForm : Form
    {
        AccountBLL accountBLL = new AccountBLL();
        List<Account> accounts = new List<Account>();
        public LoginForm()
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
            } else
            {
                pbShowHide.Image = Image.FromFile("D:\\Workspace\\C#\\SoundCloud\\Icons\\hide.png");
                txtPassword.UseSystemPasswordChar = true;
            }
            isShow = !isShow;
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            System.Threading.Thread newTHread = new System.Threading.Thread(new System.Threading.ThreadStart(OpenSignUpForm));
            newTHread.Start();

            this.Close();
        }
        private void OpenSignUpForm()
        {
            Application.Run(new SignUpForm());
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string hassPass = txtPassword.Text.GetHashCode().ToString();
            string password = hassPass;
            string adminUsername = "admin";
            string adminPassword = "admin";
            if (txtUsername.Text == "" || txtPassword.Text == "")
            {
                lbNotice.Text = "Please complete all information";
            } else if (txtUsername.Text == adminUsername)
            {
                if (txtPassword.Text != adminPassword)
                {
                    lbNotice.Text = "Wrong Password";
                } else
                {
                    System.Threading.Thread newTHread = new System.Threading.Thread(new System.Threading.ThreadStart(OpenAdminForm));
                    newTHread.Start();

                    this.Close();
                }
            } else
            {
                bool isExist = false;
                string checkPass = "";
                foreach (var i in accounts)
                {
                    if (username == i.username)
                    {
                        isExist = true;
                        checkPass = i.password;
                        break;
                    }
                }
                if (!isExist)
                {
                    lbNotice.Text = "Username does not exist";
                } else
                {
                    if (password != checkPass)
                    {
                        lbNotice.Text = "Wrong password";
                    } else
                    {
                        User.Username = username;
                        System.Threading.Thread newTHread = new System.Threading.Thread(new System.Threading.ThreadStart(OpenHomePageForm));
                        newTHread.Start();

                        this.Close();
                    }
                }
            }
        }
        private void OpenHomePageForm()
        {
            Application.Run(new HomePageForm());
        }
        private void OpenAdminForm()
        {
            Application.Run(new AdminForm());
        }
    }
}
