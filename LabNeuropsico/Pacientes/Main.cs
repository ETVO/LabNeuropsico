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

namespace LabNeuropsico.Pacientes
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            Util.DisposeForm("Pacientes.Cadastro");

            Cadastro cadastro = new Cadastro();
            this.Hide();
            cadastro.ShowDialog();
            this.Close();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            if (Util.Confirm("Deseja realmente fechar o sistema?"))
            {
                this.Close();
            }
        }

        private void Main_Load(object sender, EventArgs e)
        {
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            Util.DisposeForm("Index");

            Index index = new Index();
            this.Hide();
            index.ShowDialog();
            this.Close();
        }

        private void btnVisualizarPaciente_Click(object sender, EventArgs e)
        {
            Util.DisposeForm("Pacientes.Visualizar");

            Visualizar visualizar = new Visualizar();
            this.Hide();
            visualizar.ShowDialog();
            this.Close();
        }

        private void btnConsultaGeral_Click(object sender, EventArgs e)
        {
            Util.DisposeForm("Pacientes.ConsultaGeral");

            ConsultaGeral cg = new ConsultaGeral();
            this.Hide();
            cg.ShowDialog();
            this.Close();
        }
    }
}
