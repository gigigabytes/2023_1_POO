using System; 

public class Program {

  public static void Main(string[] args) {
    double b, h, a, p, d;
    Console.WriteLine("Digite a base e a altura do retângulo");
    b = double.Parse(Console.ReadLine());
    h = double.Parse(Console.ReadLine());

  a = b * h; 

  p = b*2 + h*2;

  d = Math.Sqrt(b*b + h*h);
    // Perguntar como usar o double Pow
    
 Console.WriteLine($"Área = {a:0.00}");   

 Console.WriteLine($"Perímetro = {p:0.00}");   

 Console.WriteLine($"Diagonal = {d:0.00}");   


  }
}