using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicFluidFlowCalculatorCLI
{
    internal class Cola : Fluid
    {
        public override double Viscosity { get => viscosity; }
        public Cola()
        {
            viscosity = 0.00149;
        }
    }
}
