

namespace PharC;

public class ProductsModel
{

    public string Name { get; set; }
    public string Image { get; set; }
    public string Price { get; set; }
    public int Product_Id { get; set; }
    public string Details { get; set; }
    

    public ProductsModel()
    {
        Name = "";
        Image = "";
        Price = "";
        Product_Id = 0;
        Details = "";
    }
}