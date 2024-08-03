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
    public class AccountSongsBLL
    {
        SqlConnectionData connector = null;
        public AccountSongsBLL()
        {
            connector = new SqlConnectionData();
        }
        public List<AccountSong> getListAccountSongs()
        {
            SqlDataReader dr = null;
            List<AccountSong> list = null;
            dr = connector.getData("SELECT * FROM AccountSongs");
            list = new List<AccountSong>();
            while (dr.Read())
            {
                AccountSong accountSong = new AccountSong();
                accountSong.username = dr.GetString(0);
                accountSong.songId = dr.GetString(1);
                list.Add(accountSong);
            }
            connector.closeConnection();

            return list;
        }
        public List<Song> getListUserSongs()
        {
            List<AccountSong> listAC = getListAccountSongs();
            List<Song> full = new SongBLL().getListSongs();
            List<Song> list = new List<Song>();
            foreach (AccountSong accountSong in listAC)
            {
                if (accountSong.username == User.Username)
                {
                    foreach (Song song in full)
                    {
                        if (song.id == accountSong.songId)
                        {
                            list.Add(song);
                        }
                    }
                }
            }
            return list;
        }
        public void AddAccountSongs(AccountSong accountSong)
        {
            string username, songId;
            username = accountSong.username;
            songId = accountSong.songId;
            connector.openConnection();
            string query = "INSERT INTO AccountSongs (Username, SongId) VALUES ('" + username + "', '" + songId + "')";
            connector.setData(query);
        }
        public void DeleteAccountSongs(AccountSong accountSong)
        {
            string username, songId;
            username = accountSong.username;
            songId = accountSong.songId;
            connector.openConnection();
            string query = "DELETE FROM Artists WHERE Username = " + username + " AND SongId = " + songId + ";";
            connector.deleteData(query);
        }
    }
}
