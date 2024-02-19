using System;
using System.Collections.Generic;
using System.Text;

namespace Musixmax.Models
{
    public class AlbumsItemModel
    {
        public string AlbumName {  get; set; }
        public int AlbumNumberOfTracks { get; set; } = 1;
        public string AlbumArtisteName {  get; set; }    
    }
}
