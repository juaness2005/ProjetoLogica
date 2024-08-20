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
    public partial class Atividade1 : Form
    {
        public Atividade1()
        {
            InitializeComponent();
        }

        //inicializando as variáveis
        int n1, n2, n3;
 

        private void btnCalcular_Click(object sender, EventArgs e)
        {

            //convertendo variáveis numéricas(int) para texto(String)
            n1 = int.Parse(tbValor1.Text);
            n2 = int.Parse(tbValor2.Text);
            n3 = int.Parse(tbValor3.Text);


            //CRIANDO ESTRUTURAS CONDICIONAIS

            //n1
            //se o n1 for maior que o n2
            if (n1 > n2)
            {

                //exibindo texto no textbox 
                tbMaior.Text = tbValor1.Text;
                tbMenor.Text = tbValor2.Text;
            }

            //senão, se o n1 for maior que o n3
            else if (n1 > n3)
            { 
                tbMaior.Text = tbValor1.Text;
                tbMenor.Text = tbValor3.Text;
            }


            //n2
            //senão, se o n2 for maior que o n1
            else if (n2 > n1)
            {
                //se o n2 for 
                tbMaior.Text = tbValor2.Text;
                tbMenor.Text = tbValor1.Text;
            }

            //senão, se o n2 for maior que o n3
            else if (n2 > n3)
            {
                //o maior é n2 e n3 menor
                tbMaior.Text = tbValor2.Text;
                tbMenor.Text = tbValor3.Text;
            }



            //n3
            //senão, se o n3 for maior que o n1
            else if (n3 > n1)
            {
                //o maior é n3 e n1 menor
                tbMaior.Text = tbValor3.Text;
                tbMenor.Text = tbValor1.Text;
            }

            //senão, se o n3 for maior que o n2
            else if (n3 > n2)
            {
                //o maior é n3 e n2 menor
                tbMaior.Text = tbValor3.Text;
                tbMenor.Text = tbValor2.Text;
            }


            //caso contrario, se os números forem iguais
            else
            {
                //são iguais
                MessageBox.Show("São iguais, informe numeros diferentes");

            }
        

        }
    }
}
