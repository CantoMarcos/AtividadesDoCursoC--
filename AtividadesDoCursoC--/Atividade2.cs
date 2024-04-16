using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtividadesDoCursoC__
{
    internal class Atividade2
    {
        //1- Fazer um programa para ler um número inteiro, e depois dizer se este número é negativo ou não.
        Console.WriteLine("Digite um numero inteiro: ");

            int numero1 = int.Parse(Console.ReadLine());

            if (numero1< 0)
            {
                Console.WriteLine("NEGATIVO");
            }
            else
            {
                Console.WriteLine("NÃO NEGATIVO");
            }


        //2- Fazer um programa para ler um número inteiro e dizer se este número é par ou ímpar

        Console.WriteLine("Digite um numero inteiro para verificar a paridade: ");
        int numero2 = int.Parse(Console.ReadLine());

        if (numero2 % 2 == 0)
        {
            Console.WriteLine("PAR");
        }
        else
        {
            Console.WriteLine("IMPAR");
        }

        /*3-Leia 2 valores inteiros (A e B). Após, o programa deve mostrar uma mensagem "Sao Multiplos" ou "Nao sao
        Multiplos", indicando se os valores lidos são múltiplos entre si. Atenção: os números devem poder ser digitados em
        ordem crescente ou decrescente.*/

        Console.WriteLine("Digite dois numeros inteiros A e B: ");

        string[] vet1 = Console.ReadLine().Split(' ');
        int A = int.Parse(vet1[0]);
        int B = int.Parse(vet1[1]);

        if (A % B == 0 || B % A == 0)
        {
            Console.WriteLine("São multiplos");
        }
        else
        {
            Console.WriteLine("Não são multiplos");
        }
        /*4- Leia a hora inicial e a hora final de um jogo. A seguir calcule a duração do jogo, sabendo que o mesmo pode
        em um dia e terminar em outro, tendo uma duração mínima de 1 hora e máxima de 24 horas.*/

        Console.WriteLine("Digite o horario inicial e o horario final: ");
        string[] vet2 = Console.ReadLine().Split(' ');
        int horainicial = int.Parse(vet2[0]);
        int horafinal = int.Parse(vet2[1]);

        int duracao;

        if (horainicial < horafinal)
        {
            duracao = horafinal - horainicial;
        }
        else
        {
            duracao = 24 - horainicial + horafinal;
        }

        Console.WriteLine($"O JOGO DUROU {duracao} HORAS");

        /*5- Com base na tabela abaixo, escreva um programa que leia o código de um item e a quantidade deste item. A
        seguir, calcule e mostre o valor da conta a pagar.*/

        Console.WriteLine("Digite o codigo e a quantidade: ");
        string[] vet3 = Console.ReadLine().Split(' ');

        int codigo = int.Parse(vet3[0]);
        int quantidade = int.Parse(vet3[1]);
        double total = 0;

        if (codigo == 1)
        {
            total = 4.00 * quantidade;
        }
        else if (codigo == 2)
        {
            total = 4.50 * quantidade;
        }
        else if (codigo == 3)
        {
            total = 5.00 * quantidade;
        }
        else if (codigo == 3)
        {
            total = 2.00 * quantidade;
        }
        else if (codigo == 4)
        {
            total = 1.50 * quantidade;
        }
        else
        {
            Console.WriteLine("Numero invalido");
        }

        Console.WriteLine($"Total: R${total.ToString("F2", CultureInfo.InvariantCulture)}");

        /*6- Você deve fazer um programa que leia um valor qualquer e apresente uma mensagem dizendo em qual dos
        seguintes intervalos ([0,25], (25,50], (50,75], (75,100]) este valor se encontra. Obviamente se o valor não estiver em
        nenhum destes intervalos, deverá ser impressa a mensagem “Fora de intervalo”.*/

        Console.WriteLine("Digite um valor inteiro: ");
        double numeroEscolhido = double.Parse(Console.ReadLine());

        if (numeroEscolhido >= 0 && numeroEscolhido <= 25)
        {
            Console.WriteLine("Intervalo [0,25]");
        }
        else if (numeroEscolhido > 25 && numeroEscolhido <= 50)
        {

        Console.WriteLine("Intervalo [25,50]");
        }
        else if (numeroEscolhido > 50 && numeroEscolhido <= 75)
        {
            Console.WriteLine("Intervalo [50,75]");
        }
        else if (numeroEscolhido > 75 && numeroEscolhido <= 100)
        {
            Console.WriteLine("Intervalo [75,100]");
        }
        else
        {
            Console.WriteLine("Numero invalido");
        }

        /*7- Leia 2 valores com uma casa decimal (x e y), que devem representar as coordenadas
        de um ponto em um plano. A seguir, determine qual o quadrante ao qual pertence o
        ponto, ou se está sobre um dos eixos cartesianos ou na origem (x = y = 0).
        Se o ponto estiver na origem, escreva a mensagem “Origem”.
        Se o ponto estiver sobre um dos eixos escreva “Eixo X” ou “Eixo Y”, conforme for a
        situação.*/

        Console.WriteLine("Digite dois numero com uma casa decimal: ");
        string[] vet4 = Console.ReadLine().Split(' ');

        double valor1 = double.Parse(vet4[0]);
        double valor2 = double.Parse(vet4[1]);

        if (valor1 == 0 && valor2 == 0)
        {
            Console.WriteLine("Origem");
        }
        else if (valor1 == 0)
        {
            Console.WriteLine("Eixo Y");
        }
        else if (valor2 == 0)
        {
            Console.WriteLine("Eixo X");
        }
        else if (valor1 > 0 && valor2 > 0)
        {
            Console.WriteLine("Quadrante 1");
        }
        else if (valor1 < 0 && valor2 > 0)
        {
            Console.WriteLine("Quadrante 2");
        }
        else if (valor1 < 0 && valor2 < 0)
        {
            Console.WriteLine("Quadrante 3");
        }
        else
        {
            Console.WriteLine("Quadrante 4");
        }

        /*8- ATIVIDADE 8 */
        double salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        double imposto;
        if (salario <= 2000.0)
        {
            imposto = 0.0;
        }
        else if (salario <= 3000.0)
        {
            imposto = (salario - 2000.0) * 0.08;
        }
        else if (salario <= 4500.0)
        {
            imposto = (salario - 3000.0) * 0.18 + 1000.0 * 0.08;
        }
        else
        {
            imposto = (salario - 4500.0) * 0.28 + 1500.0 * 0.18 + 1000.0 * 0.08;
        }

        if (imposto == 0.0)
        {
            Console.WriteLine("Isento");
        }
        else
        {
            Console.WriteLine("R$ " + imposto.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
