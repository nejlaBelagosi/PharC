namespace PharC;

public partial class MainPage : ContentPage
{
	

	public MainPage()
	{
		InitializeComponent();

}

    private void OnClickLogin(object sender, EventArgs e)
    {
        Navigation.PushAsync(new LoginPage());
    }
    private void OnClickSignUp(object sender, EventArgs e)
	{
        Navigation.PushAsync(new SignupPage());
    }
}

