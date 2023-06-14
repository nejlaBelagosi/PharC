using System.Collections.ObjectModel;

namespace PharC;

//*Nejla* View model
public class NewProductsViewModel
{
    public ObservableCollection<ProductsModel> NewProducts { get; set; } = new ObservableCollection<ProductsModel>
    {
            new ProductsModel
            {
                Name = "Micellar 30ml",
                Image = "micellar_01.png",
                Price = "$20.80",

            },
            new ProductsModel
             {
                Name = "Moisturiser ",
                Image = "moisturiser_01.png",
                Price = "$25.99",

            },
            new ProductsModel
            {
                Name = "Tylenol Extra Strength 500mg",
                Image = "tylenol.png",
                Price = "$16.15",

            },
            new ProductsModel
            {
                Name = "Cleansing Oil 30ml",
                Image = "cleansing_oil_01.png",
                Price = "$9.87",

            },
    };
}