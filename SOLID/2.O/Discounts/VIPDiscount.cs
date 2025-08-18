namespace SOLID.O;

public class VIPDiscount : IDiscountStrategy
{
    public decimal calculateDiscount(decimal amount)
    {
        return amount * 0.9m;
    }
}