using System;

public class Program {
  public static void Main(string[]args) {
    int n, n100, n50, n20, n10, n5, n2, n1, r;
    n = int.Parse(Console.ReadLine());
    Console.WriteLine(n);

    n100 = n/100;
    r = n%100;
    
    n50 = r/50;
    r = r%50;
    
    n20 = r/20;
    r = r%20;
    
    n10 = r/10;
    r = r%10;
    
    n5 = r/5;
    r = r%5;
    
    n2 = r/2;
    r = r%2;
    
    n1 = r;

    Console.WriteLine($"{n100} nota(s) de R$ 100,00");
    Console.WriteLine($"{n50} nota(s) de R$ 50,00");
    Console.WriteLine($"{n20} nota(s) de R$ 20,00");
    Console.WriteLine($"{n10} nota(s) de R$ 10,00");
    Console.WriteLine($"{n5} nota(s) de R$ 5,00");
    Console.WriteLine($"{n2} nota(s) de R$ 2,00");
    Console.WriteLine($"{n1} nota(s) de R$ 1,00");
    
  }
}
