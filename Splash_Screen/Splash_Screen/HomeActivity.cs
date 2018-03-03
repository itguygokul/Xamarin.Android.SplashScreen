using Android.App;
using Android.Widget;
using Android.OS;
using Android.Support.V7.App;
using Android.Support.V4.Widget;
using Android.Support.Design.Widget;
using Android.Views.Animations;
using Android.Content.PM;

namespace Splash_Screen
{
    [Activity(Label = "Home Page", MainLauncher = false, Icon = "@mipmap/icon", Theme = "@style/Splash_Theme.pages", ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation, ScreenOrientation = ScreenOrientation.Portrait)]
    public class HomeActivity : AppCompatActivity
    {

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);


            SetContentView(Resource.Layout.Home);

            // Create your application here
        }
    }
}
