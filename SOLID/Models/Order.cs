using SOLID._3.L;

namespace SOLID.S;

public class Order
{
    public Guid ID {get;set;}
    
    public string EmailCustumer {get;set;}
        
    public List<Chair> Itens {get;set;}

    public decimal TotalAmount { get; set; }
    
    public string Type{get;set;}
}