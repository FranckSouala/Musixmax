using Musixmax.Models;
using System.Collections.ObjectModel;
namespace Musixmax.PageModels
{
    public class MainPageModel : BasePageModel
    {
        public MainPageModel()
        {
        }
        #region collection items
        public ObservableCollection<TracksItemModel> Tracks { get; set; } = new ObservableCollection<TracksItemModel>();
        public ObservableCollection<AlbumsItemModel> Albums { get; set; } = new ObservableCollection<AlbumsItemModel>();

        public override void Init(object initData)
        {
            base.Init(initData);

            Albums = new ObservableCollection<AlbumsItemModel>
            {
                new AlbumsItemModel()
                {
                    AlbumName = "kjfnfjrkng",
                    AlbumArtisteName = "dkfjnnrg"
                },

                new AlbumsItemModel()
                {
                    AlbumName = "kjfnfjrkng",
                    AlbumArtisteName = "dkfjnnrg",
                },

                new AlbumsItemModel()
                {
                    AlbumName = "kjfnfjrkng",
                    AlbumArtisteName = "dkfjnnrg",
                },

                new AlbumsItemModel()
                {
                    AlbumName = "kjfnfjrkng",
                    AlbumArtisteName = "dkfjnnrg",
                },

                new AlbumsItemModel()
                {
                    AlbumName = "kjfnfjrkng",
                    AlbumArtisteName = "dkfjnnrg",
                },

                new AlbumsItemModel()
                {
                    AlbumName = "kjfnfjrkng",
                    AlbumArtisteName = "dkfjnnrg",
                },
            };

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
                Title = "whatever It Takes"
            });
            Tracks.Add(new TracksItemModel()
            {
                Artist = "Imagine Dragons",
                Title = "whatever It Takes"
            });

            Tracks.Add(new TracksItemModel()
            {
                Artist = "Imagine Dragons",
                Title = "whatever It Takes"
            });

            Tracks.Add(new TracksItemModel()
            {
                Artist = "Imagine Dragons",
                Title = "whatever It Takes"
            });

            Tracks.Add(new TracksItemModel()
            {
                Artist = "Imagine Dragons",
                Title = "whatever It Takes"
            });
        }
        #endregion



    }
}
