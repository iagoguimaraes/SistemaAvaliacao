using System.Collections.Generic;

namespace Model
{
    public class Questao
    {

        #region Campos

        private int idQuestao;
        private int idModelo;       
        private Tema temaQuestao;
        private Abrangencia abrangenciaQuestao;
        private Categoria categoriaQuestao;
        private List<Alternativa> alternativas;
        private string descricao;

        #endregion

        #region Construtor

        public Questao()
        {
        }

        #endregion

        #region Propriedades

        public int IdQuestao
        {
            get
            {
                return idQuestao;
            }
            set
            {
                idQuestao = value;
            }
        }
        public int IdModelo
        {
            get
            {
                return idModelo;
            }
            set
            {
                idQuestao = value;
            }
        }
        public Tema TemaQuestao
        {
            get
            {
                return temaQuestao;
            }

            set
            {
                temaQuestao = value;
            }
        }
        public Abrangencia AbrangenciaQuestao
        {
            get
            {
                return abrangenciaQuestao;
            }

            set
            {
                abrangenciaQuestao = value;
            }
        }
        public Categoria CategoriaQuestao
        {
            get
            {
                return categoriaQuestao;
            }

            set
            {
                categoriaQuestao = value;
            }
        }
        public List<Alternativa> Alternativas
        {
            get
            {
                return alternativas;
            }

            set
            {
                alternativas = value;
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
