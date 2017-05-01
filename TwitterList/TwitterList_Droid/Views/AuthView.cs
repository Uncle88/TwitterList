using System;
using Android.App;
using Android.Content.PM;
using Android.OS;
using MvvmCross.Core.ViewModels;
using MvvmCross.Droid.Views;
using TwitterList.ViewModels;

namespace TwitterList_Droid.Views
{
    [Activity(Label = "TwitterList_Droid", MainLauncher = true, ScreenOrientation = ScreenOrientation.Portrait)]
    [MvxViewFor(typeof(AuthViewModel))]

    public class AuthView : MvxActivity
    {
        public new AuthViewModel ViewModel
        {
            get { return (AuthViewModel)base.ViewModel; }
            set { base.ViewModel = value; }
        }

        protected override void OnViewModelSet()
        {
            base.OnViewModelSet();
            SetContentView(Resource.Layout.AuthView);
        }

        //protected override void OnCreate(Bundle bundle)
        //{
        //base.OnCreate(bundle);
        //SetContentView(Resource.Layout.Main);
        //}
    }
}
