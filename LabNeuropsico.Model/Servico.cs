using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;
using LabNeuropsico.Model.Entidades;
using LabNeuropsico.Model.Suporte;
using System.Windows.Forms;
using System.Data;

namespace LabNeuropsico.Model
{
    public class Servico
    {
        // métodos para criação de objeto

        public static Paciente ObjetoPaciente(ref NpgsqlDataReader dr)
        {
            Paciente p = new Paciente();
            if (!dr.HasRows)
                return null;

            p.SetProperties(Convert.ToInt64(dr["id_paciente"]), dr["nome"].ToString(), 
                DateTime.Parse(dr["data_nasc"].ToString()), Convert.ToChar(dr["lateralidade"]),
                dr["escolaridade"].ToString(), Convert.ToChar(dr["sexo"]), 
                Convert.ToChar(dr["nacionalidade"]), dr["responsavel"].ToString(), 
                dr["ocup_responsavel"].ToString(), dr["prontuario"].ToString(),
                Convert.ToChar(dr["hospital"]), dr["condicao"].ToString(), Convert.ToBoolean(dr["excluido"]));

            return p;
        }

        public static User ObjetoUser(ref NpgsqlDataReader dr)
        {
            User u = new User();
            if (!dr.HasRows)
                return null;

            u.SetProperties(Convert.ToInt64(dr["id_user"]), dr["nome"].ToString(), dr["login"].ToString(), 
                dr["senha"].ToString(), dr["email"].ToString(), Convert.ToChar(dr["hospital"]),
                dr["obs"].ToString(), Convert.ToBoolean(dr["admin"]));

            return u;
        }

        public static Relatorio ObjetoRelatorio(ref NpgsqlDataReader dr)
        {
            Relatorio r = new Relatorio();
            if (!dr.HasRows)
                return null;

            r.SetProperties(Convert.ToInt64(dr["id_relatorio"]), Convert.ToInt64(dr["id_paciente"]),
                dr["num_relatorio"].ToString(), dr["queixa_clinica"].ToString(), 
                DateTime.Parse(dr["inicio_aval"].ToString()), 
                DateTime.Parse(dr["fim_aval"].ToString()), 
                Convert.ToBoolean(dr["excluido"]));

            return r;
        }
        
        public static Instrumento ObjetoInstrumento(ref NpgsqlDataReader dr)
        {
            Instrumento i = new Instrumento();
            if (!dr.HasRows)
                    return null;

            i.SetProperties(Convert.ToInt64(dr["id_instrumento"]), 
                dr["nome"].ToString(), dr["tipo"].ToString(), Convert.ToBoolean(dr["excluido"]));

            return i;
        }

        public static Campo ObjetoCampo(ref NpgsqlDataReader dr)
        {
            Campo c = new Campo();
            if (!dr.HasRows)
                return null;

            c.SetProperties(Convert.ToInt64(dr["id_campo"]), Convert.ToInt64(dr["id_instrumento"]), 
                dr["nome"].ToString(), dr["tipo"].ToString(), Convert.ToBoolean(dr["excluido"]));

            return c;
        }

        public static Avaliacao ObjetoAvaliacao(ref NpgsqlDataReader dr)
        {
            Avaliacao a = new Avaliacao();
            if (!dr.HasRows)
                return null;

            a.SetProperties(Convert.ToInt64(dr["id_avaliacao"]),
                Convert.ToInt64(dr["id_instrumento"]), Convert.ToInt64(dr["id_relatorio"]),
                Convert.ToBoolean(dr["excluido"]));

            return a;
        }

        public static Valor ObjetoValor(ref NpgsqlDataReader dr)
        {
            Valor v = new Valor();
            if (!dr.HasRows)
                return null;

            v.SetProperties(Convert.ToInt64(dr["id_valor"]), Convert.ToInt64(dr["id_avaliacao"]), 
                Convert.ToInt64(dr["id_campo"]), Convert.ToDateTime(dr["vdate"]), 
                Convert.ToInt32(dr["vint"]), Convert.ToDouble(dr["vdouble"]), 
                dr["vtext"].ToString(), Convert.ToBoolean(dr["excluido"]));

            return v;
        }

