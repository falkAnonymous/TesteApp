using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AppGaleria.Paginas.NavPaginas.Formulario;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppGaleria.Paginas.NavPaginas
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Pagina3 : ContentPage
	{
		public Pagina3 ()
		{
			InitializeComponent ();
		}

        protected override bool OnBackButtonPressed()
        {
			return true;
        }

        private void Btn_AdcionarForm(object sender, EventArgs e)
        {
            Navigation.InsertPageBefore(new Formulario1(),this);
        }

        private void Btn_RemoverForm(object sender, EventArgs e)
        {
            Navigation.RemovePage(Navigation.NavigationStack[2]);
        }
    }
}