using System;

public class Beer : Beverage {
    
    
    private double alcoholicContent;
    
    
     public Beer(int volume, bool isChilled, double alcoholicContent):base("Beer", volume, isChilled){
        this.alcoholicContent=alcoholicContent;
    
        
        
    }

    
    public string GetAlcoholType(){
        if(alcoholicContent<0.03)
        return "Flavored";
        else if (alcoholicContent<0.06)
        return "Regular";
        else 
        return "Strong";
    }
    
    public override string ToString(){
        string baseString  = base.ToString();
        return $"{baseString} ({alcoholicContent * 100:F1}% alcoholic content)";
    }
    
    public double GetAlcoholicContent(){
        return alcoholicContent;
    }
    
}
