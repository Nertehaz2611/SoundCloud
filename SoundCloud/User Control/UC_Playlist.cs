using BLL;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SoundCloud.User_Control
{
    public partial class UC_Playlist : UserControl
    {
        AccountSongsBLL accountSongsBLL = new AccountSongsBLL();
        List<AccountSong> accountSongs = new List<AccountSong>();
        List<Song> userSongs = new List<Song>();
        public UC_Playlist()
        {
            InitializeComponent();
            accountSongs = accountSongsBLL.getListAccountSongs();
            userSongs = accountSongsBLL.getListUserSongs();
            dataGridView1.DataSource = userSongs;
        }
        public void refreshSongs()
        {
            accountSongs.Clear();
            userSongs.Clear();
            accountSongs = accountSongsBLL.getListAccountSongs();
            userSongs = accountSongsBLL.getListUserSongs();
            dataGridView1.DataSource = userSongs;
        }

        private void pnInfo_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
