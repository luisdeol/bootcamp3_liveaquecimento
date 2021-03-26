using System;
using System.Collections.Generic;
using System.Linq;

namespace BootcampAquecimento
{
    public static class FundamentosCsharpListaLinq
    {
        public static void ObterExemplo()
        {
            // INÍCIO LEITURA DE DADOS + TIPOS DISPONIVEIS
            var nome = Console.ReadLine();

            var umaString = "Essa é uma string";
            var numeroInt = 5;
            var numeroFloat = 5.4f;
            var numeroDouble = 5.4;
            var numeroDecimal = 5.3m;
            var array = new int[3] { 1, 2, 3 };
            var caractere = 'a';
            var data = new DateTime(1992, 12, 1);

            // FIM LEITURA DE DADOS + TIPOS DISPONIVEIS

            // INÍCIO ESTRUTURAS DE CONTROLE DE FLUXO DE TIPO CONDICIONAL
            Console.WriteLine("Digite uma opção entre 1 a 3");
            var opcao = Console.ReadLine();

            if (opcao == "1")
            {
                Console.WriteLine("Opcao 1 selecionada.");
            }
            else if (opcao == "2")
            {
                Console.WriteLine("Opcao 2 selecionada.");
            }
            else if (opcao == "3")
            {
                Console.WriteLine("Opcao 3 selecionada.");
            }
            else
            {
                Console.WriteLine("Opcao inválida.");
            }

            switch (opcao)
            {
                case "1":
                    Console.WriteLine("Opcao 1 selecionada.");
                    break;
                case "2":
                    Console.WriteLine("Opcao 2 selecionada.");
                    break;
                case "3":
                    Console.WriteLine("Opcao 3 selecionada.");
                    break;
                default:
                    Console.WriteLine("Opção Inválida");
                    break;
            }

            // FIM ESTRUTURAS DE CONTROLE DE FLUXO DE TIPO CONDICIONAL

            // INÍCIO ESTRUTURAS DE CONTROLE DE FLUXO DE TIPO REPETIÇÃO
            var valores = Console.ReadLine(); // "1 2 3 4 5"
            var valoresArray = valores.Split(" "); // ["1", "2", "3", "4", "5"]

            for (var i = 0; i < valoresArray.Length; i++)
            {
                Console.Write(valoresArray[i] + " ");
            }

            Console.WriteLine();

            var contador = 0;

            while (contador < valoresArray.Length)
            {
                Console.Write(valoresArray[contador] + " ");

                contador++;
            }

            // FIM ESTRUTURAS DE CONTROLE DE FLUXO DE TIPO REPETIÇÃO

            // INÍCIO LISTAS E LINQ
            var notasTurma = new List<int> { 10, 5, 2, 3, 10, 4, 3, 2, 9, 10, 6, 7, 10, 2, 3, 4, 5, 7 };

            var anyNota1 = notasTurma.Any(n => n == 1);
            var firstNota10 = notasTurma.First(n => n == 10);
            var singleNota9 = notasTurma.Single(n => n == 9);
            var orderedNotas = notasTurma.OrderBy(n => n);
            var max = notasTurma.Max();
            var min = notasTurma.Min();
            var sum = notasTurma.Sum();
            var mediaNotas = notasTurma.Average();

            foreach (var nota in notasTurma)
            {
                Console.WriteLine(nota);
            }

            // FIM LISTAS E LINQ

            Console.WriteLine("Hello, " + nome);
            Console.WriteLine($"Hello, {nome}");
        }
    }
}
