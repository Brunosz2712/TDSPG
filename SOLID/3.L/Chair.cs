namespace SOLID._3.L;

public class Chair : IItem
{
    public int Weight { get; set; }
    public int Heigth { get; set; }
    public int Depth { get; set; }
    
    public int Dimension() =>  this.Weight * this.Heigth * this.Depth;
    
}