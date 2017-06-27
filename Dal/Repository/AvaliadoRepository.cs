using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Linq.Expressions;
using Dal.Factory;

namespace Dal.Repository
{
    public class AvaliadoRepository : IRepository<Avaliado>, IDisposable
    {
        #region Campos

        private AvaliadoFactory factory;

        #endregion

        #region Construtor

        public AvaliadoRepository()
        {
            factory = new AvaliadoFactory();
        }

        #endregion

        #region Métodos

        public void Delete(int id)
        {
            using (SqlHelper sql = new SqlHelper())
            {
                Dictionary<string, string> parameter = new Dictionary<string, string>();
                parameter.Add("idavo", id.ToString());
                sql.ExecuteNonProcedure("sp_del_avaliado",parameter);
            }
        }

        public Avaliado Get(int id)
        {
            using (SqlHelper sql = new SqlHelper())
            {
                Dictionary<string, string> parameter = new Dictionary<string, string>();
                parameter.Add("idavo", id.ToString());
                return sql.ExecuteProcedureObject(factory, "sp_sel_avaliado", parameter).First();
            }
        }

        public List<Avaliado> GetAll()
        {
            using (SqlHelper sql = new SqlHelper())
            {
                return sql.ExecuteProcedureObject(factory, "sp_sel_avaliados");
            }
        }

        public Avaliado Insert(Avaliado entity)
        {
            using (SqlHelper sql = new SqlHelper())
            {
                Dictionary<string, string> parameter = new Dictionary<string, string>();
                parameter.Add("nmavo", entity.Nome);
                entity.IdAvaliado = Convert.ToInt32(sql.ExecuteProcedureScalar("sp_ins_avaliado",parameter));
                return entity;
            }
        }

        public void Update(Avaliado entity)
        {
            using (SqlHelper sql = new SqlHelper())
            {
                Dictionary<string, string> parameter = new Dictionary<string, string>();
                parameter.Add("idavo", entity.IdAvaliado.ToString());
                parameter.Add("nmavo", entity.Nome);
                sql.ExecuteNonProcedure("sp_upd_avaliado", parameter);
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

        ~AvaliadoRepository()
        {
            Dispose(false);
        }

        #endregion
    }
}
