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
    public partial class Visualizar : Form
    {
        private long id_paciente;
        private Paciente paciente;
        private bool consulta = false;
        private bool cadastro = false;
        private DataTable cleandt = new DataTable();

        public Visualizar()
        {
            InitializeComponent();
        }

        public Visualizar(long id_paciente)
        {
            InitializeComponent();
            this.id_paciente = id_paciente;
            this.consulta = true;
        }

        public Visualizar(long id_paciente, bool cadastro)
        {
            InitializeComponent();
            this.id_paciente = id_paciente;
            this.cadastro = true;
        }

        void visualizarClick()
        {
            if (String.IsNullOrEmpty(txtId.Text))
            {
                Util.Alert("Preencha um id ou busque o paciente desejado!", MessageBoxIcon.Error);
                limparCampos();
            }
            else
            {
                try
                {
                    id_paciente = Convert.ToInt64(txtId.Text);
                    fillFields();
                    relFields();
                }
                catch (Exception)
                {
                    Util.Alert("Valor inválido para id! Deve ser um número!", MessageBoxIcon.Error);
                    limparCampos();
                }
            }
        }

        void fillFields()
        {
            paciente = Servico.BuscarPaciente(id_paciente);

            if (paciente != null) //achou paciente compatível
            {
                if (paciente.Excluido)
                {
                    if (!Util.Confirm("Paciente (" + paciente.Nome + ") excluíd" + paciente.GetArtigo() + ". \nDeseja recuperar o registro?"))
                    {
                        limparCampos();
                        fieldsEnabled(false);

                        if (consulta)
                        {
                            Util.DisposeForm("Pacientes.ConsultaGeral");

                            ConsultaGeral cg = new ConsultaGeral();
                            this.Hide();
                            cg.ShowDialog();
                            this.Close();
                        }

                        return;
                    }
                    else
                    {
                        Servico.PacienteExcluido(paciente, false);

                        paciente = Servico.BuscarPaciente(id_paciente);
                    }
                }

                string lateralidade = "Não informado";
                string sexo = "Masculino";
                string nacionalidade = "Estrangeiro";
                string hospital = "HRAC";

                if (paciente.Lateralidade == 'a') lateralidade = "Ambidestro";
                if (paciente.Lateralidade == 's') lateralidade = "Sinistro";
                if (paciente.Lateralidade == 'd') lateralidade = "Destro";

                if (paciente.Sexo == 'f') sexo = "Feminino";

                if (paciente.Nacionalidade == 'b') nacionalidade = "Brasileiro";
                if (paciente.Nacionalidade == 'n') nacionalidade = "Não informado";

                if (paciente.Hospital == 'f') hospital = "FOB";
                if (paciente.Hospital == 'a') hospital = "Ambos";

                txtId.Text = paciente.Id_Paciente.ToString();
                lblNome.Text = paciente.Nome;
                lblDataNasc.Text = paciente.Data_Nasc.ToShortDateString();
                lblLateralidade.Text = lateralidade;
                lblEscolaridade.Text = paciente.Escolaridade;
                lblSexo.Text = sexo;
                lblNacionalidade.Text = nacionalidade;
                lblResponsavel.Text = paciente.Responsavel;
                lblOcupacaoResponsavel.Text = paciente.Ocupacao_Responsavel;
                lblHospital.Text = hospital;
                lblProntuario.Text = paciente.Prontuario;
                txtCondicao.Text = paciente.Condicao;
                fieldsEnabled(true);
            }
            else
            {
                Util.Alert("Paciente não encontrado(a)!", MessageBoxIcon.Error);
                limparCampos();
                fieldsEnabled(false);
            }
        }

        void limparCampos()
        {
            txtId.Text = "";
            lblNome.Text = "";
            lblDataNasc.Text = "";
            lblLateralidade.Text = "";
            lblEscolaridade.Text = "";
            lblSexo.Text = "";
            lblNacionalidade.Text = "";
            lblResponsavel.Text = "";
            lblOcupacaoResponsavel.Text = "";
            lblHospital.Text = "";
            lblProntuario.Text = "";
            txtCondicao.Text = "";
            paciente = null;
        }

        void fieldsEnabled(bool enabled)
        {
            controlPaciente.Enabled = enabled;
            if (!enabled)
                txtId.Focus();
        }

        void voltar()
        {
            if (consulta)
            {
                Util.DisposeForm("Pacientes.ConsultaGeral");

                ConsultaGeral cg = new ConsultaGeral();
                this.Hide();
                cg.ShowDialog();
                this.Close();
            }
            else if (cadastro)
            {
                Util.DisposeForm("Pacientes.Cadastro");

                Cadastro cadastro = new Cadastro();
                this.Hide();
                cadastro.ShowDialog();
                this.Close();
            }
            else
            {
                Util.DisposeForm("Pacientes.Main");

                Main main = new Main();
                this.Hide();
                main.ShowDialog();
                this.Close();
            }
        }

        void relFields()
        {
            lblNenhum.Visible = false;

            string sql = "SELECT id_relatorio, num_relatorio, queixa_clinica, inicio_aval, " +
                "fim_aval, CASE WHEN r.excluido IS TRUE THEN 'Excluído' ELSE 'Disponível' END " +
                "FROM relatorio AS r INNER JOIN paciente AS p ON p.id_paciente = r.id_paciente WHERE r.id_paciente = " + id_paciente + " ";

            if (!checkExcluido.Checked)
                sql += "AND r.excluido = false ";

            sql += "ORDER BY inicio_aval ASC ";

            dgvRelatorios.DataSource = Servico.PopDataTable(sql);
            ajustesDGV();
        }



        void ajustesDGV()
        {
            List<string> colunas = new List<string>();
            colunas.Add("Id");
            colunas.Add("Num. relatório");
            colunas.Add("Queixa clínica");
            colunas.Add("Início da avaliação");
            colunas.Add("Fim da avaliação");
            colunas.Add("Status");

            for (int c = 0; c < colunas.Count; c++)
            {
                dgvRelatorios.Columns[c].HeaderText = colunas[c];

                if (colunas[c] == "Id")
                {
                    dgvRelatorios.Columns[c].Visible = false;
                }
            }

            if (dgvRelatorios.Rows.Count == 0)
                lblNenhum.Visible = true;
        }

        void limpaDGV()
        {
            dgvRelatorios.DataSource = cleandt;
            ajustesDGV();
        }

        private void Visualizar_Load(object sender, EventArgs e)
        {
            if (consulta || cadastro)
            {
                txtId.Enabled = false;
                btnVisualizar.Visible = false;
                btnPesquisar.Visible = false;
                fillFields();
            }
            else
            {
                controlPaciente.Enabled = false;
                limparCampos();
                txtId.Focus();
            }

            txtId.Focus();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            voltar();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            if (Util.Confirm("Deseja realmente fechar o sistema?"))
            {
                this.Close();
            }
        }

        private void btnVisualizar_Click(object sender, EventArgs e)
        {
            visualizarClick();
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            Util.DisposeForm("Pacientes.ConsultaGeral");

            ConsultaGeral cg = new ConsultaGeral(true);
            this.Hide();
            cg.ShowDialog();
            this.Show();

            if (cg.DialogResult != DialogResult.Cancel)
            {
                id_paciente = cg.id_paciente;
                fillFields();
                relFields();
            }
            else
            {
                limparCampos();
                fieldsEnabled(false);
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (Util.Confirm("Deseja realmente excluir esse paciente?"))
            {
                Servico.PacienteExcluido(paciente, true);
                Util.Alert("Paciente excluíd" + paciente.GetArtigo() + " com sucesso!", MessageBoxIcon.Information);
                limparCampos();
                fieldsEnabled(false);
                if(consulta)
                {
                    Util.DisposeForm("Pacientes.ConsultaGeral");

                    ConsultaGeral cg = new ConsultaGeral();
                    this.Hide();
                    cg.ShowDialog();
                    this.Close();
                }
                else if(cadastro)
                {
                    Util.DisposeForm("Pacientes.Cadastro");

                    Cadastro cadastro = new Cadastro();
                    this.Hide();
                    cadastro.ShowDialog();
                    this.Close();
                }
            }
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            if (id_paciente == 0)
            {
                Util.Alert("Nenhum paciente foi selecionado!", MessageBoxIcon.Error);
                if (consulta || cadastro)
                    voltar();
            }
            else
            {
                Util.DisposeForm("Pacientes.AlterarPaciente");

                AlterarRelatorio alterar = new AlterarRelatorio(id_paciente);
                this.Hide();
                alterar.ShowDialog();
                this.Show();
                if(alterar.DialogResult == DialogResult.OK)
                {
                    fillFields();
                }
                else if (alterar.DialogResult == DialogResult.Abort)
                {
                    this.Close();
                }
            }
        }

        private void tabRelatorios_Layout(object sender, LayoutEventArgs e)
        {
            string sql = "SELECT id_relatorio, num_relatorio, queixa_clinica, inicio_aval, fim_aval, CASE WHEN excluido IS TRUE THEN 'Excluído' ELSE 'Disponível' END FROM relatorio WHERE false = true";
            cleandt = Servico.PopDataTable(sql);
            limpaDGV();
            relFields();
        }

        private void checkExcluido_CheckedChanged(object sender, EventArgs e)
        {
            limpaDGV();
            relFields();
        }

        private void btnCadastrarRelatorio_Click(object sender, EventArgs e)
        {
            Util.DisposeForm("Pacientes.Relatorios.Cadastro");

            Relatorios.Cadastro cadastro_rel = new Relatorios.Cadastro(paciente);

            this.Hide();
            cadastro_rel.ShowDialog();
            this.Show();

            if (cadastro_rel.DialogResult == DialogResult.OK)
            {
                relFields();
            }
            else if (cadastro_rel.DialogResult == DialogResult.Abort)
            {
                this.Close();
            }

        }

        private void txtId_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyValue == '\r')
            {
                visualizarClick();

                void visualizar()
                {
                    if (String.IsNullOrEmpty(txtId.Text))
                    {
                        Util.Alert("Preencha um id ou busque o paciente desejado!", MessageBoxIcon.Error);
                        limparCampos();
                    }
                    else
                    {
                        try
                        {
                            id_paciente = Convert.ToInt64(txtId.Text);
                            fillFields();
                        }
                        catch (Exception)
                        {
                            Util.Alert("Valor inválido para id! Deve ser um número!", MessageBoxIcon.Error);
                            limparCampos();
                        }
                    }
                }
            }
        }

        private void dgvRelatorios_SelectionChanged(object sender, EventArgs e)
        {
            //dgvRelatorios.ClearSelection();
        }

        private void tabRelatorios_Click(object sender, EventArgs e)
        {

        }

        private void btnExcluirRelatorio_Click(object sender, EventArgs e)
        {
            if(Util.Confirm("Deseja realmente excluir este relatório?"))
            {
                int index = 0;
                long id = 0;
                Relatorio r;
                foreach (DataGridViewRow row in dgvRelatorios.Rows)
                {
                    if (row.Selected)
                    {
                        index = row.Index;
                        id = Convert.ToInt64(row.Cells[0].Value);
                        dgvRelatorios.Rows.RemoveAt(index);
                        r = Servico.BuscarRelatorio(id);
                        Servico.RelatorioExcluido(r, true);
                        Util.Alert("Relatório excluído com sucesso!", MessageBoxIcon.Information);
                        break;
                    }
                }

                ajustesDGV();
                relFields();
            }
        }

        private void btnVisualizarRelatorio_Click(object sender, EventArgs e)
        {
            Relatorio relatorio;
            long sel_id = 0;
            foreach (DataGridViewRow row in dgvRelatorios.Rows)
            {
                if (row.Selected)
                {
                    sel_id = Convert.ToInt64(row.Cells[0].Value);
                    break;
                }
            }
            if(sel_id != 0)
            {
                relatorio = Servico.BuscarRelatorio(sel_id);
                Util.DisposeForm("Pacientes.Relatorios.Visualizar");

                Relatorios.Visualizar visualizar = new Relatorios.Visualizar(relatorio);
                this.Hide();
                visualizar.ShowDialog();
                this.Show();

                if (visualizar.DialogResult == DialogResult.OK)
                {
                    relFields();
                }
                else if (visualizar.DialogResult == DialogResult.Abort)
                {
                    this.Close();
                }
            }
        }

        private void dgvRelatorios_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Relatorio relatorio;
            long sel_id;

            if (e.RowIndex >= 0)
            {
                sel_id = (long)dgvRelatorios.Rows[e.RowIndex].Cells[0].Value;
                relatorio = Servico.BuscarRelatorio(sel_id);
                Util.DisposeForm("Pacientes.Relatorios.Visualizar");


                Relatorios.Visualizar visualizar = new Relatorios.Visualizar(relatorio);
                this.Hide();
                visualizar.ShowDialog();
                this.Show();

                if (visualizar.DialogResult == DialogResult.OK)
                {
                    relFields();
                }
                else if (visualizar.DialogResult == DialogResult.Abort)
                {
                    this.Close();
                }
            }
        }
    }
}
