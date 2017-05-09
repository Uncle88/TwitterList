using MvvmCross.Core.ViewModels;
using MvvmCross.iOS.Platform;
using MvvmCross.iOS.Views.Presenters;
using MvvmCross.Platform;
using TwitterList.Authentication;
using UIKit;

namespace TwitterList_iOS
{
    public class Setup : MvxIosSetup
    {
        public Setup(MvxApplicationDelegate applicationDelegate, UIWindow window)
            : base(applicationDelegate, window)
        {
        }

        public Setup(MvxApplicationDelegate applicationDelegate, IMvxIosViewPresenter presenter)
            : base(applicationDelegate, presenter)
        {
        }

        protected override IMvxApplication CreateApp()
        {
            return new TwitterList.App();
        }

        protected override void InitializePlatformServices()
        {
            Mvx.RegisterSingleton<IAuthenticationService>(new IosAuthenticationService());
            base.InitializePlatformServices();
        }
    }
}
