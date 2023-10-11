using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicFluidFlowCalculatorCLI
{
    public interface IFluid
    {
        string Name { get;}
        double Viscosity { get;}
    }
}
