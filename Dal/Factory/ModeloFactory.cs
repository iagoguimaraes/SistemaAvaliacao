using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;

namespace Dal.Factory
{
    public class ModeloFactory : IFactory<Modelo>
    {
        public List<Modelo> Make(DataTable dt)
        {
            List<Modelo> modelos = new List<Modelo>();

            List<DataTable> _modelos = dt.AsEnumerable()
                                                     .GroupBy(s => s["mod_idmod"])
                                                     .Select(g => g.CopyToDataTable())
                                                     .ToList();

            foreach (DataTable _modelo in _modelos)
            {
                modelos.Add(MakeOne(_modelo));
            }

            return modelos;
        }

        public Modelo MakeOne(DataTable dt)
        {
            Modelo modelo = new Modelo();
       
            modelo.IdModelo = (int)dt.Rows[0]["mod_idmod"];
            modelo.Nome = dt.Rows[0]["mod_descr"].ToString();

            QuestaoFactory questaoFactory = new QuestaoFactory();
            modelo.Questoes = questaoFactory.Make(dt);

            return modelo;
        }
    }
}
