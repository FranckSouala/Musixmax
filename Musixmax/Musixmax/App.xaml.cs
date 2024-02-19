using FreshMvvm;
using MediaManager;
using Musixmax.PageModels;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Musixmax
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            CrossMediaManager.Current.Init();

            var page = FreshPageModelResolver.ResolvePageModel<MainPageModel>();

            var navigation = new FreshNavigationContainer(page);

            MainPage = navigation;
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
