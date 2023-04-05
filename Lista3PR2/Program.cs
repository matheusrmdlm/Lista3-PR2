using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista3_PR2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int Exec;

            Console.WriteLine("             Menu");
            Console.WriteLine("          Execício 1");
            Console.WriteLine("          Execício 2");
            Console.WriteLine("          Execício 3");
            Console.WriteLine("          Execício 4");
            Console.WriteLine("          Execício 5");
            Console.WriteLine("          Execício 6\n");

            Exec = int.Parse(Console.ReadLine());

            switch (Exec)
            {
                case 1:
                    int dia;
                    Console.WriteLine("     Digite um numero de 1 0 7 para a Semana");
                    dia = int.Parse(Console.ReadLine());

                    switch (dia)
                    {
                        case 1:
                            Console.WriteLine("Domingo-Feira");
                            break;
                        case 2:
                            Console.WriteLine("Segunda-Feira");
                            break;
                        case 3:
                            Console.WriteLine("Terça-Feira");
                            break;
                        case 4:
                            Console.WriteLine("Quarta-Feira");
                            break;
                        case 5:
                            Console.WriteLine("Quinta-Feira");
                            break;
                        case 6:
                            Console.WriteLine("Sexta-Feira");
                            break;
                        case 7:
                            Console.WriteLine("Sábado-Feira");
                            break;

                        default:
                            Console.WriteLine("O Número Digitado Não Existe na Semana");
                            break;
                            return;

                    }
                    break;

                case 2:
                    Console.Write("Digite o valor total da compra: ");
                    double valorTotal = double.Parse(Console.ReadLine());

                    Console.WriteLine("Selecione a forma de pagamento:");
                    Console.WriteLine("1 - À vista no dinheiro (15% de desconto)");
                    Console.WriteLine("2 - À vista no PIX (10% de desconto)");
                    Console.WriteLine("3 - No débito (5% de acréscimo)");
                    Console.WriteLine("4 - No cartão de crédito (10% de acréscimo)");

                    Console.Write("Opção escolhida: ");
                    int opcao = int.Parse(Console.ReadLine());

                    double valorFinal;

                    switch (opcao)
                    {
                        case 1:
                            valorFinal = valorTotal * 0.85;
                            Console.WriteLine("Valor final a ser pago: R$ " + valorFinal.ToString("F2"));
                            break;
                        case 2:
                            valorFinal = valorTotal * 0.9;
                            Console.WriteLine("Valor final a ser pago: R$ " + valorFinal.ToString("F2"));
                            break;
                        case 3:
                            valorFinal = valorTotal * 1.05;
                            Console.WriteLine("Valor final a ser pago: R$ " + valorFinal.ToString("F2"));
                            break;
                        case 4:
                            valorFinal = valorTotal * 1.1;
                            Console.WriteLine("Valor final a ser pago: R$ " + valorFinal.ToString("F2"));
                            break;
                        default:

                            Console.WriteLine("Opção inválida!");
                            break;



                    }
                    break;

                case 3:
                    Console.Write("Digite o número do mês (1-12): ");
                    int mes = int.Parse(Console.ReadLine());

                    Console.Write("Digite o ano (yyyy): ");
                    int ano = int.Parse(Console.ReadLine());

                    int dias;

                    switch (mes)
                    {
                        case 1:
                            Console.WriteLine("Janeiro");
                            dias = 31;
                            break;
                        case 2:
                            Console.WriteLine("Fevereiro");
                            if ((ano % 4 == 0 && ano % 100 != 0) || ano % 400 == 0)
                            {
                                dias = 29;
                            }
                            else
                            {
                                dias = 28;
                            }
                            break;
                        case 3:
                            Console.WriteLine("Março");
                            dias = 31;
                            break;
                        case 4:
                            Console.WriteLine("Abril");
                            dias = 30;
                            break;
                        case 5:
                            Console.WriteLine("Maio");
                            dias = 31;
                            break;
                        case 6:
                            Console.WriteLine("Junho");
                            dias = 30;
                            break;
                        case 7:
                            Console.WriteLine("Julho");
                            dias = 31;
                            break;
                        case 8:
                            Console.WriteLine("Agosto");
                            dias = 31;
                            break;
                        case 9:
                            Console.WriteLine("Setembro");
                            dias = 30;
                            break;
                        case 10:
                            Console.WriteLine("Outubro");
                            dias = 31;
                            break;
                        case 11:
                            Console.WriteLine("Novembro");
                            dias = 30;
                            break;
                        case 12:
                            Console.WriteLine("Dezembro");
                            dias = 31;
                            break;
                        default:
                            Console.WriteLine("Mês inválido!");
                            dias = 0;
                            break;
                    }

                    if (dias > 0)
                    {
                        Console.WriteLine("O mês de " + mes.ToString("D2") + "/" + ano + " possui " + dias + " dias.");
                    }
                    break;

                case 4:
                    Console.Write("Digite o primeiro número: ");
                    int num1 = int.Parse(Console.ReadLine());

                    Console.Write("Digite o segundo número: ");
                    int num2 = int.Parse(Console.ReadLine());

                    Console.Write("Digite a operação (+, -, *, / ou ^): ");
                    char operador = char.Parse(Console.ReadLine());

                    int resultado = 0;

                    switch (operador)
                    {
                        case '+':
                            resultado = num1 + num2;
                            break;
                        case '-':
                            resultado = num1 - num2;
                            break;
                        case '*':
                            resultado = num1 * num2;
                            break;
                        case '/':
                            resultado = num1 / num2;
                            break;
                        case '^':
                            resultado = (int)Math.Pow(num1, num2);
                            break;
                        default:
                            Console.WriteLine("Operação inválida.");
                            return;
                    }

                    Console.WriteLine("Resultado: " + resultado);

                    break;

                case 5:
                    Console.Write("Digite o salário do funcionário: ");
                    double salario = double.Parse(Console.ReadLine());

                    Console.Write("Digite o código do cargo do funcionário: ");
                    int codigo = int.Parse(Console.ReadLine());

                    double percentualAumento;

                    switch (codigo)
                    {
                        case 101:
                            percentualAumento = 0.075;
                            break;
                        case 102:
                            percentualAumento = 0.097;
                            break;
                        case 103:
                            percentualAumento = 0.117;
                            break;
                        case 204:
                            percentualAumento = 0.089;
                            break;
                        case 206:
                            percentualAumento = 0.1324;
                            break;
                        case 301:
                            percentualAumento = 0.104;
                            break;
                        case 302:
                            percentualAumento = 0.146;
                            break;
                        default:
                            percentualAumento = 0.435;
                            break;
                    }

                    double novoSalario = salario * (1 + percentualAumento);

                    Console.WriteLine("Salário antigo: R$ " + salario.ToString("F2"));
                    Console.WriteLine("Novo salário: R$ " + novoSalario.ToString("F2"));
                    Console.WriteLine("Diferença salarial: R$ " + (novoSalario - salario).ToString("F2"));

                    break;

                case 6:
                    Console.Write("Informe o salário mensal do trabalhador: ");
                    double salari = double.Parse(Console.ReadLine());

                    double imposto = 0;
                    if (salari <= 1903.98)
                    {
                        imposto = 0;
                    }
                    else if (salari <= 2826.65)
                    {
                        imposto = salari * 0.075;
                    }
                    else if (salari <= 3751.05)
                    {
                        imposto = salari * 0.15;
                    }
                    else if (salari <= 4664.68)
                    {
                        imposto = salari * 0.225;
                    }
                    else
                    {
                        imposto = salari * 0.275;
                    }

                    double salarioLiquido = salari - imposto;

                    Console.WriteLine($"Imposto de renda a ser pago: R$ {imposto:F2}");
                    Console.WriteLine($"Salário líquido após o desconto do imposto: R$ {salarioLiquido:F2}");

                    break;
            }
        }
    }
}
