using System;
using Android.Content;
using MvvmCross.Core.ViewModels;
using MvvmCross.Droid.Platform;
using TwitterList;
using MvvmCross.Platform.Droid.Views;
using TwitterList.Authentication;
using MvvmCross.Platform;
using MvvmCross.Platform.Platform;
using System.Diagnostics;

namespace TwitterList_Droid
{
    public class Setup : MvxAndroidSetup
    {
        public Setup(Context applicationContext) : base(applicationContext)
        {
        }
        protected override IMvxApplication CreateApp()
        {
            return new App();
        }

        protected override void InitializePlatformServices()
        {
            base.InitializePlatformServices();

            Mvx.RegisterType<IAuthenticationService, DroidAuthenticationService>();
        }
    }
}
