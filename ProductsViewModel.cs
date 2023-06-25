
using System.Collections.ObjectModel;


namespace PharC;

//*Nejla* View Model za sve produkte koji se nalaze u apoteci i njihovo dodavanje u razlicitim carouselima
public class ProductsViewModel

{
    public int SelectedProductId { get; set; }
    public ProductsViewModel()
    {
        LoadData();
        UpdateFilteredProducts(Products);
    }


    //public ObservableCollection<ProductsModel> Product { get; set; } = new ObservableCollection<ProductsModel>
    public ObservableCollection<ProductsModel> Carousel1Products { get; } = new ObservableCollection<ProductsModel>();
    public ObservableCollection<ProductsModel> Carousel2Products { get; } = new ObservableCollection<ProductsModel>();
    public ObservableCollection<ProductsModel> Carousel3Products { get; } = new ObservableCollection<ProductsModel>();
    public ObservableCollection<ProductsModel> Carousel4Products { get; } = new ObservableCollection<ProductsModel>();
    public ObservableCollection<ProductsModel> SelectedProducts { get; } = new ObservableCollection<ProductsModel>();
    public ObservableCollection<ProductsModel> Products { get; } = new ObservableCollection<ProductsModel>();
    public ObservableCollection<ProductsModel> FilteredProducts { get; } = new ObservableCollection<ProductsModel>();


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
            Details = "HAWAIIAN TROPIC SUNSCREEN LOTION SPF 30 with an Ultra Radiance formula that leaves skin luminous" +
            "OIL-FREE SUNSCREEN LOTION WITH A NON-GREASY LOOK AND FEEL — contains vitamins C & E to condition skin ",

        });
        // Dodavanje produkata u drugi carousel
        Carousel2Products.Add(new ProductsModel
        {
            Name = "Vividrin 10ml",
            Image = "vividrin.png",
            Price = "$5.13",
            Product_Id = 5,
            Details = "Eye drops Vividrin ectoin 10 ml are a natural preparation that does not contain preservatives," +
            " which is why they are very suitable for sensitive eyes.",
        });
        Carousel2Products.Add(new ProductsModel
        {
            Name = "Lorano Pro 5mg ",
            Image = "loranopro.png",
            Price = "$7.13",
            Product_Id = 6,
            Details = "LoranoPro 5mg - For hay fever, house dust allergy and animal allergy ",
        });
        Carousel2Products.Add(new ProductsModel
        {
            Name = "Cetirizin Hexal 10mg",
            Image = "cetirizin.png",
            Price = "$16.15",
            Product_Id = 7,
            Details = "Cetirizin HEXAL® for allergies – strong for allergies runny nose, watery eyes or constant sneezing – allergies are tormenting and widespread.  ",
        });
        Carousel2Products.Add(new ProductsModel
        {
            Name = "Fenistil Gel 1mg/g",
            Image = "fenistil_gel.png",
            Price = "$6.79",
            Product_Id = 8,
            Details = "Fenistil gel is used for short-term relief of itching (pruritus) that accompanies skin reactions",
        });

        //dodavanje produkata u treci carousel
        Carousel3Products.Add(new ProductsModel
        {
            Name = "Supradyn Immuno",
            Image = "supradyn.png",
            Price = "$11.80",
            Product_Id = 9,
            Details = "Supradyn® IMUNO is a dietary supplement that is taken to support immunity" +
            " during periods of increased physical or mental stress ",
        });
        Carousel3Products.Add(new ProductsModel
        {
            Name = "Ibuprofen 200mg ",
            Image = "ibuprofen.png",
            Price = "$12.00",
            Product_Id = 10,
            Details = "Ibuprofen relieves pain, reduces inflammation and helps to lower temperatures if you have a fever. ",
        });
        Carousel3Products.Add(new ProductsModel
        {
            Name = "Facial Cleanser",
            Image = "facial_cleanser_01",
            Price = "$16.15",
            Product_Id = 11,
            Details = "Specially formulated gentle gel to foam formula " +
            "deep cleans and minimizes the appearance of pores without stripping skin of natural moisture. ",
        });
        Carousel3Products.Add(new ProductsModel
        {
            Name = "Synofen 500mg",
            Image = "synofen.png",
            Price = "$9.87",
            Product_Id = 12,
            Details = "Synofen against pain with the triple effect:fast, strong and well tolerated",
        });
        // dodavanje u cetvrti carousel
        Carousel4Products.Add(new ProductsModel
        {
            Name = "Micellar",
            Image = "micellar_01.png",
            Price = "$20.80",
            Product_Id = 13,
            Details = "ALL-IN-1 Cleanser To hydrate and Rrefresh skin: This all-in-1 micellar cleansing water is a facial cleanser and makeup remover that is gentle on skin." +
            " This micellar water for all skin types gently cleanses, removes makeup, dirt and oils from skin.",
        });
        Carousel4Products.Add(new ProductsModel
        {
            Name = "Moisturiser ",
            Image = "moisturiser_01.png",
            Price = "$25.99",
            Product_Id = 14,
            Details = "Moisturisers should be used every day as part of your skincare routine to ensure that your skin cells are healthy and rejuvenated, minimising irritation and dryness ",
        });
        Carousel4Products.Add(new ProductsModel
        {
            Name = "Tylenol Extra",
            Image = "tylenol.png",
            Price = "$16.15",
            Product_Id = 15,
            Details = "Trust Extra Strength TYLENOL®. " +
            "Extra Strength TYLENOL® products are tough on pain, but gentle on your stomach, providing fast, effective relief.",
        });
        Carousel4Products.Add(new ProductsModel
        {
            Name = "Cleansing Oil",
            Image = "cleansing_oil_01.png",
            Price = "$9.87",
            Product_Id = 16,
            Details = "If you have oily or acne-prone skin, " +
            "the concept of slathering on any oil-based products like cleansing oils probably doesn't make much sense. ",
        });

        // svi podaci
        Products.Add(new ProductsModel

        {
            Name = "Amygdallon Bademovo ulje 100 ml",
            Image = "bademovo.png",
            Price = "$8,99",
            Product_Id = 1,
            Details =
            "Almond oil is a delicacy oil with pleasant sensory properties. It has been used for many years for its numerous health benefits. " +
            "It is extremely rich in proteins, vitamins A, B1, B2, B6, E."


        });

       Products.Add(new ProductsModel
        {
            Name = "Advil Tablets 200mg",
            Image = "advil.png",
            Price = "$15.97",
            Product_Id = 2,
            Details = "Advil has provided safe, effective pain relief for over 35+ years." +
            "So whether you have a headache, muscle aches, backaches, menstrual pain, minor arthritis and other joint pain."


        });
        Products.Add(new ProductsModel
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
            Details = "HAWAIIAN TROPIC SUNSCREEN LOTION SPF 30 with an Ultra Radiance formula that leaves skin luminous" +
            "OIL-FREE SUNSCREEN LOTION WITH A NON-GREASY LOOK AND FEEL — contains vitamins C & E to condition skin ",

        });
      
        Products.Add(new ProductsModel
        {
            Name = "Vividrin 10ml",
            Image = "vividrin.png",
            Price = "$5.13",
            Product_Id = 5,
            Details = "Eye drops Vividrin ectoin 10 ml are a natural preparation that does not contain preservatives," +
            " which is why they are very suitable for sensitive eyes.",
        });
        Products.Add(new ProductsModel
        {
            Name = "Lorano Pro 5mg ",
            Image = "loranopro.png",
            Price = "$7.13",
            Product_Id = 6,
            Details = "LoranoPro 5mg - For hay fever, house dust allergy and animal allergy ",
        });
        Products.Add(new ProductsModel
        {
            Name = "Cetirizin Hexal 10mg",
            Image = "cetirizin.png",
            Price = "$16.15",
            Product_Id = 7,
            Details = "Cetirizin HEXAL® for allergies – strong for allergies runny nose, watery eyes or constant sneezing – allergies are tormenting and widespread.  ",
        });
        Products.Add(new ProductsModel
        {
            Name = "Fenistil Gel 1mg/g",
            Image = "fenistil_gel.png",
            Price = "$6.79",
            Product_Id = 8,
            Details = "Fenistil gel is used for short-term relief of itching (pruritus) that accompanies skin reactions",
        });

        Products.Add(new ProductsModel
        {
            Name = "Supradyn Immuno",
            Image = "supradyn.png",
            Price = "$11.80",
            Product_Id = 9,
            Details = "Supradyn® IMUNO is a dietary supplement that is taken to support immunity" +
            " during periods of increased physical or mental stress ",
        });
       Products.Add(new ProductsModel
        {
            Name = "Ibuprofen 200mg ",
            Image = "ibuprofen.png",
            Price = "$12.00",
            Product_Id = 10,
            Details = "Ibuprofen relieves pain, reduces inflammation and helps to lower temperatures if you have a fever. ",
        });
        Products.Add(new ProductsModel
        {
            Name = "Facial Cleanser",
            Image = "facial_cleanser_01",
            Price = "$16.15",
            Product_Id = 11,
            Details = "Specially formulated gentle gel to foam formula " +
            "deep cleans and minimizes the appearance of pores without stripping skin of natural moisture. ",
        });
       Products.Add(new ProductsModel
        {
            Name = "Synofen 500mg",
            Image = "synofen.png",
            Price = "$9.87",
            Product_Id = 12,
            Details = "Synofen against pain with the triple effect:fast, strong and well tolerated",
        });
        
        Products.Add(new ProductsModel
        {
            Name = "Micellar",
            Image = "micellar_01.png",
            Price = "$20.80",
            Product_Id = 13,
            Details = "ALL-IN-1 Cleanser To hydrate and Rrefresh skin: This all-in-1 micellar cleansing water is a facial cleanser and makeup remover that is gentle on skin." +
            " This micellar water for all skin types gently cleanses, removes makeup, dirt and oils from skin.",
        });
        Products.Add(new ProductsModel
        {
            Name = "Moisturiser ",
            Image = "moisturiser_01.png",
            Price = "$25.99",
            Product_Id = 14,
            Details = "Moisturisers should be used every day as part of your skincare routine to ensure that your skin cells are healthy and rejuvenated, minimising irritation and dryness ",
        });
       Products.Add(new ProductsModel
        {
            Name = "Tylenol Extra",
            Image = "tylenol.png",
            Price = "$16.15",
            Product_Id = 15,
            Details = "Trust Extra Strength TYLENOL®. " +
            "Extra Strength TYLENOL® products are tough on pain, but gentle on your stomach, providing fast, effective relief.",
        });
        Products.Add(new ProductsModel
        {
            Name = "Cleansing Oil",
            Image = "cleansing_oil_01.png",
            Price = "$9.87",
            Product_Id = 16,
            Details = "If you have oily or acne-prone skin, " +
            "the concept of slathering on any oil-based products like cleansing oils probably doesn't make much sense. ",
        });
    }

    public void FilterProducts(string searchText)
    {
        if (string.IsNullOrWhiteSpace(searchText))
        {
            // Ako je polje za pretragu prazno, prikaži sve proizvode
            UpdateFilteredProducts(Products);
        }
        else
        {
            // Filtriraj proizvode na temelju imena
            var filtered = Products.Where(p => p.Name.ToLower().Contains(searchText.ToLower()));
            UpdateFilteredProducts(filtered);
        }
    }

    private void UpdateFilteredProducts(IEnumerable<ProductsModel> filteredProducts)
    {
        FilteredProducts.Clear();
        foreach (var product in filteredProducts)
        {
           FilteredProducts.Add(product);
        }
    }




}
