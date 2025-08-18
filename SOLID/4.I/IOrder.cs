namespace SOLID._4.I;

public interface IOrder
{
    void CreateOrder();
    void CalculateTotal();
    void CalculateDiscount();
    void CalculateSend();
}