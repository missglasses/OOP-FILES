using System; 

class Car {
    
    private int speed;
    
        public void Accelerate(int amount){
        if (amount > 0){
            speed += amount;
            Console.WriteLine($"Accelerated by {amount}. Current speed: {speed} km/h");
        } else {
            Console.WriteLine("Should not be a negative value");
        }
    }
    
    public void Brake(int amount){
        if (amount > 0){
            speed -= amount;
            if (speed < 0) speed = 0;
            Console.WriteLine($"Braked by {amount}. Current speed: {speed} km/h");
        } else {
            Console.WriteLine("Should not be a negative value");
        }
    }


    
}


class Program {
    
  static void Main(){
        Car c = new Car();
    c.Accelerate(30);
    c.Accelerate(20);
    c.Brake(40);
    c.Brake(20);
    
  }
    
    
}
