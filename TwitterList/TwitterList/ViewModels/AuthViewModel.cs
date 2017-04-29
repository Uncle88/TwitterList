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
            _authServ.LoginToTwitter();
        }
        private MvxCommand _clickCommand;

        public Command ClickCommand
        {
            get
            {
                return _clickCommand ?? (_clickCommand = new Command(async (_) =>//
                {
                    if (string.IsNullOrEmpty(Login) || string.IsNullOrEmpty(Password))
                    {
                        return;
                    }
                    var doc = await _loginServiсe.Login(Login, Password);
                    string Message = DialogFilter.LinqFilter(doc);
                    RootObject obj = JsonConvert.DeserializeObject<RootObject>(Message);
                    _dialogService.ShowMessage(obj.ResultMessage);
                }
        }
        }
    }
