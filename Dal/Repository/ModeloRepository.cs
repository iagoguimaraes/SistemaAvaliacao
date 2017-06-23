using Dal.Factory;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dal.Repository
{
    public class ModeloRepository : IRepository<Modelo>, IDisposable
    {

        #region Campos

        ModeloFactory factory;

        #endregion

        #region Construtor
        public ModeloRepository()
        {
            factory = new ModeloFactory();
        }

        #endregion

        #region Métodos

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Modelo Get(int id)
        {
            using (SqlHelper sql = new SqlHelper())
            {
                Dictionary<string, string> parameter = new Dictionary<string, string>();
                parameter.Add("idmod", id.ToString());
                return sql.ExecuteProcedureObject(factory, "sp_sel_modelo", parameter).First();
            }
        }

        public List<Modelo> GetAll()
        {
            using (SqlHelper sql = new SqlHelper())
            {
                return sql.ExecuteProcedureObject(factory, "sp_sel_modelos");
            }
        }

        public void Insert(Modelo entity)
        {
            throw new NotImplementedException();
        }

        public void Update(Modelo entity)
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
                factory = null;
            }

            // Free any unmanaged objects here.
            //
            disposed = true;
        }

        ~ModeloRepository()
        {
            Dispose(false);
        }

        #endregion

    }
}
