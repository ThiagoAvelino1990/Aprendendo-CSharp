//Criando uma classe
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora.Salario.Model
{
    //Calsse pública de nome Funcionario
    public class Funcionario
    {   
        //Método publico da classe que não retorna nada mas tem um parâmetro de entrada do tipo double
        public void CalculaBonus(double bonus)
        {
            salario = salario + bonus;

        }
        public double salario{ get; set; }
        public string nome { get; set; }

    }
}
