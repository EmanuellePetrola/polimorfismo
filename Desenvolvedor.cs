using System;
using System.Collections.Generic;
using System.Text;

namespace Polimorfismo

    {
        class Desenvolvedor : Funcionario
        {
            public override double CalcularBonusAnual()
            {
                return Salario * 0.12;
            }
        }
    }


