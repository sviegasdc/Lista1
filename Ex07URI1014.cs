using System;
 
class URI {
 
   static void Main(string[] args) {
 
   int X = int.Parse(Console.ReadLine());
 
   double Y = double.Parse(Console.ReadLine());
 
   double Z = X/Y;
 
   Console.WriteLine($"{Z:0.000}" + " km/l");
 
 
   }
 
}
