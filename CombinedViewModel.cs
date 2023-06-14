namespace PharC;

//*Nejla* kombinovani ViewModel 
public class CombinedViewModel
{

    public AdsViewModel AdsViewModel { get; set; }
    public ProductsViewModel ProductsViewModel { get; set; }
    public AllergySeasonViewModel AllergySeasonViewModel { get; set; }
    public TopOffersViewModel TopOffersViewModel { get; set; }
    public NewProductsViewModel NewProductsViewModel { get; set; }

    //*Nejla*
    public CombinedViewModel()
    {
        AdsViewModel = new AdsViewModel();
        ProductsViewModel = new ProductsViewModel();
        AllergySeasonViewModel = new AllergySeasonViewModel();
        TopOffersViewModel = new TopOffersViewModel();
        NewProductsViewModel = new NewProductsViewModel();
    }
}