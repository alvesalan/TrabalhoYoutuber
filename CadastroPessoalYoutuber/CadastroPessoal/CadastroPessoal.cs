using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CadastroPessoalYoutuber
{
    [Serializable]
    public class CadastroPessoal
    {
        public string A = "";
        private string Login;
        private string Senha;
        private string Senha2;
        private string Nome;
        private string Sobrenome;
        private string NickName;
        private string Nacionalidade;
        private int Idade;
        private double RendaMensal;
        private string NomeDoCanal;
        private string Categoria;
        private string PlataformaJogo;
        private int QuantidadesDeInscritos;
        private int QuantidadeDeVisualizacoes;
        private int QuantidadeMediaDeLikesPorVideo;
        private int QuantidadeVideos;
        public bool PossueLive;
        public bool CanalMonetizado;
        public bool PossuePatrocinador;
        public int QuantidadeStricker;
        public string Link;
        public string Descricao;






        public void SetLogin(string login)
        {
            if (login.Count() < 6)
            {
                throw new Exception("Login deve ter no minimo 6 caracteres !!");
            }
            if (login.Count() > 20)
            {
                throw new Exception("Login pode ter no maximo 20 caracter !!");
            }
            this.Login = login;
        }
        public void SetSenha(string senha)
        {            
            this.Senha = senha;
            senha = A;
        }
        public void SetSenha2(string senha2)
        {

            this.Senha2 = senha2;
 
        }
        public void SetNome(string nome)
        {
            this.Nome = nome;
        }
        public void SetSobrenome(string sobrenome)
        {
            this.Sobrenome = sobrenome;
        }
        public void SetNickName(string nickname)
        {
            this.NickName = nickname;
        }

        public string GetLogin() { return Login; }
        public string GetSenha() { return Senha; }
        public string GetNome() { return Nome; }
        public string GetSobrenome() { return Sobrenome; }
        public string GetNickName() { return NickName; }

    }
}
