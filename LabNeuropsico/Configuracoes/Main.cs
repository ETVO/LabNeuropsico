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
using LabNeuropsico.Model.Suporte;
using LabNeuropsico.Model.Session;

namespace LabNeuropsico.Configuracoes
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        bool checkRoot()
        {
            if (Session.Usuario.Login == "root" && Session.Usuario.Senha == "5a4092948705fa0a1b8886c75dd78a21")
                return true;
            return false;
        }

        private void btnRestaurar_Click(object sender, EventArgs e)
        {
            if(Util.Confirm("ATENÇÃO!\nDeseja realmente restaurar todos os dados?\n\nProsseguir apagará permanentemente todos os dados salvos na base de dados do sistema!"))
            {
                Connection.Open();
                bool restart = Connection.DropTables();
                Connection.Close();

                if(restart)
                    Application.Restart();
            }
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

        private void Main_Load(object sender, EventArgs e)
        {
            if (!checkRoot())
            {
                btnRestaurar.Enabled = false;
                lblRestrito.Visible = true;
            }

        }
    }
}
