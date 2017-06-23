
using System.Collections.Generic;

namespace Model
{
    public class Avaliador
    {
        private int idAvaliador;
        private string ip;
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

        public Avaliador()
        {

        }
    }
}
