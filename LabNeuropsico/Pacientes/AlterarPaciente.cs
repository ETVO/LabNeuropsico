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

namespace LabNeuropsico.Pacientes
{
    public partial class AlterarRelatorio : Form
    {
        private long id_paciente;
        private Paciente paciente;
        private bool same_form = true;

        public AlterarRelatorio()
        {
            InitializeComponent();
        }

        public AlterarRelatorio(long id_paciente)
        {
            this.id_paciente = id_paciente;
            this.same_form = false;
            InitializeComponent();
        }



        void fillFields()
        {
            paciente = Servico.BuscarPaciente(id_paciente);

            if (paciente != null) //achou paciente compatível
            {
                if (paciente.Excluido)
                {
                    Util.Alert("Paciente excluíd" + paciente.GetArtigo() + "!", MessageBoxIcon.Error);
                    voltar(false);
                }

                int lateralidade = 3;
                int sexo = 0;
                int nacionalidade = 2;
                int hospital = 0;

                if (paciente.Lateralidade == 'a') lateralidade = 0;
                if (paciente.Lateralidade == 's') lateralidade = 1;
                if (paciente.Lateralidade == 'd') lateralidade = 2;

                if (paciente.Sexo == 'f') sexo = 1;

                if (paciente.Nacionalidade == 'b') nacionalidade = 0;
                if (paciente.Nacionalidade == 'e') nacionalidade = 1;

                if (paciente.Hospital == 'f') hospital = 1;
                if (paciente.Hospital == 'a') hospital = 1;

                txtNome.Text = paciente.Nome;
                dataNasc.Value = paciente.Data_Nasc;
                cmbLateralidade.SelectedIndex = lateralidade;
                txtEscolaridade.Text = paciente.Escolaridade;
                cmbSexo.SelectedIndex = sexo;
                cmbNacionalidade.SelectedIndex = nacionalidade;
                txtResponsavel.Text = paciente.Responsavel;
                txtOcupacaoResponsavel.Text = paciente.Ocupacao_Responsavel;
                cmbHospital.SelectedIndex = hospital;
                txtProntuario.Text = paciente.Prontuario;
                txtCondicao.Text = paciente.Condicao;
            }
            else
            {
                Util.Alert("Paciente não encontrado(a)!", MessageBoxIcon.Error);
                Util.CleanFields(Controls);
                voltar(false);
            }
        }

        //void fieldsEnabled(bool enabled)
        //{
        //    Util.FieldsEnabled(Controls, enabled);
        //    txtId.Enabled = true;
        //    btnSalvar.Enabled = enabled;
        //    btnExcluir.Enabled = enabled;
        //    if (!enabled)
        //        txtId.Focus();
        //}

        void voltar(bool paciente_alterado)
        {
            if (paciente_alterado)
                this.DialogResult = DialogResult.OK;
            else
                this.DialogResult = DialogResult.Cancel;
        }

        private void VisualizarPaciente_Load(object sender, EventArgs e)
        {
            if (id_paciente == 0)
            {
                Util.Alert("Algo deu errado! Nenhum paciente foi selecionado!", MessageBoxIcon.Error);
                voltar(false);
            }
            else
                fillFields();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            if (Util.Confirm("Deseja realmente fechar o sistema?"))
            {
                this.DialogResult = DialogResult.Abort;
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (Util.Confirm("Deseja realmente salvar as alterações realizadas?"))
            {
                DateTime data_nasc = dataNasc.Value;

                string nome = txtNome.Text;
                string escolaridade = txtEscolaridade.Text;
                string responsavel = txtResponsavel.Text;
                string ocup_responsavel = txtOcupacaoResponsavel.Text;
                string prontuario = txtProntuario.Text;
                string condicao = txtCondicao.Text;

                char lateralidade = 'N';
                char nacionalidade = 'N';
                char sexo;
                char hospital;

                if (cmbLateralidade.SelectedIndex != -1)
                    lateralidade = Convert.ToChar(cmbLateralidade.Text.Substring(0, 1));

                if (cmbNacionalidade.SelectedIndex != -1)
                    nacionalidade = Convert.ToChar(cmbNacionalidade.Text.Substring(0, 1));
                sexo = Convert.ToChar(cmbSexo.Text.Substring(0, 1));
                hospital = Convert.ToChar(cmbHospital.Text.Substring(0, 1));
                
                paciente.SetProperties(id_paciente, nome, data_nasc, lateralidade, escolaridade, sexo, nacionalidade,
                    responsavel, ocup_responsavel, prontuario, hospital, condicao, false);
                Servico.AlterarPaciente(paciente);
                Util.Alert("Paciente alterad" + paciente.GetArtigo() + " com sucesso!", MessageBoxIcon.Information);
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
    }
}
