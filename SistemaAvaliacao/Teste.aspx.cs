using Dal.Repository;
using Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SistemaAvaliacao
{
    public partial class Teste : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                List<Avaliacao> avaliacoes;
                using (AvaliacaoRepository repository = new AvaliacaoRepository())
                {
                    avaliacoes = repository.GetAll();
                }

                int x = 0;
                //int y = 1;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }




    }
}