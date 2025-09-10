using System;

public abstract class Shape
{
    // TODO: Add abstract method GetArea()
    public abstract void GetArea();
    
}

// Square class
public class Square : Shape {
    public override  void GetArea(){
        Console.WriteLine("Square flexes with an area of: 16");

    }
}
// Triangle class
public class Triangle : Shape {
    public override void GetArea(){
        Console.WriteLine("Triangle strikes back with an area of: 9");

    }
}

class Program
{
    static void Main()
    {
        // TODO: Create Square and Triangle, then print their areas
        Shape sq = new Square();
        Shape tri = new Triangle();
        sq.GetArea();
        tri.GetArea();
    }
}
