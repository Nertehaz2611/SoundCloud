using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class AccountSong
    {
        private string _username, _songId;
        public string username
        {
            get { return _username; }
            set { _username = value; }
        }
        public string songId
        {
            get { return _songId; }
            set { _songId = value; }
        }
        public AccountSong() { }
        public AccountSong(string username, string songId)
        {
            this._username = username;
            this._songId = songId;
        }
    }
}
