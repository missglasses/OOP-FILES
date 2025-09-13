using System;

public class Blender {
    public void Blend(){
        Console.WriteLine("There's nothing to blend here, boss.");
    }
    
    public void Blend(string fruit1, string fruit2){
          Console.WriteLine($"Blending {fruit1} and {fruit2}, boss.");
    }
    
    public void Blend(string fruit1, string fruit2, int n){
         int i;
         for (i=0; i<n; i++){
              Console.WriteLine($"Blending {fruit1} and {fruit2}, boss.");
         }
    }
}
