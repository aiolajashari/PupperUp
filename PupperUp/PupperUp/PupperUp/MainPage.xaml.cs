using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace PupperUp
{
	public partial class MainPage : ContentPage
	{
		public MainPage()
		{
			InitializeComponent();
            
        }


        async void ButtonSignUp(object sender, EventArgs e)
        {
            //find out what sender does
            Button button = sender as Button;
            await Navigation.PushModalAsync(new SignUp());
        
            
        }

        async void ButtonLogIn(object sender, EventArgs e)
        {
            //find out what sender does
            Button button = sender as Button;
            button.BackgroundColor = Color.White;
            button.TextColor = Color.FromRgb(0, 199, 146);
            await Navigation.PushModalAsync(new LogIn());

        }
    }
}
