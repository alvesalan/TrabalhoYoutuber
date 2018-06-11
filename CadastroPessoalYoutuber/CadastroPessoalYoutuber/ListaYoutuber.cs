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
    public partial class ListaYoutuber : Form
    {
        int posicao = -1;
        public static string NOME_ARQUIVO = "Personagens.bin";
        public ListaYoutuber()
        {
            InitializeComponent();
        }

     
        private void AtualizarListaYoutuber()
        {
            CadastroPessoal cadastropessoal = new CadastroPessoal();
            string Name = cadastropessoal.GetNome();
            string Sobrenome = cadastropessoal.GetSobrenome();
            string NickName = cadastropessoal.GetNickName();          
           
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
            new ListaCadastrosPessoais().ShowDialog();
        }

        private void txtLogin_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (txtSenha2.Text != txtSenha.Text)
            {
                MessageBox.Show("Senhas não se coicidem !!");
                return;
            }


            CadastroPessoal cadastropessoal = new CadastroPessoal();
            
            try
            {

                cadastropessoal.SetLogin(txtLogin.Text);
                cadastropessoal.SetSenha(txtSenha.Text);
                cadastropessoal.SetSenha2(txtSenha2.Text);
                cadastropessoal.SetNome(txtNome.Text);
                cadastropessoal.SetSobrenome(txtSobrenome.Text);
                cadastropessoal.SetNickName(txtNickName.Text);
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

            AtualizarListaYoutuber();
        }
    }
}
