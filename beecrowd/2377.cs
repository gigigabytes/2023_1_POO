using System;

public class Program {
  public static void Main(string[] args) {
    
  string[] x = (Console.ReadLine().Split());
  int l = int.Parse(x[
0]);
    int d = int.Parse(x[
1]);


  string[] y = (Console.ReadLine().Split());
  int k = int.Parse(y[
0]);
    int p = int.Parse(y[
1]);
    

int pedagio = ((int)l/d);

int gasolina = ((int)l*k);
int pedagios = (int)pedagio*p;

int total = ((int) gasolina + pedagios);

Console.WriteLine(total);
  
  }
  
}