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
        protected override async void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Adicione um atraso de 8 segundos
            await Task.Delay(8000);

            // Inicie a MainActivity após o atraso
            StartActivity(typeof(MainActivity));

            // Termine esta atividade
            Finish();

            // Desative a animação de entrada da atividade
            OverridePendingTransition(0, 0);
        }
    }
}
