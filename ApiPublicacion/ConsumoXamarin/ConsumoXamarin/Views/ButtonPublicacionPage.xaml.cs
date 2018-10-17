using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ConsumoXamarin.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class ButtonPublicacionPage : ContentPage
	{
		public ButtonPublicacionPage ()
		{
			InitializeComponent ();
		}

        private async void VerPublicacion(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new PublicacionPage());
        }
    }
}