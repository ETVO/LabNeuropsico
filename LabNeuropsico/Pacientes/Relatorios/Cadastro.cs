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
    public partial class Cadastro : Form
    {

        private Paciente paciente;
        private Relatorio relatorio;

        public Cadastro()
        {
            InitializeComponent();
            voltar(false);
        }

        public Cadastro(Paciente paciente)
        {
            InitializeComponent();
            this.paciente = paciente;
        }

        void voltar(bool cadastro_realizado)
        {
            if(cadastro_realizado)
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

        void view_aval()
        {
            Util.DisposeForm("Pacientes.Relatorios.Visualizar");

            Visualizar visualizar = new Visualizar(relatorio);
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

        private void CadastroRelatorio_Load(object sender, EventArgs e)
        {
            lblNome.Text = paciente.Nome;
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            if (Util.Confirm("Deseja realmente fechar o sistema?"))
            {
                DialogResult = DialogResult.Abort;
                this.Close();
            }
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            if (Util.Confirm("Deseja realmente cancelar esse cadastro?"))
            {
                voltar(false);
            }
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            if (!Util.FieldsEmpty(Controls))
            {
                Util.CleanFields(Controls);
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

                relatorio = new Relatorio();
                relatorio.SetProperties(0, paciente.Id_Paciente, num_relatorio,
                    queixa_clinica, inicio_aval, fim_aval, false);
                relatorio.Id_Relatorio = Servico.SalvarRelatorioId(relatorio);
                Util.Alert("Relatório cadastrado com sucesso!", MessageBoxIcon.Information);

                view_aval();
            }
        }
    }
}
