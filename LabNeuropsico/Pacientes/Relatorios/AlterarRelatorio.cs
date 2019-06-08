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
using LabNeuropsico.Model.Entidades;

namespace LabNeuropsico.Pacientes.Relatorios
{
    public partial class AlterarRelatorio : Form
    {
        private Paciente paciente;
        private Relatorio relatorio;

        public AlterarRelatorio()
        {
            InitializeComponent();
            voltar(false);
        }

        public AlterarRelatorio(Paciente paciente, Relatorio relatorio)
        {
            InitializeComponent();
            this.paciente = paciente;
            this.relatorio = relatorio;
        }

        void voltar(bool relatorio_alterado)
        {
            if (relatorio_alterado)
            {
                this.DialogResult = DialogResult.OK;
            }
            else
            {
                this.DialogResult = DialogResult.Cancel;
            }
        }

        bool cons()
        {
            if (txtQueixaClinica.Text == "") return false;
            return true;
        }

        void cad_aval()
        {
            Util.DisposeForm("Pacientes.Relatorios.Visualizar");

            Visualizar visualizar = new Visualizar(relatorio, true);
            this.Hide();
            visualizar.ShowDialog();
            this.Show();

            if (visualizar.DialogResult == DialogResult.Abort)
            {
                this.DialogResult = DialogResult.Abort;
            }
            else
            {
                this.DialogResult = DialogResult.OK;
            }
        }

        void fillFields()
        {
            lblNome.Text = paciente.Nome;
            txtRelatorio.Text = relatorio.Num_Relatorio;
            txtQueixaClinica.Text = relatorio.Queixa_Clinica;
            dataInicioAval.Value = relatorio.Inicio_Aval;
            dataFimAval.Value = relatorio.Fim_Aval;
        }

        private void AlterarRelatorio_Load(object sender, EventArgs e)
        {
            if (relatorio.Id_Relatorio == 0 || relatorio == null)
            {
                Util.Alert("Algo deu errado! Nenhum relatório foi selecionado!", MessageBoxIcon.Error);
                voltar(false);
            }
            else
            {
                fillFields();
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (!cons())
                Util.Alert("Alguns campos obrigatórios ficaram sem ser preenchidos!",
                    MessageBoxIcon.Error);
            else
            {

                DateTime inicio_aval = dataInicioAval.Value;
                DateTime fim_aval = dataFimAval.Value;

                string queixa_clinica = txtQueixaClinica.Text;

                string num_relatorio = txtRelatorio.Text;
                
                relatorio.SetProperties(relatorio.Id_Relatorio, paciente.Id_Paciente, num_relatorio,
                    queixa_clinica, inicio_aval, fim_aval, false);
                Servico.AlterarRelatorio(relatorio);
                Util.Alert("Relatório alterado com sucesso!", MessageBoxIcon.Information);
                voltar(true);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            voltar(false);
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            voltar(false);
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            if (Util.Confirm("Deseja realmente fechar o sistema?"))
            {
                this.DialogResult = DialogResult.Abort;
                this.Close();
            }
        }
    }
}
