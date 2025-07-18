using System.Text;
public class Order
{
    private List<Product> _products;
    private Customer _customer;

    // makes a new order
    public Order(Customer customer)
    {
        _customer = customer;
        // makes a list of products
        _products = new List<Product>(); 
    }

    // add something to your order
    public void NewProduct(Product product)
    {
        _products.Add(product);
    }

    // calculates cost of order
    public decimal CalculateTotalCost()
    {
        decimal totalProductsCost = 0;
        foreach (Product product in _products)
        {
            totalProductsCost += product.GetTotalCost();
        }
// we didnt forget shipping
        decimal shippingCost = 0;
        if (_customer.IsInUSA())
        {
            shippingCost = 5.00m; 
        }
        else
        {
            shippingCost = 35.00m; 
        }

        return totalProductsCost + shippingCost;
    }

    // make the shipping label
    public string NewPackingLabel()
    {
        StringBuilder sb = new StringBuilder();
        sb.AppendLine("--- Packing Label ---");
        foreach (Product product in _products)
        {
            sb.AppendLine($"Product: {product.Name}, ID: {product.ProductId}");
        }
        sb.AppendLine("---------------------");
        return sb.ToString();
    }
    public string NewShippingLabel()
    {
        StringBuilder sb = new StringBuilder();
        sb.AppendLine("--- Shipping Label ---");
        sb.AppendLine($"Customer: {_customer.Name}");
        sb.Append(_customer.Address.GetAddressString());
        sb.AppendLine("----------------------");
        return sb.ToString();
    }
}