        // métodos para inserção no banco

        public static void SalvarPaciente(Paciente p)
        {
            List<object> param = new List<object>();
            param = p.GetList(false);

            string sql = "INSERT INTO paciente " +
                "(nome, data_nasc, lateralidade, " +
                "escolaridade, sexo, nacionalidade, responsavel, ocup_responsavel, prontuario, " +
                "hospital, condicao)" +
                "VALUES (";

            for(int i = 0; i < param.Count(); i++)
            {
                sql += "@" + (i + 1);

                if (i < param.Count() - 1)
                    sql += ", ";
            }

            sql += ");";

            Connection.Open();
            Connection.Run(sql, param);
            Connection.Close();
        }

        public static long SalvarPacienteId(Paciente p)
        {
            List<object> param = new List<object>();
            param = p.GetList(false);

            string sql = "INSERT INTO paciente " +
                "(nome, data_nasc, lateralidade, " +
                "escolaridade, sexo, nacionalidade, responsavel, ocup_responsavel, prontuario, " +
                "hospital, condicao)" +
                "VALUES (";

            for (int i = 0; i < param.Count(); i++)
            {
                sql += "@" + (i + 1);

                if (i < param.Count() - 1)
                    sql += ", ";
            }

            sql += ") RETURNING id_paciente;";

            Connection.Open();
            NpgsqlDataReader dr = Connection.Select(sql, param);
            dr.Read();
            long id = dr.GetInt64(0);
            Connection.Close();

            return id;
        }

        public static void SalvarRelatorio(Relatorio r)
        {
            List<object> param = new List<object>();
            param = r.GetList(false, true);

            string sql = "INSERT INTO relatorio " +
                "(id_paciente, num_relatorio, queixa_clinica, inicio_aval, fim_aval)" + 
                "VALUES (";

            for (int i = 0; i < param.Count(); i++)
            {
                sql += "@" + (i + 1);

                if (i < param.Count() - 1)
                    sql += ", ";
            }

            sql += ");";

            Connection.Open();
            Connection.Run(sql, param);
            Connection.Close();
        }

        public static long SalvarRelatorioId(Relatorio r)
        {
            List<object> param = new List<object>();
            param = r.GetList(false, true);

            string sql = "INSERT INTO relatorio " +
                "(id_paciente, num_relatorio, queixa_clinica, inicio_aval, fim_aval)" +
                "VALUES (";

            for (int i = 0; i < param.Count(); i++)
            {
                sql += "@" + (i + 1);

                if (i < param.Count() - 1)
                    sql += ", ";
            }

            sql += ") RETURNING id_relatorio;";

            Connection.Open();
            NpgsqlDataReader dr = Connection.Select(sql, param);
            dr.Read();
            long id = dr.GetInt64(0);
            Connection.Close();

            return id;
        }

        public static void SalvarInstrumento(Instrumento ins)
        {
            List<object> param = new List<object>();
            param = ins.GetList(false);

            string sql = "INSERT INTO instrumento " +
                "(nome, tipo)" +
                "VALUES (";

            for (int i = 0; i < param.Count(); i++)
            {
                sql += "@" + (i + 1);

                if (i < param.Count() - 1)
                    sql += ", ";
            }

            sql += ");";

            Connection.Open();
            Connection.Run(sql, param);
            Connection.Close();
        }

        public static long SalvarInstrumentoId(Instrumento ins)
        {
            List<object> param = new List<object>();
            param = ins.GetList(false);

            string sql = "INSERT INTO instrumento " +
                "(nome, tipo)" +
                "VALUES (";

            for (int i = 0; i < param.Count(); i++)
            {
                sql += "@" + (i + 1);

                if (i < param.Count() - 1)
                    sql += ", ";
            }

            sql += ") RETURNING id_instrumento;";

            Connection.Open();
            NpgsqlDataReader dr = Connection.Select(sql, param);
            dr.Read();
            long id = dr.GetInt64(0);
            Connection.Close();

            return id;
        }

