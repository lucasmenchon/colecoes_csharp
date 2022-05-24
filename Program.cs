using System;
using System.Collections.Generic;
using System.Linq;
using static System.Console;

namespace Colecoes
{
    internal class Program
    {
        static void Main(string[] args)
        {


            //valor min, med, max | sum, distinct
            int[] arrayNum = new int[3] { 100, 20, 30 };

            var min = arrayNum.Min();
            var max = arrayNum.Max();
            var med = arrayNum.Average();
            var soma = arrayNum.Sum();
            var unico = arrayNum.Distinct().ToArray();

            WriteLine($"Min: {min}, Max {max}, Med {med}");
            WriteLine($"Sum: {string.Join(", ", arrayNum)}");
            WriteLine($"Distinct: {string.Join(", ", unico)}");

            ////LINQ
            //int[] arrayNum = new int[6] { 1, 3, 5, 6, 8, 10 };
            //var numPar =
            //    from num in arrayNum
            //    where num % 2 == 0
            //    orderby num
            //    select num;

            //var numParMetodo = arrayNum.Where(x => x % 2 == 0).OrderBy(x => x).ToList();
            //WriteLine("Pares Query:" + string.Join(", ", numPar));
            //WriteLine("Pares Metodo:" + string.Join(", ", numParMetodo));



            ////dicionario
            //Dictionary<string, string> estados = new Dictionary<string, string>();

            //estados.Add("a", "b");
            //estados.Add("c", "d");
            //foreach (KeyValuePair<string, string> item in estados)
            //{
            //    WriteLine($"Chave: {item.Key},  Valor: {item.Value}");
            //}

            ////procurar valor
            //string valorProcurar = "a";
            //WriteLine($"removendo: {valorProcurar}");
            //estados.Remove(valorProcurar);

            //foreach (KeyValuePair<string, string> item in estados)
            //{
            //    WriteLine($"Chave: {item.Key},  Valor: {item.Value}");
            //}

            ////colecao stack //pilha
            //Stack<string> pilhaObjeto = new Stack<string>();

            //pilhaObjeto.Push("a");
            //pilhaObjeto.Push("b");
            //pilhaObjeto.Push("c");

            //while (pilhaObjeto.Count > 0)
            //{
            //    WriteLine($"Proxima letra: {pilhaObjeto.Peek()}");
            //    WriteLine($"{pilhaObjeto.Pop()} ok");
            //}

            ////add colecao queue com string //fila
            //Queue<string> fila = new Queue<string>();


            //fila.Enqueue("a");
            //fila.Enqueue("b");
            //fila.Enqueue("c");

            //while (fila.Count > 0)
            //{
            //    WriteLine($"Vez de {fila.Peek()}");
            //    WriteLine($"{fila.Dequeue()} atendido");
            //}

            //WriteLine($"Pessoas na fila: {fila.Count}");
        }
    }
}
