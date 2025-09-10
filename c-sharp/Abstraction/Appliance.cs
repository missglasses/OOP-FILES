using System;

public abstract class Appliance
{
    // TODO: Add abstract method TurnOn()
    public abstract void TurnOn();
    public abstract void TurnOff();
    // TODO: Add a normal method TurnOff()
}

// TV class
public class TV : Appliance{
    public override void TurnOn(){
          Console.WriteLine("TV is now ON. Showing channels...");
    }
    
    public override void TurnOff(){
        Console.WriteLine("Appliance turned off.");
    }
}

// WashingMachine class
public class WashingMachine : Appliance {
    public override void TurnOn(){
          Console.WriteLine("Washing machine is now ON. Ready to wash clothes.");
    }
    
   public override void TurnOff(){
        Console.WriteLine("Appliance turned off.");
    }
}


class Program
{
    static void Main()
    {
        // TODO: Create TV and WashingMachine objects
        Appliance sony = new TV();
        Appliance samsung = new WashingMachine();
        sony.TurnOn();
        sony.TurnOff();
         samsung.TurnOn();
        samsung.TurnOff();
        // Call TurnOn() and TurnOff()
    }
}
