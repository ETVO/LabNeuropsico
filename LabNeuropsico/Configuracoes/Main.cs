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

namespace LabNeuropsico.Configuracoes
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void btnRestaurar_Click(object sender, EventArgs e)
        {
            if(Util.Confirm("ATENÇÃO!\nDeseja realmente restaurar todos os dados?\n\nProsseguir apagará permanentemente todos os dados salvos na base de dados do sistema!"))
            {
                Connection.Open();
                Connection.DropTables();
                Connection.Close();

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
    }
}
