using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ParentApp.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Login : ContentPage
    {
        public Login()
        {
            InitializeComponent();
            ///DisplayAlert(title:"Hello", message:"How are you",cancel:"Cancel");
        }

        private void loginClicked(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(username.Text)) 
            {
                
            }
        }
    }
}