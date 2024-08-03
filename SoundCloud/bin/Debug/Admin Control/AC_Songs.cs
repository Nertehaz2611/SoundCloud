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

namespace SoundCloud.Admin_Control
{
    public partial class AC_Songs : UserControl
    {
        string id, name, artist, filePath, image;
        SongBLL songBLL = new SongBLL();
        List<Song> songs = new List<Song>();
        public AC_Songs()
        {
            InitializeComponent();
            songs = songBLL.getListSongs();
            dataGridView1.DataSource = songs;
        }
        public void refreshSongs()
        {
            songs.Clear();
            songs = songBLL.getListSongs();
            dataGridView1.DataSource = songs;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

       

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
        private bool isExist(Song song)
        {
            foreach (var i in songs)
            {
                if (i.id == song.id) return true;
            }
            return false;
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            id = txtID.Text;
            name = txtName.Text;
            artist = txtArtist.Text;
            filePath = txtFilePath.Text;
            image = txtImage.Text;
            Song song = new Song(id, name, artist, image, filePath);
            if (isExist(song))
            {
                MessageBox.Show("This song already exist");
            } else
            {
                MessageBox.Show("Added successfully");
                songBLL.AddSong(song);
                refreshSongs();
            } 
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            id = txtID.Text;
            name = txtName.Text;
            artist = txtArtist.Text;
            filePath = txtFilePath.Text;
            image = txtImage.Text;
            Song song = new Song(id, name, artist, image, filePath);
            if (!isExist(song))
            {
                MessageBox.Show("This song does not exist");
            }
            else
            {
                MessageBox.Show("Deleted successfully");
                songBLL.DeleteSong(song);
                refreshSongs();
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            id = txtID.Text;
            name = txtName.Text;
            artist = txtArtist.Text;
            filePath = txtFilePath.Text;
            image = txtImage.Text;
            Song song = new Song(id, name, artist, image, filePath);
            
            MessageBox.Show("Updated successfully");
            songBLL.UpdateSong(song);
            refreshSongs();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
            txtID.Text = row.Cells["id"].Value.ToString();
            txtName.Text = row.Cells["name"].Value.ToString();
            txtArtist.Text = row.Cells["artistName"].Value.ToString();
            txtImage.Text = row.Cells["image"].Value.ToString();
            txtFilePath.Text = row.Cells["filePath"].Value.ToString();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void txtID_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
