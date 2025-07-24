public class Product
{
    private string _productName;
    private string _productId;
    private decimal _price;
    private int _quantity;

    public Product(string productName, string productId, decimal price, int quantity)
    {
        _productName = productName;
        _productId = productId;
        _price = price;
        _quantity = quantity;
    }

    public string GetProductInfo()
    {
        return $"Product Name: {_productName}\nProduct ID: {_productId}\nPrice: {_price:C}\nQuantity: {_quantity}";
    }
    public decimal GetTotalPrice()
    {
        return _price * _quantity;
    }
}