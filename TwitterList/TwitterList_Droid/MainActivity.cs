using Android.App;
using Android.OS;
using Android.Widget;

namespace TwitterList_Droid
{
    [Activity(Label = "TwitterList_Droid", MainLauncher = true, Icon = "@mipmap/icon")]
    public class MainActivity : Activity
    {
        Button twitterBtn;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            twitterBtn = FindViewById<Button>(Resource.Id.TwitterButton);
        }
    }
}

