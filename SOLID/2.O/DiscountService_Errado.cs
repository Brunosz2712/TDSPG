namespace SOLID.O;

public class DiscountService_Errado
{
    public decimal CalculateDiscount(string type, decimal amount)
    {
        switch (type)
        {
            case "VIP":
                return amount * 0.4m;
            case "Partner":
                return amount * 0.3m;
            case "Employee":
                return amount * 0.2m;
        }
    }
}