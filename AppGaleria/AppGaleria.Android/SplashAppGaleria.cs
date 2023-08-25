using Android.App;
using Android.Content;
using Android.Content.PM;
using Android.OS;
using System.Threading.Tasks;

namespace AppGaleria.Droid
{
    [Activity(Label = "ChatLove", Icon = "@mipmap/ic_launcher", Theme = "@style/MainTheme.Splash", MainLauncher = true, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation | ConfigChanges.UiMode | ConfigChanges.ScreenLayout | ConfigChanges.SmallestScreenSize)]
    public class SplashAppGaleria : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            StartActivity(typeof(MainActivity));
            Finish();

            // Disable activity slide-in animation
            OverridePendingTransition(0, 0);
        }
    }
}
