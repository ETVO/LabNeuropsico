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

            //Connection.Open();

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

        private void Master_Click(object sender, EventArgs e)
        {
        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            iniciar();
        }

        private void iniciar()
        {
            Index index = new Index();
            //Pacientes.Visualizar index = new Pacientes.Visualizar();
            this.Hide();
            index.ShowDialog();
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
