using System;
using Xamarin.Auth;

namespace TwitterList.Services
{
    public class Login : Constans, ILoginToTwitter
    {
        public void TwitterAuthentication()
        {
            var auth = new OAuth1Authenticator(
                              TWITTER_KEY,
                              TWITTER_SECRET,
                              new Uri(TWITTER_REQTOKEN_URL),
                              new Uri(TWITTER_AUTH),
                              new Uri(TWITTER_ACCESSTOKEN_URL),
                              new Uri(TWITTER_CALLBACK_URL));

            //auth.AllowCancel = true;
            //StartActivity(auth.GetUI(this)); - maybe this is for droid

            auth.Completed += async (sender, e) =>
            {
                //Fires when authentication is cancelled
                if (!e.IsAuthenticated)
                {
                    //Authentication failed Do something
                    return;
                }

                //Make request to get the parameters access
                var request = new OAuth1Request("GET",
                                  new Uri(TWITTER_GRAPH_URL),
                                  null,
                                  e.Account);

                //Get response here
                var response = await request.GetResponseAsync();
                if (response != null)
                {
                    //Get the user data here
                    var userData = response.GetResponseText();
                };

            };
        }
    }
}

