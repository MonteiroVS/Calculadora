using System;

class Program
{
    static void Main(string[] args)
    {
        while (true)
        {
            Console.Clear();
            Console.WriteLine("=== Calculadora ===\n");
            Console.WriteLine("1 - Adição");
            Console.WriteLine("2 - Subtração");
            Console.WriteLine("3 - Multiplicação");
            Console.WriteLine("4 - Divisão");
            Console.WriteLine("5 - Sair\n");
            
            Console.Write("Escolha uma operação (1-5): ");
            string opcao = Console.ReadLine();

            if (opcao == "5")
            {
                Console.WriteLine("\nObrigado por usar a calculadora!");
                break;
            }

            if (opcao != "1" && opcao != "2" && opcao != "3" && opcao != "4")
            {
                Console.WriteLine("\nOpção inválida! Pressione qualquer tecla para continuar...");
                Console.ReadKey();
                continue;
            }

            Console.Write("\nDigite o primeiro número: ");
            if (!double.TryParse(Console.ReadLine(), out double num1))
            {
                Console.WriteLine("\nNúmero inválido! Pressione qualquer tecla para continuar...");
                Console.ReadKey();
                continue;
            }

            Console.Write("Digite o segundo número: ");
            if (!double.TryParse(Console.ReadLine(), out double num2))
            {
                Console.WriteLine("\nNúmero inválido! Pressione qualquer tecla para continuar...");
                Console.ReadKey();
                continue;
            }

            double resultado = 0;
            string operacao = "";

            switch (opcao)
            {
                case "1":
                    resultado = num1 + num2;
                    operacao = "+";
                    break;
                case "2":
                    resultado = num1 - num2;
                    operacao = "-";
                    break;
                case "3":
                    resultado = num1 * num2;
                    operacao = "*";
                    break;
                case "4":
                    if (num2 == 0)
                    {
                        Console.WriteLine("\nErro: Divisão por zero não é permitida! Pressione qualquer tecla para continuar...");
                        Console.ReadKey();
                        continue;
                    }
                    resultado = num1 / num2;
                    operacao = "/";
                    break;
            }

            Console.WriteLine($"\nResultado: {num1} {operacao} {num2} = {resultado}");
            Console.WriteLine("\nPressione qualquer tecla para continuar...");
            Console.ReadKey();
        }
    }
}