// See https://aka.ms/new-console-template for more information
using System; 

//dotnet new console -o CoffeeShop
// cd Coffeeshop
// dotnet run


class Drink {

    public virtual void Serve(){
        Console.WriteLine("Serving your order.....");
    }


}

class Coffee : Drink {

    public override void Serve(){
         Console.WriteLine("Here's your hot coffee!");
    }

}


class Tea : Drink {

    public override void Serve(){
         Console.WriteLine("Here's your warm tea!");
    }

}


class Smoothie : Drink {

    public override void Serve(){
         Console.WriteLine("Here's a cold smoothie!");
    }


}

class Program {

    static void Main (){
        Drink kape = new Coffee();
        Drink tsaa = new Tea();
        Drink sheyk = new Smoothie();

        kape.Serve();
        tsaa.Serve();
        sheyk.Serve();
    }
    
}
