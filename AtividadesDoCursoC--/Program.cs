﻿//Atividades de Estrutura Sequencial

using System.Drawing;
using System.Globalization;
using System.Net.Http.Headers;
using System.Runtime.ConstrainedExecution;
using System.Runtime.Intrinsics.Arm;
using System.Security.Cryptography.X509Certificates;
using AtividadesDoCursoC__;

namespace Curso
{
    class Curso
    {
        static void Main(string[] args)
        {
            /*Fazer um programa para ler nome e salário de dois funcionários. Depois, mostrar o salário
            médio dos funcionários.*/

            Salario x, y;
            x = new Salario();
            y = new Salario();

            Console.WriteLine("Digite o nome do primeiro funcionario: ");
            x.NomeFuncionario = Console.ReadLine();
            Console.WriteLine("O salario do primeiro funcionario: ");
            x.SalarioFuncionario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("Digite o nome do segundo funcionario: ");
            y.NomeFuncionario = Console.ReadLine();
            Console.WriteLine("Digite o salario do segundo funcionario");
            y.SalarioFuncionario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double media = ((x.SalarioFuncionario + y.SalarioFuncionario) / 2.0);

            Console.WriteLine("Salario Medio= " + media.ToString("F2",CultureInfo.InvariantCulture));
        }


    }
}

