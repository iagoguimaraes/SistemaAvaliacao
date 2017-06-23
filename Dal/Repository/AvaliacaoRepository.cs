using Dal.Factory;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dal.Repository
{
    public class AvaliacaoRepository : IRepository<Avaliacao>, IDisposable
    {
        #region Campos

        AvaliacaoFactory factory;

        #endregion

        #region Construtor

        public AvaliacaoRepository()
        {
            factory = new AvaliacaoFactory();
        }

        #endregion

        #region Métodos

        public void Delete(int id)
        {
            using (SqlHelper sql = new SqlHelper())
            {
                Dictionary<string, string> parameter = new Dictionary<string, string>();
                parameter.Add("idava", id.ToString());
                sql.ExecuteNonProcedure("sp_del_avaliacao", parameter);
            }
        }

        public Avaliacao Get(int id)
        {
            using (SqlHelper sql = new SqlHelper())
            {
                Dictionary<string, string> parameter = new Dictionary<string, string>();
                parameter.Add("idava", id.ToString());
                return sql.ExecuteProcedureObject(factory, "sp_sel_avaliacao", parameter).First();
            }
        }

        public List<Avaliacao> GetAll()
        {
            using (SqlHelper sql = new SqlHelper())
            {
                return sql.ExecuteProcedureObject(factory, "sp_sel_avaliacoes");
            }
        }

        public void Insert(Avaliacao entity)
        {
            using (SqlHelper sql = new SqlHelper())
            {
                Dictionary<string, string> parameter = new Dictionary<string, string>();
                parameter.Add("idmod", entity.IdModelo.ToString());
                parameter.Add("idavo", entity.Avaliado.IdAvaliado.ToString());
                parameter.Add("descr", entity.Descricao);
                sql.ExecuteNonProcedure("sp_ins_avaliacao", parameter);
            }
        }

        public void Update(Avaliacao entity)
        {
            using (SqlHelper sql = new SqlHelper())
            {
                Dictionary<string, string> parameter = new Dictionary<string, string>();
                parameter.Add("idava", entity.IdAvaliacao.ToString());
                parameter.Add("descr", entity.Descricao);
                sql.ExecuteNonProcedure("sp_upd_avaliacao", parameter);
            }
        }

        #endregion

        #region Dispose

        // Flag: Has Dispose already been called?
        bool disposed = false;

        // Public implementation of Dispose pattern callable by consumers.
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        // Protected implementation of Dispose pattern.
        protected virtual void Dispose(bool disposing)
        {
            if (disposed)
                return;

            if (disposing)
            {
                // Free any other managed objects here.
                factory = null;
            }

            // Free any unmanaged objects here.
            //
            disposed = true;
        }

        ~AvaliacaoRepository()
        {
            Dispose(false);
        }

        #endregion

    }
}
