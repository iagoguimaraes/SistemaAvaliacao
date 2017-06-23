
namespace Model
{
    public class Abrangencia
    {

        #region Campos

        private int idAbrangencia;
        private string descricao;

        #endregion

        #region Construtor

        public Abrangencia()
        {

        }

        #endregion

        #region Propriedades

        public int IdAbrangencia
        {
            get
            {
                return idAbrangencia;
            }
            set
            {
                idAbrangencia = value;
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
