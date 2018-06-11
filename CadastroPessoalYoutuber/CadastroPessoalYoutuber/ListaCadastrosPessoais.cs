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
    public partial class ListaCadastrosPessoais : Form
    {
        public ListaCadastrosPessoais()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ListaCadastrosPessoais_Load(object sender, EventArgs e)
        {
            CadastroPessoalRepositorio tudo = new CadastroPessoalRepositorio();
            foreach (CadastroPessoal cadastropessoal in tudo.ObterPersonagens())
            {
                dataGridView1.Rows.Add(new Object[]{

                cadastropessoal.GetNome(),
                cadastropessoal.GetSobrenome(),
                cadastropessoal.GetNickName(),

                });
            }
        }
    }
}
