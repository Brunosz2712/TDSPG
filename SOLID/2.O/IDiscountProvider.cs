namespace SOLID.O;

public interface IDiscountProvider
{
    IDiscountStrategy Get(string key);
}