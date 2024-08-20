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
    public partial class Atividade2 : Form
    {
        public Atividade2()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click_1(object sender, EventArgs e)
        {
            //variaveis
            double peso;
            int mercurio, venus, marte, jupiter, saturno, urano;

            //entradas
            //traduzindo a caixa de texto para a variavel
            peso = double.Parse(txtPesoTerra.Text);

            //processamento - saida
            if (rbtnMercurio.Checked)
            {
                peso = peso * 0.37;
                //caixa de texto para o usuario saber o peso no planeta escolhido
                MessageBox.Show("O seu peso em Mercúrio: " + peso);

            }

            // os planetas separados por estrutura de decisão, para que o usario veja apenas o peso do planeta escolhido
            else if (rbnVenus.Checked)
            {
                peso = peso * 0.88;

                MessageBox.Show("O seu peso em Vênus: " + peso);

            }

            else if (rbtnMarte.Checked)
            {
                peso = peso * 0.38;

                MessageBox.Show("O seu peso em Marte: " + peso);


            }

            else if (rbnJupiter.Checked)
            {
                //conta utilizada para medir o peso na Terra e no planeta escolhido pelo usuario
                peso = peso * 2.64;

                MessageBox.Show("O seu peso em Jupiter: " + peso);

            }

            else if (rbnSaturno.Checked)
            {
                peso = peso * 1.15;

                MessageBox.Show("O seu peso em Saturno: " + peso);

            }

            else if (rbnUrano.Checked)
            {
                peso = peso * 1.17;

                MessageBox.Show("O seu peso em Urano: " + peso);

            }
        }
    }
}
