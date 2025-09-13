using System; 
public class Pet
{
    public void Move(){
        Console.WriteLine("The pet has moved.");
    }
    
    public void GiveCompanionship(int n){
       int i;
       for (i=0; i<n; i++){
            Console.WriteLine("The pet is giving you companionship.");
       }
    }

}
