using System; 


public abstract class TwoDShape: Shape {
    
    private int numberOfSides;
    
    public TwoDShape(string name, string color, int numberOfSides): base(name,color,true) {
        
        this.numberOfSides=numberOfSides;
    }
    
    public abstract double GetArea();
    public abstract double GetPerimeter();
  
    
}
