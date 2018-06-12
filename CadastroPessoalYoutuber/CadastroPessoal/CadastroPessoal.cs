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
        private string PossueLive;
        private string CanalMonetizado;
        private string PossuePatrocinador;
        private int QuantidadeStricker;
        private string Link;
        private string Descricao;



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
            if (senha.Count() < 8)
            {
                throw new Exception("Senha deve possuir mais de 8 caracter !!");
            }
            if (senha.Count()> 30)
            {
                throw new Exception("Senha dev possuir no maximo 30 caracter !!");
            }
            
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
        public void SetNacionalidade(string nacionalidade)
        {
            this.Nacionalidade = nacionalidade;
        }
        public void SetIdade(int idade)
        {
            this.Idade = idade;
        }
        public void SetRendaMensal(double rendamensal)
        {
            this.RendaMensal = rendamensal;
        }
        public void SetNomeDoCanal(string nomedocanal)
        {
            this.NomeDoCanal = nomedocanal;
        }
        public void SetCategoria(string categoria)
        {
            this.Categoria = categoria;
        }
        public void SetPlataformaJogo(string plataformajogo)
        {
            this.PlataformaJogo = plataformajogo;
        }
        public void SetQuantidadeDeInscritos(int quantidadedeinscritos)
        {
            this.QuantidadesDeInscritos = quantidadedeinscritos;          
        }
        public void SetQuantidadeDeVisualizacoes(int quantidadedevisualizacoes)
        {
            this.QuantidadeDeVisualizacoes = quantidadedevisualizacoes;
        }
        public void SetQuantidadeMediaDeLikesPorVideo(int quantidademediadelikesporvideo)
        {
            this.QuantidadeMediaDeLikesPorVideo = quantidademediadelikesporvideo;
        }
        public void SetQuantidadeVideos(int quantidadedevideos)
        {
            this.QuantidadeVideos = quantidadedevideos;
        }
        public void SetPossueLive(string possuelive)
        {
            this.PossueLive = possuelive;
        }
        public void SetCanalMonetizado(string canalmonetizado)
        {
            this.CanalMonetizado = canalmonetizado;
        }
        public void SetPossuePatrocinador(string possuepatricinador)
        {
            this.PossuePatrocinador = possuepatricinador;
        }
        public void SetQuantidadeStricker(int quantidadestricker)
        {
            this.QuantidadeStricker = quantidadestricker;
        }
        public void SetLink(string link)
        {
            this.Link = link;
        }
        public void SetDescricao(string descricao)
        {
            this.Descricao = descricao;
        }



        public string GetLogin() { return Login; }
        public string GetSenha() { return Senha; }
        public string GetSenha2() { return Senha2; }
        public string GetNome() { return Nome; }
        public string GetSobrenome() { return Sobrenome; }
        public string GetNickName() { return NickName; }
        public string GetNacionalidade(){return Nacionalidade;}
        public int GetIdade() { return Idade; }
        public double GetRendaMensal() { return RendaMensal;}
        public string GetNomeDoCanal() {return NomeDoCanal ;}
        public string GetCategoria() { return Categoria;}
        public string GetPlataformaJogo() {return PlataformaJogo ;}
        public int GetQuantidadesDeInscritos() {return QuantidadesDeInscritos; }
        public int GetQuantidadeDeVisualizacoes() {return QuantidadeDeVisualizacoes ;}
        public int GetQuantidadeMediaDeLikesPorVideo() {return QuantidadeMediaDeLikesPorVideo ;}
        public int GetQuantidadeVideos() {return QuantidadeVideos ;}
        public string GetPossueLive() { return PossueLive; }
        public string GetCanalMonetizado() { return CanalMonetizado; }
        public string GetPossuePatrocinador() { return PossuePatrocinador; }
        public int GetQuantidadeStricker() { return QuantidadeStricker; }
        public string GetLink() { return Link; }
        public string GetDescricao() { return Descricao; }




                 
    }
}
