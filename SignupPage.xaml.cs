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


        string KorIme = LastNameEntry.Text;
        string email = emailEntry.Text;
        string pass = passwordEntry.Text;
        string conf = confirmPasswordEntry.Text;



        List<string> RegistrovaniKorisnici = new List<string>();
        RegistrovaniKorisnici.Add(KorIme);
        RegistrovaniKorisnici.Add(email);
        RegistrovaniKorisnici.Add(pass);
        RegistrovaniKorisnici.Add(conf);


        if (KorIme == null && email == null && pass == null && conf == null)
        {
            BezuspjesnaRegistracija.IsVisible = true;


        }

        else
        {

            BezuspjesnaRegistracija.IsVisible = false;
            UspjesnaRegistracija.IsVisible = true;
            Navigation.PushAsync(new LoginPage());
        }
    }
    
}