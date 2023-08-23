namespace Exercícios_entrada_e_saida_de_operadores
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Exercícios do dia

            //Exercício 1

            float salario, abono;

            Console.WriteLine("Digite o salário: ");
            salario = Convert.ToSingle(Console.ReadLine());

            Console.WriteLine("Digite o abono: ");
            abono = Convert.ToSingle(Console.ReadLine());

            Console.WriteLine($"Novo salário: {Math.Round(salario + abono, 2)}.");



            //Exercício 2

            float nota1, nota2, nota3, nota4, mediaFinal;


            Console.WriteLine("\nDigite a nota 1: ");
            nota1 = Convert.ToSingle(Console.ReadLine());

            Console.WriteLine("Digite a nota 2: ");
            nota2 = Convert.ToSingle(Console.ReadLine());

            Console.WriteLine("Digite a nota 3: ");
            nota3 = Convert.ToSingle(Console.ReadLine());

            Console.WriteLine("Digite a nota 4: ");
            nota4 = Convert.ToSingle(Console.ReadLine());

            mediaFinal = (nota1 + nota2 + nota3 + nota4) / 4;

            Console.WriteLine($"A média final é {Math.Round(mediaFinal, 1)}.");



            //Exercício 3

            float salarioBruto, adicionalNoturno, horasExtras, descontos, salarioLiquido;

            Console.WriteLine("\nDigite o salário bruto: ");
            salarioBruto = Convert.ToSingle(Console.ReadLine());

            Console.WriteLine("Digite o adicional noturno: ");
            adicionalNoturno = Convert.ToSingle(Console.ReadLine());

            Console.WriteLine("Digite o número de horas extras: ");
            horasExtras = Convert.ToSingle(Console.ReadLine());

            Console.WriteLine("Digite o desconto: ");
            descontos = Convert.ToSingle(Console.ReadLine());

            salarioLiquido = salarioBruto + adicionalNoturno + (horasExtras * 5) - descontos;
            Console.WriteLine($"O salário líquido é: {salarioLiquido}");



            //Exercício 4

            float n1, n2, n3, n4, diferenca;

            Console.WriteLine("\nDigite o numero 1: ");
            n1 = Convert.ToSingle(Console.ReadLine());

            Console.WriteLine("Digite o numero 2: ");
            n2 = Convert.ToSingle(Console.ReadLine());

            Console.WriteLine("Digite o numero 3: ");
            n3 = Convert.ToSingle(Console.ReadLine());

            Console.WriteLine("Digite o numero 4: ");
            n4 = Convert.ToSingle(Console.ReadLine());


            diferenca = (n1 * n2) - (n3 * n4);
            Console.WriteLine($"A diferença é {Math.Round(diferenca, 1)}.");

        }
    }
}