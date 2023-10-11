using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BasicFluidFlowCalculator
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
            btnSzamol.Click += BtnSzamol_Click;
        }

        private void BtnSzamol_Click(object sender, EventArgs e)
        {
            var diameter = double.Parse(txtbAtmero.Text); //d
            var velocity = double.Parse(txtVelocity.Text); //v
            var time = double.Parse(txtElapsedTime.Text);//s
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
        }
    }
}
