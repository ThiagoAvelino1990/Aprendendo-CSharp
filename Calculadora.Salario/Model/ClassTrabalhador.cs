using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora.Salario.Model
{
    public class Trabalhador
    {
        //Propriedades da Classe
        public string Nome { get; set; }

        public double SalarioBruto { get; set; }

        public double SalarioLiquido { get; set; }


        //Métodos da Classe
        public double CalculoINSS(double SalarioBruto)
        {
            var faixaUm = 0.075;//7,5%
            var faixaDois = 0.09;//9%
            var faixaTres = 0.12;//12%
            var faixaQuatro = 0.14;//14%

            //Faixa Um
            if (SalarioBruto <= 1212.00)
            {
                return Math.Round((SalarioBruto * faixaUm),2);
            }
            //Faixa Dois
            else if (SalarioBruto > 1212.00 && SalarioBruto <= 2427.35)
            {
                return Math.Round((1212.00 * faixaUm) + (faixaDois * (SalarioBruto - 1212.00)),2);
            }
            //Faixa Três
            else if (SalarioBruto > 2427.35 && SalarioBruto <= 3641.03)
            {
                return Math.Round((1212.00 * faixaUm) + ((2427.35  - 1212.00)* faixaDois) + (faixaTres * (SalarioBruto - 2427.35)),2);
            }
            //Faixa quatro
            else if (SalarioBruto > 3641.03 && SalarioBruto <= 7087.22)
            {
                return Math.Round((1212.00 * faixaUm) + ((2427.35 - 1212.00) * faixaDois) + ((3641.03 - 2427.35) * faixaTres) + (faixaQuatro * (SalarioBruto - 3641.03)),2); 
            }

            return Math.Round((1212.00 * faixaUm) + ((2427.35 - 1212.00) * faixaDois) + ((3641.03 - 2427.35) * faixaTres) + ((7087.22 - 3641.03)*faixaQuatro),2); 
        }

        public double CalculoIR(double SalarioBruto)
        {
            var aliquotaUm = 0.075;
            var aliquotaDois = 0.15;
            var aliquotaTres = 0.225;
            var aliquotaQuatro = 0.275;

            if (SalarioBruto <= 1903.98)
            {
                return 0;
            }
            else if (SalarioBruto > 1903.98 && SalarioBruto <= 2826.65)
            {
                return Math.Round(((SalarioBruto * aliquotaUm) - 142.80),2);
            }
            else if (SalarioBruto >= 2826.66 && SalarioBruto <= 3751.05)
            {
                return Math.Round(((SalarioBruto * aliquotaDois) - 354.80),2); 
            }
            else if (SalarioBruto >= 3751.06 && SalarioBruto <= 4664.68)
            {
                return Math.Round(((SalarioBruto * aliquotaTres) - 636.13),2); 
            }
            else if (SalarioBruto >= 4664.69)
            {
                return Math.Round(((SalarioBruto * aliquotaQuatro) - 869.36),2); 
            }

            return 0;

        }
    }
}
