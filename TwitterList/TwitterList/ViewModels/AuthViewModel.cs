using System;
using System.Windows.Input;
using MvvmCross.Core.ViewModels;
using TwitterList.Authentication;
using System.Reflection;
using MvvmCross.Platform;

namespace TwitterList.ViewModels
{
    public class AuthViewModel : MvxViewModel
    {
        private readonly IAuthenticationService _authServ;

        public AuthViewModel(IAuthenticationService authServ)
        {
            _authServ = authServ;
        }

        private MvxCommand _authCommand;
        public ICommand AuthCommand
        {
            get
            {
                _authCommand = _authCommand ?? new MvxCommand(LoginTwitter);
                return _authCommand;
            }
        }

        private void LoginTwitter()
        {
            _authServ.LoginToTwitter();
        }
    }
}

