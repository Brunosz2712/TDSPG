namespace SOLID.O;

public class PartnerDiscount : IDiscountStrategy
{
    public decimal calculateDiscount(decimal amount)
    {
        return amount * 0.5m;
    }
}