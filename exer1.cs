/******************************************************************************

Welcome to GDB Online.
GDB online is an online compiler and debugger tool for C, C++, Python, Java, PHP, Ruby, Perl,
C#, OCaml, VB, Swift, Pascal, Fortran, Haskell, Objective-C, Assembly, HTML, CSS, JS, SQLite, Prolog.
Code, Compile, Run and Debug online from anywhere in world.

*******************************************************************************/
using System;
class Program {
  static void Main() {
      double nota1, nota2, nota3, nota4, Media, notadoexame;
      
      
      Console.WriteLine("Digite a nota1");
      nota1 = double.Parse(Console.ReadLine());
      Console.WriteLine("Digite a nota2");
      nota2 = double.Parse(Console.ReadLine());
    
      Console.WriteLine("Digite a nota3");
      nota3 = double.Parse(Console.ReadLine());
      Console.WriteLine("Digite a nota4");
      nota4 = double.Parse(Console.ReadLine());
      notadoexame = double.Parse(Console.ReadLine());
      
      
      
      double peso1 = double.Parse(Console.ReadLine());
      double peso2 = double.Parse(Console.ReadLine());
      double peso3 = double.Parse(Console.ReadLine());
      double peso4 = double.Parse(Console.ReadLine());
      Media = (nota1 * peso1 + nota2 * peso2 + nota3 * peso3 + nota4 * peso4);
      {
          Console.WriteLine("Media:" + notadoexame);
      }
      
      if (Media <= 7.0){
          Console.WriteLine("Aprovado");
          
      }
      else if (Media < notadoexame){
          Console.WriteLine("Reprovado");
      }
      else (Media =! notadoexame)
      Console.WriteLine("Diferente da Media");
      Console.Read();
      
  }
}