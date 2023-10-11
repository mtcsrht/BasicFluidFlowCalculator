using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BasicFluidFlowCalculatorCLI;

namespace BasicFluidFlowCalculator
{

    public partial class FrmMain : Form
    {
        static List<IFluid> fluids = new List<IFluid>();
        Timer timer = new Timer();
        static double pipeLength;
        static double pipeDiameter;
        static double pipeRadius = (pipeDiameter / 100) / 2;
        static double pressureDifference;
        static double fluidViscosity;
        static double cur;
        static int elapsedSeconds;
        static double Q;

        public FrmMain()
        {
            InitializeComponent();
            InitLista();
            InitDropdown();
            btnSzamol.Click += BtnSzamol_Click;

            btnSzamol.MouseDown += BtnSzamol_MouseDown;
            btnSzamol.MouseUp += BtnSzamol_MouseUp;
            timer.Interval = 1000;
       }

        private void BtnSzamol_MouseUp(object sender, MouseEventArgs e)
        {
            timer.Stop();
        }

        private void BtnSzamol_MouseDown(object sender, MouseEventArgs e)
        {
            pipeLength = double.Parse(txtLength.Text) / 100;
            pipeDiameter = double.Parse(txtbAtmero.Text.Replace('.', ','));
            pipeRadius = (pipeDiameter / 100) / 2;
            pressureDifference = double.Parse(txtPressure.Text);
            fluidViscosity = fluids[cmbFluids.SelectedIndex].Viscosity;

            timer.Start();
            timer.Tick += Timer_Tick;
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            elapsedSeconds++;
            txtTime.Text = elapsedSeconds.ToString();
            //Q alap esetben 1m3/s de nekunk az ezred resze kell a milisecond miatt azaz 0.001m3/ms ezt literbe atszamolva 1l/ms azaz 1000ml/ms
            Q = (((Math.PI * pressureDifference * Math.Pow(pipeRadius, 4) / (8 * fluidViscosity * pipeLength)))*1000)*1000;
            cur += Q;
            txtOutput.Text = cur.ToString();
        }

        private void InitDropdown()
        {
            cmbFluids.DataSource = fluids;
            cmbFluids.DisplayMember = "Name";
        }

        private void InitLista()
        {
            fluids.Add(new Cola());
            fluids.Add(new Water());
        }

        private void BtnSzamol_Click(object sender, EventArgs e)
        {
            /*
            var diameter = double.Parse(txtbAtmero.Text); //d
            var velocity = double.Parse(txtLength.Text); //v
            var time = double.Parse(txtPressure.Text);//s
            //r = d/2
            //A = pi*r^2
            //Q = A*v
            //Q*s = output

            var radius = (diameter / 2.0)/100.0; //sugár cm to m
            var A = Math.PI * Math.Pow(radius, 2); //Keresztmetszet m2
            var Q = A * velocity; //térfogatáram köbméter/másodperc
            var result = Q * time; // eredmény

            var convertingtoDl = (result * 1000) * 10;

            txtOutput.Text = convertingtoDl.ToString();
            //android 8.1 oreo
            //unity gitignore

            //Mixer alkalmazás
            //százalékos kiértékelés, hogy mekkora pontossággal sikerült kitölteni az egyes összetevőket
            //több koktél recept
            //viszkozitás és nyomáskülönbség presetek.
            */


        }
    }
}
