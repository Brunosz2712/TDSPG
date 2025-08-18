namespace SOLID._3.L;

public sealed class Monitor : IItem
{
    public int Width{get;set;}
    public int Height{get;set;}
    public int Depth{get;set;}
    
    public int Dimension() => Width * Height * Depth;
    
}