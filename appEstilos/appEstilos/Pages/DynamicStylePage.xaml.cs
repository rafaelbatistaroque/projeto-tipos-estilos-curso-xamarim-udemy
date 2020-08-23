using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace appEstilos.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class DynamicStylePage : ContentPage
    {
        public DynamicStylePage()
        {
            InitializeComponent();
        }

        private void MudarCor(object s, EventArgs e)
        {
            //this.Resources["lblColor"] = Color.Tomato;
            this.Resources["lblColor"] = this.Resources["lbl"];
        }
    }
}