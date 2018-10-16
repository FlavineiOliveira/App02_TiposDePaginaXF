using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App02_TiposDePaginaXF.Views.MasterDetail
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MasterDetailPageView : MasterDetailPage
    {
        public MasterDetailPageView()
        {
            InitializeComponent();
        }

        private void Pagina1_Clicked(object sender, EventArgs e)
        {
            Detail = new Navigation1View();
        }

        private void Pagina2_Clicked(object sender, EventArgs e)
        {
            Detail = new Navigation2View();
        }

        private void Conteudo_Clicked(object sender, EventArgs e)
        {
            Detail = new CounteudoMasterView();
        }
    }
}