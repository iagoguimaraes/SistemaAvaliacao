
namespace Model
{
    public class Resposta : Questao
    {
        private int idResposta;
        private Alternativa alternativaEscolhida;

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

        public Alternativa AlternativaEscolhida
        {
            get
            {
                return alternativaEscolhida;
            }

            set
            {
                alternativaEscolhida = value;
            }
        }

        public Resposta()
        {

        }
    }
}
