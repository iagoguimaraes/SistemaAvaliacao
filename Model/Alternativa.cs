
namespace Model
{
    public class Alternativa
    {

        #region Campos

        private int idAlternativa;
        private int idQuestao;
        private string descricao;
        private int valor;

        #endregion

        #region Construtor

        public Alternativa()
        {

        }

        #endregion

        #region Propriedades

        public int IdAlternativa
        {
            get
            {
                return idAlternativa;
            }
            set
            {
                idAlternativa = value;
            }
        }

        public int IdQuestao
        {
            get
            {
                return idQuestao;
            }
            set
            {
                idAlternativa = value;
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
        public int Valor
        {
            get
            {
                return valor;
            }

            set
            {
                valor = value;
            }
        }

        #endregion

    }
}
