using System.Net.Mail;

namespace SOLID.S;

//Ferindo o S do SOLID
public class OderService_Errada
{
    public void Create(Order order)
    {
        //Validação
        if (order.Itens.Count == 0) throw new Exception("Order is empty");
        if (order.TotalAmount <= 0) throw new Exception("Order is empty");
        {
            
        }
        //Persistencia
        
        //Notificação
        using var smtp = new SmtpClient();
        smtp.Send("Teste", "", "Pedido Criado", "Obrigado!");
        {
            
        }
    }
    
    
}