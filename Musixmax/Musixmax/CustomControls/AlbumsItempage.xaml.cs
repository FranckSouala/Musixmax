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
            get => (string)GetValue(AlbumNameProperty);
            set => SetValue(AlbumNameProperty, value);
        }

        public static readonly BindableProperty AlbumNameProperty =
            BindableProperty.Create(
                declaringType: typeof(AlbumsItempage),
                propertyName: nameof(AlbumName),
                returnType: typeof(string),
                defaultValue: String.Empty, 
                defaultBindingMode: BindingMode.OneWay);


        public string AlbumArtist
        {
            get => (string)GetValue(AlbumArtistProperty);
            set => SetValue(AlbumArtistProperty, value);
        }

        public static readonly BindableProperty AlbumArtistProperty =
            BindableProperty.Create(
                declaringType: typeof(AlbumsItempage),
                propertyName: nameof(AlbumArtist),
                returnType: typeof(string),
                defaultValue: String.Empty, 
                defaultBindingMode: BindingMode.OneWay);



        public string AlbumCoverImage
        {
            get => (string)GetValue(AlbumCoverImageProperty);
            set => SetValue(AlbumCoverImageProperty, value);
        }

        public static readonly BindableProperty AlbumCoverImageProperty =
            BindableProperty.Create(
                declaringType: typeof(AlbumsItempage),
                propertyName: nameof(AlbumCoverImage),
                returnType: typeof(string),
                defaultValue: "cover", 
                defaultBindingMode: BindingMode.OneWay);


        public int NumberOfTracks
        {
            get => (int)GetValue(NumberOfTracksProperty);
            set => SetValue(NumberOfTracksProperty, value);
        }

        public static readonly BindableProperty NumberOfTracksProperty =
            BindableProperty.Create(
                declaringType: typeof(AlbumsItempage),
                propertyName: nameof(NumberOfTracks),
                returnType: typeof(int),
                defaultBindingMode: BindingMode.OneWay);


    }

}
