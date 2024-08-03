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
    public class ArtistBLL
    {
        SqlConnectionData connector = null;
        public ArtistBLL()
        {
            connector = new SqlConnectionData();
        }
        public List<Artist> getListArtists()
        {
            SqlDataReader dr = null;
            List<Artist> list = null;
            dr = connector.getData("SELECT * FROM Artists");
            list = new List<Artist>();
            while (dr.Read())
            {
                Artist artist = new Artist();
                artist.id = dr.GetString(0);
                artist.name = dr.GetString(1);
                artist.category = dr.GetString(2);
                artist.image = dr.GetString(3);
                artist.since = dr.GetString(4);
                list.Add(artist);
            }
            connector.closeConnection();

            return list;
        }
        public void AddArtist(Artist artist)
        {
            string id, name, category, image, since;
            id = artist.id;
            name = artist.name;
            category = artist.category;
            image = artist.image;
            since = artist.since;
            connector.openConnection();
            string query = "INSERT INTO Artists (Id, Name, Category, Image, Since) VALUES ('" + id + "', '" + name + "', '" + category + "', '" + image + "', '" + since + "')";
            connector.setData(query);
        }
        public void DeleteArtist(Artist artist)
        {
            string id = artist.id;
            connector.openConnection();
            string query = "DELETE FROM Artists WHERE Id = " + id + ";";
            connector.deleteData(query);
        }
        public void UpdateArtist(Artist artist)
        {
            string id, name, category, image, since;
            id = artist.id;
            name = artist.name;
            category = artist.category;
            image = artist.image;
            since = artist.since;
            connector.openConnection();
            string query = "UPDATE Artists SET Name = '" + name + "', Category = '" + category + "', Image = '" + image + "', Since = '" + since + "' WHERE Id = '" + id + "';";
            connector.updateData(query);
        }
    }
}
