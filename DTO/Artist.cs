using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Artist
    {
        private string _id, _name, _category, _image, _since;
        private List<Song> _songs;
        public string id
        {
            get { return _id; }
            set { _id = value; }
        }
        public string name
        {
            get { return _name; }
            set { _name = value; }
        }
        public string category
        {
            get { return _category; }
            set { _category = value; }
        }
        public string image
        {
            get { return _image; }
            set { _image = value; }
        }
        public string since
        {
            get { return _since; }
            set { _since = value; }
        }
        public List<Song> songs
        {
            get { return _songs; }
            set { _songs = value; }
        }
        public Artist()
        {

        }
        public Artist(string id, string name, string category, string image, string since, List<Song> songs)
        {
            this._id = id;
            this._name = name;
            this._category = category;
            this._image = image;
            this._since = since;
            this._songs = songs;
        }
        public Artist(string id, string name, string category, string image, string since)
        {
            this._id = id;
            this._name = name;
            this._category = category;
            this._image = image;
            this._since = since;
        }
        public Artist(string id, string name, string since)
        {
            this._id = id;
            this._name = name;
            this._category = category;
        }
    }
}
