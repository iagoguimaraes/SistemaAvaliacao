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
                Avaliacao avaliacao;
                using (AvaliacaoRepository repository = new AvaliacaoRepository())
                {
                    avaliacao = repository.Get(1);
                }

                Avaliador avaliador = new Avaliador(avaliacao.IdAvaliacao);
                avaliador.Ip = GetIPAddress();
                avaliador.Dtini = DateTime.Now;
                avaliador.Dtfim = DateTime.Now;

                using(AvaliadorRepository repository = new AvaliadorRepository())
                {
                    avaliador = repository.Insert(avaliador);
                }

                foreach (Questao questao in avaliacao.Questoes)
                {
                    Resposta resposta = new Resposta(questao);
                    resposta.IdAvaliador = avaliador.IdAvaliador;
                    resposta.IdAlternativa = questao.Alternativas[0].IdAlternativa;
                    avaliador.Respostas.Add(resposta);
                }

                using (RespostaRepository repository = new RespostaRepository())
                {
                    foreach (Resposta r in avaliador.Respostas)
                    {
                        repository.Insert(r);
                    }
                }

                int x = 0;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }

        protected string GetIPAddress()
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



    }
}