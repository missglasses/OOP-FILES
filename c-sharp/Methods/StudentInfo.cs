    // Start typing your code
using System;
using System.Text.RegularExpressions;
    
namespace StudentInfo{
    public class Student {
            
          public int idNumber {get; set; }
           public string name {get; set; }
           public string course {get; set; }
           
          public Student (){}
           
          public Student(int id, string name, string course="Unknown"){
              this.idNumber = id;
              this.name = name;
              this.course = course;
          }
           
           public override string ToString(){
               //"123456789 - John Doe - Computer Science"
               return $"{idNumber} - {name} - {course}";
           }
           
            public void ValidateInfo(){
                
                bool isValidID = idNumber.ToString().Length==9;
                
                bool isValidName =Regex.IsMatch(name, @"^[a-zA-Z\s]+$");
                
                if(isValidID && isValidName){
                    Console.WriteLine("Student information is valid.");
                    // return true;
                } else {
                     Console.WriteLine("Student information is not valid.");
                    //  return false;
                }
               
            }
    }
        
                
            
}
