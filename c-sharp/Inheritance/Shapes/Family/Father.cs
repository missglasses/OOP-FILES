using System; 

public class Father : FamilyMember{
    
    public Father() : base("Father") {}
    
    public override void Greet(){
        Console.WriteLine("I am your father");
    }
    
}
