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
    public partial class TestePage : ContentPage
    {
        public TestePage()
        {
            InitializeComponent();
        }

        private void LoginBtn_Clicked(object sender, EventArgs e)
        {
            DisplayAlert("cliquei", "message", "botao");
        }
    }
}