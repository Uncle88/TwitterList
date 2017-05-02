using System;
using TwitterList;
using TwitterList.Authentication;
using Xamarin.Auth;
using MvvmCross.Platform.Droid.Views;
using MvvmCross.Platform;
using Android.Content;
using Android.App;
using Mono.Security.Interface;
using System.Json;

namespace TwitterList_Droid
{
    public class DroidAuthenticationService : Constans, IAuthenticationService
    {
        public Activity Context { get; private set; }

        public void LoginToTwitter()
        {
            var activity = this.Context as Activity;

            //var filehandler = Mvx.Resolve<IAuthenticationService>();
            //filehandler.LoginToTwitter();

            var auth = new OAuth1Authenticator(
                                               TWITTER_KEY,
                                               TWITTER_SECRET,
                                               new Uri(TWITTER_REQTOKEN_URL),
                                               new Uri(TWITTER_AUTH),
                                               new Uri(TWITTER_ACCESSTOKEN_URL),
                                               new Uri(TWITTER_CALLBACK_URL));

            auth.AllowCancel = true;
            auth.Completed += (s, eventArgs) =>
            {
                if (!eventArgs.IsAuthenticated)
                {
                    var builder = new AlertDialog.Builder(activity);
                    builder.SetMessage("Not Authenticated");
                    builder.SetPositiveButton("Ok", (o, e) => { });
                    builder.Create().Show();
                    return;
                }
                else
                {
                    //save the account data for a later session, according to Twitter docs, this doesn't expire
                    Account loggedInAccount = eventArgs.Account;
                    AccountStore.Create().Save(loggedInAccount, "Twitter");

                    var request = new OAuth2Request("GET", new Uri("https://api.twitter.com/1.1/account/verify_credentials.json"), null, eventArgs.Account);
                    request.GetResponseAsync().ContinueWith(t =>
                    {
                        if (t.IsFaulted)
                        //Alert.GetAlertMessage((Mono.Security.Interface.AlertDescription)t.Exception.InnerException.Message);
                        {
                            var obj = JsonValue.Parse(t.Result.GetResponseText());
                        }
                    });
                }
            };
            activity.StartActivity((Android.Content.Intent)auth.GetUI(activity));
        }
    }
}
