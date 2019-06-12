using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabNeuropsico.Model.Entidades
{
    public class Paciente
    {
        private long id_paciente;
        private string nome;
        private DateTime data_nasc;
        private char lateralidade;
        private string escolaridade;
        private char sexo;
        private char nacionalidade;
        private string responsavel;
        private string ocup_responsavel;
        private string prontuario;
        private char hospital;
        private string condicao;
        private bool excluido;
        
        public long Id_Paciente { get => id_paciente; set => id_paciente = value; }
        public string Nome { get => nome; set => nome = value; }
        public DateTime Data_Nasc { get => data_nasc; set => data_nasc = value; }
        /// <summary>
        /// 'D' (Destro), 'S' (Sinistro), 'A' (Ambidestro) ou 'N' (Não informado)
        /// </summary>
        public char Lateralidade{ get => lateralidade; set => lateralidade = char.ToLower(value); }
        public string Escolaridade
        {
            get
            {
                return escolaridade;
            }

            set
            {
                if (value == "")
                    escolaridade = "Não informado";
                else
                    escolaridade = value;
            }
        }
        /// <summary>
        /// 'M' (Masculino) ou 'F' (Feminino)
        /// </summary>
        public char Sexo { get => sexo; set => sexo = char.ToLower(value); }
        /// <summary>
        /// 'B' (Brasileiro), 'E' (Estrangeiro) ou 'N' (Não informado)
        /// </summary>
        public char Nacionalidade { get => nacionalidade; set => nacionalidade = char.ToLower(value); }
        public string Responsavel
        {
            get
            {
                return responsavel;
            }

            set
            {
                if (value == "")
                    responsavel = "Não informado";
                else
                    responsavel = value;
            }
        }
        public string Ocupacao_Responsavel
        {
            get
            {
                return ocup_responsavel;
            }

            set
            {
                if (value == "")
                    ocup_responsavel = "Não informado";
                else
                    ocup_responsavel = value;
            }
        }
        public string Prontuario
        {
            get
            {
                return prontuario;
            }

            set
            {
                if (value == "")
                    prontuario = "Não informado";
                else
                    prontuario = value;
            }
        }
        /// <summary>
         /// 'H' (HRAC), 'F' (FOB) ou 'A' (Ambos)
         /// </summary>
        public char Hospital { get => hospital; set => hospital = char.ToLower(value); }
        public string Condicao { get => condicao; set => condicao = value; }
        public bool Excluido { get => excluido; set => excluido = value; }

        public Paciente()
        {
            ClearProperties();
        }

        /// <summary>
        /// Compila todas as propriedades em uma lista de objetos
        /// </summary>
        /// <returns>Lista de propriedades</returns>
        public List<object> GetList(bool with_id)
        {
            List<object> param = new List<object>();

            if(with_id)
                param.Add(Id_Paciente);
            param.Add(Nome);
            param.Add(Data_Nasc);
            param.Add(Lateralidade);
            param.Add(Escolaridade);
            param.Add(Sexo);
            param.Add(Nacionalidade);
            param.Add(Responsavel);
            param.Add(Ocupacao_Responsavel);
            param.Add(Prontuario);
            param.Add(Hospital);
            param.Add(Condicao);

            return param;
        }

        /// <summary>
        /// Transforma os parâmetros recebidos nas propriedades do objeto
        /// </summary>
        public void SetProperties(
            long id_paciente, 
            string nome, 
            DateTime data_nasc, 
            char lateralidade,
            string escolaridade, 
            char sexo, 
            char nacionalidade, 
            string responsavel, 
            string ocup_responsavel, 
            string prontuario, 
            char hospital,
            string condicao,
            bool excluido)
        {
            Id_Paciente = id_paciente;
            Nome = nome;
            Data_Nasc = data_nasc;
            Lateralidade = char.ToLower(lateralidade);
            Escolaridade = escolaridade;
            Sexo = sexo;
            Nacionalidade = char.ToLower(nacionalidade);
            Responsavel = responsavel;
            Ocupacao_Responsavel = ocup_responsavel;
            Prontuario = prontuario;
            Hospital = char.ToLower(hospital);
            Condicao = condicao;
            Excluido = excluido;
        }

        public void ClearProperties()
        {
            Id_Paciente = 0;
            Nome = "";
            Data_Nasc = new DateTime();
            Lateralidade = '\0';
            Escolaridade = "";
            Sexo = '\0';
            Nacionalidade = '\0';
            Responsavel = "";
            Ocupacao_Responsavel = "";
            Prontuario = "";
            Hospital = '\0';
            Condicao = "";
            Excluido = false;
        }

        public char GetArtigo()
        {
            if (Sexo == 'm')
                return 'o';
            return 'a';
        }
    }

    public class User
    {
        private long id_user;
        private string nome;
        private string login;
        private string senha;
        private string email;
        private char hospital;
        private string obs;
        private bool admin;
        private bool excluido;

        public long Id_User { get => id_user; set => id_user = value; }
        public string Nome { get => nome; set => nome = value; }
        public string Login { get => login; set => login = value; }
        public string Senha { get => senha; set => senha = value; }
        public string Email { get => email; set => email = value; }
        public char Hospital { get => hospital; set => hospital = char.ToLower(value); }
        public string Obs { get => obs; set => obs = value; }
        public bool Is_Admin { get => admin; set => admin = value; }
        public bool Excluido { get => excluido; set => excluido = value; }

        public User()
        {
            ClearProperties();
        }

        /// <summary>
        /// Compila todas as propriedades em uma lista de objetos
        /// </summary>
        /// <returns>Lista de propriedades</returns>
        public List<object> GetList(bool with_id)
        {
            List<object> param = new List<object>();

            if (with_id)
                param.Add(Id_User);
            param.Add(Nome);
            param.Add(Login);
            param.Add(Senha);
            param.Add(Email);
            param.Add(Hospital);
            param.Add(Obs);
            param.Add(Is_Admin);

            return param;
        }

        /// <summary>
        /// Transforma os parâmetros recebidos nas propriedades do objeto User
        /// </summary>
        public void SetProperties(long id_user,
             string nome,
             string login,
             string senha,
             string email,
             char hospital,
             string obs,
             bool admin)
        {
            Id_User = id_user;
            Nome = nome;
            Login = login;
            Senha = senha;
            Email = email;
            Hospital = hospital;
            Obs = obs;
            Is_Admin = admin; 
        }

        public void ClearProperties()
        {
            Id_User = 0;
            Nome = "";
            Login = "";
            Senha = "";
            Email = "";
            Hospital = '\0';
            Obs = "";
            Is_Admin = false;
        }
    }

    public class Relatorio
    {
        private long id_relatorio;
        private long id_paciente;
        private string num_relatorio;
        private string queixa_clinica;
        private DateTime inicio_aval;
        private DateTime fim_aval;
        private bool excluido;

        public long Id_Relatorio { get => id_relatorio; set => id_relatorio = value; }
        public long Id_Paciente { get => id_paciente; set => id_paciente = value; }
        public string Num_Relatorio { get => num_relatorio; set => num_relatorio = value; }
        public string Queixa_Clinica { get => queixa_clinica; set => queixa_clinica = value; }
        public DateTime Inicio_Aval { get => inicio_aval; set => inicio_aval = value; }
        public DateTime Fim_Aval { get => fim_aval; set => fim_aval = value; }
        public bool Excluido { get => excluido; set => excluido = value; }

        public Relatorio()
        {
            ClearProperties();
        }

        public List<object> GetList(bool with_id_rel, bool with_id_pac)
        {
            List<object> param = new List<object>();

            if (with_id_rel)
                param.Add(this.Id_Relatorio);
            if (with_id_pac)
                param.Add(this.Id_Paciente);
            param.Add(Num_Relatorio);
            param.Add(Queixa_Clinica);
            param.Add(Inicio_Aval);
            param.Add(Fim_Aval);

            return param;
        }

        /// <summary>
        /// Transforma os parâmetros recebidos nas propriedades do objeto
        /// </summary>
        public void SetProperties(
            long id_relatorio,
             long id_paciente,
             string num_relatorio,
             string queixa_clinica,
             DateTime inicio_aval,
             DateTime fim_aval, bool excluido)
        {
            Id_Relatorio = id_relatorio;
            Id_Paciente = id_paciente;
            Num_Relatorio = num_relatorio;
            Queixa_Clinica = queixa_clinica;
            Inicio_Aval = inicio_aval;
            Fim_Aval = fim_aval;
            Excluido = excluido;
        }

        public void ClearProperties()
        {
            Id_Relatorio = 0;
            Id_Paciente = 0;
            Num_Relatorio = "";
            Queixa_Clinica = "";
            Inicio_Aval = new DateTime();
            Fim_Aval = new DateTime();
            Excluido = false;
        }
    }

    public class Instrumento
    {
        private long id_instrumento;
        private string nome;
        private string tipo;
        private bool excluido;

        public long Id_Instrumento { get => id_instrumento; set => id_instrumento = value; }
        public string Nome { get => nome; set => nome = value; }
        public string Tipo { get => tipo; set => tipo = value; }
        public bool Excluido { get => excluido; set => excluido = value; }

        public Instrumento()
        {
            ClearProperties();
        }

        public List<object> GetList(bool with_id)
        {
            List<object> param = new List<object>();

            if (with_id)
                param.Add(this.Id_Instrumento);
            param.Add(Nome);
            param.Add(Tipo);

            return param;
        }

        /// <summary>
        /// Transforma os parâmetros recebidos nas propriedades do objeto
        /// </summary>
        public void SetProperties(
             long id_instrumento,
             string nome,
             string tipo,
             bool excluido)
        {
            Id_Instrumento = id_instrumento;
            Nome = nome;
            Tipo = tipo;
            Excluido = excluido;
        }

        public void ClearProperties()
        {
            Id_Instrumento = 0;
            Nome = "";
            Tipo = "";
            Excluido = false;
        }
    }

    public class Campo
    {
        private long id_campo;
        private long id_instrumento;
        private string nome;
        private string tipo;
        private bool excluido;

        public long Id_Campo { get => id_campo; set => id_campo = value; }
        public long Id_Instrumento { get => id_instrumento; set => id_instrumento = value; }
        public string Nome { get => nome; set => nome = value; }
        public string Tipo { get => tipo; set => tipo = value; }
        public bool Excluido { get => excluido; set => excluido = value; }

        public Campo()
        {
            ClearProperties();
        }

        public List<object> GetList(bool with_id)
        {
            List<object> param = new List<object>();

            if (with_id)
                param.Add(this.Id_Campo);
            param.Add(this.Id_Instrumento);
            param.Add(Nome);
            param.Add(Tipo);

            return param;
        }

        /// <summary>
        /// Transforma os parâmetros recebidos nas propriedades do objeto
        /// </summary>
        public void SetProperties(
            long id_campo,
            long id_instrumento,
            string nome,
            string tipo,
            bool excluido)
        {
            Id_Campo = id_campo;
            Id_Instrumento = id_instrumento;
            Nome = nome;
            Tipo = tipo;
            Excluido = excluido;
        }

        public void ClearProperties()
        {
            Id_Campo = 0;
            Id_Instrumento = 0;
            Nome = "";
            Tipo = "";
            Excluido = false;
        }
    }

    public class Avaliacao
    {
        private long id_avaliacao;
        private long id_instrumento;
        private long id_relatorio;
        private bool excluido;

        public long Id_Avaliacao { get => id_avaliacao; set => id_avaliacao = value; }
        public long Id_Instrumento { get => id_instrumento; set => id_instrumento = value; }
        public long Id_Relatorio { get => id_relatorio; set => id_relatorio = value; }
        public bool Excluido { get => excluido; set => excluido = value; }

        public Avaliacao()
        {
            ClearProperties();
        }

        public List<object> GetList(bool with_id)
        {
            List<object> param = new List<object>();

            if (with_id)
                param.Add(this.Id_Avaliacao);
            param.Add(this.Id_Instrumento);
            param.Add(this.Id_Relatorio);

            return param;
        }

        /// <summary>
        /// Transforma os parâmetros recebidos nas propriedades do objeto
        /// </summary>
        public void SetProperties(
             long id_avaliacao,
             long id_instrumento,
             long id_relatorio,
             bool excluido)
        {
            Id_Avaliacao = id_avaliacao;
            Id_Instrumento = id_instrumento;
            Id_Relatorio = id_relatorio;
            Excluido = excluido;
        }

        public void ClearProperties()
        {
            Id_Avaliacao = 0;
            Id_Instrumento = 0;
            Id_Relatorio = 0;
            Excluido = false;
        }
    }

    public class Valor

    {
        private long id_valor;
        private long id_avaliacao;
        private long id_campo;
        private DateTime vdate;
        private int vint;
        private double vdouble;
        private string vtext;
        private bool excluido;

        public long Id_Valor { get => id_valor; set => id_valor = value; }
        public long Id_Avaliacao { get => id_avaliacao; set => id_avaliacao = value; }
        public long Id_Campo { get => id_campo; set => id_campo = value; }
        public DateTime Date { get => vdate; set => vdate = value; }
        public int Int { get => vint; set => vint = value; }
        public double Double { get => vdouble; set => vdouble = value; }
        public string Text { get => vtext; set => vtext = value; }
        public bool Excluido { get => excluido; set => excluido = value; }

        public List<object> GetList(bool with_id)
        {
            List<object> param = new List<object>();

            if (with_id)
                param.Add(this.Id_Valor);
            param.Add(this.Id_Avaliacao);
            param.Add(this.Id_Campo);
            param.Add(this.Date);
            param.Add(this.Int);
            param.Add(this.Double);
            param.Add(this.Text);

            return param;
        }

        /// <summary>
        /// Transforma os parâmetros recebidos nas propriedades do objeto
        /// </summary>
        public void SetProperties(
             long id_valor,
             long id_avaliacao,
             long id_campo,
             DateTime vdate,
             int vint,
             double vdouble,
             string vtext,
             bool excluido)
        {
            Id_Valor = id_valor;
            Id_Avaliacao = id_avaliacao;
            Id_Campo = id_campo;
            Date = vdate;
            Int = vint;
            Double = vdouble;
            Text = vtext;
            Excluido = excluido;
        }

        public void SetValue(string tipo, string valor)
        {
            Date = new DateTime();
            Int = 0;
            Double = 0;
            Text = "";

            switch(tipo)
            {
                case "vdate":
                    if (valor == "")
                        Date = new DateTime();
                    else
                        Date = DateTime.Parse(valor);
                    break;

                case "vint":
                    if (valor == "")
                        Int = 0;
                    else
                        Int = Convert.ToInt32(valor);
                    break;

                case "vdouble":
                    valor = valor.Replace(",", ".");
                    if (valor == "")
                        Double = 0;
                    else
                        Double = Convert.ToDouble(valor);
                    break;

                case "vtext":
                    Text = valor.ToString();
                    break;
            }
        }

        public object GetValue(string tipo)
        {
            switch (tipo)
            {
                case "vdate":
                    return Date;

                case "vint":
                    return Int;

                case "vdouble":
                    return Double;

                case "vtext":
                    return Text;

                default:
                    return null;
            }
        }

        public void ClearProperties()
        {
            Id_Valor = 0;
            Id_Avaliacao = 0;
            Id_Campo = 0;
            Date = new DateTime();
            Int = 0;
            Double = 0;
            Text = "";
            Excluido = false;
        }
    }

}
