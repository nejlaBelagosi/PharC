using System.Collections.ObjectModel;

namespace PharC;

//*Nejla* View Model za produkte
public class ProductsViewModel
{
    public ObservableCollection<ProductsModel> Product { get; set; } = new ObservableCollection<ProductsModel>
    {
            new ProductsModel
            {
                Name = "Amygdallon Bademovo ulje 100 ml",
                Image = "bademovo.png",
                Price = "$8,99",

            },
            new ProductsModel
             {
                Name = "Advil Tablets 200mg",
                Image = "advil.png",
                Price = "$15.97",

            },
            new ProductsModel
            {
                Name = "Forever young Collagen 500 ml",
                Image = "kolagen.png",
                Price = "$58.70",

            },
            new ProductsModel
            {
                Name = "Hawaiian Tropic Sheer Touch Radiance Lotion Sunscreen - 8oz",
                Image = "hawaiian_sunscreen.png",
                Price = "$9.99",

            },
    };



}
