
using System;
using System.Collections.Generic;

namespace Model
{
    public class Avaliador
    {
        private int idAvaliador;
        private string ip;
        private DateTime dtini;
        private DateTime dtfim;
        private int idAvaliacao;
        private List<Resposta> respostas;

        public int IdAvaliador
        {
            get
            {
                return idAvaliador;
            }

            set
            {
                idAvaliador = value;
            }
        }

        public string Ip
        {
            get
            {
                return ip;
            }

            set
            {
                ip = value;
            }
        }

        public DateTime Dtini
        {
            get
            {
                return dtini;
            }

            set
            {
                dtini = value;
            }
        }

        public DateTime Dtfim
        {
            get
            {
                return dtfim;
            }

            set
            {
                dtfim = value;
            }
        }

        public List<Resposta> Respostas
        {
            get
            {
                return respostas;
            }

            set
            {
                respostas = value;
            }
        }

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

        public Avaliador(int idAvaliacao)
        {
            this.idAvaliacao = idAvaliacao;
            this.respostas = new List<Resposta>();
        }
    }
}
