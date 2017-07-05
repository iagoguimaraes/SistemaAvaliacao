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
        #region Eventos

        protected void Page_Load(object sender, EventArgs e)
        {
            Avaliacao avaliacao = ObterAvaliacao();
            PopularAvaliacao(avaliacao);
        }

        protected void bt_finalizar_Click(object sender, EventArgs e)
        {

        }

        #endregion

        #region Métodos
        private Avaliacao ObterAvaliacao()
        {
            using (AvaliacaoRepository repositoy = new AvaliacaoRepository())
            {
                return repositoy.Get(1);
            }
        }
        private void PopularAvaliacao(Avaliacao avaliacao)
        {
            lb_titulo.Text = avaliacao.Nome + " - " + avaliacao.Avaliado.Nome;

            foreach (Questao questao in avaliacao.Questoes)
            {
                HtmlGenericControl html_questao = new HtmlGenericControl("div");
                html_questao.Attributes["class"] = "questao";
                html_questao.Attributes["id"] = questao.IdQuestao.ToString();
                html_questao.InnerText = questao.Descricao;

                foreach (Alternativa alternativa in questao.Alternativas)
                {
                    HtmlGenericControl html_alternativa = new HtmlGenericControl("div");
                    html_alternativa.Attributes["class"] = "alternativa";

                    HtmlGenericControl html_radio = new HtmlGenericControl("input");
                    html_radio.Attributes["type"] = "radio";
                    html_radio.Attributes["name"] = alternativa.IdQuestao.ToString();
                    html_radio.Attributes["id"] = alternativa.IdAlternativa.ToString();

                    HtmlGenericControl html_descricao = new HtmlGenericControl("label");
                    html_descricao.InnerText = alternativa.Descricao;
                    html_descricao.Attributes["for"] = alternativa.IdAlternativa.ToString();

                    html_alternativa.Controls.Add(html_radio);
                    html_alternativa.Controls.Add(html_descricao);
                    html_questao.Controls.Add(html_alternativa);
                }

                form_avaliacao.Controls.AddAt(form_avaliacao.Controls.Count-2, html_questao);
            }
        }

        #endregion

    }
}