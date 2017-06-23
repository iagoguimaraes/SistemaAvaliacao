
using System;
using System.Collections.Generic;

namespace Model
{
    public class Avaliacao: Modelo
    {

        #region Campos

        private int idAvaliacao;
        private Avaliado avaliado;
        private List<Avaliador> avaliadores;
        private bool ativo;
        private DateTime dataCadastro;
        private DateTime dataExclusao;
        private string descricao;

        #endregion

        #region Construtor

        public Avaliacao(Modelo modelo): base(modelo)
        {
        }

        #endregion

        #region Propriedades

        public int IdAvaliacao
        {
            get
            {
                return idAvaliacao;
            }
            set
            {
                idAvaliacao = value;
            }
        }

        public Avaliado Avaliado
        {
            get
            {
                return avaliado;
            }

            set
            {
                avaliado = value;
            }
        }

        public List<Avaliador> Avaliadores
        {
            get
            {
                return avaliadores;
            }

            set
            {
                avaliadores = value;
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

        public string Descricao
        {
            get
            {
                return descricao;
            }

            set
            {
                descricao = value;
            }
        }

        #endregion

    }
}
