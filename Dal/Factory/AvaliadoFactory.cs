using Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace Dal.Factory
{
    public class AvaliadoFactory : IFactory<Avaliado>
    {
        public List<Avaliado> Make(DataTable dt)
        {
            List<Avaliado> avaliados = new List<Avaliado>();

            List<DataTable> _avaliados = dt.AsEnumerable()
                                                     .GroupBy(s => s["avo_idavo"])
                                                     .Select(g => g.CopyToDataTable())
                                                     .ToList();

            foreach (DataTable _avaliado in _avaliados)
            {
                avaliados.Add(MakeOne(_avaliado));
            }

            return avaliados;
        }

        public Avaliado MakeOne(DataTable dt)
        {
            Avaliado avaliado = new Avaliado();

            avaliado.IdAvaliado = (int)dt.Rows[0]["avo_idavo"];
            avaliado.Nome = dt.Rows[0]["avo_nmavo"].ToString();
            avaliado.Ativo = Convert.ToBoolean(dt.Rows[0]["avo_ativo"]);
            avaliado.DataCadastro = (DateTime)dt.Rows[0]["avo_dtcad"];

            if (!string.IsNullOrEmpty(dt.Rows[0]["avo_dtdel"].ToString()))
                avaliado.DataExclusao = (DateTime)dt.Rows[0]["avo_dtdel"];

            return avaliado;
        }
    }
}
