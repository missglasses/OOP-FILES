// Start typing your code
using System; 

public class ComplexCalculator{
    
    public double GetSquareRoot(int number){
        if(number<0){
    return 0.00;
        }
            return Math.Round(Math.Sqrt(number), 2);
        
    } 
    
    public int GetFactorial(int number){
       if(number<0){
            return 0;
        } else {
            
        int result=1;
        int i;
        for (i=2; i<=number; i++){
            result*=i;
        }
        return result;
        }
    }
    
   public double GetSum(int number1, int number2){
        return Math.Round((double)number1+number2,2);
    }
    
    public double GetProduct(int number1, int number2){
        return Math.Round((double)number1*number2,2);
    }
    
    public double GetDifference(int number1, int number2){
        return Math.Round((double)number1-number2,2);
    }
    
    public double GetQuotient(int number1, int number2){
        if(number2==0){
            return 0;
        } else {
            return Math.Round((double)number1/number2,2);
        }
    }
}
