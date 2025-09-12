using System; 

public class Son : FamilyMember{
    
    public Son():base("Son"){}

    
    public override void Greet(){
        Console.WriteLine("My father and mother love me");
    }
    
}