        public static void SalvarCampo(Campo c)
        {
            List<object> param = new List<object>();
            param = c.GetList(false);

            string sql = "INSERT INTO campo " +
                "(id_instrumento, nome, tipo)" +
                "VALUES (";

            for (int i = 0; i < param.Count(); i++)
            {
                sql += "@" + (i + 1);

                if (i < param.Count() - 1)
                    sql += ", ";
            }

            sql += ");";

            Connection.Open();
            Connection.Run(sql, param);
            Connection.Close();
        }

        public static void SalvarUser(User u)
        {
            List<object> param = new List<object>();
            param = u.GetList(false);

            string sql = "INSERT INTO user " +
                "(nome, login, senha, email, " +
                "hospital, obs, admin)" +
                "VALUES (";

            for (int i = 0; i < param.Count(); i++)
            {
                sql += "@" + (i + 1);

                if (i < param.Count() - 1)
                    sql += ", ";
            }

            sql += ");";

            Connection.Open();
            Connection.Run(sql, param);
            Connection.Close();
        }

        public static void SalvarAvaliacao(Avaliacao a)
        {
            List<object> param = new List<object>();
            param = a.GetList(false);

            string sql = "INSERT INTO avaliacao " +
                "(id_instrumento, id_relatorio)" +
                "VALUES (";

            for (int i = 0; i < param.Count(); i++)
            {
                sql += "@" + (i + 1);

                if (i < param.Count() - 1)
                    sql += ", ";
            }

            sql += ");";

            Connection.Open();
            Connection.Run(sql, param);
            Connection.Close();
        }

        public static long SalvarAvaliacaoId(Avaliacao a)
        {
            List<object> param = new List<object>();
            param = a.GetList(false);

            string sql = "INSERT INTO avaliacao " +
                "(id_instrumento, id_relatorio)" +
                "VALUES (";

            for (int i = 0; i < param.Count(); i++)
            {
                sql += "@" + (i + 1);

                if (i < param.Count() - 1)
                    sql += ", ";
            }

            sql += ") RETURNING id_avaliacao;";

            Connection.Open();
            NpgsqlDataReader dr = Connection.Select(sql, param);
            dr.Read();
            long id = dr.GetInt64(0);
            Connection.Close();

            return id;
        }

        public static void SalvarValor(Valor v)
        {
            List<object> param = new List<object>();
            param = v.GetList(false);

            string sql = "INSERT INTO valor " +
                "(id_avaliacao, id_campo, vdate, vint, " +
                "vdouble, vtext)" +
                "VALUES (";

            for (int i = 0; i < param.Count(); i++)
            {
                sql += "@" + (i + 1);

                if (i < param.Count() - 1)
                    sql += ", ";
            }

            sql += ");";

            Connection.Open();
            Connection.Run(sql, param);
            Connection.Close();
        }

        // métodos para alteração no banco

        public static void AlterarAvaliacao(Avaliacao a)
        {
            List<object> param = new List<object>();
            param = a.GetList(false);

            int i = 1;

            string sql = "UPDATE public.avaliacao " +
                "SET id_instrumento = @" + (i++) + ", id_relatorio = @" + (i++) + " " +
                "WHERE id_avaliacao = " + a.Id_Avaliacao;

            Connection.Open();
            Connection.Run(sql, param);
            Connection.Close();
        }

        public static void AlterarPaciente(Paciente p)
        {
            List<object> param = new List<object>();
            param = p.GetList(false);

            int i = 1;

            string sql = "UPDATE public.paciente" +
                " SET nome = @" + (i++) + ", " +
                " data_nasc = @" + (i++) + ", lateralidade = @" + (i++) + "," +
                " escolaridade = @" + (i++) + ", sexo = @" + (i++) + "," +
                " nacionalidade = @" + (i++) + ", responsavel = @" + (i++) + "," +
                " ocup_responsavel = @" + (i++) + ", prontuario = @" + (i++) + "," +
                " hospital = @" + (i++) + ", condicao = @" + (i++) +
                " WHERE id_paciente = " + p.Id_Paciente + ";";

            Connection.Open();
            Connection.Run(sql, param);
            Connection.Close();
        }

