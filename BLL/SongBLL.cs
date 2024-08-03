using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class SongBLL
    {
        SqlConnectionData connector = null;
        public SongBLL()
        {
            connector = new SqlConnectionData();
        }
        public List<Song> getListSongs()
        {
            SqlDataReader dr = null;
            List<Song> list = null;
            dr = connector.getData("SELECT * FROM Songs");
            list = new List<Song>();
            while (dr.Read())
            {
                Song song = new Song();
                song.id = dr.GetString(0);
                song.name = dr.GetString(1);
                song.artistName = dr.GetString(2);
                song.image = dr.GetString(3);
                song.filePath = dr.GetString(4);
                list.Add(song);
            }
            connector.closeConnection();

            return list;
        }
        public void AddSong(Song song)
        {
            string id, name, artistName, image, filePath;
            id = song.id;
            name = song.name;
            artistName = song.artistName;
            image = song.image;
            filePath = song.filePath;
            connector.openConnection();
            string query = "INSERT INTO Songs (Id, Name, ArtistName, Image, FilePath) VALUES ('" + id + "', '" + name + "', '" + artistName + "', '" + image + "', '" + filePath + "')";
            connector.setData(query);
        }
        public void DeleteSong(Song song)
        {
            string id = song.id;
            connector.openConnection();
            string query = "DELETE FROM Songs WHERE Id = " + id + ";";
            connector.deleteData(query);
        }
        public void UpdateSong(Song song)
        {
            string id, name, artistName, image, filePath;
            id = song.id;
            name = song.name;
            artistName = song.artistName;
            image = song.image;
            filePath = song.filePath;
            connector.openConnection();
            string query = "UPDATE Songs SET Name = '" + name + "', ArtistName = '" + artistName + "', Image = '" + image + "', FilePath = '" + filePath + "' WHERE Id = '" + id + "';";
            connector.updateData(query);
        }
    }
}
