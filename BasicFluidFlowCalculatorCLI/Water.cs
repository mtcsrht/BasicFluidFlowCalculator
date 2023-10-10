using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicFluidFlowCalculatorCLI
{
    internal class Water : Fluid
    { 
        public override double Viscosity { get => viscosity; }
        public Water()
        {
            viscosity = 0.001;
        }
    }
}
