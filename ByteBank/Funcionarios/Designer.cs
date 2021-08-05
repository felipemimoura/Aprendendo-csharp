using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.Funcionarios
{
    class Designer: Funcionario
    {
        public Designer(string cpf) : base(3000, "987.654.321-10")
        {

        }

        public override void AumentarSalario()
        {
            Salario *= 1.17;
        }
        public override double GetBonificacao()
        {

            return Salario * 0.17;
        }
    }
}
