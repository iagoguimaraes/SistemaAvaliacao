
namespace Model
{
    public class Categoria
    {

        #region Campos

        private int idCategoria;
        private string descricao;

        #endregion

        #region Construtores

        public Categoria()
        {

        }

        #endregion

        #region Propriedades

        public int IdCategoria
        {
            get
            {
                return idCategoria;
            }
            set
            {
                idCategoria = value;
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
