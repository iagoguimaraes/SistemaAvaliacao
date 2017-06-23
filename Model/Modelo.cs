using System.Collections.Generic;

namespace Model
{
    public class Modelo
    {

        #region Campos 

        private int idModelo;
        private string nome;
        private List<Questao> questoes;

        #endregion

        #region Construtor

        public Modelo()
        {

        }

        public Modelo(Modelo modelo)
        {
            this.idModelo = modelo.IdModelo;
            this.nome = modelo.Nome;
            this.questoes = modelo.Questoes;
        }

        #endregion

        #region Propriedades

        public int IdModelo
        {
            get
            {
                return idModelo;
            }
            set
            {
                idModelo = value;
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

        public List<Questao> Questoes
        {
            get
            {
                return questoes;
            }

            set
            {
                questoes = value;
            }
        }

        #endregion

    }
}
