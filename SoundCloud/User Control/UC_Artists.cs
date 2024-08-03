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
    public partial class UC_Artists : UserControl
    {
        string id, name, artist, filePath, image;
        ArtistBLL artistBLL = new ArtistBLL();
        List<Artist> artists = new List<Artist>();
        public UC_Artists()
        {
            InitializeComponent();
            artists = artistBLL.getListArtists();
            dataGridView1.DataSource = artists;

        }
        public void refreshSongs()
        {
            artists.Clear();
            artists = artistBLL.getListArtists();
            dataGridView1.DataSource = artists;
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

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
            lbArtist.Text = row.Cells["name"].Value.ToString();
            lbCategory.Text = "Category: " + row.Cells["category"].Value.ToString();
            lbYOO.Text = "Since: " + row.Cells["since"].Value.ToString();
            try
            {
                pbImg.Image = System.Drawing.Image.FromFile(row.Cells["image"].Value.ToString());
            }
            catch (Exception ex)
            {
                pbImg.Image = System.Drawing.Image.FromFile("D:\\Workspace\\C#\\SoundCloud\\SongImages\\_outOfMemory.png");
            }
        }
        

        private void txtSearch_Click(object sender, EventArgs e)
        {
            txtSearch.Text = "";
        }
    }
}
