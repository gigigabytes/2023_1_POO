class Retangulo {
  private double b, h, d;
public double Base {
  get { return b; }
  set { if (value > 0) b = value; }

}
public double Altura {
  get { return h;}
  set { if (value > 0) h = value; }

}
  
public double Area {
  get { return b * h / 2; }

}

public double Diagonal {
  get { return d = Math.Pow() }
}
// Falta colocar a formula - raiz quadrada da soma dos lados ao quadrado  
}

class MainClass {
  public static void Main () {
  Triangulo x = new Triangulo();
      x.Base = 10;
      x.Altura = 20;
    
Console.WriteLine(x.Base);
Console.WriteLine(x.Altura);
Console.WriteLine(x.Area);
Console.WriteLine(x.Diagonal);
//add to string
    }
}