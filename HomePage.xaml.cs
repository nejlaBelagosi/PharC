

namespace PharC;

public partial class HomePage : TabbedPage
{
  

    public HomePage()
	{
        InitializeComponent();
       
        //*Nejla* Binding context
        BindingContext = new ProductsViewModel();
       
    }

    private void ShowDetails_Clicked(object sender, EventArgs e)
    {
        Button button = (Button)sender;
        ProductsModel selectedProduct = button.BindingContext as ProductsModel;

        switch (selectedProduct.Product_Id)
        {
            case 1:
                Navigation.PushAsync(new ProductsDetails(selectedProduct));
                break;
            case 2:
                Navigation.PushAsync(new ProductsDetails(selectedProduct));
                break;
            case 3:
                break;
            case 4:
                Navigation.PushAsync(new ProductsDetails(selectedProduct));
                break;
            case 5:
                Navigation.PushAsync(new ProductsDetails(selectedProduct));
                break;
            case 6:
                Navigation.PushAsync(new ProductsDetails(selectedProduct));
                break;
            case 7:
                Navigation.PushAsync(new ProductsDetails(selectedProduct));
                break;
            case 8:
                Navigation.PushAsync(new ProductsDetails(selectedProduct));
                break;
            case 9:
                Navigation.PushAsync(new ProductsDetails(selectedProduct));
                break;
            case 10:
                Navigation.PushAsync(new ProductsDetails(selectedProduct));
                break;
            case 11:
                Navigation.PushAsync(new ProductsDetails(selectedProduct));
                break;
            case 12:
                Navigation.PushAsync(new ProductsDetails(selectedProduct));
                break;
            case 13:
                Navigation.PushAsync(new ProductsDetails(selectedProduct));
                break;
            case 14:
                Navigation.PushAsync(new ProductsDetails(selectedProduct));
                break;
            case 15:
                Navigation.PushAsync(new ProductsDetails(selectedProduct));
                break;
            case 16:
                Navigation.PushAsync(new ProductsDetails(selectedProduct));
                break;
            // add cases for other product ids and their respective pages

            default:

               // handle the case when the product id is not recognized
                       break;
                    }

        }
}