using System;
 
class MainClass {
 public static void Main (string[] args) {
  
   Console.WriteLine ("Digite a nota do primeiro bimestre da disciplina: ");
 
   int primeiraNota = int.Parse(Console.ReadLine());
 
  Console.WriteLine ("Digite a nota do segundo bimestre da disciplina: ");
 
  int segundaNota = int.Parse(Console.ReadLine());
 
  int mediaParcial = (((primeiraNota * 2) + (segundaNota * 3)) / 5);
 
  Console.WriteLine ("Média parcial = " + mediaParcial);
 }
}
