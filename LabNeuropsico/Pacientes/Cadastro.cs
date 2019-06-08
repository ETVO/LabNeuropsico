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
    public partial class Cadastro : Form
    {
        public Cadastro()
        {
            InitializeComponent();
        }

        private void Cadastro_Load(object sender, EventArgs e)
        {
            DateTime today = DateTime.Today.Date;
            dataNasc.MaxDate = today;
            dataNasc.Value = today;
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
            Util.DisposeForm("Pacientes.Main");

            Main main = new Main();
            this.Hide();
            main.ShowDialog();
            this.Close();
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            if(!Util.FieldsEmpty(Controls))
            {
                if(Util.Confirm("Deseja realmente limpar os campos e iniciar um novo cadastro?"))
                {
                    Util.CleanFields(Controls);
                }
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (!cons())
                Util.Alert("Alguns campos obrigatórios ficaram sem ser preenchidos!",
                    MessageBoxIcon.Error);
            else
            {
                //Paciente p = new Paciente();

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

                Paciente p = new Paciente();
                p.SetProperties(0, nome, data_nasc, lateralidade, escolaridade, sexo, nacionalidade,
                    responsavel, ocup_responsavel, prontuario, hospital, condicao, false);
                long id_paciente = Servico.SalvarPacienteId(p);
                Util.Alert("Paciente " + nome + " cadastrad" + p.GetArtigo() + " com sucesso!");

                Util.DisposeForm("Pacientes.Visualizar");

                Visualizar visualizar = new Visualizar(id_paciente, true);
                this.Hide();
                visualizar.ShowDialog();
                this.Close();
            }
        }

        bool cons()
        {
            if (txtNome.Text == "") return false;
            if (dataNasc.Value == dataNasc.MaxDate) return false;
            if (cmbSexo.SelectedIndex == -1) return false;
            if (cmbHospital.SelectedIndex == -1) return false;
            if (txtCondicao.Text == "") return false;

            return true;
        }
    }
}
