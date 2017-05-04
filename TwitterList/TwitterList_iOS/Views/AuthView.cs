using System;
using MvvmCross.iOS.Views;
using TwitterList.ViewModels;
using UIKit;
using MvvmCross.Binding.BindingContext;

namespace TwitterList_iOS.Views
{
    public partial class AuthView : MvxViewController
    {
        public new AuthViewModel ViewModel
        {
            get { return (AuthViewModel)base.ViewModel; }
            set { base.ViewModel = value; }
        }

        public AuthView() : base("AuthView", null)
        {
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            this.CreateBinding(authButton).To((AuthViewModel vm) => vm.AuthCommand).Apply();
            authButton.TintColor = UIColor.Red;
            authButton.BackgroundColor = UIColor.Cyan;
            authButton.Layer.CornerRadius = 30;
        }
    }
}

