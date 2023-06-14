using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace PharC;

public partial class SignupPage : ContentPage
{
    public SignupPage()
    {
        InitializeComponent();

    }

    private void RegisterBtn_Clicked(object sender, EventArgs e)
    {
		Navigation.PushAsync(new LoginPage());
    }
}