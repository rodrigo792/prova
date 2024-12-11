/******************************************************************************

Welcome to GDB Online.
GDB online is an online compiler and debugger tool for C, C++, Python, Java, PHP, Ruby, Perl,
C#, OCaml, VB, Swift, Pascal, Fortran, Haskell, Objective-C, Assembly, HTML, CSS, JS, SQLite, Prolog.
Code, Compile, Run and Debug online from anywhere in world.

*******************************************************************************/
using System;
class Program {
  static void Main() {
    
    double Dia = double.Parse(Console.ReadLine());
    double DiadoMes = double.Parse(Console.ReadLine());
    double horas = double.Parse(Console.ReadLine());
    double minutos = double.Parse(Console.ReadLine());
    double segundos = double.Parse(Console.ReadLine());
    DiadoMes = (horas + minutos + segundos)/Dia;
    Console.WriteLine("DiadoMes:" +Dia);
  }
}