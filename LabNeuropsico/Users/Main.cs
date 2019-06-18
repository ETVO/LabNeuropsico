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

namespace LabNeuropsico.Users
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            Util.DisposeForm("Usuarios.Cadastro");

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

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            Util.DisposeForm("Index");

            Index index = new Index();
            this.Hide();
            index.ShowDialog();
            this.Close();
        }

        private void btnConsultaGeral_Click(object sender, EventArgs e)
        {
            Util.DisposeForm("Usuarios.ConsultaGeral");

            ConsultaGeral consultaGeral = new ConsultaGeral();
            this.Hide();
            consultaGeral.ShowDialog();
            this.Close();
        }
    }
}
