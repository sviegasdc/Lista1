using System;
 
class MainClass {
 public static void Main (string[] args) {
   string nome = Console.ReadLine();
 
  double salario = double.Parse(Console.ReadLine());
 
  double vendas = double.Parse(Console.ReadLine());
   double comissao = 0.15;
 
  double total = salario + vendas * comissao;
 
  Console.WriteLine($"TOTAl R$ = {total:0.00}");
 
 }
}
