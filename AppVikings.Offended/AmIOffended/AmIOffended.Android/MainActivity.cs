using Android.App;
using Android.Content.PM;
using Android.OS;
using MvvmCross.Forms.Droid.Views;

namespace AmIOffended.Droid
{
    [Activity(Label = "Am I Offended", Icon = "@drawable/offended_icon", Theme = "@style/MainTheme", ScreenOrientation = ScreenOrientation.Portrait)]
    public class MainActivity : MvxFormsApplicationActivity
    {        
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
        }
    }
}
