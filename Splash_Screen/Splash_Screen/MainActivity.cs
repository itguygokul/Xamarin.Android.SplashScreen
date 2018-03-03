using Android.App;
using Android.Widget;
using Android.OS;
using Android.Support.V7.App;
using Android.Support.V4.Widget;
using Android.Support.Design.Widget;
using Android.Views.Animations;
using Android.Content.PM;
using System.Threading;
using Android.Content;
using System.Threading.Tasks;

namespace Splash_Screen
{
    [Activity(Label = "Splash_Screen", MainLauncher = true, Icon = "@mipmap/icon", Theme = "@style/Splash_Theme.Main",  NoHistory = true, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation, ScreenOrientation = ScreenOrientation.Portrait)]
    public class MainActivity : AppCompatActivity
    {

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);


            SetContentView(Resource.Layout.Main);


            TextView textView1 = FindViewById<TextView>(Resource.Id.textView1);

            ImageView imageView1 = FindViewById<ImageView>(Resource.Id.imageView1);

            Animation myanim = AnimationUtils.LoadAnimation(this, Resource.Animation.MyTransition);

            textView1.StartAnimation(myanim);

            imageView1.StartAnimation(myanim);

        }


        // Launches the startup task
        protected override void OnResume()
        {
            base.OnResume();

            Task startupWork = new Task(() => { SimulateStartup(); });
            startupWork.Start();

        }


        async void SimulateStartup()
        {
            
            await Task.Delay(3000);

            this.StartActivity(new Intent(Application.Context, typeof(HomeActivity)));

        }

    }
}

