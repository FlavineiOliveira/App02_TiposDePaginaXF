using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App02_TiposDePaginaXF.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Navigation1View : ContentPage
	{
		public Navigation1View ()
		{
			InitializeComponent ();
		}

        private async void ProximoPagina_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Navigation2View());
        }

        private async void AbrirModal_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new NavigationModalView());
        }
    }
}