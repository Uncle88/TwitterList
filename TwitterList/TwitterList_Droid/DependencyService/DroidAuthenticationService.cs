using System;
using Android.Content;
using TwitterList.Authentication;
using Xamarin.Auth;
using MvvmCross.Platform.Droid.Views;

namespace TwitterList_Droid.DependencyService
{
    //public class DroidAuthenticationService : IAuthenticationService
    //{
    //public void LoginToTwitter()
    //{
    //var auth = new OAuth1Authenticator(
    //consumerKey: "3v7rOXkdexGYhQmr3HVhtGgPO",
    //consumerSecret: "mGhRjee87tAp4X0vHUmMIohWoYy0JGg9zFGyin7CigFP64y3j5",
    //requestTokenUrl: new Uri("https://api.twitter.com/oauth/request_token"),
    //authorizeUrl: new Uri("https://api.twitter.com/oauth/authorize"),
    //accessTokenUrl: new Uri("https://api.twitter.com/oauth/access_token"),
    //callbackUrl: new Uri("http://mobile.twitter.com")
    //);
    //auth.AllowCancel = true;
    //auth.Completed += (s, eventArgs) =>
    //{
    //if (eventArgs.IsAuthenticated)
    //{
    //Account loggedInAccount = eventArgs.Account;
    //save the account data for a later session, according to Twitter docs, this doesn't expire
    //AccountStore.Create().Save(loggedInAccount, "Twitter");
    //}
    //};
    //var ui = auth.GetUI(this);//var ui = auth.GetUI(this);  
    //StartActivityForResult(ui, -1);  
    //MainActivity.GetObject(-1, ui);
    //}
    //}
}
