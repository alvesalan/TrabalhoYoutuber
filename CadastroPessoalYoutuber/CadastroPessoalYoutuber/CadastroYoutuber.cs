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
    public partial class CadastroYoutuber : Form
    {
        int posicao = -1;
        private int codigo;
        public static string NOME_ARQUIVO = "Personagens.bin";


        public CadastroYoutuber()
        {
            InitializeComponent();
        }
        public CadastroYoutuber(int codigo)
        {
            InitializeComponent();

            this.codigo = codigo;
            CadastroPessoalRepositorio repositorio = new CadastroPessoalRepositorio();
           
        }
        

     
        private void AtualizarListaYoutuber()
        {
            CadastroPessoal cadastropessoal = new CadastroPessoal();
            int Codigo = cadastropessoal.GetCodigo();
            string Login = cadastropessoal.GetLogin();
            string Senha = cadastropessoal.GetSenha();
            string Senha2 = cadastropessoal.GetSenha2();
            string Name = cadastropessoal.GetNome();
            string Sobrenome = cadastropessoal.GetSobrenome();
            string NickName = cadastropessoal.GetNickName();
            string Nacionalidade = cadastropessoal.GetNacionalidade();
            int Idade = cadastropessoal.GetIdade();
            double RendaMensal = cadastropessoal.GetRendaMensal();
            string NomeDoCanal = cadastropessoal.GetNomeDoCanal();
            string Categoria = cadastropessoal.GetCategoria();
            long QuantidadesDeInscritos = cadastropessoal.GetQuantidadesDeInscritos();
            long QuantidadeDeVisualizacoes = cadastropessoal.GetQuantidadeDeVisualizacoes();
            long QuantidadeMediaDeLikesPorVideo = cadastropessoal.GetQuantidadeMediaDeLikesPorVideo();
            long QuantidadeVideos = cadastropessoal.GetQuantidadeVideos();
            string PossueLive = cadastropessoal.GetPossueLive();
            string CanalMonetizado = cadastropessoal.GetCanalMonetizado();
            string PossuePatrocinador = cadastropessoal.GetPossuePatrocinador();
            int QuantidadeStricker = cadastropessoal.GetQuantidadeStricker();
            string Link = cadastropessoal.GetLink();
            string Descricao = cadastropessoal.GetDescricao();
           
        }
        private void txtNome_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtNickName_TextChanged(object sender, EventArgs e)
        {

        }

        private void ListaYoutuber_Load(object sender, EventArgs e)
        {
          
        }

        private void button2_Click(object sender, EventArgs e)
        {
            new ListaYoutuber().ShowDialog();
        }

        private void txtLogin_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            CadastrarYoutuber();
        }

        private void CadastrarYoutuber()
        {

            if (txtSenha2.Text != txtSenha.Text)
            {
                MessageBox.Show("Senhas não se coicidem !!");
                txtSenha.Focus();
                return;
            }


            CadastroPessoal cadastropessoal = new CadastroPessoal();


            string SimCanalMonetizado;
            string SimPossueLive;
            string SimPossuePatrocinador;
            try
            {
                if (rbSimCanalMonetizado.Checked == true)
                {
                    SimCanalMonetizado = "Sim";
                }
                else
                {
                    SimCanalMonetizado = "Não";
                }

                if (rbNaoPossueLive.Checked == true)
                {
                    SimPossueLive = "Sim";
                }
                else
                {
                    SimPossueLive = "Não";
                }

                if (rbSimPossuePatrocinador.Checked == true)
                {
                    SimPossuePatrocinador = "Sim";
                }
                else
                {
                    SimPossuePatrocinador = "Não";
                }
                cadastropessoal.SetLogin(txtLogin.Text);
                cadastropessoal.SetSenha(txtSenha.Text);
                cadastropessoal.SetSenha2(txtSenha2.Text);
                cadastropessoal.SetNome(txtNome.Text);
                cadastropessoal.SetSobrenome(txtSobrenome.Text);
                cadastropessoal.SetNickName(txtNickName.Text);
                cadastropessoal.SetNacionalidade(cbNacionalidade.SelectedItem.ToString());
                cadastropessoal.SetIdade(Convert.ToInt32(nudIdade.Value.ToString()));
                cadastropessoal.SetNomeDoCanal(txtNomeCanal.Text);
                cadastropessoal.SetCategoria(cbCategoria.SelectedItem.ToString());
               

                try
                {
                    cadastropessoal.SetRendaMensal(Convert.ToDouble(txtRenda.Text));
                    cadastropessoal.SetQuantidadeDeInscritos(Convert.ToInt32(txtQuantidadeInscritos.Text));
                    cadastropessoal.SetQuantidadeDeVisualizacoes(Convert.ToInt32(txtQuantidadeVisualizacoes.Text));
                    cadastropessoal.SetQuantidadeMediaDeLikesPorVideo(Convert.ToInt32(txtQuantidadeMediaLikes.Text));
                    cadastropessoal.SetQuantidadeVideos(Convert.ToInt32(txtQuantidadeVideos.Text));
                }
                catch (Exception)
                {
                    MessageBox.Show("Insira apenas numeros com virgula, Sem ponto !!");
                    return;
                }



                cadastropessoal.SetPossueLive(Convert.ToString(SimPossueLive));
                cadastropessoal.SetCanalMonetizado(Convert.ToString(SimCanalMonetizado));
                cadastropessoal.SetPossuePatrocinador(Convert.ToString(SimPossuePatrocinador));
                cadastropessoal.SetQuantidadeStricker(Convert.ToInt32(txtQuantidadeDeStrinker.Text));
                cadastropessoal.SetLink(txtLink.Text);
                cadastropessoal.SetDescricao(txtDescricao.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }


            CadastroPessoalRepositorio tudo = new CadastroPessoalRepositorio();

            if (posicao == -1)
            {
                tudo.AdicionarCadastroPessoal(cadastropessoal);
                MessageBox.Show("Personagem cadastarado com sucesso");
            }
            else
            {
                tudo.EditarCadastroPessoal(cadastropessoal, posicao);
                MessageBox.Show("Personagem alterado com sucesso !!");
            }

          
        }

        private void txtNickName_TextChanged_1(object sender, EventArgs e)
        {


        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void cbPlataformaJogo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            Dispose();
        }

        private void cbCategoria_SelectedIndexChanged(object sender, EventArgs e)
        {            
            
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

       
    }
}
