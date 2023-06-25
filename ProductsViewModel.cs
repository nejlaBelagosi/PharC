
using System.Collections.ObjectModel;
using System.Windows.Input;

namespace PharC;

//*Nejla* View Model za sve produkte koji se nalaze u apoteci i njihovo dodavanje u razlicitim carouselima
public class ProductsViewModel

{
    public int SelectedProductId { get; set; }
    public ProductsViewModel()
    {
        LoadData();
    }


    //public ObservableCollection<ProductsModel> Product { get; set; } = new ObservableCollection<ProductsModel>
    public ObservableCollection<ProductsModel> Carousel1Products { get; } = new ObservableCollection<ProductsModel>();
    public ObservableCollection<ProductsModel> Carousel2Products { get; } = new ObservableCollection<ProductsModel>();
    public ObservableCollection<ProductsModel> Carousel3Products { get; } = new ObservableCollection<ProductsModel>();
    public ObservableCollection<ProductsModel> Carousel4Products { get; } = new ObservableCollection<ProductsModel>();
    public ObservableCollection<ProductsModel> SelectedProducts { get; } = new ObservableCollection<ProductsModel>();


    public void LoadData()
    {
        // dodavanje podataka u prvi carousel
        Carousel1Products.Add(new ProductsModel

        {
            Name = "Amygdallon Bademovo ulje 100 ml",
            Image = "bademovo.png",
            Price = "$8,99",
            Product_Id = 1,
            Details = 
            "Almond oil is a delicacy oil with pleasant sensory properties. It has been used for many years for its numerous health benefits. " +
            "It is extremely rich in proteins, vitamins A, B1, B2, B6, E."
            

        });

        Carousel1Products.Add(new ProductsModel
        {
            Name = "Advil Tablets 200mg",
            Image = "advil.png",
            Price = "$15.97",
            Product_Id = 2,
            Details = "Advil has provided safe, effective pain relief for over 35+ years." +
            "So whether you have a headache, muscle aches, backaches, menstrual pain, minor arthritis and other joint pain."
            

        });
        Carousel1Products.Add(new ProductsModel
        {
            Name = "Forever young Collagen 500 ml",
            Image = "kolagen.png",
            Price = "$58.70",
            Product_Id = 3,
            Details = "The secret of Collagen Boost is the ideal selection and ratio of" +
            " all ingredients that are combined together to maximize collagen absorption and make your skin and hair look youthful. ",

        });
        Carousel1Products.Add(new ProductsModel
        {
            Name = "Hawaiian Lotion Sunscreen - 8oz",
            Image = "hawaiian_sunscreen.png",
            Price = "$9.99",
            Product_Id = 4,
            Details = "Detaljni opis produkta ",

        });
        // Dodavanje produkata u drugi carousel
        Carousel2Products.Add(new ProductsModel
        {
            Name = "Vividrin 10ml",
            Image = "vividrin.png",
            Price = "$5.13",
            Product_Id = 5,
            Details = "Detaljni opis produkta ",
        });
        Carousel2Products.Add(new ProductsModel
        {
            Name = "Lorano Pro 5mg ",
            Image = "loranopro.png",
            Price = "$7.13",
            Product_Id = 6,
            Details = "Detaljni opis produkta ",
        });
        Carousel2Products.Add(new ProductsModel
        {
            Name = "Cetirizin Hexal 10mg",
            Image = "cetirizin.png",
            Price = "$16.15",
            Product_Id = 7,
            Details = "Detaljni opis produkta ",
        });
        Carousel2Products.Add(new ProductsModel
        {
            Name = "Fenistil Gel 1mg/g",
            Image = "fenistil_gel.png",
            Price = "$6.79",
            Product_Id = 8,
            Details = "Detaljni opis produkta ",
        });

        //dodavanje produkata u treci carousel
        Carousel3Products.Add(new ProductsModel
        {
            Name = "Supradyn Immuno",
            Image = "supradyn.png",
            Price = "$11.80",
            Product_Id = 9,
            Details = "Detaljni opis produkta ",
        });
        Carousel3Products.Add(new ProductsModel
        {
            Name = "Ibuprofen 200mg ",
            Image = "ibuprofen.png",
            Price = "$12.00",
            Product_Id = 10,
            Details = "Detaljni opis produkta ",
        });
        Carousel3Products.Add(new ProductsModel
        {
            Name = "Facial Cleanser",
            Image = "facial_cleanser_01",
            Price = "$16.15",
            Product_Id = 11,
            Details = "Detaljni opis produkta ",
        });
        Carousel3Products.Add(new ProductsModel
        {
            Name = "Synofen 500mg",
            Image = "synofen.png",
            Price = "$9.87",
            Product_Id = 12,
            Details = "Detaljni opis produkta ",
        });
        // dodavanje u cetvrti carousel
        Carousel4Products.Add(new ProductsModel
        {
            Name = "Micellar",
            Image = "micellar_01.png",
            Price = "$20.80",
            Product_Id = 13,
            Details = "Detaljni opis produkta ",
        });
        Carousel4Products.Add(new ProductsModel
        {
            Name = "Moisturiser ",
            Image = "moisturiser_01.png",
            Price = "$25.99",
            Product_Id = 14,
            Details = "Detaljni opis produkta ",
        });
        Carousel4Products.Add(new ProductsModel
        {
            Name = "Tylenol Extra",
            Image = "tylenol.png",
            Price = "$16.15",
            Product_Id = 15,
            Details = "Detaljni opis produkta ",
        });
        Carousel4Products.Add(new ProductsModel
        {
            Name = "Cleansing Oil",
            Image = "cleansing_oil_01.png",
            Price = "$9.87",
            Product_Id = 16,
            Details = "Detaljni opis produkta ",
        });
    }


}
