class Order
{
    private List<Product> _order = new List<Product>();


    private int _shippingCost;

    private int _totalcost;

    public void GetShippingCost(Customer customer)
    {
        bool USA = customer.WhereLive();
        if (USA)
        {
            _shippingCost = 35;    
        }
        else
        {
            _shippingCost = 5;
        }
        
    }
    public int TotalPrice()
    {
        foreach(Product product in _order)
        {
            _totalcost += product.ComputePrice();
        }
        return _totalcost + _shippingCost;
    }

    public void LoadProducts(Product product)
    {
        _order.Add(product);
    }

    public string ReturnShippingLabel(Customer customer)
    {
        (string name, string address) = customer.ShippingLable();
        string shippingLable = name + "\n" + address;
        return shippingLable;
    }

    public List<Product> ReturnPackingLabel()
    {
        return _order;
    }
}