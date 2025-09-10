using System; 

public class Water : Beverage {
    
    private string waterType;
    
    public Water(int volume, bool isChilled, string type):base("Water", volume, isChilled){
        this.waterType=type;
    
        
        
    }
    
    public Water(int volume, bool isChilled):this(volume, isChilled, "Regular"){
    
    }
    
    public string GetWaterType(){
        return waterType;
    }
    
    
    
}
