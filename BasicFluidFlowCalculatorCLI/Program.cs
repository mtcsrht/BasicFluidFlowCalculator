using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Timers;

namespace BasicFluidFlowCalculatorCLI
{
    internal class Program
    {
        static void Main()
        {

            
            /*
            var diameter = double.Parse(args[0]); //d
            var velocity = double.Parse(args[1]); //v
            var time = double.Parse(args[2]);//s
            //r = d/2
            //A = pi*r^2
            //Q = A*v
            //Q*s = 
            var radius = (diameter / 2.0) / 100.0;
            var A = Math.PI * Math.Pow(radius, 2);
            var Q = A * velocity;
            var result = Q * time;
            Console.WriteLine(result);
            */



            Water water = new Water();
            //30cm-es cső 1.5-ös átmérő 0.8 Pa nyomáskülönbség víz viszkozitás
            //Q = (π * ΔP * r^4) / (8 * η * L)
            //Ahol:
            //Q a folyadék áramlási sebessége(köbméterben másodpercenként).
            //ΔP a nyomáskülönbség a cső két végpontja között(pascal-ban).
            //r a cső vagy vezeték sugara(méterben).
            //η a folyadék viszkozitása(pascal másodpercenként, más néven poiseuille).
            //L a cső vagy vezeték hossza(méterben).


            Cola cola = new Cola();
            string[] args;
            do
            {
                try
                {

                    args = Console.ReadLine().Split(' ');
                    if (args[0] == "ex")
                    {
                        break;
                    }
                    var pipeLength = double.Parse(args[0]) / 100;
                    var pipeDiameter = double.Parse(args[1]); //d
                    var pipeRadius = (pipeDiameter / 100) / 2;
                    var pressureDifference = double.Parse(args[2]); //ΔPa
                    var fluidViscosity = water.Viscosity;

                    var Q = (Math.PI * pressureDifference * Math.Pow(pipeRadius, 4)) / (8 * fluidViscosity * pipeLength);
                    var convertToMl = (Q * 1000) * 1000;
                    Console.WriteLine($"Másodpercenként {convertToMl:0.00} ml\nEgy 250ml-es pohár {250/convertToMl:0.00} s alatt telik meg.");
                }
                catch (Exception)
                {

                    Console.WriteLine("Hiba valahol!");
                    continue;
                }
            } while (true);
        }
    }
}
