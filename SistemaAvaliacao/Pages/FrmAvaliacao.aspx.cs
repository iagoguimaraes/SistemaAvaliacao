using Dal.Repository;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;

namespace SistemaAvaliacao.Pages
{
    public partial class FrmAvaliacao : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            PopularAvaliacao(ObterAvaliacao());
        }

        private Avaliacao ObterAvaliacao()
        {
            using(AvaliacaoRepository repositoy = new AvaliacaoRepository())
            {
                return repositoy.Get(1);
            }
        }

        private void PopularAvaliacao(Avaliacao avaliacao)
        {
            foreach (Questao questao in avaliacao.Questoes)
            {

                HtmlGenericControl html_questao = new HtmlGenericControl("div");
                html_questao.Attributes["id"] = questao.IdQuestao.ToString();
                html_questao.InnerText = questao.Descricao;

                foreach (Alternativa alternativa in questao.Alternativas)
                {
                    HtmlGenericControl html_alternativa = new HtmlGenericControl("input");
                    html_alternativa.Attributes["type"] = "radio";
                    html_alternativa.Attributes["name"] = alternativa.IdQuestao.ToString();
                    html_alternativa.Attributes["id"] = alternativa.IdQuestao.ToString();
                    html_alternativa.InnerText = alternativa.Descricao;
                    html_questao.Controls.Add(html_alternativa);
                }

                form_avaliacao.Controls.Add(html_questao);
            }
        }

    }
}