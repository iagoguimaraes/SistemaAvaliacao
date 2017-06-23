using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace Dal.Factory
{
    public class AlternativaFactory : IFactory<Alternativa>
    {
        public List<Alternativa> Make(DataTable dt)
        {
            List<Alternativa> alternativas = new List<Alternativa>();

            List<DataTable> _alternativas = dt.AsEnumerable()
                                                     .GroupBy(s => s["alt_idalt"])
                                                     .Select(g => g.CopyToDataTable())
                                                     .ToList();

            foreach (DataTable _alternativa in _alternativas)
            {
                alternativas.Add(MakeOne(_alternativa));
            }

            return alternativas;
        }

        public Alternativa MakeOne(DataTable dt)
        {
            Alternativa alternativa = new Alternativa();

            alternativa.IdAlternativa = (int)dt.Rows[0]["alt_idalt"];
            alternativa.IdQuestao = (int)dt.Rows[0]["alt_idque"];
            alternativa.Descricao = dt.Rows[0]["alt_descr"].ToString();
            alternativa.Valor = (int)dt.Rows[0]["alt_valor"];

            return alternativa;
        }
    }
}
