using SOLID.O;

namespace SOLID.S;

public class DiscountService
{
    private readonly IDiscountProvider _provider;
    
    public DiscountService(IDiscountProvider provider) => _provider = provider;
    
    public decimal Calculate(string type, decimal total) => _provider.Get(type).Apply(total);
}