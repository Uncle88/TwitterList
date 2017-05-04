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
            //Mvx.IocConstruct<IAuthenticationService>();
            //Mvx.CanResolve<IAuthenticationService>();
        }

        private MvxCommand _authCommand;
        public ICommand AuthCommand
        {
            get
            {
                _authCommand = _authCommand ?? new MvxCommand(() => _authServ.LoginToTwitter());
                //ShowViewModel<AuthViewModel>(), () => true
                return _authCommand;
            }
        }
    }
}

