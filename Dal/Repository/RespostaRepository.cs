using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dal.Repository
{
    public class RespostaRepository: IRepository<Resposta>, IDisposable
    {
        #region Métodos

        public Resposta Get(int id)
        {
            throw new NotImplementedException();
        }

        public List<Resposta> GetAll()
        {
            throw new NotImplementedException();
        }

        public Resposta Insert(Resposta entity)
        {
            using (SqlHelper sql = new SqlHelper())
            {
                Dictionary<string, string> parameter = new Dictionary<string, string>();
                parameter.Add("idque", entity.IdQuestao.ToString());
                parameter.Add("idalt", entity.IdAlternativa.ToString());
                parameter.Add("idavr", entity.IdAvaliador.ToString());
                entity.IdResposta = Convert.ToInt32(sql.ExecuteProcedureScalar("sp_ins_resposta", parameter));
                return entity;
            }
        }

        public void Update(Resposta entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
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
                //factory = null;
            }

            // Free any unmanaged objects here.
            //
            disposed = true;
        }

        ~RespostaRepository()
        {
            Dispose(false);
        }

        #endregion
    }
}
