using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LabNeuropsico.Model;

namespace LabNeuropsico
{
    public partial class Index : Form
    {
        public Index()
        {
            InitializeComponent();
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
    }
}
