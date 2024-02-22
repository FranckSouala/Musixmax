using System;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Musixmax.CustomControls
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class TracksItempage : ContentView
    {
        public TracksItempage()
        {
            InitializeComponent();
        }



        public string Artist
        {
            get => (string)GetValue(ArtistProperty);
            set => SetValue(ArtistProperty, value);
        }

        public static readonly BindableProperty ArtistProperty =
            BindableProperty.Create(
                declaringType: typeof(TracksItempage),
                propertyName: nameof(Artist),
                returnType: typeof(string),
                defaultValue: String.Empty,
                defaultBindingMode: BindingMode.OneWay);


        public string Title
        {
            get { return (string)GetValue(TitleProperty); }
            set { SetValue(TitleProperty, value); }
        }

        public static readonly BindableProperty TitleProperty =
            BindableProperty.Create(nameof(Title),
                typeof(string),
                typeof(TracksItempage),
                defaultValue: string.Empty,
                defaultBindingMode: BindingMode.OneWay);



        public string ImageCover
        {
            get => (string)GetValue(ImageCoverProperty);
            set => SetValue(ImageCoverProperty, value);
        }

        public static readonly BindableProperty ImageCoverProperty =
            BindableProperty.Create(
                declaringType: typeof(TracksItempage),
                propertyName: nameof(ImageCover),
                returnType: typeof(string),
                defaultValue: "cover",
                defaultBindingMode: BindingMode.OneWay);


    }
}