        public static void AlterarRelatorio(Relatorio r)
        {
            List<object> param = new List<object>();
            param = r.GetList(false, false);

            int i = 1;

            string sql = "UPDATE public.relatorio " +
                "SET num_relatorio = @" + (i++) + ", queixa_clinica = @" + (i++) + ", " +
                "inicio_aval = @" + (i++) + ", fim_aval = @" + (i++) + " " + 
                "WHERE id_relatorio = " + r.Id_Relatorio;

            Connection.Open();
            Connection.Run(sql, param);
            Connection.Close();
        }

        public static void AlterarValor(Valor v)
        {
            List<object> param = new List<object>();
            param = v.GetList(false);

            int i = 1;

            string sql = "UPDATE public.valor " +
                "SET id_avaliacao = @" + (i++) + ", id_campo = @" + (i++) + ", " +
                "vdate = @" + (i++) + ", vint = @" + (i++) + ", vdouble = @" + (i++) + ", " +
                "vtext = @" + (i++) + " " +
                "WHERE id_valor = " + v.Id_Valor;

            Connection.Open();
            Connection.Run(sql, param);
            Connection.Close();
        }

        // métodos para exclusão no banco

        public static void PacienteExcluido(Paciente p, bool excluido)
        {
            string sql = "UPDATE paciente" +
                " SET excluido = " + excluido +
                " WHERE id_paciente = " + p.Id_Paciente + ";";

            Connection.Open();
            Connection.Run(sql);
            Connection.Close();
        }

        public static void RelatorioExcluido(Relatorio r, bool excluido)
        {
            string sql = "UPDATE relatorio" +
                " SET excluido = " + excluido +
                " WHERE id_relatorio = " + r.Id_Relatorio + ";";

            Connection.Open();
            Connection.Run(sql);
            Connection.Close();
        }

        public static void AvaliacaoExcluido(Avaliacao a, bool excluido)
        {
            string sql = "UPDATE avaliacao" +
                " SET excluido = " + excluido +
                " WHERE id_avaliacao = " + a.Id_Avaliacao + ";";

            Connection.Open();
            Connection.Run(sql);
            Connection.Close();
        }

        public static void InstrumentoExcluido(Instrumento i, bool excluido)
        {
            string sql = "UPDATE instrumento" +
                " SET excluido = " + excluido +
                " WHERE id_instrumento = " + i.Id_Instrumento + ";";

            Connection.Open();
            Connection.Run(sql);
            Connection.Close();
        }

        // métodos para consulta no banco

        public static Paciente BuscarPaciente(long id_paciente)
        {
            Paciente p = new Paciente();

            string sql = "SELECT * FROM paciente " +
                "WHERE id_paciente = " + id_paciente;

            Connection.Open();
            NpgsqlDataReader dr = Connection.Select(sql);

            if (!dr.HasRows)
                return null;

            dr.Read();
            p = ObjetoPaciente(ref dr);

            Connection.Close();
            return p;
        }

        public static Relatorio BuscarRelatorio(long id_relatorio)
        {
            Relatorio r = new Relatorio();

            string sql = "SELECT * FROM relatorio " +
                "WHERE id_relatorio = " + id_relatorio;

            Connection.Open();
            NpgsqlDataReader dr = Connection.Select(sql);

            if (!dr.HasRows)
                return null;

            dr.Read();
            r = ObjetoRelatorio(ref dr);

            Connection.Close();
            return r;
        }

        public static User BuscarUser(long id_user)
        {
            User u = new User();
            
            string sql = "SELECT * FROM user " +
                "WHERE id_user = " + id_user;

            Connection.Open();
            NpgsqlDataReader dr = Connection.Select(sql);

            if (!dr.HasRows)
                return null;

            dr.Read();
            u = ObjetoUser(ref dr);

            Connection.Close();
            return u;
        }

