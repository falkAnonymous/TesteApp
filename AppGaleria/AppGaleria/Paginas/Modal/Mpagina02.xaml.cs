using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppGaleria.Paginas.Modal
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Mpagina02 : ContentPage
    {
        public Mpagina02()
        {
            InitializeComponent();
        }

        private void Btn_Fechar(object sender, EventArgs e)
        {
            Navigation.PopModalAsync(false);
        }
    }
}