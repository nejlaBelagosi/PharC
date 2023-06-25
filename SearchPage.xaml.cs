using System.Collections.ObjectModel;

namespace PharC;

public partial class SearchPage : ContentPage
{
    private ObservableCollection<ProductsModel> allProducts;
    public SearchPage()
	{
		InitializeComponent();
        viewModel = new ProductsViewModel();
        allProducts = viewModel.Products;

    }

    private void Searchbar_SearchButtonPressed(object sender, EventArgs e)
    {
        string searchText = Searchbar.Text;

        if (string.IsNullOrWhiteSpace(searchText))
        {
            ProductsList.ItemsSource = allProducts;
        }
        else
        {
            var filteredProducts = allProducts.Where(p => p.Name.ToLower().Contains(searchText.ToLower())).ToList();
            ProductsList.ItemsSource = filteredProducts;
        }
    }

}