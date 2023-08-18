using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppGaleria.Paginas.NavPaginas
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Pagina1 : ContentPage
	{
		public Pagina1 ()
		{
			InitializeComponent ();
		}

        private void Btn_Avançar(object sender, EventArgs e)
        {
			Navigation.PushAsync(new Pagina2());
        }

        private void Btn_Cancelar(object sender, EventArgs e)
        {
			System.Environment.Exit(0);
        }
    }
}