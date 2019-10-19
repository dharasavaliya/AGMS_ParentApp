using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using ParentApp.Views.LoginScreenSimple1.Views;

namespace ParentApp.Views.LoginScreenSimple1
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class LoginScreenSimple1 : ContentPage, INavigationHandler
	{
	    public LoginScreenSimple1()
		{
		    InitializeComponent();

		    this.BindingContext = new LoginPageViewModel { NavigationHandler = this };

            this.Content = new LoginView();
        }

	    public void LoadView(ViewType viewType)
        {
            switch (viewType)
            {
                case ViewType.LoginView:
                    this.Content = new LoginView();
                    break;
                case ViewType.SignUpView:
                    this.Content = new SignUpView();
                    break;
                case ViewType.PasswordResetView:
                    this.Content = new PasswordResetView();
                    break;
            }
        }
        
        protected override bool OnBackButtonPressed()
        {
            var viewType = this.Content.GetType();

            if (viewType == typeof(SignUpView) || viewType == typeof(PasswordResetView))
            {
                this.Content = new LoginView();
                return true;
            }

            return base.OnBackButtonPressed();
        }
    }
}