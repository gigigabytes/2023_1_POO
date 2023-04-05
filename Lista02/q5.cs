using System; 

public class Program {

  public static void Main(string[] args) {
    Console.WriteLine("Digite o intervalo de tempo no formato “HH:MM:SS");
    string [] t = Console.ReadLine().Split(':');
    int h = int.Parse(t[0]);
    int m = int.Parse(t[1]);
    int s = int.Parse(t[2]);
    long totalSegundos = s + m * 60 + h * 3600;
    long distancia = 300000 * totalSegundos;
    Console.WriteLine($"A luz percorreu {distancia} km nesse intervalo");

  }
}