using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoLogica
{
    public partial class Atividade3 : Form
    {
        public Atividade3()
        {
            InitializeComponent();
        }

        //inicializando as variáveis
        int gremio, palmeiras, santos, corinthians, pontePreta, flamengo, juventude, internacional, botafogo, cruzeiro, vasco, atleticoMineiro;


        string resultado;

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            //convertendo de tipo numérico (int) para tipo texto (string)
            //Time 1
            gremio = int.Parse(tbA1.Text); //a
            palmeiras = int.Parse(tbB1.Text); //b
            santos = int.Parse(tbC1.Text); //c
            corinthians= int.Parse(tbD1.Text); //d 
            pontePreta = int.Parse(tbE1.Text); //e
            flamengo = int.Parse(tbF1.Text); //f

            //Time 2
            juventude = int.Parse(tbA2.Text); //a
            internacional = int.Parse(tbB2.Text); //b
            botafogo = int.Parse(tbC2.Text); //c
            cruzeiro = int.Parse(tbD2.Text); //d
            vasco = int.Parse(tbE2.Text); //e
            atleticoMineiro = int.Parse(tbF2.Text); //f

            //criando estruturas condicionais
            //time A
            if (gremio > juventude) {

                //exibindo o texto no textbox de resultado
                tbResultadoA.Text = ("Gremio");
            }

            else if (gremio < juventude)
            {
                tbResultadoA.Text = ("Juventude");
            }
            else
            {
                tbResultadoA.Text = ("Empate");
            }

            //Time B
            if (palmeiras > internacional)
            {
                tbResultadoB.Text = ("Palmeiras");
            }
            else if (palmeiras < internacional)
            {
                tbResultadoB.Text = ("Internacional");
            }
            else
            {
                tbResultadoB.Text = ("Empate");
            }

            //Time C
            if (santos > botafogo)
            {
                tbResultadoC.Text = ("Santos");

            }
            else if (santos < botafogo)
            {
                tbResultadoC.Text = ("Botafogo");
            }
            else
            {
                tbResultadoC.Text = ("Empate");
            }

            //Time D
            if (corinthians > cruzeiro)
            {
                tbResultadoD.Text = ("Corinthians");
            }
            else if (corinthians < cruzeiro)
            {
                tbResultadoD.Text = ("Cruzeiro");
            }
            else
            {
                tbResultadoD.Text = ("Empate");
            }

            //Time E
            if (pontePreta > vasco)
            {
                tbResultadoE.Text = ("Ponte Preta");

            }
            else if (pontePreta < vasco)
            {
                tbResultadoE.Text = ("Vasco");
            }
            else
            {
                tbResultadoE.Text = ("Empate");
            }

            //Time F
            if (flamengo > atleticoMineiro)
            {
                tbResultadoF.Text = ("Flamengo");

            }
            else if (flamengo < atleticoMineiro)
            {
                tbResultadoF.Text = ("Atlético Mineiro");
            }
            else
            {
                tbResultadoF.Text = ("Empate");
            }
        }
    }
}
