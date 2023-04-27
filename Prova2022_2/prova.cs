using System;

class Program {
  public static void Main() {

    //Console.ReadLine();
    //fazer um for para pegar as densidades e armazená-las para depois comparar
    Pais x = new Pais(1000, "teste", 10);
    Console.WriteLine(x.GetPopulacao());
    Console.WriteLine(x.GetNome());
    Console.WriteLine(x.GetArea());
    //Console.WriteLine(x.GetCalcDens());
    Console.WriteLine(x);
  }
}


class Pais {
  private int populacao;
  private string nome;
  private double area;
  public Pais (int populacao, string nome, double area) {
    this.populacao = populacao;
    this.nome = nome;
    this.area = area;
    
  }
  public void SetPopulacao(int populacao) {
    this.populacao = populacao;
      if ( populacao > 0 ) this.populacao = populacao;
    }

  public void SetNome(string nome){
    this.nome = nome;
    
  }

  public void SetArea(double area){
    if ( area > 0 ) this.area = area;

  }

  public int GetPopulacao() {
    return populacao;
    
  }
  public string GetNome() {
    return nome;
  }

  public double GetArea() {
    return area;
  }


  public double CalcDens() {
    return populacao / area;
    
  }
  //densidade = populção / area


  public override string ToString() {
    return $"{populacao} - {nome} - {area}";
  }
}
