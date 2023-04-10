using System; 

public class Program {
  public static void Main(string[] args) {
    int distancia;
    double combustivel, consumo;
    
/*Perguntar se a conversão está correta */
        
    distancia = int.Parse(Console.ReadLine());
    
    combustivel = double.Parse(Console.ReadLine());

consumo = ((double)distancia/combustivel);

 Console.WriteLine($"{consumo:0.000} km/l");   

   }
}