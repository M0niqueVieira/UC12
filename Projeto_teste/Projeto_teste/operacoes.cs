using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_teste
{
    public static class operacoes //internal = modificador de acesso (como se fosse um private)
    {
        public static double Somar(double pNum, double sNum)
        {
            return (pNum + sNum);
        }
        public static double Subtrair(double pNum, double sNum)
        {
            return (pNum - sNum);
        }
    }
    
}
