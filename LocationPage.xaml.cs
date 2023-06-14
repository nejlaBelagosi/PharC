namespace PharC;

public partial class LocationPage : ContentPage
{
	public LocationPage()
	{
		InitializeComponent();
	}
    async private void Mapa_Clicked(object sender, EventArgs e)
    {

        var location = new Location(43.856333, 18.413222);
        var options = new MapLaunchOptions { Name = "Pharmacy N&N, 71000 Sarajevo" };
        try
        {
            await Map.OpenAsync(location, options);
        }
        catch (Exception ex)
        {
        }




    }
}