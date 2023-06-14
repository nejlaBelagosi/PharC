using System.Collections.ObjectModel;

namespace PharC;

//*Nejla* ViewModel za top offers proizvode
public class TopOffersViewModel
{
    public ObservableCollection<ProductsModel> TopOffersProducts { get; set; } = new ObservableCollection<ProductsModel>
    {
            new ProductsModel
            {
                Name = "Supradyn Immuno",
                Image = "supradyn.png",
                Price = "$11.80",

            },
            new ProductsModel
             {
                Name = "Ibuprofen 200mg ",
                Image = "ibuprofen.png",
                Price = "$12.00",

            },
            new ProductsModel
            {
                Name = "Facial Cleanser",
                Image = "facial_cleanser_01",
                Price = "$16.15",

            },
            new ProductsModel
            {
                Name = "Synofen 500mg",
                Image = "synofen.png",
                Price = "$9.87",

            },
    };
}
