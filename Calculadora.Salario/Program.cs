//importante a classe
using Calculadora.Salario.Model;


//Instanciando a classe
var funcionario = new Trabalhador();
var descINSS = 0d;
var descIR = 0d;

Console.WriteLine("Favor informar o nome do funcionário: ");
funcionario.Nome = Console.ReadLine();

Console.WriteLine("Favor informar o salário Bruto: ");
funcionario.SalarioBruto = Convert.ToDouble(Console.ReadLine());

descINSS = Math.Round(funcionario.CalculoINSS(funcionario.SalarioBruto),2);
Console.WriteLine($"Desconto INSS: {descINSS}");

descIR = Math.Round(funcionario.CalculoIR(funcionario.SalarioBruto),2);
Console.WriteLine($"Desconto IR: {descIR}");

funcionario.SalarioLiquido = Math.Round(funcionario.SalarioBruto - (descINSS + descIR),2);
Console.WriteLine($"O Funcionario: {funcionario.Nome}, receberá um salário líquido de: {funcionario.SalarioLiquido}");








