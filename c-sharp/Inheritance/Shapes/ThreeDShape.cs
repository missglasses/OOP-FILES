using System; 


public abstract class ThreeDShape: Shape {
    

    public ThreeDShape(string name, string color) : base (name, color, false) {}
    
    public abstract double GetSurfaceArea();
    
    public abstract double GetVolume();
    
}
