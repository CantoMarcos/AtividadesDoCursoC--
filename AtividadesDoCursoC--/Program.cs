//Atividades de Estrutura Sequencial

using System.Drawing;
using System.Globalization;
using System.Runtime.ConstrainedExecution;
using System.Runtime.Intrinsics.Arm;

namespace Curso
{
    class Curso
    {
        static void Main(string[] args)
        {
            /*Um Posto de combustíveis deseja determinar qual de seus produtos tem a preferência de seus clientes. Escreva
            um algoritmo para ler o tipo de combustível abastecido (codificado da seguinte forma: 1.Álcool 2.Gasolina 3.Diesel
            4.Fim). Caso o usuário informe um código inválido (fora da faixa de 1 a 4) deve ser solicitado um novo código (até
            que seja válido). O programa será encerrado quando o código informado for o número 4. Deve ser escrito a
            mensagem: "MUITO OBRIGADO" e a quantidade de clientes que abasteceram cada tipo de combustível, conforme
            exemplo*/

            Console.WriteLine("Digite o tipo de combustivel: ");
            Console.WriteLine("1 - Alcool");
            Console.WriteLine("2 - Gasolina");
            Console.WriteLine("3 - Diesel");
            Console.WriteLine("4 - FIM");

            int combustivel = int.Parse(Console.ReadLine());
            int somaAlcool = 0;
            int somaGasolina = 0;
            int somaDiesel = 0;

            while (combustivel != 4) 
            {
                if(combustivel == 1) {
                    Console.WriteLine("Álcool");
                    somaAlcool++;
                }
                else if(combustivel == 2)
                {
                    Console.WriteLine("Gasolina");
                    somaGasolina++;
                }
                else if( combustivel == 3)
                {
                    Console.WriteLine("Diesel");
                    somaDiesel++;
                }
                else if((combustivel <=0) || (combustivel> 4))
                {
                    Console.WriteLine("Opção Invalida");
                }
                Console.WriteLine("Digite o tipo de combustivel: ");
                Console.WriteLine("1 - Alcool");
                Console.WriteLine("2 - Gasolina");
                Console.WriteLine("3 - Diesel");
                Console.WriteLine("4 - FIM");
                combustivel = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Muito Obrigado");
            Console.WriteLine($"Total de Alcool: {somaAlcool}");
            Console.WriteLine($"Total de Gasolina: {somaGasolina}");
            Console.WriteLine($"Total de Diesel: {somaDiesel}");



        }
    }
}

