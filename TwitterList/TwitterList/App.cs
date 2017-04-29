using MvvmCross.Core.ViewModels;
using MvvmCross.Platform;
using TwitterList.Authentication;
using TwitterList.ViewModels;

namespace TwitterList
{
    public class App : MvxApplication
    {
        public App()
        {
            Mvx.RegisterType<IAuthenticationService, CoreAuthenticationService>();
            Mvx.RegisterSingleton<IMvxAppStart>(new MvxAppStart<AuthViewModel>());
        }
    }
}
