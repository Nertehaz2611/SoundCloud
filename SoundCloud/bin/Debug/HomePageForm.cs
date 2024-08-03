using SoundCloud.User_Control;
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
    public partial class HomePageForm : Form
    {
        public HomePageForm()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void pnSongs_Paint(object sender, PaintEventArgs e)
        {

        }
        private void addUserControl(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            pnEmpty.Controls.Clear();
            pnEmpty.Controls.Add(userControl);
            userControl.BringToFront();
        }
        private void btnSongs_Click(object sender, EventArgs e)
        {
            UC_Songs songs = new UC_Songs();
            addUserControl(songs);
        }

        private void btnArtists_Click(object sender, EventArgs e)
        {
            UC_Artists artist = new UC_Artists();
            addUserControl(artist);
        }

        private void btnPlaylist_Click(object sender, EventArgs e)
        {
            UC_Playlist playlist = new UC_Playlist();   
            addUserControl(playlist);
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            
            System.Threading.Thread newTHread = new System.Threading.Thread(new System.Threading.ThreadStart(OpenNewForm));
            newTHread.Start();

            this.Close();
        }
        private void OpenNewForm()
        {
            Application.Run(new LoginForm());
        }
    }
}
