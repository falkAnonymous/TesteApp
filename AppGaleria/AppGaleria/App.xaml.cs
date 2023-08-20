using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using AppGaleria.Paginas.Conteudos;
using AppGaleria.Paginas.NavPaginas;
using AppGaleria.Paginas.Modal;
using AppGaleria.Paginas.CarrouselPaginas;

namespace AppGaleria
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            //object pagina = new NavigationPage(new Mpagina01());

            var pagina = new CarouselPage();
            pagina.Children.Add(new CarouselPagina01());
            pagina.Children.Add(new Carousel02());
            pagina.Children.Add(new Carousel03());


            MainPage = pagina;
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
