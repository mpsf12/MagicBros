using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MagicBros.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Login : ContentPage
	{
		public Login ()
		{
			InitializeComponent ();
		}

        private void LoginBtn_Clicked(object sender, EventArgs e)
        {
            Navigation.PopModalAsync();
            //new NavigationPage(new MainPage());
            //Navigation.PushAsync(new MainPage());
            //Navigation.InsertPageBefore(new MainPage(), this);
        }
    }
}