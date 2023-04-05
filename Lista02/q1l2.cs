using System; 

public class Program {

  public static void Main(string[] args) {
   Console.WriteLine("Digite seu nome completo:"); 
string s = Console.ReadLine();
    Console.WriteLine("Bem vindo ao C#," + s); 
    Console.WriteLine($"Bem vindo ao C#,{s}"); 

  }
}