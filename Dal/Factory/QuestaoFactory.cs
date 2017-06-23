using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace Dal.Factory
{
    public class QuestaoFactory : IFactory<Questao>
    {
        public List<Questao> Make(DataTable dt)
        {
            List<Questao> questoes = new List<Questao>();

            List<DataTable> _questoes = dt.AsEnumerable()
                                                     .GroupBy(s => s["que_idque"])
                                                     .Select(g => g.CopyToDataTable())
                                                     .ToList();

            foreach (DataTable _questao in _questoes)
            {
                questoes.Add(MakeOne(_questao));
            }

            return questoes;
        }

        public Questao MakeOne(DataTable dt)
        {
            Questao questao = new Questao();
           
            questao.IdQuestao = (int)dt.Rows[0]["que_idque"];
            questao.IdModelo = (int)dt.Rows[0]["que_idmod"];
            questao.Descricao = dt.Rows[0]["que_descr"].ToString();

            AbrangenciaFactory abrangenciaFactory = new AbrangenciaFactory();
            questao.AbrangenciaQuestao = abrangenciaFactory.MakeOne(dt);

            CategoriaFactory categoriaFactory = new CategoriaFactory();
            questao.CategoriaQuestao = categoriaFactory.MakeOne(dt);

            TemaFactory temaFactory = new TemaFactory();
            questao.TemaQuestao = temaFactory.MakeOne(dt);

            AlternativaFactory alternativaFactory = new AlternativaFactory();
            questao.Alternativas = alternativaFactory.Make(dt);

            return questao;
        }
    }
}
