using Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dal.Factory
{
    public class AvaliacaoFactory : IFactory<Avaliacao>
    {
        public List<Avaliacao> Make(DataTable dt)
        {
            List<Avaliacao> avaliacoes = new List<Avaliacao>();

            List<DataTable> _avaliacoes = dt.AsEnumerable()
                                                     .GroupBy(s => s["ava_idava"])
                                                     .Select(g => g.CopyToDataTable())
                                                     .ToList();

            foreach (DataTable _avaliacao in _avaliacoes)
            {
                avaliacoes.Add(MakeOne(_avaliacao));
            }

            return avaliacoes;
        }

        public Avaliacao MakeOne(DataTable dt)
        {
            ModeloFactory modeloFactory = new ModeloFactory();
            Modelo modelo = modeloFactory.MakeOne(dt);

            Avaliacao avaliacao = new Avaliacao(modelo);

            avaliacao.IdAvaliacao = (int)dt.Rows[0]["ava_idava"];
            avaliacao.Descricao = dt.Rows[0]["ava_descr"].ToString();
            avaliacao.Ativo = Convert.ToBoolean(dt.Rows[0]["ava_ativo"]);
            avaliacao.DataCadastro = (DateTime)dt.Rows[0]["ava_dtcad"];

            if (!string.IsNullOrEmpty(dt.Rows[0]["ava_dtdel"].ToString()))
                avaliacao.DataExclusao = (DateTime)dt.Rows[0]["ava_dtdel"];

            AvaliadoFactory avaliadoFactory = new AvaliadoFactory();
            avaliacao.Avaliado = avaliadoFactory.MakeOne(dt);

            return avaliacao;
        }
    }
}
