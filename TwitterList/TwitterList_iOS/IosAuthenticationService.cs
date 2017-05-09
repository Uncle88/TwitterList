using System;
using TwitterList;
using TwitterList.Authentication;
using Xamarin.Auth;
using TwitterList_iOS.Views;
using MvvmCross.Core.Views;
using UIKit;
using Newtonsoft.Json;
using System.Threading.Tasks;
using System.Json;
using ObjCRuntime;

namespace TwitterList_iOS
{
    public class IosAuthenticationService : Constans, IAuthenticationService
    {
        public void LoginToTwitter()
        {
            var auth = new OAuth1Authenticator
                            (
                                "61jConoUfzvXhymCCJ4bZpyO3",
                                "1i6Ms9nVZUKdkcw9PlXmXpGXRQCN0FEIYq2m3Ub7tAyNH6FC3q",
new Uri(TWITTER_REQTOKEN_URL),
            new Uri(TWITTER_AUTH),
            new Uri(TWITTER_ACCESSTOKEN_URL),
            new Uri(TWITTER_CALLBACK_URL));



            //var auth = new OAuth1Authenticator(
            //Consumer_KEY,
            // Consumer_SECRET,
            //new Uri(TWITTER_REQTOKEN_URL),
            //new Uri(TWITTER_AUTH),
            //new Uri(TWITTER_ACCESSTOKEN_URL),
            //new Uri(TWITTER_CALLBACK_URL));

            auth.AllowCancel = true;

            UIViewController authView = (UIKit.UIViewController)auth.GetUI();
            var window = UIApplication.SharedApplication.KeyWindow;
            var vc = window.RootViewController;
            vc.PresentViewController(authView, true, null);
            //auth.Completed += (s, eventArgs) =>
            //{
            //    if (eventArgs.IsAuthenticated)
            //    {
            //        var request = new OAuth1Request("GET", new Uri("https://api.twitter.com/1.1/account/verify_credentials.json"), null, eventArgs.Account, false);
            //        request.GetResponseAsync().ContinueWith(t =>
            //                            {
            //                                if (t.IsFaulted)
            //                                {
            //                                    UIAlertView alert = new UIAlertView();
            //                                    alert.Message = t.Exception.InnerException.Message;
            //                                    alert.Show();
            //                                    return;
            //                                }
            //                                else
            //                                {
            //                                    string _data = t.Result.GetResponseText();
            //                                    object obj = JsonConvert.DeserializeObject<object>(_data);
            //                                }
            //                            });
            //        return;
            //    }
            //    else
            //    {
            //    UIAlertView alert = new UIAlertView()
            //    {
            //        Title = "Error",
            //        Message = "Not Authenticated"
            //    };
            //    alert.AddButton("OK");
            //    alert.Show();
            //    return;
            //    }
            //};
        }
    }
}


