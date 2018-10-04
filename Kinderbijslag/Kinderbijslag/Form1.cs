using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kinderbijslag
{
    public partial class Form1 : Form
    {
        //
        //Vars
        //
        double betaal;
        byte aantalKinderen;
        byte opgeslagenKinderen;
        DateTime Nu = DateTime.Now;

        
        public Form1()
        {
            InitializeComponent();
        }

        //
        //Methodes
        //
        private void SlaOp()
        {
            int leeftijdJaren = Nu.Year - dateTimePicker1.Value.Year;
            if(leeftijdJaren < 12) { betaal = betaal + 150; }
            else if(leeftijdJaren < 18) { betaal = betaal + 235; }
            opgeslagenKinderen += 1;
            if(opgeslagenKinderen >= aantalKinderen)
            {
                if(aantalKinderen == 3 || aantalKinderen == 4)
                {
                    betaal = (betaal / 100) * 102; 
                }
                else if (aantalKinderen == 5)
                {
                    betaal = (betaal / 100) * 103;
                }
                else if (aantalKinderen >= 6)
                {
                    betaal = (betaal / 100) * 103.5;
                }
                lblOut.Text = "Te betalen Kinderbijslag: €" + betaal.ToString();
                betaal = 0;
                aantalKinderen = 0;
                opgeslagenKinderen = 0;
                Nu = DateTime.Now;
            }
        }


        //
        //Events
        //
        private void btnConfirm_Click(object sender, EventArgs e)
        {
            aantalKinderen = byte.Parse(txbaantalKinderen.Text);

            pnlKinderen.Visible = true;
        }

        private void btnpnlOk_Click(object sender, EventArgs e)
        {
            SlaOp();
            lblID.Text = "Kind " + (opgeslagenKinderen + 1).ToString();
            dateTimePicker1.Value = DateTime.Now;
        }
    }
}
