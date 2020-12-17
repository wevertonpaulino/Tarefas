using System;
using System.Collections.Generic;
using System.Linq;

namespace Tarefas
{
    class Program
    {
        static void Main(string[] args)
        {
            var lista1 = new List<int> { 3, 2, 1, 6, 0, 5 };
            var lista2 = new List<int> { 7, 5, 13, 9, 1, 6, 4 };
            var lista3 = new List<int> { 10, 14, 9, 18, 40, 5, 0, 28 };
            
            ImprimeCenario(lista1);
            ImprimeCenario(lista2);
            ImprimeCenario(lista3);

            Console.ReadKey();

            static void ImprimeCenario(List<int> lista)
            {
                var raiz = RetornaRaiz(lista);
                var galhosEsquerda = RetornaGalhosEsquerda(lista);
                var galhosDireita = RetornaGalhosDireita(lista);

                Console.WriteLine("Lista: " + string.Join(", ", lista));
                Console.WriteLine("Raiz: " + raiz);
                Console.WriteLine("Galhos da esquerda: " + string.Join(", ", galhosEsquerda.OrderByDescending(p => p)));
                Console.WriteLine("Galhos da direita: " + string.Join(", ", galhosDireita.OrderByDescending(p => p)));
                Console.WriteLine("\n");
            }

            static int RetornaRaiz(List<int> lista)
            {
                var raiz = lista[0];

                foreach (var item in lista)
                {
                    if (item > raiz)
                    {
                        raiz = item;
                    }
                }

                return raiz;
            }

            static List<int> RetornaGalhosEsquerda(List<int> lista)
            {
                var galhosEsquerda = new List<int> { };
                var raiz = RetornaRaiz(lista);
                var indice = lista.IndexOf(raiz);

                for (int i = 0; i < indice; i++)
                {
                    galhosEsquerda.Add(lista[i]);
                }

                return galhosEsquerda;
            }

            static List<int> RetornaGalhosDireita(List<int> lista)
            {
                var galhosDireita = new List<int> { };
                var raiz = RetornaRaiz(lista);
                var indice = lista.IndexOf(raiz);

                for (int i = indice + 1; i < lista.Count; i++)
                {
                    galhosDireita.Add(lista[i]);
                }

                return galhosDireita;
            }
        }
    }
}
