using Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dal.Factory
{
    public class CategoriaFactory:IFactory<Categoria>
    {
        public List<Categoria> Make(DataTable dt)
        {
            List<Categoria> categorias = new List<Categoria>();

            List<DataTable> _categorias = dt.AsEnumerable()
                                                     .GroupBy(s => s["cat_idcat"])
                                                     .Select(g => g.CopyToDataTable())
                                                     .ToList();

            foreach (DataTable _categoria in _categorias)
            {
                categorias.Add(MakeOne(_categoria));
            }

            return categorias;
        }

        public Categoria MakeOne(DataTable dt)
        {
            Categoria categoria = new Categoria();

            categoria.IdCategoria = (int)dt.Rows[0]["cat_idcat"];
            categoria.Descricao = dt.Rows[0]["cat_descr"].ToString();

            return categoria;
        }
    }
}
