namespace SOLID.S;

public class OrderValidator: IOrderValidator
{
    public void Validate(Order order)
    {
        if (order.Itens.Count == 0 || order.TotalAmount <= 0) throw new Exception("Order is empty");
    }
}