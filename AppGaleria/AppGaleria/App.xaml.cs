using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
//using AppGaleria.Paginas.Conteudos;
//using AppGaleria.Paginas.NavPaginas;
//using AppGaleria.Paginas.Modal;
//using AppGaleria.Paginas.CarouselPaginas;
//using AppGaleria.Paginas.PaginasGuias;
using AppGaleria.Paginas.MenuLateral;
using AppGaleria.Paginas.PaginasGuias;

namespace AppGaleria
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            //object pagina = new NavigationPage(new Mpagina01());

            //var paginas = new CarouselPage();
            //paginas.Children.Add(new PaginaPrincipal1());
            //paginas.Children.Add(new Cpagina02());
            //paginas.Children.Add(new Cpagina03());
            //paginas.CurrentPage = paginas.Children[1];

            //object paginas = new TabbedPage1();

            //MainPage = (Page)paginas;

            //var pagina = new FlyoutPage();


            //// Menu
            //pagina.Flyout = new Conteudo02();



            ////Conteudo
            //pagina.Detail = new Conteudo03();


            // Main

            object PaginaInicial = new NavigationPage(new Pagina_Chat());
            MainPage = (Page)PaginaInicial;


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
