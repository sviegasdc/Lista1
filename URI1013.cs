using System;
 
class URI {
 
 static void Main(string[] args) {
 
  int a, b, c,MaiorAB,MaiorABC;
  string[] texto = Console.ReadLine().Split(" ");
  a = int.Parse(texto[0]);
  b = int.Parse(texto[1]);
  c = int.Parse(texto[2]);
  
  MaiorAB = (a + b + Math.Abs(a - b )) / 2;
  MaiorABC = (MaiorAB + c + Math.Abs(MaiorAB - c)) / 2;
  Console.WriteLine(MaiorABC+" eh o maior");
 }
 
}
