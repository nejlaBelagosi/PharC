using System.Collections.ObjectModel;

namespace PharC;

public partial class SearchPage : ContentPage
{
    public SearchPage()
	{
		InitializeComponent();
        viewModel = new ProductsViewModel();

    }

    private void Searcbar_SearchButtonPressed(object sender, EventArgs e)
    {
        string searchText = Searcbar.Text;
        viewModel.FilterProducts(searchText);
    }
}