class Product
{
    private string _name;

    private int _productID;

    private int _price;

    private int _quantity;

    public Product(string name, int productID, int price, int quantity)
    {
        _name = name;
        _price = price;
        _productID = productID;
        _quantity = quantity;
    }
    public int ComputePrice()
    {
        return _price * _quantity;
    }
    
    public string PackingLable()
    {
        int total = ComputePrice();
        return $"{_name}, #{_productID}: ${total}";
    }
}