using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CadastroPessoalYoutuber
{
    public partial class Lista2 : Form
    {
        public Lista2()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void AtualizarLista()
        {
            CadastroPessoalRepositorio tudo = new CadastroPessoalRepositorio();
            foreach (CadastroPessoal cadastropessoal in tudo.ObterPersonagens())
            {
                dataGridView1.Rows.Add(new Object[]
                {
                    cadastropessoal.GetNome(),
                    cadastropessoal.GetNomeDoCanal(),
                    cadastropessoal.GetQuantidadesDeInscritos(),
                });
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AtualizarLista();
        }
    }
}
