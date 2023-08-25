using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppGaleria.Paginas.PaginasGuias
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Guiarapida : TabbedPage
    {
        public Guiarapida()
        {
            InitializeComponent();

            CurrentPage = Children[2];

            this.CurrentPageChanged += (object sender, EventArgs e) => {
                this.Title = this.CurrentPage.Title;
            };


        }

    }
}