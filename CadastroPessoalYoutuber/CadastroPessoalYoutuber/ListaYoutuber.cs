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
                DialogResult resultado = MessageBox.Show("Deseja realmente apagar o arquivo ??", "AVISO", MessageBoxButtons.YesNo);
                if (resultado == DialogResult.Yes)
                {
                    ApagarYoutuber();
                }
                else
                {
                    MessageBox.Show("Arquivo salvo com sucesso !!");
                }
                
            }
            if (e.Modifiers == Keys.Control && e.KeyCode == Keys.E)
            {
                MessageBox.Show("Me desculpe professor mais não conseguir fazer algumas partes do editar por estar em telas diferentes mais vou tentar fazer ate conseguir terminar !! OBS: Na hora que chega na parte do codigo de abrir a janela para editar, não consigo relacionar a pagina com o codigo que esta no repositorio que e o cadastro escolhido para editar, abre a janela de cadastro mais não trais a informaçoes para editar. ");
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
