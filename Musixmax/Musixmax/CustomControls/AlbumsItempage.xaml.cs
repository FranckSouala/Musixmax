using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Musixmax.CustomControls
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AlbumsItempage : ContentView
    {
        public AlbumsItempage()
        {
            InitializeComponent();
        }

        public string AlbumName
        {
            get { return (string)GetValue(AlbumNameProperty); }
            set { SetValue(AlbumNameProperty, value); }
        }

        public static readonly BindableProperty AlbumNameProperty =
            BindableProperty.Create(
                nameof(AlbumName),
                typeof(string),
                typeof(AlbumsItempage),
                defaultValue: string.Empty,
                defaultBindingMode: BindingMode.OneWay);

        public string AlbumArtiste
        {
            get { return (string)GetValue(AlbumTitleProperty); }
            set { SetValue(AlbumTitleProperty, value); }
        }

        public static readonly BindableProperty AlbumTitleProperty =
            BindableProperty.Create(nameof(AlbumArtiste),
                typeof(string),
                typeof(AlbumsItempage),
                defaultValue: string.Empty,
                defaultBindingMode: BindingMode.OneWay);

        public int NumberOfTracks
        {
            get { return (int)GetValue(NumberOfTracksProperty); }
            set { SetValue(NumberOfTracksProperty, value); }
        }

        public static readonly BindableProperty NumberOfTracksProperty =
            BindableProperty.Create(nameof(NumberOfTracks),
                typeof(int),
                typeof(AlbumsItempage),
                defaultBindingMode: BindingMode.OneWay);

    }

}
