using System; 


public class Square: TwoDShape {
    
    private double lengthOfSide;
    
     public Square(string color, double lengthOfSide): base ("Square", color, 4) {
        
        this.lengthOfSide=lengthOfSide;
        
    }
    
    public override double GetArea(){
        return lengthOfSide*lengthOfSide;
    }
    
    public override double GetPerimeter(){
          return 4 * lengthOfSide;
    }
    
    
}
