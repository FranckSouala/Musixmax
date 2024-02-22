using System;
using System.Collections.Generic;
using System.Text;

namespace Musixmax.Models
{
    public class AlbumsItemModel
    {
        public string AlbumName {  get; set; }
        public int NumberOfTracks { get; set; } = 1;
        public string AlbumImageCover { get; set; } = "cover";
        public string AlbumArtist {  get; set; }    
    }
}
