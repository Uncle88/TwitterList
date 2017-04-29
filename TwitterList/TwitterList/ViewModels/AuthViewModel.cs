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


    }
}
