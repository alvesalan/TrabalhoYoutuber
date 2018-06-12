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
    [Serializable]
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
            AtualizarListaYoutubers();
        }

        private void AtualizarListaYoutubers()
        {
            CadastroPessoalRepositorio tudo = new CadastroPessoalRepositorio();
            foreach (CadastroPessoal cadastropessoal in tudo.ObterPersonagens())
            {
                dataGridView1.Rows.Add(new Object[]{

                cadastropessoal.GetLogin(),
                cadastropessoal.GetSenha(),
                cadastropessoal.GetNome(),
                cadastropessoal.GetSobrenome(),
                cadastropessoal.GetNickName(),
                cadastropessoal.GetNacionalidade(),
                cadastropessoal.GetIdade(),
                cadastropessoal.GetRendaMensal(),
                cadastropessoal.GetNomeDoCanal(),
                cadastropessoal.GetCategoria(),
                cadastropessoal.GetPlataformaJogo(),
                cadastropessoal.GetQuantidadesDeInscritos(),
                cadastropessoal.GetQuantidadeDeVisualizacoes(),
                cadastropessoal.GetQuantidadeMediaDeLikesPorVideo(),
                cadastropessoal.GetQuantidadeVideos(),
                cadastropessoal.GetPossueLive(),
                cadastropessoal.GetCanalMonetizado(),
                cadastropessoal.GetPossuePatrocinador(),
                cadastropessoal.GetQuantidadeStricker(),
                cadastropessoal.GetLink(),
                cadastropessoal.GetDescricao()
                                
                });
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            CadastroPessoalRepositorio tudo = new CadastroPessoalRepositorio();
            if (dataGridView1.CurrentRow == null)
            {
                MessageBox.Show("Selecione um registro para que seja possível apagar");
                return;
            }

            string codigo = Convert.ToString((dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[0].Value.ToString()));
            for (int i = 0; i < tudo.ObterPersonagem().cadastropessoal.Count(); i++)
            {
                CadastroPessoal cadastropessoal = cadastroPessoals[i];
                if (cadastropessoal.GetNomeDoCanal() == codigo)
                {
                    CadastroPessoal.cadastroPessoals.Remove(cadastropessoal);
                    AtualizarListaYoutubers();
                    MessageBox.Show(cadastropessoal.GetNome() + " apagado com sucesso");
                    return;
                }

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (dataGridView1.CurrentRow == null)
            {
                MessageBox.Show("Selecione um registro para que seja possível editar");
                return;
            }
            string codigo = Convert.ToString(dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[0].Value.ToString());
            new ListaYoutuber(codigo).ShowDialog();
        }

        private void btnApagarAluno_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow == null)
            {
                MessageBox.Show("Selecione um registro para que seja possível apagar");
                return;
            }

            string codigo = Convert.ToString(dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[0].Value.ToString());
            for (int i = 0; i < CadastroPessoalRepositorio.tudo.Count(); i++)
            {
                CadastroPessoal cadastropessoal = CadastroPessoal.cadastroPessoals[i];
                if (cadastropessoal.GetNome() == codigo)
                {
                    Program.alunos.Remove(aluno);
                    PopularListaAlunos();
                    MessageBox.Show(cadastropessoal.GetNome() + " apagado com sucesso");
                    return;
                }

            }
        }
    }
}
