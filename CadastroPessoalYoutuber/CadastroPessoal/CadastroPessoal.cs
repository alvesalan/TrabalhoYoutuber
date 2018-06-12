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
        private long QuantidadesDeInscritos;
        private long QuantidadeDeVisualizacoes;
        private long QuantidadeMediaDeLikesPorVideo;
        private long QuantidadeVideos;
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
                throw new Exception("Senha deve possuir no maximo 30 caracter !!");
            }           
            
            this.Senha = senha;
            senha = A;

        }
        public void SetSenha2(string senha2)
        {
            if (senha2.Count() < 8)
            {
                throw new Exception("Senha deve possuir mais de 8 caracter !!");
            }
            if (senha2.Count() > 30)
            {
                throw new Exception("Senha deve possuir no maximo 30 caracter !!");
            }              
            this.Senha2 = senha2;
 
        }

        public void SetNome(string nome)
        {
            if (nome.Count() < 3)
            {
                throw new Exception("Nome deve conter no minimo 3 caracter !!");
            }
            if (nome.Count() > 30)
            {
                throw new Exception("Nome deve conter no maximo 30 caracter !!");
            }
            this.Nome = nome;
        }

        public void SetSobrenome(string sobrenome)
        {

            if (sobrenome.Count() < 3)
            {
                throw new Exception("sobrenome deve conter no minimo 3 caracter !!");
            }
            if (sobrenome.Count() > 30)
            {
                throw new Exception("sobrenome deve conter no maximo 30 caracter !!");
            }         
            this.Sobrenome = sobrenome;
        }

        public void SetNickName(string nickname)
        {
            if (nickname.Count() < 3)
            {
                throw new Exception("nickname deve conter no minimo 3 caracter !!");
            }
            if (nickname.Count() > 30)
            {
                throw new Exception("nickname deve conter no maximo 30 caracter !!");
            }      
            this.NickName = nickname;
        }

        public void SetNacionalidade(string nacionalidade)
        {
            if (nacionalidade.Count() < 3)
            {
                throw new Exception("Selecione uma nacionalidade !!");
            }
           
            this.Nacionalidade = nacionalidade;
        }

        public void SetIdade(int idade)
        {
            if (idade <= 0)
            {
                throw new Exception("Digite saua idade !!");
            }
            this.Idade = idade;
        }
        public void SetRendaMensal(double rendamensal)
        {
            if (rendamensal < 0)
            {
                throw new Exception("Digite sua renda mensal !!");
            }
            this.RendaMensal = rendamensal;
        }
        public void SetNomeDoCanal(string nomedocanal)
        {
            if (nomedocanal.Count() < 3)
            {
                throw new Exception("Nome do canal deve ter no minimo 3 caracter !!");
            }
            if (nomedocanal.Count() > 40)
            {
                throw new Exception("Nome do canal deve ter na maximo 40 caracter !!");
            }
            this.NomeDoCanal = nomedocanal;
        }
        public void SetCategoria(string categoria)
        {
            if (categoria.Count() < 3)
            {
                throw new Exception("Selecione uma categoria !!");
            }
            this.Categoria = categoria;
        }

        public void SetPlataformaJogo(string plataformajogo)
        {
            if (plataformajogo.Count() < 3 )
            {
                throw new Exception("Selecione uma plataforma ");
            }
            this.PlataformaJogo = plataformajogo;
        }
        public void SetQuantidadeDeInscritos(int quantidadedeinscritos)
        {
            if (quantidadedeinscritos <= 0)
            {
                throw new Exception("Digite a quantidade de inscritos !!");
            }
            this.QuantidadesDeInscritos = quantidadedeinscritos;          
        }
        public void SetQuantidadeDeVisualizacoes(int quantidadedevisualizacoes)
        {
            if (quantidadedevisualizacoes <= 0)
            {
                throw new Exception("Digite a quantidade de inscritos !!");
            }
            this.QuantidadeDeVisualizacoes = quantidadedevisualizacoes;
        }
        public void SetQuantidadeMediaDeLikesPorVideo(int quantidademediadelikesporvideo)
        {
            if (quantidademediadelikesporvideo <= 0)
            {
                throw new Exception("Digite a media de likes por video !!");
            }
            this.QuantidadeMediaDeLikesPorVideo = quantidademediadelikesporvideo;
        }
        public void SetQuantidadeVideos(int quantidadedevideos)
        {
            if (quantidadedevideos <= 0)
            {
                throw new Exception("Digite a aquantidades de videos !!");
            }
            this.QuantidadeVideos = quantidadedevideos;

        }
        public void SetPossueLive(string possuelive)
        {
            if (possuelive.Count() < 3)
            {
                throw new Exception("Selecione se você possue live !!");
            }
            this.PossueLive = possuelive;
        }
        public void SetCanalMonetizado(string canalmonetizado)
        {
            if (canalmonetizado.Count() < 3)
            {
                throw new Exception("Selecione se você !!");
            }
            this.CanalMonetizado = canalmonetizado;
        }
        public void SetPossuePatrocinador(string possuepatricinador)
        {
            if (possuepatricinador.Count() < 3)
            {
                throw new Exception("Selecione se o canal possue patrocinador !!");
            }
            this.PossuePatrocinador = possuepatricinador;
        }
        public void SetQuantidadeStricker(int quantidadestricker)
        {
            if (quantidadestricker <= 0)
            {
                throw new Exception("Coloque a quantidade de stricker !!");
            }
            this.QuantidadeStricker = quantidadestricker;

        }
        public void SetLink(string link)
        {
            if (link.Count() < 8)
            {
                throw new Exception("Digite o link do canal !!");
            }
            this.Link = link;
        }
        public void SetDescricao(string descricao)
        {
            if (descricao.Count() < 10)
            {
                throw new Exception("Descrição deve ter no minimo 10 caracteres !!");
            }
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
        public long GetQuantidadesDeInscritos() {return QuantidadesDeInscritos; }
        public long GetQuantidadeDeVisualizacoes() {return QuantidadeDeVisualizacoes ;}
        public long GetQuantidadeMediaDeLikesPorVideo() {return QuantidadeMediaDeLikesPorVideo ;}
        public long GetQuantidadeVideos() {return QuantidadeVideos ;}
        public string GetPossueLive() { return PossueLive; }
        public string GetCanalMonetizado() { return CanalMonetizado; }
        public string GetPossuePatrocinador() { return PossuePatrocinador; }
        public int GetQuantidadeStricker() { return QuantidadeStricker; }
        public string GetLink() { return Link; }
        public string GetDescricao() { return Descricao; }




                 
    }
}
