using System; 

public class Mother : FamilyMember{
    
    public Mother() : base("Mother"){}
    
    public override void Greet(){
        Console.WriteLine("Mother knows best");
    }
    
}
