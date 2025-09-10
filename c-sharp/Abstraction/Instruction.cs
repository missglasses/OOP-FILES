using System; 


public abstract class Instrument
{

    public abstract void PlaySound();
    
}

public class Guitar : Instrument{
    
    public override void PlaySound(){
        Console.WriteLine("Guitar goes: Strum strum!");
    }
    
}


public class Drums : Instrument{
    
    public override void PlaySound(){
        Console.WriteLine("Drums go: Boom boom!");
    }
}

class Program
{
    static void Main()
    {
        Instrument g = new Guitar();
        g.PlaySound();
        Instrument d = new Drums();
        d.PlaySound();
       
    }
}
