using Dal.Repository;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
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
            try
            {
                Avaliacao avaliacao = ObterAvaliacao();
                PopularAvaliacao(avaliacao);
                Session["Avaliador"] = InicializarAvaliador(avaliacao);
            }
            catch (Exception)
            {
                throw;
            }
        }

        protected void bt_finalizar_Click(object sender, EventArgs e)
        {
            try
            {
                Avaliador avaliador = ResgatarAvaliador();
                int x = 0;
            }
            catch (Exception)
            {
                throw;
            }
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
                html_questao.InnerText = questao.Descricao;

                RadioButtonList radio_alternativas = new RadioButtonList();
                radio_alternativas.ID = "questao_" + questao.IdQuestao;
                radio_alternativas.Attributes["class"] = "alternativas";
                

                foreach (Alternativa alternativa in questao.Alternativas)
                {
                    radio_alternativas.Items.Add(new ListItem(alternativa.Descricao, alternativa.IdAlternativa.ToString()));                   
                }

                html_questao.Controls.Add(radio_alternativas);
                form_avaliacao.Controls.AddAt(form_avaliacao.Controls.Count-2, html_questao);
            }
        }
        private Avaliador InicializarAvaliador(Avaliacao avaliacao)
        {
            Avaliador avaliador = new Avaliador(avaliacao.IdAvaliacao);
            avaliador.Dtini = DateTime.Now;
            avaliador.Ip = string.Concat(GetIPAddress(), "|", GetLocalIPAddress());
            foreach (var q in avaliacao.Questoes)
            {
                avaliador.Respostas.Add(new Resposta(q));
            }
            return avaliador;
        }
        private string GetIPAddress()
        {
            try
            {
                System.Web.HttpContext context = System.Web.HttpContext.Current;
                string ipAddress = context.Request.ServerVariables["HTTP_X_FORWARDED_FOR"];

                if (!string.IsNullOrEmpty(ipAddress))
                {
                    string[] addresses = ipAddress.Split(',');
                    if (addresses.Length != 0)
                    {
                        return addresses[0];
                    }
                }

                return context.Request.ServerVariables["REMOTE_ADDR"];
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

        }
        private string GetLocalIPAddress()
        {
            try
            {
                IPHostEntry host;
                string localIP = "";
                host = Dns.GetHostEntry(Dns.GetHostName());
                foreach (IPAddress ip in host.AddressList)
                {
                    if (ip.AddressFamily == AddressFamily.InterNetwork)
                    {
                        localIP = ip.ToString();
                        break;
                    }
                }
                return localIP;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        private Avaliador ResgatarAvaliador()
        {
            Avaliador avaliador = (Avaliador)Session["Avaliador"];
            avaliador.Dtfim = DateTime.Now;
            foreach (var r in avaliador.Respostas)
            {
                RadioButtonList radio_alternativas = (RadioButtonList)form_avaliacao.FindControl("questao_" + r.IdQuestao);
                r.IdAlternativa = Convert.ToInt32(radio_alternativas.SelectedValue);
            }
            return avaliador;
        }

        #endregion

    }
}