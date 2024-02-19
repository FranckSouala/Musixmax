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
    public partial class TracksItempage : ContentView
    {
        public TracksItempage()
        {
            InitializeComponent();
        }
        public string Artist
        {
            get { return (string)GetValue(ArtistProperty); }
            set { SetValue(ArtistProperty, value); }
        }

        public static readonly BindableProperty ArtistProperty =
            BindableProperty.Create(
                nameof(Artist),
                typeof(string),
                typeof(TracksItempage),
                defaultValue: string.Empty,
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

    }
}