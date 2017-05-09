using Android.Content;
using MvvmCross.Core.ViewModels;
using MvvmCross.Droid.Platform;
using MvvmCross.Platform;
using TwitterList.Authentication;

namespace TwitterList_Droid
{
    public class Setup : MvxAndroidSetup
    {
        public Setup(Context applicationContext) : base(applicationContext)
        {
        }
        protected override IMvxApplication CreateApp()
        {
            return new TwitterList.App();
        }

        protected override void InitializePlatformServices()
        {
            //Mvx.RegisterType<IAuthenticationService, DroidAuthenticationService>();
            //Mvx.RegisterSingleton(typeof(IAuthenticationService), new DroidAuthenticationService());
            Mvx.RegisterSingleton<IAuthenticationService>(new DroidAuthenticationService());
            base.InitializePlatformServices();
        }
    }
}
