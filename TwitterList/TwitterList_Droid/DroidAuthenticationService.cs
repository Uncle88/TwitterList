using System;
using TwitterList;
using TwitterList.Authentication;
using Xamarin.Auth;
using MvvmCross.Platform.Droid.Views;

namespace TwitterList_Droid
{
    public class DroidAuthenticationService : Constans, IAuthenticationService
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

            auth.AllowCancel = true;
            auth.Completed += (s, eventArgs) =>
            {
                if (eventArgs.IsAuthenticated)
                {
                    //save the account data for a later session, according to Twitter docs, this doesn't expire
                    Account loggedInAccount = eventArgs.Account;
                    AccountStore.Create().Save(loggedInAccount, "Twitter");
                }
                else return;
            };
            //StartActivity(auth.GetUI(this));
            //var filehandler = Mvx.Resolve<IAuthenticationService>();
        }
    }
}
