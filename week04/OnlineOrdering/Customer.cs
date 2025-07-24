public class Customer
{
    private string _customerName;
    private Address _customerAddress;

    public Customer(string customerName, Address customerAddress)
    {
        _customerName = customerName;
        _customerAddress = customerAddress;
    }

    public bool IsInUSA()
    {
        return _customerAddress.IsInUSA();
    }

    public string GetCustomerInfo()
    {
        return $"Customer Name: {_customerName}\nAddress:\n{_customerAddress.GetFullAddress()}";
    }
}