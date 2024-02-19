using Xamarin.Forms;

namespace Musixmax.PageModels
{
    public class PlayerPageModel : BasePageModel
    {
        public PlayerPageModel()
        {
            NavigationBackCommand = new Command(() =>
            {
                CoreMethods.PushPageModel<MainPageModel>();
            });
        }

        public Command NavigationBackCommand { get; }
    }
}
