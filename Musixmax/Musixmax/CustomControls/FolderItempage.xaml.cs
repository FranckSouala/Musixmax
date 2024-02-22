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
	public partial class FolderItempage : ContentView
	{
		public FolderItempage ()
		{
			InitializeComponent ();
		}


        public string FolderPath
        {
            get => (string)GetValue(FolderPathProperty);
            set => SetValue(FolderPathProperty, value);
        }

        public static readonly BindableProperty FolderPathProperty =
            BindableProperty.Create(
                declaringType: typeof(FolderItempage),
                propertyName: nameof(FolderPath),
                returnType: typeof(string),
                defaultValue: String.Empty, 
                defaultBindingMode: BindingMode.OneWay);


        public string Foldername
        {
            get => (string)GetValue(FoldernameProperty);
            set => SetValue(FoldernameProperty, value);
        }

        public static readonly BindableProperty FoldernameProperty =
            BindableProperty.Create(
                declaringType: typeof(FolderItempage),
                propertyName: nameof(Foldername),
                returnType: typeof(string),
                defaultValue: String.Empty, 
                defaultBindingMode: BindingMode.OneWay);


        public string FolderImage
        {
            get => (string)GetValue(FolderImageProperty);
            set => SetValue(FolderImageProperty, value);
        }

        public static readonly BindableProperty FolderImageProperty =
            BindableProperty.Create(
                declaringType: typeof(FolderItempage),
                propertyName: nameof(FolderImage),
                returnType: typeof(string),
                defaultValue: "cover",  
                defaultBindingMode: BindingMode.OneWay);

    }
}