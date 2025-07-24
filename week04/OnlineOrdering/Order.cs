public class Order
{
    private List<Product> _products;
    private Customer _customer;

    public Order(Customer customer)
    {
        _customer = customer;
        _products = new List<Product>();
    }
    public void AddProduct(Product product)
    {
        _products.Add(product);
    }

    public string GetPackingLabel()
    {
        string label = "Packing Label:\n";
        foreach (Product p in _products)
        {
            label += $"{p.GetProductInfo()}\n";
        }
        return label;
    }

    public string GetShippingLabel()
    {
        return $"Shipping Label:\n{_customer.GetCustomerInfo()}";
    }

    public decimal GetTotalPrice()
    {
        decimal total = 0;
        foreach (Product p in _products)
        {
            total += p.GetTotalPrice();
        }

        decimal shippingCost = _customer.IsInUSA() ? 5.00m : 35.00m;
        return total + shippingCost;
    }
}