        public static Instrumento BuscarInstrumento(long id_instrumento)
        {
            Instrumento i = new Instrumento();

            string sql = "SELECT * FROM instrumento " +
                "WHERE id_instrumento = " + id_instrumento;

            Connection.Open();
            NpgsqlDataReader dr = Connection.Select(sql);

            if (!dr.HasRows)
                return null;

            dr.Read();
            i = ObjetoInstrumento(ref dr);

            Connection.Close();
            return i;
        }

        public static List<Instrumento> ListarInstrumentos()
        {
            List<Instrumento> ins = new List<Instrumento>();

            string sql = "SELECT * FROM instrumento WHERE excluido = FALSE";

            Connection.Open();
            NpgsqlDataReader dr = Connection.Select(sql);

            while(dr.Read())
            {
                ins.Add(ObjetoInstrumento(ref dr));
            }

            return ins;
        }

        public static bool ExisteInstrumento(string nome)
        {
            nome = nome.ToLower();
            string sql = "SELECT nome FROM instrumento WHERE lower(nome) = '" + nome + "'";

            Connection.Open();
            DataTable ds = Connection.SelectDataTable(sql);
            Connection.Close();
            if (ds.Rows.Count > 0)
                return true;

            return false;
        }

        public static Campo BuscarCampo(long id_campo)
        {
            Campo c = new Campo();

            string sql = "SELECT * FROM campo " +
                "WHERE id_campo = " + id_campo;

            Connection.Open();
            NpgsqlDataReader dr = Connection.Select(sql);

            if (!dr.HasRows)
                return null;

            dr.Read();
            c = ObjetoCampo(ref dr);

            Connection.Close();
            return c;
        }

        public static Campo BuscarCampoValor(long id_valor)
        {
            Campo c = new Campo();

            string sql = "SELECT c.* FROM valor AS v INNER JOIN campo AS c ON v.id_campo = c.id_campo " +
                "WHERE id_valor = " + id_valor;

            Connection.Open();
            NpgsqlDataReader dr = Connection.Select(sql);

            if (!dr.HasRows)
                return null;

            dr.Read();
            c = ObjetoCampo(ref dr);

            Connection.Close();
            return c;
        }

        public static Avaliacao BuscarAvaliacao(long id_avaliacao)
        {
            Avaliacao a = new Avaliacao();

            string sql = "SELECT * FROM avaliacao " +
                "WHERE id_avaliacao = " + id_avaliacao;

            Connection.Open();
            NpgsqlDataReader dr = Connection.Select(sql);

            if (!dr.HasRows)
                return null;

            dr.Read();
            a = ObjetoAvaliacao(ref dr);

            Connection.Close();
            return a;
        }

        public static Valor BuscarValor(long id_valor)
        {
            Valor v = new Valor();

            string sql = "SELECT * FROM valor " +
                "WHERE id_valor = " + id_valor;

            Connection.Open();
            NpgsqlDataReader dr = Connection.Select(sql);

            if (!dr.HasRows)
                return null;

            dr.Read();
            v = ObjetoValor(ref dr);

            Connection.Close();
            return v;
        }

        public static Valor BuscarValor(long id_campo, long id_avaliacao)
        {
            Valor v = new Valor();

            string sql = "SELECT * FROM valor " +
                "WHERE id_campo = " + id_campo + " AND id_avaliacao = " + id_avaliacao;

            Connection.Open();
            NpgsqlDataReader dr = Connection.Select(sql);

            if (!dr.HasRows)
                return null;

            dr.Read();
            v = ObjetoValor(ref dr);

            Connection.Close();
            return v;
        }

        // métodos genéricos

        public static DataTable PopDataTable(string sql)
        {
            Connection.Open();
            DataTable d = Connection.SelectDataTable(sql);
            Connection.Close();

            return d;
        }
    }
}
