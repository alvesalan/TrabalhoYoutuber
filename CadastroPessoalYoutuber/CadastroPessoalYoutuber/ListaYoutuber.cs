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
    public partial class ListaYoutuber : Form
    {
       
        

        public ListaYoutuber()
        {
            InitializeComponent();
        }

       


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ListaCadastrosPessoais_Load(object sender, EventArgs e)
        {
           
        }

        private void AtualizarListaYoutubers()
        {
            CadastroPessoalRepositorio tudo = new CadastroPessoalRepositorio();
            dataGridView1.Rows.Clear();
            foreach (CadastroPessoal cadastropessoal in tudo.ObterPersonagens())
            {
                dataGridView1.Rows.Add(new Object[]{

                cadastropessoal.GetCodigo(),
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

            ApagarYoutuber();
        }

        private void ApagarYoutuber()
        {
            if (dataGridView1.CurrentRow == null)
            {
                MessageBox.Show("Selecione algo nesta lista");
                return;
            }

            string nome = dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[3].Value.ToString();
            dataGridView1.Rows.RemoveAt(dataGridView1.CurrentRow.Index);
            CadastroPessoalRepositorio repository = new CadastroPessoalRepositorio();
            repository.ApagarCadastroPessoal(nome);
            MessageBox.Show(nome + " apagado com sucesso");


        }

        private void button3_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void ListaCadastrosPessoais_Activated(object sender, EventArgs e)
        {
            AtualizarListaYoutubers();
        }

        private void ListaCadastrosPessoais_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Modifiers == Keys.Control && e.KeyCode == Keys.T)
            {
                ApagarYoutuber();
            }
            if (e.Modifiers == Keys.Control && e.KeyCode == Keys.E)
            {
                EditarPersonagem();
            }

        }

        private void EditarPersonagem()
        {
            if (dataGridView1.CurrentRow == null)
            {
                MessageBox.Show("Selecione um registro para que seja possível editar");
                return;
            }
            int codigo = Convert.ToInt32(dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[0].Value.ToString()); ;
            new CadastroYoutuber(codigo).ShowDialog();
        }

        
            private void button1_Click_1(object sender, EventArgs e)
        {
            
        }

            private void button3_Click_1(object sender, EventArgs e)
            {
                Dispose();
            }

            private void button1_Click(object sender, EventArgs e)
            {
                AtualizarListaYoutubers();
            }
    }
}
