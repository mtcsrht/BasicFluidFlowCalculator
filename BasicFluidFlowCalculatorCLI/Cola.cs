using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicFluidFlowCalculatorCLI
{
    public class Cola : IFluid
    {
        public string Name { get => "Cola"; }
        public double Viscosity { get => 0.00149; }

    }
}
