//Atividades de Estrutura Sequencial

using System.Globalization;

namespace Curso
{
    class Curso
    {
        static void Main(string[] args)
        {

            /*Faça um programa para ler dois valores inteiros, e depois mostrar na tela a soma desses números com uma
 mensagem explicativa, conforme exemplos.*/

            Console.WriteLine("Aplicativo de Soma de dois numero");
            Console.Write("Digite o primeiro numero: ");
            int num1 = int.Parse(Console.ReadLine());
            Console.Write("Digite o primeiro numero: ");
            int num2 = int.Parse(Console.ReadLine());


            int soma = num1 + num2;
            Console.WriteLine($"A soma dos numero é: {soma}");

            /*Faça um programa para ler o valor do raio de um círculo, e depois mostrar o valor da área deste círculo com quatro
            casas decimais conforme exemplos.
            Fórmula da área: area = π . raio2
            Considere o valor de π = 3.14159*/

            Console.WriteLine("Codigo que calcula a area de um circulo");
            Console.Write("Digite o valor do raio: ");
            double raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double pi = 3.14159;

            double volume = pi * Math.Pow(raio, 2);
            Console.WriteLine($"O valor da area é: {volume.ToString("F4")}");

            /*Fazer um programa para ler quatro valores inteiros A, B, C e D. A seguir, calcule e mostre a diferença do produto
            de A e B pelo produto de C e D segundo a fórmula: DIFERENCA = (A * B - C * D).*/

            Console.WriteLine("Calcular a diferença do produto de A e B pelo produto de C e D");
            Console.Write("Digite o valor de A: ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Digite o valor de B: ");
            int b = int.Parse(Console.ReadLine());
            Console.Write("Digite o valor de C: ");
            int c = int.Parse(Console.ReadLine());
            Console.Write("Digite o valor de D: ");
            int d = int.Parse(Console.ReadLine());
            int valor = a * b - c * d;
            Console.WriteLine("O valor de A*B - C*D é: ");
            Console.WriteLine(valor);

            /*Fazer um programa que leia o número de um funcionário, seu número de horas trabalhadas, o valor que recebe por
            hora e calcula o salário desse funcionário. A seguir, mostre o número e o salário do funcionário, com duas casas
            decimais.*/

            Console.WriteLine("Programa que identifica o numero do funcionario e indica seu salario");
            Console.Write("Digite o numero do funcionario: ");
            int numero = int.Parse(Console.ReadLine());
            Console.Write("Digite a quantidade de horas trabalhadas: ");
            int horas = int.Parse(Console.ReadLine());
            Console.Write("Digite o valor que o funcionario recebe por hora: ");
            double valorhora = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("O numero do funcionario e seu salario são: ");
            double salario = horas * valorhora;
            Console.WriteLine($"Numero : {numero}");
            Console.WriteLine($"Salário: U$ {salario.ToString("F2", CultureInfo.InvariantCulture)}");

            /*Fazer um programa para ler o código de uma peça 1, o número de peças 1, o valor unitário de cada peça 1, o
            código de uma peça 2, o número de peças 2 e o valor unitário de cada peça 2. Calcule e mostre o valor a ser pago.*/

            Console.WriteLine("Digite o codigo da peça, o numero de peças e o valor por peça: ");
            string valores1 = Console.ReadLine();

            string[] vet = valores1.Split(' ');
            int codigo1 = int.Parse(vet[0]);
            int numeropeca1 = int.Parse(vet[1]);
            double valorpeca1 = double.Parse(vet[2], CultureInfo.InvariantCulture);

            double valor1 = numeropeca1 * valorpeca1;

            Console.WriteLine("Digite o codigo da segunda peça, o numero de peças e o valor por peça: ");
            string valores2 = Console.ReadLine();

            string[] vet2 = valores2.Split(' ');
            int codigo2 = int.Parse(vet2[0]);
            int numeropeca2 = int.Parse(vet2[1]);
            double valorpeca2 = double.Parse(vet2[2], CultureInfo.InvariantCulture);

            double valor2 = numeropeca2 * valorpeca2;

            double valorTotal = valor1 + valor2;

            Console.WriteLine($"Valor a Pagar: {valorTotal.ToString("F2", CultureInfo.InvariantCulture)}");
            /*Fazer um programa que leia três valores com ponto flutuante de dupla precisão: A, B e C. Em seguida, calcule e
            mostre:
                a) a área do triângulo retângulo que tem A por base e C por altura.
                b) a área do círculo de raio C. (pi = 3.14159)
                c) a área do trapézio que tem A e B por bases e C por altura.
                d) a área do quadrado que tem lado B.
                e) a área do retângulo que tem lados A e B.*/

            Console.WriteLine("Digite os valores dos numero com ponto flutuante de dupla precisão A , B e C respectivamente: ");
            string valores = Console.ReadLine();
            string[] vetValores = valores.Split(' ');
            double A = double.Parse(vetValores[0],CultureInfo.InvariantCulture);
            double B = double.Parse(vetValores[1],CultureInfo.InvariantCulture); 
            double C = double.Parse(vetValores[2],CultureInfo.InvariantCulture);
            double pi2 = 3.14159;

            Console.WriteLine("Area do Triangulo com A como base e C como altura");
            double areaTri = A * C / 2;
            Console.WriteLine(areaTri.ToString("F3",CultureInfo.InvariantCulture));

            Console.WriteLine("Area do Circulo com Raio C: ");
            double areaC = pi2 * Math.Pow(C, 2);
            Console.WriteLine(areaC.ToString("F3",CultureInfo.InvariantCulture));

            Console.WriteLine("Area Do trapézio que tem A e B como base e C como altura: ");
            double areaTra = ((A+B)*C) / 2;
            Console.WriteLine(areaTra.ToString("F3", CultureInfo.InvariantCulture));

            Console.WriteLine("Area do quadrado que tem lado B: ");
            double areaB = Math.Pow(B, 2);
            Console.WriteLine(areaB.ToString("F3",CultureInfo.InvariantCulture));

            Console.WriteLine("Area do retangulo que tem lado A e B: ");
            double areaRet = A * B;
            Console.WriteLine(areaRet.ToString("F3", CultureInfo.InvariantCulture));

        }
    }
}

