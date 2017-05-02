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
        private IAuthenticationService _authServ;

        public AuthViewModel(IAuthenticationService authServ)
        {
            _authServ = authServ;
            Mvx.IocConstruct<IAuthenticationService>();
        }

        private MvxCommand _authCommand;

        public ICommand AuthCommand
        {
            get
            {
                _authCommand = _authCommand ?? new MvxCommand(() =>
                                                              ShowViewModel<AuthViewModel>(), () => true);
                _authServ.LoginToTwitter();
                //{
                //var _authCommand = Mvx.Resolve<IAuthenticationService>();
                //_authCommand.LoginToTwitter();
                //}); 
                return _authCommand;
            }
        }
    }
}

