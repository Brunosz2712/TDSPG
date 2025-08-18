namespace SOLID.S;

public class NotificationService : INotificationService
{
    private readonly INotification _notificationEmail;
    private readonly INotification _notificationWhats;
    private readonly INotification _notificationSms;
    
    public NotificationService(INotification notificationEmail, INotification notificationWhats, INotification notificationSms)
    {
        _notificationEmail = notificationEmail;
        _notificationWhats = notificationWhats;
        _notificationSms = notificationSms;
    }

    public void SendNotification(Order order)
    {
        _notificationEmail.Send(order);
        _notificationWhats.Send(order);
        _notificationSms.Send(order);
    }
}