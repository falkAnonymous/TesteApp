using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using AppGaleria.Paginas.Conteudos;
using AppGaleria.Paginas.NavPaginas;

namespace AppGaleria
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            object pagina = new NavigationPage(new Pagina1());
            MainPage = (Page)pagina;
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
