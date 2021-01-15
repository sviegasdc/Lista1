using System;
 
class URI {
 
   static void Main(string[] args) {
 
   double x1,y1,x2,y2;
   string[] linha = Console.ReadLine().Split(" ");
   string[] linha2 = Console.ReadLine().Split(" ");
   x1 = double.Parse(linha[0]);
   y1 = double.Parse(linha[1]);
   x2 = double.Parse(linha2[0]);
   y2 = double.Parse(linha2[1]);
   double p1 = (x2 - x1)*(x2 - x1);
   double p2 = (y2 - y1)*(y2 - y1);
   double distancia =(p1+p2);
  
   double d = Math.Sqrt(distancia);
 
   Console.WriteLine(Math.Round(d,4));
 }
 
}
