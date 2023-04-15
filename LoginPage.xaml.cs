
namespace PharC;
public partial class LoginPage : ContentPage
{
	public LoginPage()
	{
		InitializeComponent();
       
 
    }

    private void LoginBtn_Clicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new HomePage());
    }

    private void ForgotButton_Clicked(object sender, EventArgs e)
    {
        
    }
}