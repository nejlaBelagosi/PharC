using System.Collections.ObjectModel;

namespace PharC;

//*Nejla* View model za allergy season produkte
public class AllergySeasonViewModel
{
    public ObservableCollection<ProductsModel> AllergyProducts { get; set; } = new ObservableCollection<ProductsModel>
    {
            new ProductsModel
            {
                Name = "Vividrin 10ml",
                Image = "vividrin.png",
                Price = "$5.13",

            },
            new ProductsModel
             {
                Name = "Lorano Pro 5mg ",
                Image = "loranopro.png",
                Price = "$7.13",

            },
            new ProductsModel
            {
                Name = "Cetirizin Hexal 10mg",
                Image = "cetirizin.png",
                Price = "$16.15",

            },
            new ProductsModel
            {
                Name = "Fenistil Gel 1mg/g",
                Image = "fenistil_gel.png",
                Price = "$6.79",

            },
    };
}
