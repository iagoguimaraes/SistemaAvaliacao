using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dal.Repository
{
    public class AvaliadorRepository: IRepository<Avaliador>, IDisposable
    {

        #region Métodos

        public Avaliador Get(int id)
        {
            throw new NotImplementedException();
        }

        public List<Avaliador> GetAll()
        {
            throw new NotImplementedException();
        }

        public Avaliador Insert(Avaliador entity)
        {
            using (SqlHelper sql = new SqlHelper())
            {
                Dictionary<string, string> parameter = new Dictionary<string, string>();
                parameter.Add("ipusr", entity.Ip);
                parameter.Add("dtini", entity.Dtini.ToString("yyyy-MM-dd HH:mm:ss"));
                parameter.Add("dtfim", entity.Dtfim.ToString("yyyy-MM-dd HH:mm:ss"));
                parameter.Add("idava", entity.IdAvaliacao.ToString());
                entity.IdAvaliador = Convert.ToInt32(sql.ExecuteProcedureScalar("sp_ins_avaliador", parameter));
                return entity;
            }
        }

        public void Update(Avaliador entity)
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
     
        ~AvaliadorRepository()
        {
            Dispose(false);
        }

        #endregion

    }
}
