namespace SOLID.O;

public interface IDiscountStrategy
{
    decimal calculateDiscount(decimal amount);
}