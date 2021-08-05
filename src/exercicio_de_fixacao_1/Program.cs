using System;

namespace exercicio_de_fixacao_1
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Qual é o seu nome: ");
            string nome = Console.ReadLine();

            Console.WriteLine("Quantos quartos tem na sua casa: ");
            int quartos = int.Parse(Console.ReadLine());

            Console.WriteLine("Informe o preço do produto: ");
            double preco = double.Parse(Console.ReadLine());

            Console.WriteLine();

            Console.WriteLine("Informe seu ultimo nome, idade e altura (na mesma linha): ");
            string[] vet = Console.ReadLine().Split(' ');
            string sobrenome = vet[0];
            int idade = int.Parse(vet[1]);
            double altura = double.Parse(vet[2]);

            Console.WriteLine();

            Console.WriteLine("Você digitou: ");
            Console.WriteLine(nome);
            Console.WriteLine(quartos);
            Console.WriteLine(preco.ToString("F2"));
            Console.WriteLine(sobrenome);
            Console.WriteLine(idade);
            Console.WriteLine(altura.ToString("f2"));

            Console.ReadKey();
                                                                              
        }
    }
}
