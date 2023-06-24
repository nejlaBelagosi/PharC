namespace PharC;

//*Nejla* kombinovani ViewModel 
public class CombinedViewModel
{

    public AdsViewModel AdsViewModel { get; set; }
    public ProductsViewModel ProductsViewModel { get; set; }


    //*Nejla*
    public CombinedViewModel()
    {
        AdsViewModel = new AdsViewModel();
        ProductsViewModel = new ProductsViewModel();
        
    }
}