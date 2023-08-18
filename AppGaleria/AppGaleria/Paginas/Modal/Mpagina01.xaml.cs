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
    public partial class Mpagina01 : ContentPage
    {
        public Mpagina01()
        {
            InitializeComponent();
        }

        private void Btn_Modal(object sender, EventArgs e)
        {
            Navigation.PushModalAsync(new Mpagina02(),false); 
        }
    }
}