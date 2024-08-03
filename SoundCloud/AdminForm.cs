using SoundCloud.Admin_Control;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SoundCloud
{
    public partial class AdminForm : Form
    {
        public AdminForm()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void btnHide_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
        private void addAdminControl(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            pnEmpty.Controls.Clear();
            pnEmpty.Controls.Add(userControl);
            userControl.BringToFront(); 
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            AC_Songs songs = new AC_Songs();
            addAdminControl(songs);
        }
        private void button2_Click(object sender, EventArgs e)
        {
            AC_Artists artists = new AC_Artists();
            addAdminControl(artists);
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            System.Threading.Thread newTHread = new System.Threading.Thread(new System.Threading.ThreadStart(OpenNewForm));
            newTHread.Start();

            this.Close();
        }
        private void OpenNewForm()
        {            Application.Run(new LoginForm());
        }
    }
}
