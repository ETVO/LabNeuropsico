using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LabNeuropsico.Model.Entidades;
using LabNeuropsico.Model;

namespace LabNeuropsico.Instrumentos
{
    public partial class Visualizar : Form
    {
        Instrumento instrumento;
        DataTable cleandt;

        public Visualizar()
        {
            InitializeComponent();
        }

        public Visualizar(Instrumento instrumento)
        {
            InitializeComponent();

            this.instrumento = instrumento;
        }

        void ajustesDGV()
        {
            lblNenhum.Visible = false;
            List<string> colunas = new List<string>();
            colunas.Add("Id");
            colunas.Add("Nome");
            colunas.Add("Tipo");

            for (int c = 0; c < colunas.Count; c++)
            {
                dgvCampos.Columns[c].HeaderText = colunas[c];

                if (colunas[c] == "Id")
                {
                    dgvCampos.Columns[c].Visible = false;
                }
            }

            if (dgvCampos.Rows.Count == 0)
                lblNenhum.Visible = true;
        }

        void limpaDGV()
        {
            dgvCampos.DataSource = cleandt;
            ajustesDGV();
        }

        void fillFields()
        {
            lblNome.Text = instrumento.Nome;
            lblTipo.Text = instrumento.Tipo;

            string sql = "SELECT id_campo, nome, " +
                "CASE WHEN tipo = 'vint' THEN 'Nº Inteiro' WHEN tipo = 'vdate' THEN 'Data' " +
                "WHEN tipo = 'vdouble' THEN 'Nº decimal' ELSE 'Texto' END " +
                "FROM campo WHERE id_instrumento = " + instrumento.Id_Instrumento;

            dgvCampos.DataSource = Servico.PopDataTable(sql);
            ajustesDGV();
        }

        private void Visualizar_Load(object sender, EventArgs e)
        {
            if (instrumento.Excluido) Servico.InstrumentoExcluido(instrumento, false);
            string sql = "SELECT id_campo, nome, tipo FROM campo WHERE false = true ";
            cleandt = Servico.PopDataTable(sql);
            limpaDGV();
            fillFields();
        }

        private void btnExcluirInstrumento_Click(object sender, EventArgs e)
        {
            if(Util.Confirm("Deseja realmente excluir esse instrumento?"))
            {
                Servico.InstrumentoExcluido(instrumento, true);
                Close();
            }
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
