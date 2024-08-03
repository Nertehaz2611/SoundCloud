using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Account
    {
        private string _username, _password, _email;
        private List<Song> _playlist;
        public string username
        {
            get { return _username; }
            set { _username = value; }
        }
        public string password
        {
            get { return _password; }
            set { _password = value; }
        }
        public string email
        {
            get { return _email; }
            set { _email = value; }
        }
        public List<Song> playlist
        {
            get { return _playlist; }
            set { _playlist = value; }
        }
        public Account() { }
        public Account(string username, string password, string email, List<Song> playlist)
        {
            this._username = username;
            this._password = password;
            this._email = email;
            this._playlist = playlist;
        }
        public Account(string username, string password, string email)
        {
            this._username = username;
            this._password = password;
            this._email = email;
        }
    }
}
