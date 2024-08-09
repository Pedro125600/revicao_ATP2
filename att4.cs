﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace att4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Nome do Aluno: ");
            string nome = Console.ReadLine();
            Console.Write("Matricula :");
            int matricula = int.Parse(Console.ReadLine());

            double[] notas = new double[3];
            for(int i = 0; i < notas.Length;i++)
            {
                Console.Write($"{i + 1} nota do Aluno: ");
                notas[i] = double.Parse(Console.ReadLine());

            }

            Aluno aluno = new Aluno(nome, matricula, notas);

            Console.WriteLine($"A medias das notas do Aluno: {aluno.Nome} e {aluno.Media()} ");
            Console.ReadLine();
        }
    }

    class Aluno
    {
        private string nome;
        private int matricula;
        private double[] notas;


        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }

        public int Matricula
        {
            get { return matricula; }
            set { matricula = value; }
        }

        public double[] Notas
        {
            get { return notas; }
            set { notas = value; }
        }

        public Aluno(string nome , int matricula , double[] notas)
        {
            this.nome = nome;
            this.matricula = matricula;
            this.notas = notas;
        }

        public double Media()
        {
            double total = 0;
            for(int i = 0; i < notas.Length; i++)
            {
                total += notas[i];
            }

            return total / notas.Length;
        }
    }

}
