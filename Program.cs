using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ESTRUTURA_CONDICIONAL___SWITCH_003
{
    internal class Program
    {
        static void Main(string[] args)

        {
            Console.WriteLine(">>>>>>>>>>>Bem Vindo ao Programa<<<<<<<<<<");
            Console.ForegroundColor = ConsoleColor.Yellow;

            Console.WriteLine("Informe a operação desejada:");
            Console.WriteLine();

            Console.WriteLine("Digite 1 - Calcular taxa de natalidade");
            Console.WriteLine();

            Console.WriteLine("Digite 2 - Calcular taxa de mortalidade");
            Console.WriteLine();

            int opcao = int.Parse(Console.ReadLine());

            switch (opcao)
            {
                case 1:
                    int taxaNatalidade = CalcularTaxaNatalidade();
                    Console.WriteLine($"A taxa de natalidade é de: {taxaNatalidade} por mil habitantes");
                    break;
                case 2:
                    int taxaMortalidade = CalcularTaxaMortalidade();
                    Console.WriteLine($"A taxa de mortalidade é de: {taxaMortalidade} por mil habitantes");
                    break;
                default:
                    Console.WriteLine("Voce digitou uma opção direfernte de 1 e 2 é inválida digite uma opçao valida.");
                    break;
            }
        }

        static int CalcularTaxaNatalidade()
        {
            Console.WriteLine("Informe o número de crianças nascidas:");
            int numeroDeCriancasNascidas = int.Parse(Console.ReadLine());

            Console.WriteLine("Informe o número de habitantes:");
            int numeroDeHabitantes = int.Parse(Console.ReadLine());

            return (numeroDeCriancasNascidas * 1000) / numeroDeHabitantes; 

        }

        static int CalcularTaxaMortalidade()
        {
            Console.WriteLine("Informe o número de óbitos:");
            int numeroDeObitos = int.Parse(Console.ReadLine());

            Console.WriteLine("Informe o número de habitantes:");
            int numeroDeHabitantes = int.Parse(Console.ReadLine());

            return (numeroDeObitos * 1000) / numeroDeHabitantes;
        }
    }
}
    
