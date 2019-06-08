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
    public partial class ConsultaGeral : Form
    {
        public long id_paciente;
        private DataTable cleandt = new DataTable();

        private bool visualizar = false;

        public ConsultaGeral()
        {
            InitializeComponent();
            this.visualizar = false;
        }

        public ConsultaGeral(bool visualizar)
        {
            InitializeComponent();
            this.visualizar = visualizar;
        }

        void ajustesDGV()
        {
            List<string> colunas = new List<string>();
            colunas.Add("Id");
            colunas.Add("Nome");
            colunas.Add("Data de Nascimento");
            colunas.Add("Hospital");
            colunas.Add("Diagnóstico médico");
            colunas.Add("Status");

            for (int c = 0; c < colunas.Count; c++)
            {
                dgvPacientes.Columns[c].HeaderText = colunas[c];

                if(colunas[c] == "Id")
                {
                    dgvPacientes.Columns[c].Visible = false;
                }
            }

            char hospital;
            DataGridViewCell cell_hospital;

            for (int r = 0; r < dgvPacientes.Rows.Count; r++)
            {
                cell_hospital = dgvPacientes.Rows[r].Cells[3];
                hospital = Convert.ToChar(cell_hospital.Value);
                if (hospital == 'h') cell_hospital.Value = "HRAC";
                else if (hospital == 'f') cell_hospital.Value = "FOB";
                else cell_hospital.Value = "Ambos";
            }

            if (dgvPacientes.Rows.Count == 0)
                lblNenhum.Visible = true;

        }

        void buscar()
        {
            lblNenhum.Visible = false;

            string sql = "SELECT id_paciente, nome, data_nasc, hospital, condicao, " +
                "CASE WHEN excluido IS TRUE THEN 'Excluído' ELSE 'Disponível' END " +
                "FROM paciente WHERE true ";

            string busca = txtBusca.Text.ToLower();

            // Modo de busca
            if (checkNome.Checked)
                sql += "AND lower(nome) LIKE '%" + busca + "%' ";
            if (checkCondicao.Checked)
                sql += "AND lower(condicao) LIKE '%" + busca + "%' ";

            // Hospital
            if (checkHRAC.Checked)
            {
                if (checkFOB.Checked)
                {
                    sql += "AND (hospital = 'h' OR hospital = 'f' OR hospital = 'a') ";
                }
                else
                {
                    sql += "AND hospital = 'h' ";
                }
            }
            else if (checkFOB.Checked)
                sql += "AND hospital = 'f' ";
            else
                sql += "AND hospital = 'a' ";

            //// Nacionalidade
            //if (checkBrasileiro.Checked)
            //{
            //    if (checkEstrangeiro.Checked)
            //    {
            //        sql += "AND (nacionalidade = 'b' OR nacionalidade = 'e') ";
            //    }
            //    else
            //    {
            //        sql += "AND nacionalidade = 'b' ";
            //    }
            //}
            //else if (checkEstrangeiro.Checked)
            //    sql += "AND nacionalidade = 'e' ";
            //else
            //{
            //    sql += "AND (nacionalidade = 'b' OR nacionalidade = 'e' OR nacionalidade = 'n') ";
            //}

            // Mostrar pacientes excluídos?
            if (!checkExcluido.Checked)
                sql += "AND excluido = false ";

            // Ordenar por nome (A-Z)
            sql += "ORDER BY nome ASC ";

            dgvPacientes.DataSource = Servico.PopDataTable(sql);
            ajustesDGV();
        }

        void limpaDGV()
        {
            dgvPacientes.DataSource = cleandt;
            ajustesDGV();
        }

        private void ConsultaGeral_Load(object sender, EventArgs e)
        {
            if(visualizar)
            {
                btnVoltar.Text = "Cancelar";
            }
            string sql = "SELECT id_paciente, nome, data_nasc, hospital, condicao, CASE WHEN excluido IS TRUE THEN 'Excluído' ELSE 'Disponível' END FROM paciente WHERE false = true ";
            cleandt = Servico.PopDataTable(sql);
            limpaDGV();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            buscar();
        }

        private void checkNome_CheckedChanged(object sender, EventArgs e)
        {
            if (checkNome.Checked)
                checkCondicao.Checked = false;
            else
            {
                if (!checkCondicao.Checked)
                {
                    Util.Alert("Um dos modos de busca deve estar ativo!", MessageBoxIcon.Error);
                    checkNome.Checked = true;
                }
            }
        }

        private void checkCondicao_CheckedChanged(object sender, EventArgs e)
        {
            if (checkCondicao.Checked)
                checkNome.Checked = false;
            else
            {
                if (!checkNome.Checked)
                {
                    Util.Alert("Um dos modos de busca deve estar ativo!", MessageBoxIcon.Error);
                    checkCondicao.Checked = true;
                }
            }
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            if (visualizar)
            {
                this.DialogResult = DialogResult.Cancel;
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

        private void btnFechar_Click(object sender, EventArgs e)
        {
            if (Util.Confirm("Deseja realmente fechar o sistema?"))
            {
                this.Close();
            }
        }

        private void dgvPacientes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void dgvPacientes_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                id_paciente = (long)dgvPacientes.Rows[e.RowIndex].Cells[0].Value;
                if (visualizar)
                {
                    this.DialogResult = DialogResult.OK;
                }
                else
                {
                    Util.DisposeForm("Pacientes.Visualizar");

                    Visualizar visualizar = new Visualizar(id_paciente);
                    this.Hide();
                    visualizar.ShowDialog();
                    this.Close();
                }
            }
        }

        private void txtBusca_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == '\r')
            {
                buscar();
            }
        }
    }
}
