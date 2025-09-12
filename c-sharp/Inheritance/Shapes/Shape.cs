using System; 


public abstract class Shape {
    
    private string name;
    private string color;
    private bool isFlat;
    
    public Shape(string name, string color, bool isFlat){
        this.name = name;
        this.color=color;
        this.isFlat = isFlat;
    }
    
    public string GetName(){
        return name;
    }
    
    public string GetColor(){
        return color;
    }
    
    public bool GetIsFlat(){
        return isFlat;
    }
    
    // public string GetName(){return name;}
    // public string GetColor(){return color;}
    // public string GetIsFlat(){return isFlat;}
    
    
}
