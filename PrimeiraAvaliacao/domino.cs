using System;

namespace Domino
{
    class Domino
    {
        private int lado1;
        private int lado2;

        public Domino(int l1, int l2){
            if(l1 >=0 && l1<7) lado1 = l1;
            else throw new ArgumentOutOfRangeException();
            if(l2 >= 0 && l2<7) lado2 = l2;
            else throw new ArgumentOutOfRangeException();
        }

        public void SetLado1(int lado1){
            if(lado1 >=0 && lado1<7) this.lado1 = lado1;
            else throw new ArgumentOutOfRangeException();
        }

        public void SetLado2(int lado2){
            if(lado2 >=0 && lado2<7) this.lado2 = lado2;
            else throw new ArgumentOutOfRangeException();
        }

        public int GetLado1(){
            return lado1;
        }

        public int GetLado2(){
            return lado2;
        }

        public override string ToString(){
            return $"Lado 1 = {lado1}, Lado 2 = {lado2}";
        }

        public bool Combinar(Domino peça){
            if(peça.lado1 == this.lado1 || peça.lado2 == this.lado2 || peça.lado1 == this.lado2 || peça.lado2 == this.lado2){
                return true;
            }
            else{
                return false;
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Digite o lado 1 da peça 1:");
            int lado1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o lado 2 da peça 1:");
            int lado2 = int.Parse(Console.ReadLine());
            Domino peça1 = new Domino(lado1, lado2);
            
            Console.WriteLine("Digite o lado 1 da peça 2:");
            lado1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o lado 2 da peça 2:");
            lado2 = int.Parse(Console.ReadLine());
            Domino peça2 = new Domino(lado1, lado2);

            if(peça1.Combinar(peça2) == true){
                Console.WriteLine("As peças são combináveis");
            }
            else{
                Console.WriteLine("As peças não são combináveis");
            }

        }
    }
}