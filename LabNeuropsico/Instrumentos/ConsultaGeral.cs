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

namespace LabNeuropsico.Instrumentos
{
    public partial class ConsultaGeral : Form
    {
        private DataTable cleandt = new DataTable();

        public ConsultaGeral()
        {
            InitializeComponent();
        }

        void ajustesDGV()
        {
            List<string> colunas = new List<string>();
            colunas.Add("Id");
            colunas.Add("Nome");
            colunas.Add("Tipo");
            colunas.Add("N° Campos");
            colunas.Add("Status");

            for (int c = 0; c < colunas.Count; c++)
            {
                dgvInstrumentos.Columns[c].HeaderText = colunas[c];

                if (colunas[c] == "Id")
                {
                    dgvInstrumentos.Columns[c].Visible = false;
                }
            }

            if (dgvInstrumentos.Rows.Count == 0)
                lblNenhum.Visible = true;
        }

        void limpaDGV()
        {
            dgvInstrumentos.DataSource = cleandt;
            ajustesDGV();
        }

        void buscar()
        {
            lblNenhum.Visible = false;

            string sql = "SELECT i.id_instrumento, i.nome, i.tipo, COUNT(c.id_campo), " +
                "CASE WHEN i.excluido IS TRUE THEN 'Excluído' ELSE 'Disponível' END " +
                "FROM instrumento AS i INNER JOIN campo AS c " +
                "ON c.id_instrumento = i.id_instrumento " +
                "WHERE true ";

            string nome = txtBusca.Text.ToLower();
            string tipo = cmbTipoAval.Text.ToLower();

            if (tipo == "todas") tipo = "";

            sql += "AND lower(i.nome) LIKE '%" + nome + "%' ";

            sql += "AND lower(i.tipo) LIKE '%" + tipo + "%' ";

            // Mostrar pacientes excluídos?
            if (!checkExcluido.Checked)
                sql += "AND i.excluido = false ";

            // Ordenar por nome (A-Z)
            sql += "GROUP BY i.id_instrumento ORDER BY nome ASC ";

            dgvInstrumentos.DataSource = Servico.PopDataTable(sql);
            ajustesDGV();
        }


        private void btnBuscar_Click(object sender, EventArgs e)
        {
            buscar();
        }

        private void ConsultaGeral_Load(object sender, EventArgs e)
        {
            string sql = "SELECT id_instrumento, nome, tipo, '', excluido FROM instrumento WHERE false = true ";
            cleandt = Servico.PopDataTable(sql);
            limpaDGV();
            buscar();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            Util.DisposeForm("Instrumentos.Main");

            Main main = new Main();
            this.Hide();
            main.ShowDialog();
            this.Close();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            if (Util.Confirm("Deseja realmente fechar o sistema?"))
            {
                this.Close();
            }
        }

        private void dgvInstrumentos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            long sel_id = 0;
            Instrumento instrumento;

            if (e.RowIndex >= 0)
            {
                sel_id = Convert.ToInt64(dgvInstrumentos.Rows[e.RowIndex].Cells[0].Value);
                instrumento = Servico.BuscarInstrumento(sel_id);

                if (instrumento.Excluido)
                {
                    if (!Util.Confirm("Esse instrumento está excluído. Para visualizá-lo, você deve recuperar o registro.\n\nDeseja recuperar este instrumento?"))
                        return;
                }
                Util.DisposeForm("Instrumentos.Visualizar");

                Visualizar visualizar = new Visualizar(instrumento);
                visualizar.ShowDialog();
                buscar();
            }
        }

        string txtExc = "excluir";

        private void btnExcluirInstrumento_Click(object sender, EventArgs e)
        {
            if(Util.Confirm("Deseja realmente " + txtExc + " esse instrumento?"))
            {
                long sel_id = 0;
                foreach (DataGridViewRow row in dgvInstrumentos.Rows)
                {
                    if (row.Selected)
                    {
                        sel_id = Convert.ToInt64(row.Cells[0].Value);
                        break;
                    }
                }

                Instrumento instrumento;

                if (sel_id != 0)
                {
                    instrumento = Servico.BuscarInstrumento(sel_id);

                    if (instrumento.Excluido)
                    {
                        Servico.InstrumentoExcluido(instrumento, false);
                    }
                    else
                    {
                        Servico.InstrumentoExcluido(instrumento, true);
                    }

                    buscar();
                }
            }
        }

        private void btnVisualizar_Click(object sender, EventArgs e)
        {
            long sel_id = 0;
            foreach (DataGridViewRow row in dgvInstrumentos.Rows)
            {
                if (row.Selected)
                {
                    sel_id = Convert.ToInt64(row.Cells[0].Value);
                    break;
                }
            }

            Instrumento instrumento;

            if (sel_id != 0)
            {
                instrumento = Servico.BuscarInstrumento(sel_id);
                if(instrumento.Excluido)
                {
                    if (!Util.Confirm("Esse instrumento está excluído. Para visualizá-lo, você deve recuperar o registro.\n\nDeseja recuperar este instrumento?"))
                        return;
                }
                Util.DisposeForm("Instrumentos.Visualizar");

                Visualizar visualizar = new Visualizar(instrumento);
                visualizar.ShowDialog();
                buscar();
            }
        }

        private void dgvInstrumentos_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;

            long sel_id = Convert.ToInt64(dgvInstrumentos.Rows[index].Cells[0].Value);

            if (sel_id == 0) return;

            Instrumento instrumento = Servico.BuscarInstrumento(sel_id);
            if(instrumento.Excluido)
            {
                btnExcluirInstrumento.Text = "Recuperar selecionado";
                txtExc = "recuperar";
            }
            else
            {
                btnExcluirInstrumento.Text = "Excluir selecionado";
                txtExc = "excluir";
            }
        }
    }
}
