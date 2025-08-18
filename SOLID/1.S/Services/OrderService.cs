namespace SOLID.S;

public class OrderService
{
    private readonly IOrderValidator _orderValidator;
    private readonly IOrderRepository _orderRepository;
    private readonly INotificationService _notificationService;
    private readonly DiscountService _discountService;
    
    public OrderService(IOrderValidator orderValidator, IOrderRepository orderRepository, INotificationService notificationService)
    {
        _orderValidator = orderValidator;
        _orderRepository = orderRepository;
        _notificationService = notificationService;
    }

    public void Create(Order order)
    {
        _orderValidator.Validate(order);
        _discountService(order.Type, order.TotalAmount);
        _orderRepository.Add(order);
        _calcularEnvio(order.Itens);
        _notificationService.SendNotification(order);
    }
}