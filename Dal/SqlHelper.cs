using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;

namespace Dal
{
    public class SqlHelper : IDisposable
    {
        #region Campos

        private string server;
        private string port;
        private string database;
        private string user;
        private string pass;
        private int timeout;

        #endregion

        #region Propriedades
        private string connectionString
        {
            get
            {
                return "Server=" + server + ";" +
                        "Port=" + port + ";" +
                        "Database=" + database + ";" +
                        "User Id=" + user + "; " +
                        "Password=" + pass + ";";
            }
        }

        #endregion

        #region Construtor

        public SqlHelper()
        {
            server = "localhost";
            port = "3306";
            database = "avaliacao";
            user = "root";
            pass = "root";
            timeout = 18000;
        }

        #endregion

        #region Métodos

        public List<T> ExecuteQueryObject<T>(IFactory<T> entity, string query)
        {
            using (MySqlConnection sqlConnection = new MySqlConnection(connectionString))
            {
                sqlConnection.Open();
                using (MySqlCommand sqlCommand = new MySqlCommand(query, sqlConnection))
                {
                    sqlCommand.CommandTimeout = timeout;
                    sqlCommand.CommandType = CommandType.Text;

                    DataTable dt = new DataTable();
                    MySqlDataAdapter sqlDataAdapter = new MySqlDataAdapter(sqlCommand);
                    sqlDataAdapter.Fill(dt);
                    return entity.Make(dt);
                }
            }
        }
        public List<T> ExecuteProcedureObject<T>(IFactory<T> entity, string procedure)
        {
            using (MySqlConnection sqlConnection = new MySqlConnection(connectionString))
            {
                sqlConnection.Open();
                using (MySqlCommand sqlCommand = new MySqlCommand(procedure, sqlConnection))
                {
                    sqlCommand.CommandTimeout = timeout;
                    sqlCommand.CommandType = CommandType.StoredProcedure;

                    DataTable dt = new DataTable();
                    MySqlDataAdapter sqlDataAdapter = new MySqlDataAdapter(sqlCommand);
                    sqlDataAdapter.Fill(dt);
                    return entity.Make(dt);
                }
            }
        }
        public List<T> ExecuteProcedureObject<T>(IFactory<T> entity, string procedure, Dictionary<string, string> parameter)
        {
            using (MySqlConnection sqlConnection = new MySqlConnection(connectionString))
            {
                sqlConnection.Open();
                using (MySqlCommand sqlCommand = new MySqlCommand(procedure, sqlConnection))
                {
                    foreach (var p in parameter)
                        if (string.IsNullOrEmpty(p.Value))
                            sqlCommand.Parameters.Add(new MySqlParameter(p.Key, DBNull.Value));
                        else
                            sqlCommand.Parameters.Add(new MySqlParameter(p.Key, p.Value));

                    sqlCommand.CommandTimeout = timeout;
                    sqlCommand.CommandType = CommandType.StoredProcedure;

                    DataTable dt = new DataTable();
                    MySqlDataAdapter sqlDataAdapter = new MySqlDataAdapter(sqlCommand);
                    sqlDataAdapter.Fill(dt);
                    return entity.Make(dt);
                }
            }
        }

        public void ExecuteNonQuery(string query)
        {
            using (MySqlConnection sqlConnection = new MySqlConnection(connectionString))
            {
                sqlConnection.Open();
                using (MySqlCommand sqlCommand = new MySqlCommand(query, sqlConnection))
                {
                    sqlCommand.CommandTimeout = timeout;
                    sqlCommand.CommandType = CommandType.Text;
                    sqlCommand.ExecuteNonQuery();
                }
            }
        }
        public void ExecuteNonProcedure(string procedure)
        {
            using (MySqlConnection sqlConnection = new MySqlConnection(connectionString))
            {
                sqlConnection.Open();
                using (MySqlCommand sqlCommand = new MySqlCommand(procedure, sqlConnection))
                {
                    sqlCommand.CommandTimeout = timeout;
                    sqlCommand.CommandType = CommandType.StoredProcedure;
                    sqlCommand.ExecuteNonQuery();
                }
            }
        }
        public void ExecuteNonProcedure(string procedure, Dictionary<string, string> parameter)
        {
            using (MySqlConnection sqlConnection = new MySqlConnection(connectionString))
            {
                sqlConnection.Open();
                using (MySqlCommand sqlCommand = new MySqlCommand(procedure, sqlConnection))
                {
                    foreach (var p in parameter)
                        if (string.IsNullOrEmpty(p.Value))
                            sqlCommand.Parameters.Add(new MySqlParameter(p.Key, DBNull.Value));
                        else
                            sqlCommand.Parameters.Add(new MySqlParameter(p.Key, p.Value));

                    sqlCommand.CommandTimeout = timeout;
                    sqlCommand.CommandType = CommandType.StoredProcedure;
                    sqlCommand.ExecuteNonQuery();
                }
            }
        }

