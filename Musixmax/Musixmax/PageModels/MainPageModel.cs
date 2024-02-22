using Musixmax.Models;
using System.Collections.ObjectModel;
namespace Musixmax.PageModels
{
    public class MainPageModel : BasePageModel
    {
        public MainPageModel()
        {
        }

        public ObservableCollection<TracksItemModel> Tracks { get; set; } = new ObservableCollection<TracksItemModel>();
        public ObservableCollection<AlbumsItemModel> Albums { get; set; }
        public ObservableCollection<FolderItemModel> Folders { get; set; }

        public override void Init(object initData)
        {
            base.Init(initData);
            #region albumcollection
            Albums = new ObservableCollection<AlbumsItemModel>
            {
                new AlbumsItemModel()
                {
                    AlbumName = "Eyes",
                    AlbumArtist= "Milet",
                    NumberOfTracks = 1,

                },

                new AlbumsItemModel()
                {
                    AlbumName = "Remixes",
                    AlbumArtist = "AmaLee",
                    NumberOfTracks = 10
                },

                new AlbumsItemModel()
                {
                    AlbumName = "Mercury act 1 & 2",
                    AlbumArtist = "Imagine Dragons",
                    NumberOfTracks = 12
                },

                new AlbumsItemModel()
                {
                    AlbumName = "key Ingredient",
                    AlbumArtist = "Mili",
                    NumberOfTracks = 7
                },

                new AlbumsItemModel()
                {
                    AlbumName = "Evolve",
                    AlbumArtist = "Imagine Dragons",
                    NumberOfTracks = 13
                },

                new AlbumsItemModel()
                {
                    AlbumName = "Millenium Mother",
                    AlbumArtist = "Mili",
                    NumberOfTracks = 6
                },
            };
            #endregion
            #region Folderscollection
            Folders = new ObservableCollection<FolderItemModel> {
                new FolderItemModel()
                {
                    FolderName = "Music",
                    FolderPath = "/Stockge interne/SHAREit/audios/Music"
                },

                new FolderItemModel() 
                {
                    FolderName = "Snaptube Audio",
                    FolderPath = "/Stockage interne/snaptube download/Snaptube Audio"
                },

                new FolderItemModel()
                {
                    FolderName = "Snaptube_Audio",
                    FolderPath = "/Stockage interne/ SHREit Audios/Snaptube_Audio"
                },

                new FolderItemModel()
                {
                    FolderName = "Stockage interne",
                    FolderPath = "/Stockage interne"
                },
            };
            #endregion
            #region Trackscollection
            Tracks.Add(new TracksItemModel()
            {
                Artist = "American Authors",
                Title = "Born To Run"
            });

            Tracks.Add(new TracksItemModel()
            {
                Artist = "Imagine Dragons",
                Title = "Gold"
            });

            Tracks.Add(new TracksItemModel()
            {
                Artist = "Mili",
                Title = "Extention of you"
            });

            Tracks.Add(new TracksItemModel()
            {
                Artist = "AmaLee",
                Title = "Devotion"
            });

            Tracks.Add(new TracksItemModel()
            {
                Artist = "Imagine Dragons",
                Title = "whatever It Takes"
            });

            Tracks.Add(new TracksItemModel()
            {
                Artist = "Imagine Dragons",
                Title = "wrecked"
            });
            Tracks.Add(new TracksItemModel()
            {
                Artist = "Fall out boys",
                Title = "Light Em up"
            });

            Tracks.Add(new TracksItemModel()
            {
                Artist = "Neffex",
                Title = "Purpose"
            });

            Tracks.Add(new TracksItemModel()
            {
                Artist = "Bury the Light",
                Title = "Casey Edwards"
            });

            Tracks.Add(new TracksItemModel()
            {
                Artist = "Bôa",
                Title = "Duvet"
            });
            #endregion
        }



    }
}
