using System; 

class Animal {

    public virtual void Sound(){ //use virtual
        Console.WriteLine("This animal makes a sound");
    }

}

class Cat : Animal {

    public override void Sound(){ //override 
        Console.WriteLine("Purrrr....");
    }
}

class Duck : Animal {

    public override void Sound(){
        Console.WriteLine("Quack!");
    }

}


class Program {

    static void Main (){
        Animal ming = new Cat();
        Animal itik = new Duck();


        ming.Sound();
        itik.Sound();
    }

}
