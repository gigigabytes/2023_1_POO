using System; 

public class Program {
  public static void Main(string[] args) {
    double a, b, t;
string s = Console.ReadLine();
    a = double.Parse(Console.ReadLine());
    b = double.Parse(Console.ReadLine());

t = ((double)15/100)*b + a;

 Console.WriteLine($"TOTAL = R$ {t:0.00}");   

   }
}