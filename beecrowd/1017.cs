using System; 

class Program {
  public static void Main () {
    
  string[] x = (Console.ReadLine().Split());
  int tempo = int.Parse(x[0]);
  int velocidade = int.Parse(x[1]);

int litros = (tempo*velocidade)/12;

Console.WriteLine(litros);

    }

}