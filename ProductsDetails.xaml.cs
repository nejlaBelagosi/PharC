namespace PharC;

public partial class ProductsDetails : ContentPage

{
    public List<ProductsModel> cartItems;

    public ProductsDetails(ProductsModel selectedProduct)
	{
		InitializeComponent();
        // za prikaz informaciju o productu u ProductDetails.xaml
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

    
    private void Add_To_Cart_Clicked(object sender, EventArgs e)
    {


    }
}