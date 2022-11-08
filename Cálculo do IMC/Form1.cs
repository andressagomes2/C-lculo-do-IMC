using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cálculo_do_IMC
{
    public partial class IMC : Form
    {
        public IMC()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            double p = double.Parse(txb1.Text);
            double a = double.Parse(txb2.Text);
            double r = p / (a*a) ;
            txb3.Text = p / (a * a) + "";
            if (r <= 18.5 )
            {
               txbresposta.Text=("Seu peso está abaixo do Ideal");
            }
            else if (r >= 18.6)
            {
                txbresposta.Text = ("Show Dez Jovem!!! Peso Ideal");
            }
            else if (r <= 25)
            {
                txbresposta.Text = ("Levemente acima, ok Jovem?!");
            }
            else if (r <= 30)
            {
                txbresposta.Text = ("Obesidade grau I, precisa melhorar Jovem.");
            }
            else if (r <= 35)
            {
                txbresposta.Text = ("Obesidade grau II, Complicado Jovem!");
            }
            else if (r <= 40)
            {
                txbresposta.Text = ("Obesidade grau III, Putz Jovem!");
            }
        }

  
    }
}
