namespace PharC;

public partial class ProductsDetails : ContentPage
{
	public ProductsDetails(ProductsModel selectedProduct)
	{
		InitializeComponent();

        ProductName.Text = selectedProduct.Name;
        ProductDescription.Text = selectedProduct.Details;
        ProductImage.Source = selectedProduct.Image;
    }
   
}