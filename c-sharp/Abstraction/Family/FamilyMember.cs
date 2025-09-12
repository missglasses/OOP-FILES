using System; 

public abstract class FamilyMember{
    private string type; 
    
    public FamilyMember(string type){
        this.type=type;
    }
    
    public abstract void Greet();
    
    public override string ToString(){
        return $"Superclass: \nType: {type}";
    }
}
