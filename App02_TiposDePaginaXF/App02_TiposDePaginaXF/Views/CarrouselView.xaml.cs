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
	public partial class CarrouselView : CarouselPage
	{
		public CarrouselView ()
		{
			InitializeComponent ();
		}

        private void Avancar_Clicked(object sender, EventArgs e)
        {
            App.Current.MainPage = new NavigationPage(new Navigation1View()) {
                BarTextColor = Color.White,
                BarBackgroundColor = Color.Black
            };
        }
    }
}