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
using LabNeuropsico.Guia;

namespace LabNeuropsico.Pacientes.Relatorios.Avaliacoes
{
    public partial class Cadastro : Form
    {
        private Instrumento instrumento;
        private Relatorio relatorio;
        private DataTable cleandt = new DataTable();
        int iatual = -1, iant = -1;

        public Cadastro()
        {
            InitializeComponent();
        }

        public Cadastro(Relatorio relatorio)
        {
            InitializeComponent();
            this.relatorio = relatorio;
        }

        void listarInstrumentos()
        {
            List<Instrumento> instrumentos = Servico.ListarInstrumentos();
            cmbInstrumento.Items.Clear();

            foreach (Instrumento instrumento in instrumentos)
            {
                cmbInstrumento.Items.Add(instrumento.Id_Instrumento + " - " + instrumento.Nome);
            }

            cmbInstrumento.SelectedIndex = -1;
            cmbInstrumento.Focus();
        }

        void ajustesDGV()
        {
            List<string> colunas = new List<string>();
            colunas.Add("Id");
            colunas.Add("Campo");
            colunas.Add("Tipo");
            colunas.Add("Valor");

            int c;

            for (c = 0; c < colunas.Count; c++)
            {
                dgvCampos.Columns[c].HeaderText = colunas[c];
                if (colunas[c] == "Valor")
                    dgvCampos.Columns[c].ReadOnly = false;
                else
                    dgvCampos.Columns[c].ReadOnly = true;

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

        void atualizaCampos()
        {
            long id_instrumento = 0;
            string ins_sel = cmbInstrumento.Text;
            int strindex = ins_sel.IndexOf(" - ");
            id_instrumento = Convert.ToInt64(ins_sel.Substring(0, strindex));

            instrumento = Servico.BuscarInstrumento(id_instrumento);
            if(instrumento.Id_Instrumento == 0)
            {
                cmbInstrumento.SelectedIndex = -1;
                listarInstrumentos();
                limpaDGV();

                return;
            }

            lblTipo.Visible = true;
            lblTipoLegenda.Visible = true;
            lblNenhum.Visible = false;

            lblTipo.Text = instrumento.Tipo;

            string sql = "SELECT id_campo, nome, " +
                "CASE WHEN tipo = 'vint' THEN 'Nº Inteiro' WHEN tipo = 'vdate' THEN 'Data' WHEN tipo = 'vdouble' THEN 'Nº decimal' ELSE 'Texto' END, " +
                "'' FROM campo WHERE excluido = false AND id_instrumento = " + instrumento.Id_Instrumento + " ";

            dgvCampos.DataSource = Servico.PopDataTable(sql);
            ajustesDGV();
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

        private void Cadastro_Load(object sender, EventArgs e)
        {
            string sql = "SELECT id_campo, nome, tipo, '' FROM campo WHERE false = true ";
            cleandt = Servico.PopDataTable(sql);
            listarInstrumentos();
            limpaDGV();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            voltar(false);
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            voltar(true);
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if(Util.Confirm("Deseja realmente salvar?"))
            {
                try
                {
                    Avaliacao avaliacao = new Avaliacao();
                    avaliacao.SetProperties(0, instrumento.Id_Instrumento, relatorio.Id_Relatorio, false);

                    avaliacao.Id_Avaliacao = Servico.SalvarAvaliacaoId(avaliacao);

                    long id_campo;
                    Campo campo;

                    Valor valor;

                    string cellvalue;

                    foreach (DataGridViewRow row in dgvCampos.Rows)
                    {
                        id_campo = Convert.ToInt64(row.Cells[0].Value);
                        campo = Servico.BuscarCampo(id_campo);

                        cellvalue = row.Cells[3].Value.ToString();

                        valor = new Valor();
                        valor.Id_Avaliacao = avaliacao.Id_Avaliacao;
                        valor.Id_Campo = campo.Id_Campo;
                        valor.SetValue(campo.Tipo, cellvalue);

                        Servico.SalvarValor(valor);
                    }

                    Util.Alert("Avaliação cadastrada com sucesso!");

                    voltar(true);
                }
                catch(Exception ex)
                {
                    Util.Alert("Algo deu errado!\n\nMais detalhes: " + ex.Message, MessageBoxIcon.Error);
                }
            }
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            if(Util.Confirm("Deseja realmente limpar todos os campos?"))
            {
                limpaDGV();
                listarInstrumentos();
            }
        }

        private void linkAjuda_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Util.Alert(Ajuda.Guia("CadastroAvaliacao"));
        }

        private void lblTipo_Click(object sender, EventArgs e)
        {

        }

        private void cmbInstrumento_SelectedIndexChanged(object sender, EventArgs e)
        {
            iatual = cmbInstrumento.SelectedIndex;

            if (iatual != -1)
            {
                //if(iant != -1)
                //{
                //    if (Util.Confirm("Deseja realmente limpar todos os campos e escolher um novo instrumento?"))
                //    {
                //        atualizaCampos();
                //        iant = iatual;
                //    }
                //    else
                //    {
                //        cmbInstrumento.SelectedIndex = iant;
                //    }
                //}
                //else
                //{
                //    atualizaCampos();
                //    iant = iatual;
                //}

                atualizaCampos();
                iant = iatual;
            }
            iant = iatual;
        }
    }
}
