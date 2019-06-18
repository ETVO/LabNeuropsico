using LabNeuropsico.Model.Entidades;
using Npgsql;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace LabNeuropsico.Model.Suporte
{
    /// <summary>
    /// Classe com funções NpgSQL
    /// </summary>
    public static class Connection
    {

        /// <summary>
        /// Atributo interno da conexão com o banco
        /// </summary>
        private static NpgsqlConnection con;

        private static string host = "localhost";
        private static string port = "5432";
        private static string db = "postgres";
        private static string user = "postgres";
        private static string password = "postgres";

        private static List<string> tables = new List<string>(new string[] 
        { "valid", "paciente", "usuario", "relatorio", "instrumento", "campo", "avaliacao", "valor" });

        /// <summary>
        /// Construtor da classe
        /// </summary>
        static Connection()
        {
            Open(host, port, db, user, password);
        }


        /// <summary>
        /// Abre a conexão
        /// </summary>
        public static void Open()
        {
            if(con != null)
                Open(host, port, db, user, password);
        }

        /// <summary>
        /// Abre a conexão
        /// </summary>
        /// <param name="host">Nome do host</param>
        /// <param name="port">Porta</param>
        /// <param name="db">Banco de dados</param>
        /// <param name="user">Nome de usuário</param>
        /// <param name="password">Senha</param>
        public static void Open(string host, string port, string db, string user, string password)
        {
            try
            {
                con = new NpgsqlConnection();
                string strConnect = "Server=" + host + "; Port=" + port + "; Database=" + db + "; User Id=" + user + "; Password=" + password + ";";

                con.ConnectionString = strConnect;
                con.Open();
            }
            catch (NpgsqlException e)
            {
                throw new NpgsqlException(e.Message);
            }

        }

        /// <summary>
        /// Encerra a conexão
        /// </summary>
        public static void Close()
        {
            con.Close();
            con.Dispose();
        }

        /// <summary>
        /// Executa um comando SQL sem retorno
        /// </summary>
        /// <param name="sql">O comando SQL</param>
        public static void Run(string sql)
        {
            try
            {
                NpgsqlCommand cmd = new NpgsqlCommand(sql, con);
                cmd.ExecuteNonQuery();
            }
            catch (NpgsqlException e)
            {
                throw new NpgsqlException(e.Message);
            }
        }

        /// <summary>
        /// Executa um comando SQL sem retorno
        /// </summary>
        /// <param name="sql">O comando SQL</param>
        /// <param name="parameters">Os parâmetros do comando</param>
        public static void Run(string sql, List<object> parameters)
        {
            try
            {
                NpgsqlCommand cmd = new NpgsqlCommand(sql, con);
                int i = 1;
                foreach (object parameter in parameters)
                {
                    cmd.Parameters.AddWithValue("@" + i++.ToString(), parameter);
                }
                
                cmd.ExecuteNonQuery();
            }
            catch (NpgsqlException e)
            {
                throw new NpgsqlException(e.Message);
            }
        }

        /// <summary>
        /// Executa um comando SQL sem retorno
        /// </summary>
        /// <param name="sql">O comando SQL</param>
        /// <param name="parameters">Os parâmetros do comando</param>
        /// <param name="returning"></param>
        /// <returns></returns>
        public static int Run(string sql, List<object> parameters, string returning)
        {
            try
            {
                NpgsqlCommand cmd = new NpgsqlCommand();
                cmd.CommandText = sql + " RETURNING " + returning;
                cmd.Connection = con;
                int i = 1;

                foreach (String parameter in parameters)
                {
                    cmd.Parameters.AddWithValue(i++.ToString(), parameter);
                }

                return Convert.ToInt32(cmd.ExecuteScalar());
            }
            catch (NpgsqlException e)
            {
                throw new NpgsqlException(e.Message);
            }
        }

        /// <summary>
        /// Executa um comando SQL com retorno de dados
        /// </summary>
        /// <param name="sql">O comando SQL</param>
        /// <returns>Retorna os dados selecionados</returns>
        public static NpgsqlDataReader Select(string sql)
        {
            try
            {
                NpgsqlCommand cmd = new NpgsqlCommand(sql, con);
                return cmd.ExecuteReader();
            }
            catch (NpgsqlException e)
            {
                throw new NpgsqlException(e.Message);
            }
        }

        /// <summary>
        /// Executa um comando SQL com retorno de dados
        /// </summary>
        /// <param name="sql">O comando SQL</param>
        /// <param name="parameters">Os parâmetros do comando</param>
        /// <returns>Retorna os dados selecionados</returns>
        public static NpgsqlDataReader Select(string sql, List<object> parameters)
        {
            try
            {
                NpgsqlCommand cmd = new NpgsqlCommand(sql, con);
                int i = 1;
                foreach (object parameter in parameters)
                {
                    cmd.Parameters.AddWithValue(i++.ToString(), parameter);
                }
                return cmd.ExecuteReader();
            }
            catch (NpgsqlException e)
            {
                throw new NpgsqlException(e.Message);
            }
        }

        /// <summary>
        /// Obtém um DataTable 
        /// </summary>
        /// <param name="sql">O comando SQL</param>
        /// <returns>Retorna um DataTable com os dados selecionados</returns>
        public static DataTable SelectDataTable(string sql)
        {
            try
            {
                DataTable dt = new DataTable();
                NpgsqlCommand cmd = new NpgsqlCommand(sql, con);
                NpgsqlDataAdapter da = new NpgsqlDataAdapter(cmd);
                da.Fill(dt);
                return dt;
            }
            catch (NpgsqlException e)
            {
                throw new NpgsqlException(e.Message);
            }
        }

        /// <summary>
        /// Obtém um DataSet
        /// </summary>
        /// <param name="sql">O comando SQL</param>
        /// <returns>Retorna um DataSet com os dados</returns>
        public static DataSet SelectDataSet(string sql)
        {
            try
            {
                DataSet ds = new DataSet();
                NpgsqlCommand cmd = new NpgsqlCommand(sql, con);
                NpgsqlDataAdapter da = new NpgsqlDataAdapter(cmd);
                da.Fill(ds);
                return ds;
            }
            catch (NpgsqlException e)
            {
                throw new NpgsqlException(e.Message);
            }
        }

        /// <summary>
        /// Obtém um DataSet
        /// </summary>
        /// <param name="table">Nome da tabela</param>
        /// <param name="fields">Todos os campos (separados por vírgula)</param>
        /// <param name="where">Condição (opcional)</param>
        /// <param name="orderBy">Ordenação (opcional)</param>
        /// <returns>Retorna um DataSet com os dados</returns>
        public static DataSet SelectDataSet(string table, string fields, string where = "", string orderBy = "")
        {
            try
            {
                DataSet ds = new DataSet();
                string sql = @"select " + fields + " from " + table;
                if (where != "")
                {
                    sql += @" where " + where + " ";
                }
                if (orderBy != "")
                {
                    sql += @" order by " + orderBy + " ";
                }
                NpgsqlCommand cmd = new NpgsqlCommand(sql, con);
                NpgsqlDataAdapter da = new NpgsqlDataAdapter(cmd);
                da.Fill(ds, table);
                return ds;
            }
            catch (NpgsqlException e)
            {
                throw new NpgsqlException(e.Message);
            }
        }

        /// <summary>
        /// Inicializa as tabelas no banco de dados
        /// </summary>
        public static void CreateTables()
        {
            string sql = "";

            foreach (string table in tables)
            {
                sql = "SELECT relname FROM pg_catalog.pg_class WHERE relkind='r' AND relname='"+ table +"'";

                DataTable dt = SelectDataTable(sql);

                if(dt.Rows.Count == 0)
                {
                    sql = Util.RawText("config/"+ table +"_create");

                    Run(sql);
                }
            }
        }

        /// <summary>
        /// Verifica validade das tabelas (baseado na existência da tabela 'valid', que não existe na primeira vez que se executa o programa)
        /// </summary>
        /// <returns>Verdadeiro caso válido, falso caso inválido</returns>
        public static bool CheckTables()
        {
            string sql = "SELECT relname FROM pg_catalog.pg_class WHERE relkind='r' AND relname='valid'";

            DataTable dt = SelectDataTable(sql);

            return dt.Rows.Count > 0;
        }

        public static void DropTables()
        {
            if(Util.Confirm("APAGAR TODOS OS DADOS É UMA AÇÃO IRREVERSÍVEL!\n\nContinuar?\nO sistema será reinicializado."))
            {
                string sql = "DROP SCHEMA public CASCADE; " +
                "CREATE SCHEMA public; " +
                "GRANT ALL ON SCHEMA public TO postgres;" +
                "GRANT ALL ON SCHEMA public TO public;";

                Run(sql);

                //CreateTables();
            }
        }

        /// <summary>
        /// Obtém os dados da conexão em String
        /// </summary>
        /// <returns>Retorna os dados da conexão</returns>
        public static string ToString()
        {
            return con.ConnectionString;
        }
    }
}
