using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace att3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("De o Titulo do livro:");
            string titulo = Console.ReadLine();
            Console.Write("De o bome do Autor:");
            string autor = Console.ReadLine();
            Console.Write("De o ano de publicação do livro: ");
            int anopubli = int.Parse(Console.ReadLine());
            Console.Write("De o genero do livro: ");
            string genero = Console.ReadLine();


            Livro livro = new Livro(titulo, autor, anopubli, genero);

            Console.WriteLine("Informações do Livro:");
            livro.ExbibirDados();

            Console.WriteLine($"O genero do livro e ficcção? {livro.VerificarGenero()} ");
            Console.ReadLine();



        }

    }

    class Livro
    {
        private string titulo;
        private string autor;
        private int anoPublicacao;
        private string genero;

        public string Titulo
        {
            get { return titulo; }
            set { titulo = value; }
        }

        public string Autor
        {
            get { return autor; }
            set { autor = value; }
        }

        public int AnoPublicacao
        {
            get { return anoPublicacao; }
            set { anoPublicacao = value; }
        }

        public string Genero
        {
            get { return genero; }
            set { genero = value; }
        }

        public Livro(string titulo, string autor, int anoPublicacao, string genero)
        {
            this.titulo = titulo;
            this.autor = autor;
            this.anoPublicacao = anoPublicacao;
            this.genero = genero;
        }

        public void ExbibirDados()
        {
            Console.WriteLine($"Titulo : {titulo}");
            Console.WriteLine($"Autor : {autor}");
            Console.WriteLine($"Ano de Publicação : {anoPublicacao}");
            Console.WriteLine($"Genero : {genero}");
        }

        public bool VerificarGenero()
        {
            if(genero == "ficção")
            {
                return true;
            }
            else
            {
                return false;
            }

        }

    }
}
