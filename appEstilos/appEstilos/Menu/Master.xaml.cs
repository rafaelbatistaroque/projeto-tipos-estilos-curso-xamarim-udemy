using appEstilos.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace appEstilos.Menu
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Master : MasterDetailPage
    {
        public Master()
        {
            InitializeComponent();
        }

        private void IrPaginaImplicitStylePage(object s, EventArgs e)
        {
            Detail = new NavigationPage(new ImplicitStylePage());
            IsPresented = false;
        }

        private void IrPaginaExplicitStylePage(object s, EventArgs e)
        {
            Detail = new NavigationPage(new ExplicitStylePage());
            IsPresented = false;
        }

        private void IrPaginaGlobalStylePage(object s, EventArgs e)
        {
            Detail = new NavigationPage(new GlobalStylePage());
            IsPresented = false;
        }

        private void IrPaginaInheritStylePage(object s, EventArgs e)
        {
            Detail = new NavigationPage(new InheritStylePage());
            IsPresented = false;
        }

        private void IrPaginaDynamicStylePage(object s, EventArgs e)
        {
            Detail = new NavigationPage(new DynamicStylePage());
            IsPresented = false;
        }
    }
}