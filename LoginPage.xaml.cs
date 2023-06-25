
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

    private void Button_Clicked(object sender, EventArgs e)
    {


        Preferences.Set("KorisnickoIme", KorisnickoIme.Text);


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
            UspjesnaRegistracija.IsVisible = false;
        }
        else
        {
            BezuspjesnaRegistracija.IsVisible = false;
            UspjesnaRegistracija.IsVisible = true;

            // Prikazivanje poruke na 2 sekunde, a zatim resetiranje vidljivosti labele
            Device.StartTimer(TimeSpan.FromSeconds(2), () =>
            {
                UspjesnaRegistracija.IsVisible = false;
                return false; // Prekida ponavljanje tajmera
            });

            Navigation.PushAsync(new SignupPage());
        }
    }
}
