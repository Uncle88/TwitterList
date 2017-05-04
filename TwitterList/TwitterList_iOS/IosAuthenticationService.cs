using System;
using TwitterList;
using TwitterList.Authentication;
using Xamarin.Auth;
using TwitterList_iOS.Views;
using MvvmCross.Core.Views;
using UIKit;
using Newtonsoft.Json;

namespace TwitterList_iOS
{
    public class IosAuthenticationService : Constans, IAuthenticationService
    {
        public void LoginToTwitter()
        {
            var auth = new OAuth1Authenticator(
                                               TWITTER_KEY,
                                               TWITTER_SECRET,
                                               new Uri(TWITTER_REQTOKEN_URL),
                                               new Uri(TWITTER_AUTH),
                                               new Uri(TWITTER_ACCESSTOKEN_URL),
                                               new Uri(TWITTER_CALLBACK_URL));


            auth.Completed += (s, eventArgs) =>
            {
                if (!eventArgs.IsAuthenticated)
                {
                    UIAlertView alert = new UIAlertView()
                    {
                        Title = "Error",
                        Message = "Not Authenticated"
                    };
                    alert.AddButton("OK");
                    alert.Show();
                    return;
                }
                else
                {
                    var request = new OAuth1Request("GET", new Uri("https://api.twitter.com/1.1/account/verify_credentials.json"), null, eventArgs.Account, false);
                    request.GetResponseAsync().ContinueWith(t =>
                    {
                        if (t.IsFaulted)
                        {
                            UIAlertView alert = new UIAlertView();
                            alert.Message = t.Exception.InnerException.Message;
                            alert.Show();
                            return;
                        }
                        else
                        {
                            string _data = t.Result.GetResponseText();
                            object obj = JsonConvert.DeserializeObject<object>(_data);
                        }
                    });
                }
            };
            auth.AllowCancel = true;
            UIViewController authView = (UIKit.UIViewController)auth.GetUI();
            UIViewController _vc = null;
            _vc.PresentViewController(authView, true, null);

        }
    }
}
