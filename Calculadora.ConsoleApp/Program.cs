namespace Calculadora.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("--------------------------------");
                Console.WriteLine("Calculadora Tabajara 2025");
                Console.WriteLine("--------------------------------");

                Console.WriteLine("1 - Somar");
                Console.WriteLine("2 - Subtrair");
                Console.WriteLine("S - Sair");

                Console.Write("Escolha uma opção: ");

                string opcao = Console.ReadLine().ToUpper();

                if (opcao == "S")
                    break;

                Console.Write("Digite o primeiro número: ");
                string primeiroNumeroString = Console.ReadLine();
                decimal primeiroNumero = Convert.ToDecimal(primeiroNumeroString);

                Console.Write("Digite o segundo número: ");
                string segundoNumeroString = Console.ReadLine();
                decimal segundoNumero = Convert.ToInt32(segundoNumeroString);

                decimal resultado = 0;

                if (opcao == "1")
                {
                    resultado = primeiroNumero + segundoNumero;
                }
                else if (opcao == "2")
                {
                    resultado = primeiroNumero - segundoNumero;
                }

                Console.WriteLine("--------------------------------");
                Console.WriteLine("Resultado: " + resultado);
                Console.WriteLine("--------------------------------");

                Console.WriteLine("Deseja continuar? (S/N): ");
                string opcaoContinuar = Console.ReadLine().ToUpper();

                if (opcaoContinuar != "S")
                    break;

                Console.ReadLine();
            }
        }
    }
}
