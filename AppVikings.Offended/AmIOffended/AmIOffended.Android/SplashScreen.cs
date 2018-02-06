using Android.App;
using Android.Content.PM;
using MvvmCross.Droid.Views;

namespace AmIOffended.Droid
{
    [Activity(
        Label = "Am I Offended?"
        , MainLauncher = true
        , Theme = "@style/MainTheme"
        , Icon = "@drawable/icon"
        , NoHistory = true
        , ScreenOrientation = ScreenOrientation.Portrait)]
    public class SplashScreen : MvxSplashScreenActivity
    {
        public SplashScreen()
            : base(Resource.Layout.SplashScreen)
        {
        }

        protected override void TriggerFirstNavigate()
        {
            StartActivity(typeof(MainActivity));
            base.TriggerFirstNavigate();
        }
    }
}
