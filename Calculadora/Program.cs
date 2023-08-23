namespace Calculadora
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float numero1, numero2;
            string parOuImpar1, parOuImpar2;

            Console.WriteLine("Digite o primeiro número: ");
            numero1 = Convert.ToSingle(Console.ReadLine());

            Console.WriteLine("Digite o segundo número: ");
            numero2 = Convert.ToSingle(Console.ReadLine());

            if (numero2 == 0)
            {
                Console.WriteLine("O segundo número não pode ser zero, digite outro número: ");
                numero2 = Convert.ToSingle(Console.ReadLine());
            }

            //operações matemáticas
            Console.WriteLine($"A soma de {numero1} e {numero2} é " + Math.Round(numero1 + numero2, 2));
            Console.WriteLine($"A subtração de {numero1} e {numero2} é " + Math.Round(numero1 - numero2, 2));
            Console.WriteLine($"A multiplicação de {numero1} e {numero2} é " + Math.Round(numero1 * numero2, 2));
            Console.WriteLine($"A divisão de {numero1} e {numero2} é aproximadamente " + Math.Round(numero1 / numero2, 2));
            Console.WriteLine($"O resultado de {numero1} elevado a {numero2} é " + Math.Round(Math.Pow(numero1, numero2), 2));
            Console.WriteLine($"A raiz quadrada de {numero1} é " + Math.Round(Math.Sqrt(numero1), 2));

            parOuImpar1 = numero1 % 2 == 0 ? "par" : "ímpar";
            Console.WriteLine($"O primeiro número é {parOuImpar1}.");

            parOuImpar2 = numero2 % 2 == 0 ? "par" : "ímpar";
            Console.WriteLine($"O segundo número é {parOuImpar2}.");
        }
    }
}