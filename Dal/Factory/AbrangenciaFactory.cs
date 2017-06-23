using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace Dal.Factory
{
    public class AbrangenciaFactory : IFactory<Abrangencia>
    {
        public List<Abrangencia> Make(DataTable dt)
        {
            List<Abrangencia> abrangencias = new List<Abrangencia>();

            List<DataTable> _abrangencias = dt.AsEnumerable()
                                                     .GroupBy(s => s["abr_idabr"])
                                                     .Select(g => g.CopyToDataTable())
                                                     .ToList();

            foreach (DataTable _abrangencia in _abrangencias)
            {
                abrangencias.Add(MakeOne(_abrangencia));
            }

            return abrangencias;
        }

        public Abrangencia MakeOne(DataTable dt)
        {
            Abrangencia abrangencia = new Abrangencia();

            abrangencia.IdAbrangencia = (int)dt.Rows[0]["abr_idabr"];
            abrangencia.Descricao = dt.Rows[0]["abr_descr"].ToString();

            return abrangencia;
        }
    }
}
