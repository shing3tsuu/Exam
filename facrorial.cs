using System;
class Programm 
{
  static int fact(int n)
  
  {
      
  int result;
  result = 1;
  for (int i = 1; i <= n; i++)
  result = result * i;
  
  return result;
  
  }
  
  static void Main(string[] args)
  
  {
  
  Console.WriteLine("Вычисление факториала");
  Console.Write("Введите число - ");
  
  int a = int.Parse(Console.ReadLine());
  
  Console.WriteLine("{0}!={1}", a, fact(a));
  
  Console.ReadKey();
  
  }
}