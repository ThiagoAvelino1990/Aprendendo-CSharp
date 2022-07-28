using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora.Salario.Model
{
    public class Funcionario
    {   
        public void CalculaBonus(double bonus)
        {
            salario = salario + bonus;

        }
        public double salario{ get; set; }
        public string nome { get; set; }

    }
}
