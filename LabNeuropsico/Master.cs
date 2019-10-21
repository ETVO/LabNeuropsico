using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using LabNeuropsico.Model;
using LabNeuropsico.Model.Suporte;

namespace LabNeuropsico
{
    public partial class Master : Form
    {
        private bool verTick = false;

        public Master()
        {
            InitializeComponent();
        }

        private void Master_Load(object sender, EventArgs e)
        {
            /*
            while(true)
            {
                if (!Util.CheckInstalled("PostgreSQL"))
                {
                    if (Util.Confirm("Você precisa instalar o banco de dados para o sistema funcionar corretamente.\n\nDeseja continuar?"))
                        System.Diagnostics.Process.Start(@"Resources/postgresql.exe");
                    else
                    {
                        Application.Exit();
                    }
                }
                else
                {
                    break;
                }
            }
            */

            if (!Connection.CheckTables())
            {
                Connection.CreateTables();
                
                verTick = true;
                timer.Enabled = true;
            }
            else
            {
                iniciar();
            }

            //Connection.Close();
        }

        private void Master_Click(object sender, EventArgs e){}

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            iniciar();
        }

        private void iniciar()
        {
            Login login = new Login();
            this.Hide();
            login.ShowDialog();
            this.Close();
        }

        private void creating()
        {
            this.Show();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            if (verTick)
            {
                verTick = false;
                iniciar();
            }
        }
    }
}
