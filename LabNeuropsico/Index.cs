using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LabNeuropsico.Model;
using LabNeuropsico.Model.Session;

namespace LabNeuropsico
{
    public partial class Index : Form
    {
        bool admin = false;

        public Index()
        {
            InitializeComponent();
        }

        void disable()
        {
            btnUsers.Enabled = admin;
            btnConfig.Enabled = admin;
        }

        private void btnPacientes_Click(object sender, EventArgs e)
        {
            Util.DisposeForm("Pacientes.Main");

            Pacientes.Main pacientes = new Pacientes.Main();
            this.Hide();
            pacientes.ShowDialog();
            this.Close();
        }

        private void Index_Load(object sender, EventArgs e)
        {
            admin = Session.Usuario.Is_Admin;

            lblNome.Text = Session.Usuario.Nome;

            disable();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            if (Util.Confirm("Deseja realmente fechar o sistema?"))
            {
                this.Close();
            }
        }

        private void btnInstrumentos_Click(object sender, EventArgs e)
        {
            Util.DisposeForm("Instrumentos.Main");

            Instrumentos.Main instrumentos = new Instrumentos.Main();
            this.Hide();
            instrumentos.ShowDialog();
            this.Close();
        }

        private void btnConfig_Click(object sender, EventArgs e)
        {
            Util.DisposeForm("Configuracoes.Main");

            Configuracoes.Main configuracoes = new Configuracoes.Main();
            this.Hide();
            configuracoes.ShowDialog();
            this.Close();
        }

        private void btnUsers_Click(object sender, EventArgs e)
        {
            Util.DisposeForm("Users.Main");

            Users.Main usuarios = new Users.Main();
            this.Hide();
            usuarios.ShowDialog();
            this.Close();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Util.DisposeForm("Login");

            Login login = new Login();
            this.Hide();
            login.ShowDialog();
            this.Close();
        }

        private void btnSobre_Click(object sender, EventArgs e)
        {
            Util.DisposeForm("Sobre");

            Sobre sobre = new Sobre();
            this.Hide();
            sobre.ShowDialog();
            this.Close();
        }

        private void btnAjuda_Click(object sender, EventArgs e)
        {
            String filename = System.IO.Path.GetDirectoryName(Assembly.GetEntryAssembly().Location) +
                 "/config/Guia.pdf";
            System.Diagnostics.Process.Start(@filename);
        }
    }
}
