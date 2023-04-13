namespace PharC;

public partial class App : Application
{
	public App()
	{
		InitializeComponent();

        var navPage = new NavigationPage(new MainPage());
		navPage.BarBackground = Color.FromArgb("#2BE0C0");

        navPage.BarTextColor = Colors.Black;

		MainPage = navPage;
		

    }
   


}
