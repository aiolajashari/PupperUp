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
	public partial class LogIn : ContentPage
	{
		public LogIn ()
		{
			InitializeComponent ();
		}

        async void ButtonLogInCheck(object sender, EventArgs e)
        {
            Button button = sender as Button;
            await Navigation.PushModalAsync(new Home());

        }

         async void ButtonSignUpRedirect(object sender, EventArgs e)
        {
            Button button = sender as Button;
            await Navigation.PushModalAsync(new SignUp());
        }
    }
}