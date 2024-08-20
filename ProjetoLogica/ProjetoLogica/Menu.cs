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
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {
            new Atividade2().Show();
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            new Atividade1().Show();
        }

        private void toolStripMenuItem5_Click(object sender, EventArgs e)
        {
            new Atividade3().Show();

        }
    }
}