        public DataSet ExecuteQueryDataSet<T>(IFactory<T> entity, string query)
        {
            using (MySqlConnection sqlConnection = new MySqlConnection(connectionString))
            {
                sqlConnection.Open();
                using (MySqlCommand sqlCommand = new MySqlCommand(query, sqlConnection))
                {
                    sqlCommand.CommandTimeout = timeout;
                    sqlCommand.CommandType = CommandType.Text;

                    DataSet ds = new DataSet();
                    MySqlDataAdapter sqlDataAdapter = new MySqlDataAdapter(sqlCommand);
                    sqlDataAdapter.Fill(ds);
                    return ds;
    
                }
            }
        }
        public DataSet ExecuteProcedureDataSet<T>(IFactory<T> entity, string procedure)
        {
            using (MySqlConnection sqlConnection = new MySqlConnection(connectionString))
            {
                sqlConnection.Open();
                using (MySqlCommand sqlCommand = new MySqlCommand(procedure, sqlConnection))
                {
                    sqlCommand.CommandTimeout = timeout;
                    sqlCommand.CommandType = CommandType.StoredProcedure;

                    DataSet ds = new DataSet();
                    MySqlDataAdapter sqlDataAdapter = new MySqlDataAdapter(sqlCommand);
                    sqlDataAdapter.Fill(ds);
                    return ds;
                }
            }
        }
        public DataSet ExecuteProcedureDataSet(string procedure, Dictionary<string, string> parameter)
        {
            using (MySqlConnection sqlConnection = new MySqlConnection(connectionString))
            {
                sqlConnection.Open();
                using (MySqlCommand sqlCommand = new MySqlCommand(procedure, sqlConnection))
                {
                    foreach (var p in parameter)
                        if (string.IsNullOrEmpty(p.Value))
                            sqlCommand.Parameters.Add(new MySqlParameter(p.Key, DBNull.Value));
                        else
                            sqlCommand.Parameters.Add(new MySqlParameter(p.Key, p.Value));

                    sqlCommand.CommandTimeout = timeout;
                    sqlCommand.CommandType = CommandType.StoredProcedure;

                    DataSet ds = new DataSet();
                    MySqlDataAdapter sqlDataAdapter = new MySqlDataAdapter(sqlCommand);
                    sqlDataAdapter.Fill(ds);
                    return ds;

                }
            }
        }

        public DataTable ExecuteQueryDataTable<T>(IFactory<T> entity, string query)
        {
            using (MySqlConnection sqlConnection = new MySqlConnection(connectionString))
            {
                sqlConnection.Open();
                using (MySqlCommand sqlCommand = new MySqlCommand(query, sqlConnection))
                {
                    sqlCommand.CommandTimeout = timeout;
                    sqlCommand.CommandType = CommandType.Text;

                    DataTable dt = new DataTable();
                    MySqlDataAdapter sqlDataAdapter = new MySqlDataAdapter(sqlCommand);
                    sqlDataAdapter.Fill(dt);
                    return dt;

                }
            }
        }
        public DataTable ExecuteProcedureDataTable<T>(IFactory<T> entity, string procedure)
        {
            using (MySqlConnection sqlConnection = new MySqlConnection(connectionString))
            {
                sqlConnection.Open();
                using (MySqlCommand sqlCommand = new MySqlCommand(procedure, sqlConnection))
                {
                    sqlCommand.CommandTimeout = timeout;
                    sqlCommand.CommandType = CommandType.StoredProcedure;

                    DataTable dt = new DataTable();
                    MySqlDataAdapter sqlDataAdapter = new MySqlDataAdapter(sqlCommand);
                    sqlDataAdapter.Fill(dt);
                    return dt;
                }
            }
        }
        public DataTable ExecuteProcedureDataTable(string procedure, Dictionary<string, string> parameter)
        {
            using (MySqlConnection sqlConnection = new MySqlConnection(connectionString))
            {
                sqlConnection.Open();
                using (MySqlCommand sqlCommand = new MySqlCommand(procedure, sqlConnection))
                {
                    foreach (var p in parameter)
                        if (string.IsNullOrEmpty(p.Value))
                            sqlCommand.Parameters.Add(new MySqlParameter(p.Key, DBNull.Value));
                        else
                            sqlCommand.Parameters.Add(new MySqlParameter(p.Key, p.Value));

                    sqlCommand.CommandTimeout = timeout;
                    sqlCommand.CommandType = CommandType.StoredProcedure;

                    DataTable dt = new DataTable();
                    MySqlDataAdapter sqlDataAdapter = new MySqlDataAdapter(sqlCommand);
                    sqlDataAdapter.Fill(dt);
                    return dt;

                }
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
                //
            }

            // Free any unmanaged objects here.
            //
            disposed = true;
        }

        ~SqlHelper()
        {
            Dispose(false);
        }

        #endregion

    }
}
