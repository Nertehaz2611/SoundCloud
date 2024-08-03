using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Song
    {
        private string _id, _name, _artistName, _image, _filePath;
        private bool _isPlaying;
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
        public string artistName
        {
            get { return _artistName; }
            set { _artistName = value; }
        }
        public string image
        {
            get { return _image; }
            set { _image = value; }
        }
        public string filePath
        {
            get { return _filePath; }
            set { _filePath = value; }
        }
        public bool isPlaying
        {
            get { return _isPlaying; }
            set { _isPlaying = value; }
        }
        public Song()
        {
            this._isPlaying = false;
        }
        public Song(string id, string name,  string artistName, string image, string filePath)
        {
            this._id = id;
            this._name = name;
            this._artistName = artistName;
            this._image = image;
            this._filePath = filePath;
            this._isPlaying = false;
        }
        public Song(string id, string name, string artistName, string filePath)
        {
            this._id = id;
            this._name = name;
            this._artistName = artistName;
            this._image = image;
            this._isPlaying = false;
        }
        public Song(string id, string name, string artistName)
        {
            this._id = id;
            this._name = name;
            this._artistName = artistName;
            this._isPlaying = false;
        }
    }
}
