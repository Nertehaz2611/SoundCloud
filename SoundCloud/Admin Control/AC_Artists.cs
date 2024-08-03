using BLL;
using DTO;
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

namespace SoundCloud.Admin_Control
{
    public partial class AC_Artists : UserControl
    {
        string id, name, category, image, since;
        ArtistBLL artistBLL = new ArtistBLL();
        List<Artist> artists = new List<Artist>();
        public AC_Artists()
        {
            InitializeComponent();
            artists = artistBLL.getListArtists();
            dataGridView1.DataSource = artists;
        }
        public void refreshArtists()
        {
            artists.Clear();
            artists = artistBLL.getListArtists();
            dataGridView1.DataSource = artists;
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
        public Boolean flag = true;

        private void lbID_Click(object sender, EventArgs e)
        {

        }

        private void txtID_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            id = txtID.Text;
            name = txtName.Text;
            category = txtCategory.Text;
            image = txtImage.Text;
            since = txtSince.Text;
            Artist artist = new Artist(id, name, category, image, since);
            if (!isExist(artist))
            {
                MessageBox.Show("This song does not exist");
            }
            else
            {
                MessageBox.Show("Deleted successfully");
                artistBLL.DeleteArtist(artist);
                refreshArtists();
            }
        }

        private void dataGridView1_Click(object sender, EventArgs e)
        {
            
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
            txtID.Text = row.Cells["id"].Value.ToString();
            txtName.Text = row.Cells["name"].Value.ToString();
            txtCategory.Text = row.Cells["category"].Value.ToString();
            txtImage.Text = row.Cells["image"].Value.ToString();
            txtSince.Text = row.Cells["since"].Value.ToString();
        }

        private bool isExist(Artist artist)
        {
            foreach (var i in artists)
            {
                if (i.id == artist.id) return true;
            }
            return false;
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            id = txtID.Text;
            name = txtName.Text;
            category = txtCategory.Text;
            image = txtImage.Text;
            since = txtSince.Text;
            Artist artist = new Artist(id, name, category, image, since);
            if (isExist(artist))
            {
                MessageBox.Show("This artist already exist");
            }
            else
            {
                MessageBox.Show("Added successfully");
                artistBLL.AddArtist(artist);
                refreshArtists();
            }
        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            id = txtID.Text;
            name = txtName.Text;
            category = txtCategory.Text;
            image = txtImage.Text;
            since = txtSince.Text;
            Artist song = new Artist(id, name, category, image, since);

            MessageBox.Show("Updated successfully");
            artistBLL.UpdateArtist(song);
            refreshArtists();
        }
        

    }
}
