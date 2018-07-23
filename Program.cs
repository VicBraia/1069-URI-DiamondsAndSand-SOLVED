using System;
using System.Collections.Generic;


class Diamonds_And_Sand
{

    class Program
    {
        public static int Diamante;
        public static List<int> Casos = new List<int>();
        public static int N;
        public static String Leitura;

        public static void AnalisaCaso()
        {
            Diamante = 0;
            int cont_abre = 0;
            foreach (char x in Leitura)
            {
                if (x == '<')
                {
                    cont_abre++;
                }
                else if (x == '>' && cont_abre > 0)
                {
                    Diamante++;
                    cont_abre--;
                }
            }
            Casos.Add(Diamante);
        }

        public static void Read()
        {
            N = int.Parse(Console.ReadLine());
            for (int i = 0; i < N; i++)
            {
                Leitura = Console.ReadLine();
                AnalisaCaso();

            }
        }

        public static void Print()
        {
            foreach (int x in Casos)
            {
                Console.WriteLine(x);
            }
        }


        static void Main(string[] args)
        {
            Read();
            Print();
        }
    }

}