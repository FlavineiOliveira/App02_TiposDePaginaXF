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
    public partial class NavigationModalView : ContentPage
    {
        public NavigationModalView()
        {
            InitializeComponent();
        }

        private async void FecharModal_Clicked(object sender, EventArgs e)
        {
            await Navigation.PopModalAsync();
        }
    }
}