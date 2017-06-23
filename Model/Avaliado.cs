
using System;

namespace Model
{
    public class Avaliado
    {

        #region Campos

        private int idAvaliado;
        private string nome;
        private bool ativo;
        private DateTime dataCadastro;
        private DateTime dataExclusao;

        #endregion

        #region Construtor

        public Avaliado()
        {

        }

        #endregion

        #region Propriedades

        public int IdAvaliado
        {
            get
            {
                return idAvaliado;
            }
            set
            {
                idAvaliado = value;
            }
        }

        public string Nome
        {
            get
            {
                return nome;
            }
            set
            {
                nome = value;
            }
        }

        public bool Ativo
        {
            get
            {
                return ativo;
            }

            set
            {
                ativo = value;
            }
        }

        public DateTime DataCadastro
        {
            get
            {
                return dataCadastro;
            }
            set
            {
                dataCadastro = value;
            }
        }

        public DateTime DataExclusao
        {
            get
            {
                return dataExclusao;
            }
            set
            {
                dataExclusao = value;
            }
        }

        #endregion

    }
}
