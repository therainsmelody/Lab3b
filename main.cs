using System;

class Program {
  public static void Main (string[] args) {
  
    Console.WriteLine ("Enter salesperson's name") ;
    string name = Console.ReadLine();

Console.WriteLine ("Enter sales amount") ;
    double amount = Convert.ToDouble(Console.ReadLine());

 double commission = 200 + (0.09 * amount);
 Console.WriteLine ("Sales commission for " + name + " is $" + commission); 



if (amount >= 15000)
{
  Console.WriteLine("Performance is outstanding");
} 

if (amount >= 10000 && amount < 15000)
{
  Console.WriteLine("Performance is excellent");
} 

if (amount >= 5000 && amount < 10000)
{
  Console.WriteLine("Performance is good");
} 


if (amount >= 3000 && amount < 5000)
{
  Console.WriteLine("Performance is average");
} 


if (amount >= 0 && amount < 3000)
{
  Console.WriteLine("Performance is poor");
} 


//if (commission > 3000);
//else if (commission < 3000) ;
//Console.WriteLine("Performance is Average");

 // if (fahrenheit > 212)
  //Console.WriteLine("This temperature is above boiling point temperature of 212 degree Fahrenheit");


  }
}