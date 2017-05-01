using System;
using MvvmCross.Core.ViewModels;
using TwitterList.Authentication;

namespace TwitterList.ViewModels
{
    public class AuthViewModel : MvxViewModel
    {
        private readonly IAuthenticationService _authServ;

        public AuthViewModel(IAuthenticationService authServ)
        {
            _authServ = authServ;

        }

        private IMvxCommand _authCommand;

        public IMvxCommand AuthCommand
        {
            get
            {
                _authCommand = _authCommand ?? new MvxCommand(
                     () => _authServ.LoginToTwitter());

                return _authCommand;
            }
        }
    }
}

