using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PupperUp
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Home : ContentPage
	{
		public Home ()
		{
			InitializeComponent ();
		}

        private async void OnTapHome(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new SignUp());
        }

        private void OnTapBookmark(object sender, EventArgs e)
        {

        }

        private void OnTapX(object sender, EventArgs e)
        {

        }

        private void OnTapHeart(object sender, EventArgs e)
        {

        }

        private void OnTapMessage(object sender, EventArgs e)
        {

        }

        private void OnTapLocation(object sender, EventArgs e)
        {

        }
    }
}