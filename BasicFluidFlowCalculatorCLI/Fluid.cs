using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicFluidFlowCalculatorCLI
{
    /// <summary>
    /// Fluid base class, amiből tudunk származtatni folyadék típusokat.
    /// </summary>
    internal abstract class Fluid
    {
        protected double viscosity;
        public abstract double Viscosity { get; }
        //public abstract decimal Pressure { get;}
    }
}
