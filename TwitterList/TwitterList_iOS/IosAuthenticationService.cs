using System;
using TwitterList;
using TwitterList.Authentication;
using Xamarin.Auth;
using TwitterList_iOS.Views;
using MvvmCross.Core.Views;
using UIKit;

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
                auth.AllowCancel = true;
                UIViewController authView = (UIKit.UIViewController)auth.GetUI();
                UIViewController _vc = null;
                _vc.PresentViewController(authView, true, null);
            };
        }
    }
}
