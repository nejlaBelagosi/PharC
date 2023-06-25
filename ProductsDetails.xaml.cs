namespace PharC;

public partial class ProductsDetails : ContentPage

{
	public ProductsDetails(ProductsModel selectedProduct)
	{
		InitializeComponent();

        ProductName.Text = selectedProduct.Name;
        ProductDescription.Text = selectedProduct.Details;
        ProductImage.Source = selectedProduct.Image;
        ProductPrice.Text = selectedProduct.Price;
    }
    private void Button_Clicked(object sender, EventArgs e)
    {
        Button button = (Button)sender;
        button.TextColor = Colors.Red;
    }

    private void BackToHomePage_Clicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new HomePage());
    }
}