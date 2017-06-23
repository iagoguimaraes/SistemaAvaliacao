using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace Dal.Factory
{
    public class TemaFactory : IFactory<Tema>
    {
        public List<Tema> Make(DataTable dt)
        {
            List<Tema> temas = new List<Tema>();

            List<DataTable> _temas = dt.AsEnumerable()
                                                     .GroupBy(s => s["tem_idtem"])
                                                     .Select(g => g.CopyToDataTable())
                                                     .ToList();

            foreach (DataTable _tema in _temas)
            {
                temas.Add(MakeOne(_tema));
            }

            return temas;
        }

        public Tema MakeOne(DataTable dt)
        {
            Tema tema = new Tema();

            tema.IdTema = (int)dt.Rows[0]["tem_idtem"];
            tema.Descricao = dt.Rows[0]["tem_descr"].ToString();

            return tema;
        }
    }
}
