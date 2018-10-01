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
	public partial class SignUp : ContentPage
	{
		public SignUp ()
        {

            InitializeComponent();
        }

        private void ButtonConfirm(object sender, EventArgs e)
        {
            

        }


        async void ButtonLogInRedirect(object sender, EventArgs e)
        {
            Button button = sender as Button;
            await Navigation.PushModalAsync(new LogIn());
           
        }
    }
    
}