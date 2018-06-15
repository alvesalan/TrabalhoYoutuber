using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace CadastroPessoalYoutuber
{
    [Serializable]
    class CadastroPessoalRepositorio
    {

        List<CadastroPessoal> cadastroPessoals = new List<CadastroPessoal>();

        public CadastroPessoalRepositorio()
        {
            if (File.Exists(CadastroYoutuber.NOME_ARQUIVO))
            {
                BinaryFormatter binaryReader = new BinaryFormatter();
                Stream stream = File.OpenRead(CadastroYoutuber.NOME_ARQUIVO);
                cadastroPessoals = ((CadastroPessoalRepositorio)binaryReader.Deserialize(stream)).ObterPersonagens();
                stream.Close();
            }
        }

       
        public List<CadastroPessoal> ObterPersonagens()
        {
            return cadastroPessoals;
        }

        private void EscreverNoArquivoDosCadastrosPessoals()
        {
            BinaryFormatter binaryWritter = new BinaryFormatter();
            Stream stream = new FileStream(CadastroYoutuber.NOME_ARQUIVO, FileMode.Create, FileAccess.Write);
            binaryWritter.Serialize(stream, this);
            stream.Close();
        }
        internal void ApagarCadastroPessoal(string nome)
        {
            foreach (CadastroPessoal cadastropessoal in cadastroPessoals)
            {
                if (cadastropessoal.GetNome() == nome)
                {
                    cadastroPessoals.Remove(cadastropessoal);
                    EscreverNoArquivoDosCadastrosPessoals();
                    return;
                }
            }
        }



        public void AdicionarCadastroPessoal(CadastroPessoal cadastropessoal)
        {
            cadastroPessoals.Add(cadastropessoal);
            EscreverNoArquivoDosCadastroPessoal();
        }


        private void EscreverNoArquivoDosCadastroPessoal()
        {
            BinaryFormatter binaryWritter = new BinaryFormatter();
            Stream stream = new FileStream(CadastroYoutuber.NOME_ARQUIVO, FileMode.Create, FileAccess.Write);
            binaryWritter.Serialize(stream, this);
            stream.Close();
        }

        internal void EditarCadastroPessoal(CadastroPessoal cadastropessoal,  int codigo)
        {
            cadastroPessoals[codigo] = cadastropessoal;
            EscreverNoArquivoDosCadastroPessoal();
        }
    }
}
