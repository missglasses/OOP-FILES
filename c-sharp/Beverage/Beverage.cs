using System;

    
    public class Beverage {
        
        private string name;
        private int volume;
        private bool isChilled; 
        
    
    
    //constuctor
    public Beverage (string name, int volume, bool isChilled){
        this.name = name;
        this.volume = volume;
        this.isChilled = isChilled;
    }
    
    public string GetName(){
                    return name;
    }
                
                
    public int GetVolume(){
                    return volume;
    }
    
    public bool GetIsChilled(){
        return isChilled;
    }
    
    public bool IsEmpty(){
        return volume==0;
    }
    
    public override string ToString(){
        string chilledStats  = isChilled ? "is still chilled" : "is not chilled anymore";
        return $"{name} ({volume}mL) {chilledStats}";
    }
    
}
