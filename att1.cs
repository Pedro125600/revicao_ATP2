using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace att01
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("De a largura de um Retangulo:");
            double largura = double.Parse(Console.ReadLine());

            Console.Write("De a altura de um Retangulo:");
            double altura= double.Parse(Console.ReadLine());

            Retangulo ret = new Retangulo(largura, altura);

            Console.WriteLine($"A area do retangulo e : {ret.Area()}");
            Console.WriteLine($"O perimetro do retangulo e : {ret.perimetro()}");

            Console.ReadLine();
        }
    }

    class Retangulo
    {
        private double largura;
        private double altura;

        public double Largura
        {
            get
            {
                return largura;
            }

            set
            {
                largura = Largura;
            }
        }

        public double Altura
        {
            get
            {
                return altura;
            }

            set
            {
                altura = Altura;
            }
        }



       public Retangulo(double lar,double alt)
        {
            this.altura = alt;
            this.largura = lar;
        }

        public double Area()
        {
            return largura * altura;
        }

        public double perimetro()
        {
            return 2 * (altura + largura);
        }



    }

    
}


