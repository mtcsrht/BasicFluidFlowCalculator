using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicFluidFlowCalculatorCLI
{
    public class Water : IFluid
    {
        public string Name { get => "Water"; }
        public double Viscosity { get => 0.001; }
    }
}
