
namespace Model
{
    public class Resposta : Questao
    {

        #region Campos

        private int idResposta;
        private int idAlternativa;
        private int idAvaliador;

        #endregion

        #region Propriedades

        public int IdResposta
        {
            get
            {
                return idResposta;
            }

            set
            {
                idResposta = value;
            }
        }

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

        #endregion

        #region Construtores

        public Resposta(Questao questao): base(questao)
        {
        }

        #endregion

    }
}
