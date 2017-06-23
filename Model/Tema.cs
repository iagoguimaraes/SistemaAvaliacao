
namespace Model
{
    public class Tema
    {

        #region Campos

        private int idTema;
        private string descricao;

        #endregion

        #region Construtor

        public Tema()
        {

        }

        #endregion

        #region Propriedades

        public int IdTema
        {
            get
            {
                return idTema;
            }
            set
            {
                idTema = value;
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
