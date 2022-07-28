//importante a classe
using Calculadora.Salario.Model;

//Instanciando a classe
var funcionario = new Funcionario();

Console.WriteLine("Favor informar o nome do funcionário: ");
funcionario.nome = Console.ReadLine();

Console.WriteLine("Favor informar o salário: ");
funcionario.salario = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Favor informar o bonus salarial: ");
double bonusSalario = Convert.ToDouble(Console.ReadLine());
//Buscando o o método Calculabonus dentro da classe Funcionario
funcionario.CalculaBonus(bonusSalario);

Console.WriteLine($"O nome do funcionário é : {funcionario.nome} e o seu salário é: {funcionario.salario}");








