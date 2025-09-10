using System; 


public abstract class IceCream
{

    public abstract void Serve();
    
}

public class ConeIceCream : IceCream{
    
    public override void Serve(){
        Console.WriteLine("Guitar goes: Strum strum!");
    }
    
}


public class CupIceCream : IceCream{
    
    public override void Serve(){
        Console.WriteLine("Serving ice cream in a cup ??");
    }
}

class Program
{
    static void Main()
    {
        IceCream cone = new ConeIceCream();
        cone.Serve();
        IceCream cup = new CupIceCream();
        cup.Serve();
       
    }
}
