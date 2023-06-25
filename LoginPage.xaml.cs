
using Microsoft.Maui.ApplicationModel.Communication;


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

    private void Registruj_Clicked(object sender, EventArgs e)
    {

        

        string KorIme = KorisnickoIme.Text;
        string email = emailEntry.Text;
        string pass = Password.Text;



        List<string> RegistrovaniKorisnici = new List<string>();
        RegistrovaniKorisnici.Add(KorIme);
        RegistrovaniKorisnici.Add(email);
        RegistrovaniKorisnici.Add(pass);


        if (KorIme == null && email == null && pass == null)
        {
            BezuspjesnaRegistracija.IsVisible = true;


        }

        else
        {

            BezuspjesnaRegistracija.IsVisible = false;
            UspjesnaRegistracija.IsVisible = true;
            Navigation.PushAsync(new HomePage());
        }
    }
}
