using System;
using System.Collections.Generic;

namespace BootcampAquecimento
{
    public class Veiculo
    {
        public string Modelo { get; set; }
        public string Marca { get; set; }
        public int Ano { get; set; }
        public decimal Valor { get; set; }
        public string Placa { get; protected set; }

        public virtual void MostrarRequisitosParaDigir()
        {
            Console.WriteLine("Uma carteira de motorista.");
        } 
    }

    public class Onibus : Veiculo
    {
        public string LinhaDoOnibus { get; set; }
        public override void MostrarRequisitosParaDigir()
        {
            Placa = "";
            Console.WriteLine("Habilitação D");
        }
    }

    public class Carro : Veiculo
    {
        public string LinhaDoOnibus { get; set; }
        public override void MostrarRequisitosParaDigir()
        {
            Placa = "";
            Console.WriteLine("Habilitação B");
        }
    }

    public class Moto : Veiculo
    {
        public string PropriedadeUnicaDeMoto { get; set; }
        public override void MostrarRequisitosParaDigir()
        {
            Console.WriteLine("Habilitação A");
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            // O EXEMPLO DE FUNDAMENTOS DE C# E LINQ ESTÁ NO OUTRO ARQUIVO "FundamentosCsharpListaLinq.cs"

            var listaVeiculos = new List<Veiculo>();

            // INÍCIO Exemplo Herança + Polimorfismo
            listaVeiculos.Add(new Onibus());
            listaVeiculos.Add(new Moto());
            listaVeiculos.Add(new Carro());

            foreach (var veiculo in listaVeiculos)
            {
                veiculo.MostrarRequisitosParaDigir();
            }

            // FIM Exemplo Herança + Polimorfismo

            Console.WriteLine("-------- DevCars - Venda de Carros --------");

            ExibirMensagemPrincipal();

            var opcao = Console.ReadLine();

            while (opcao != "0")
            {
                switch (opcao)
                {
                    case "1":
                        var veiculo = CadastrarVeiculo();
                        listaVeiculos.Add(veiculo);
                        break;
                    case "2":
                        ListarVeiculos(listaVeiculos);
                        break;
                    case "3":
                        ComprarVeiculo(listaVeiculos);
                        break;
                    default:
                        break;
                }

                ExibirMensagemPrincipal();
                opcao = Console.ReadLine();
            }
        }

        public static void ExibirMensagemPrincipal()
        {
            Console.WriteLine("Digite sua opção:");
            Console.WriteLine("1 - Cadastro");
            Console.WriteLine("2 - Listagem");
            Console.WriteLine("3 - Compra");
            Console.WriteLine("0 - Sair");
        }

        public static Veiculo CadastrarVeiculo()
        {
            var veiculo = new Veiculo();

            Console.WriteLine("Digite a Marca:");
            veiculo.Marca = Console.ReadLine();

            Console.WriteLine("Digite o Modelo:");
            veiculo.Modelo = Console.ReadLine();

            Console.WriteLine("Digite o Ano:");
            veiculo.Ano = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o Valor:");
            veiculo.Valor = decimal.Parse(Console.ReadLine());

            return veiculo;
        }

        public static void ListarVeiculos(List<Veiculo> veiculos)
        {
            for (var i = 0; i < veiculos.Count; i++)
            {
                Console.WriteLine($"{i} - Marca: {veiculos[i].Marca}, Modelo: {veiculos[i].Modelo}, Ano: {veiculos[i].Ano}, Valor: R${veiculos[i].Valor}");
            }
        }

        public static void ComprarVeiculo(List<Veiculo> veiculos)
        {
            ListarVeiculos(veiculos);

            Console.WriteLine("Escolha uma opção de Veiculo:");

            var opcao = int.Parse(Console.ReadLine());

            var veiculo = veiculos[opcao];

            veiculos.Remove(veiculo);
        }
    }
}

//var nome = Console.ReadLine();

//var umaString = "Essa é uma string";
//var numeroInt = 5;
//var numeroFloat = 5.4f;
//var numeroDouble = 5.4;
//var numeroDecimal = 5.3m;
//var array = new int[3] { 1, 2, 3 };
//var caractere = 'a';
//var data = new DateTime(1992, 12, 1);

//Console.WriteLine("Digite uma opção entre 1 a 3");
//var opcao = Console.ReadLine();

//if (opcao == "1")
//{
//    Console.WriteLine("Opcao 1 selecionada.");
//} else if (opcao == "2")
//{
//    Console.WriteLine("Opcao 2 selecionada.");
//} else if (opcao == "3")
//{
//    Console.WriteLine("Opcao 3 selecionada.");
//} else
//{
//    Console.WriteLine("Opcao inválida.");
//}

//switch (opcao)
//{
//    case "1":
//        Console.WriteLine("Opcao 1 selecionada.");
//        break;
//    case "2":
//        Console.WriteLine("Opcao 2 selecionada.");
//        break;
//    case "3":
//        Console.WriteLine("Opcao 3 selecionada.");
//        break;
//    default:
//        Console.WriteLine("Opção Inválida");
//        break;
//}

//var valores = Console.ReadLine(); // "1 2 3 4 5"
//var valoresArray = valores.Split(" "); // ["1", "2", "3", "4", "5"]

//for (var i = 0; i < valoresArray.Length; i++)
//{
//    Console.Write(valoresArray[i] + " ");
//}

//Console.WriteLine();

//var contador = 0;

//while (contador < valoresArray.Length)
//{
//    Console.Write(valoresArray[contador] + " ");

//    contador++;
//}

//var notasTurma = new List<int> { 10, 5, 2, 3, 10, 4, 3, 2, 9, 10, 6, 7, 10, 2, 3, 4, 5, 7 };

//var anyNota1 = notasTurma.Any(n => n == 1);
//var firstNota10 = notasTurma.First(n => n == 10);
//var singleNota9 = notasTurma.Single(n => n == 9);
//var orderedNotas = notasTurma.OrderBy(n => n);
//var max = notasTurma.Max();
//var min = notasTurma.Min();
//var sum = notasTurma.Sum();
//var mediaNotas = notasTurma.Average();

//foreach (var nota in notasTurma)
//{
//    Console.WriteLine(nota);
//}

//Console.WriteLine("Hello, " + nome);
//Console.WriteLine($"Hello, {nome}");