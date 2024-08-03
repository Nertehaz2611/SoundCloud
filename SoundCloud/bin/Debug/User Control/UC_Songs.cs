using BLL;
using DTO;
using NAudio.Wave;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace SoundCloud.User_Control
{
    public partial class UC_Songs : UserControl
    {
        string id, name, artist, filePath, image;
        SongBLL songBLL = new SongBLL();
        List<Song> songs = new List<Song>();
        List<Song> currentSongs = new List<Song>();
        AccountBLL accountBLL = new AccountBLL();
        List<Account> accounts = new List<Account>();
        public UC_Songs()
        {
            InitializeComponent();
            songs = songBLL.getListSongs();
            dataGridView1.DataSource = songs;
            accounts = accountBLL.getListAccounts();
        }
        public void refreshSongs()
        {
            songs.Clear();
            songs = songBLL.getListSongs();
            dataGridView1.DataSource = songs;
        }
        
        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pnInfo_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
        private void pictureBox1_Click_2(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            string searchTerm = txtSearch.Text;

            // Xóa màu nền của các hàng trước khi tìm kiếm
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                row.DefaultCellStyle.BackColor = Color.White;
            }

            // Thực hiện tìm kiếm và tô màu các hàng tìm thấy
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                foreach (DataGridViewCell cell in row.Cells)
                {
                    if (cell.Value != null && cell.Value.ToString().Contains(searchTerm))
                    {
                        row.DefaultCellStyle.BackColor = Color.Yellow;
                        break; // Ngừng kiểm tra các ô còn lại trong hàng này
                    }
                }
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
            lbSongName.Text = row.Cells["name"].Value.ToString();
            lbArtist.Text = row.Cells["artistName"].Value.ToString();
            try
            {
                pbImg.Image = System.Drawing.Image.FromFile(row.Cells["image"].Value.ToString());
            }
            catch (Exception ex)
            {
                pbImg.Image = System.Drawing.Image.FromFile("D:\\Workspace\\C#\\SoundCloud\\SongImages\\_outOfMemory.png");
            }
            string id, name, artist, image, filePath;
            if (dataGridView1.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];
                id = selectedRow.Cells["id"].ToString();
                name = selectedRow.Cells["name"].Value.ToString();
                artist = selectedRow.Cells["artistName"].Value.ToString();
                image = selectedRow.Cells["image"].Value.ToString();
                filePath = selectedRow.Cells["filePath"].Value.ToString();
                Song song = new Song(id, name, artist, image, filePath);
                Audio.audioFileReader = new NAudio.Wave.AudioFileReader(filePath);
                Audio.waveOutDevice = new WaveOutEvent();

                Audio.waveOutDevice.Init(Audio.audioFileReader);
            }
        }

        private void pbPlayPause_Click(object sender, EventArgs e)
        {
            if (Audio.waveOutDevice.PlaybackState == PlaybackState.Playing)
            {
                Audio.waveOutDevice.Stop();
            }
            else if (Audio.audioFileReader != null && Audio.waveOutDevice != null)
            {
                Audio.waveOutDevice.Play();
            } else
            {
                MessageBox.Show("Please select a song first");
            }
        }

        private void pbPause_Click(object sender, EventArgs e)
        {
            Audio.waveOutDevice.Pause();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                string id, name, artist, image, filePath;  
                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];
                id = selectedRow.Cells["id"].ToString();
                name = selectedRow.Cells["name"].Value.ToString();
                artist = selectedRow.Cells["artistName"].Value.ToString();
                image = selectedRow.Cells["image"].Value.ToString();
                filePath = selectedRow.Cells["filePath"].Value.ToString();
                Song song = new Song(id, name, artist, image, filePath);
                foreach (Account account in accounts)
                {
                    if (account.username == User.Username)
                    {
                        account.playlist.Add(song);
                    }
                }
            }
        }

        private void lbSongName_Click_1(object sender, EventArgs e)
        {

        }

        private void pbImg_Click(object sender, EventArgs e)
        {

        }

        private void txtSearch_Click(object sender, EventArgs e)
        {
            txtSearch.Text = "";
        }
        
        private void pbLike_Click(object sender, EventArgs e)
        {

        }
    }
}
