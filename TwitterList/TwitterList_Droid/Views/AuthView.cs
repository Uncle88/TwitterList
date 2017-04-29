using System;
using Android.App;
using MvvmCross.Droid.Views;
using TwitterList.ViewModels;

namespace TwitterList_Droid.Views
{
    [Activity(Label = "TwitterList_Droid", MainLauncher = true)]
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
            SetContentView(Resource.Layout.Main);
        }
    }
}
