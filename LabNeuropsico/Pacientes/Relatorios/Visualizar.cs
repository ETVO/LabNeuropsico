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
    public partial class Visualizar : Form
    {
        Relatorio relatorio = new Relatorio();
        Paciente paciente;
        private DataTable cleandt = new DataTable();
        bool cadastro = false;

        public Visualizar()
        {
            InitializeComponent();
        }

        public Visualizar(Relatorio relatorio)
        {
            InitializeComponent();
            this.relatorio = relatorio;
            this.cadastro = false;
        }

        public Visualizar(Relatorio relatorio, bool cadastro)
        {
            InitializeComponent();
            this.relatorio = relatorio;
            this.cadastro = cadastro;
        }
        
        void fillFields()
        {
            if(relatorio.Excluido)
            {
                if (!Util.Confirm("Relatorio excluído. \nDeseja recuperar o registro?"))
                {
                    voltar(true);
                    return;
                }
                else
                {
                    Servico.RelatorioExcluido(relatorio, false);

                    relatorio = Servico.BuscarRelatorio(relatorio.Id_Relatorio);
                }
            }
            lblNome.Text = paciente.Nome;
            lblInicioAval.Text = relatorio.Inicio_Aval.ToShortDateString();
            lblFimAval.Text = relatorio.Fim_Aval.ToShortDateString();
            txtQueixa.Text = relatorio.Queixa_Clinica;
            lblNumRelatorio.Text = relatorio.Num_Relatorio;
        }

        void voltar(bool ok)
        {
            if(ok)
            {
                this.DialogResult = DialogResult.OK;
            }
            else
            {
                this.DialogResult = DialogResult.Abort;
            }
        }

        void ajustesDGV()
        {
            List<string> colunas = new List<string>();
            colunas.Add("Id");
            colunas.Add("Instrumento utilizado");
            colunas.Add("Tipo de Avaliação");
            colunas.Add("Status");

            for (int c = 0; c < colunas.Count; c++)
            {
                dgvAvaliacoes.Columns[c].HeaderText = colunas[c];

                if (colunas[c] == "Id")
                {
                    dgvAvaliacoes.Columns[c].Visible = false;
                }
            }

            if (dgvAvaliacoes.Rows.Count == 0)
                lblNenhum.Visible = true;
            else
                lblNenhum.Visible = false;
        }

        void limpaDGV()
        {
            dgvAvaliacoes.DataSource = cleandt;
            ajustesDGV();
        }

        void avalFields()
        {
            string sql = "SELECT id_avaliacao, i.nome, i.tipo, " +
                "CASE WHEN a.excluido IS TRUE THEN 'Excluído' ELSE 'Disponível' END " +
                "FROM avaliacao AS a INNER JOIN instrumento AS i ON a.id_instrumento = i.id_instrumento " +
                "WHERE a.id_relatorio = " + relatorio.Id_Relatorio + " ";
            
            if (!checkExcluido.Checked)
                sql += "AND a.excluido = false ";

            sql += "AND i.excluido = FALSE ORDER BY i.nome ASC ";

            dgvAvaliacoes.DataSource = Servico.PopDataTable(sql);
            ajustesDGV();
        }

        private void Visualizar_Load(object sender, EventArgs e)
        {
            paciente = Servico.BuscarPaciente(relatorio.Id_Paciente);

            fillFields();
            if(cadastro)
                controlRelatorio.SelectedIndex = 1;
            else
                controlRelatorio.SelectedIndex = 0;
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            if (Util.Confirm("Deseja realmente fechar o sistema?"))
            {
                voltar(false);
            }
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            voltar(true);
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            Util.DisposeForm("Pacientes.Relatorios.AlterarRelatorio");

            AlterarRelatorio alterar = new AlterarRelatorio(paciente, relatorio);
            this.Hide();
            alterar.ShowDialog();
            this.Show();
            if (alterar.DialogResult == DialogResult.OK)
            {
                fillFields();
            }
            else if (alterar.DialogResult == DialogResult.Abort)
            {
                this.Close();
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if(Util.Confirm("Deseja realmente excluir este relatório?"))
            {
                Servico.RelatorioExcluido(relatorio, true);
                Util.Alert("Relatório excluído com sucesso!", MessageBoxIcon.Information);
                voltar(true);
            }
        }

        private void tabAvaliacoes_Layout(object sender, LayoutEventArgs e)
        {
            string sql = "SELECT id_relatorio, id_avaliacao, id_instrumento, excluido FROM avaliacao WHERE false = true ";
            cleandt = Servico.PopDataTable(sql);
            limpaDGV();
            if(relatorio != null)
                avalFields();
        }

        private void btnCadastrarAvaliacao_Click(object sender, EventArgs e)
        {
            Util.DisposeForm("Pacientes.Relatorios.Avaliacoes.Cadastro");

            Avaliacoes.Cadastro cadastro = new Avaliacoes.Cadastro(relatorio);
            this.Hide();
            cadastro.ShowDialog();
            this.Show();
            
            if(cadastro.DialogResult == DialogResult.OK)
            {
                avalFields();
            }
            else if(cadastro.DialogResult == DialogResult.Abort)
            {
                voltar(false);
            }
        }

        private void btnVisualizarAvaliacao_Click(object sender, EventArgs e)
        {
            Avaliacao avaliacao;
            long sel_id = 0;
            foreach (DataGridViewRow row in dgvAvaliacoes.Rows)
            {
                if (row.Selected)
                {
                    sel_id = Convert.ToInt64(row.Cells[0].Value);
                    break;
                }
            }
            if (sel_id != 0)
            {
                avaliacao = Servico.BuscarAvaliacao(sel_id);

                Util.DisposeForm("Pacientes.Relatorios.Avaliacoes.Visualizar");
                Avaliacoes.Visualizar visualizar = new Avaliacoes.Visualizar(relatorio, avaliacao);
                this.Hide();
                visualizar.ShowDialog();
                this.Show();

                if (visualizar.DialogResult == DialogResult.OK)
                {
                    avalFields();
                }
                else if (visualizar.DialogResult == DialogResult.Abort)
                {
                    voltar(false);
                }
            }
        }

        private void dgvAvaliacoes_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Avaliacao avaliacao;
            long sel_id;

            if (e.RowIndex >= 0)
            {
                sel_id = (long)dgvAvaliacoes.Rows[e.RowIndex].Cells[0].Value;
                avaliacao = Servico.BuscarAvaliacao(sel_id);

                Util.DisposeForm("Pacientes.Relatorios.Avaliacoes.Visualizar");
                Avaliacoes.Visualizar visualizar = new Avaliacoes.Visualizar(relatorio, avaliacao);
                this.Hide();
                visualizar.ShowDialog();
                this.Show();

                if (visualizar.DialogResult == DialogResult.OK)
                {
                    avalFields();
                }
                else if (visualizar.DialogResult == DialogResult.Abort)
                {
                    voltar(false);
                }
            }
        }

        private void btnExcluirAvaliacao_Click(object sender, EventArgs e)
        {
            if(Util.Confirm("Deseja realmente excluir essa avaliação?"))
            {
                Avaliacao avaliacao;
                long sel_id = 0;
                foreach (DataGridViewRow row in dgvAvaliacoes.Rows)
                {
                    if (row.Selected)
                    {
                        sel_id = Convert.ToInt64(row.Cells[0].Value);
                        break;
                    }
                }
                if (sel_id != 0)
                {
                    avaliacao = Servico.BuscarAvaliacao(sel_id);

                    Servico.AvaliacaoExcluido(avaliacao, true);

                    avalFields();
                }
            }
        }

        private void checkExcluido_CheckedChanged(object sender, EventArgs e)
        {
            avalFields();
        }
    }
}
