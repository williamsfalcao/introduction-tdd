using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Calculadora.Model
{
    public class Claculadora
    {
        private List<string> _hitorico = new List<string>();
        public int Somar(int val1, int val2)
        {
            _hitorico.Insert(0, "Soma");
            return val1 + val2;
        }

        public int Subtrair(int val1, int val2)
        {
            _hitorico.Insert(0, "Subtracao");
            return val1 - val2;
        }

        public int Multiplicar(int val1, int val2)
        {
            _hitorico.Insert(0, "Multiplicacao");
            return val1 * val2;
        }

        public int Dividir(int val1, int val2)
        {
            _hitorico.Insert(0, "Divisao");
            return val1 / val2;
        }

        public List<string>Historico()
        {
            return _hitorico.GetRange(0,3);
        }
    }
}