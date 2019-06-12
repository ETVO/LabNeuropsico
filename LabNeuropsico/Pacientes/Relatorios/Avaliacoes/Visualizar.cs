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

namespace LabNeuropsico.Pacientes.Relatorios.Avaliacoes
{
    public partial class Visualizar : Form
    {
        Relatorio relatorio = new Relatorio();
        Avaliacao avaliacao = new Avaliacao();
        Instrumento instrumento = new Instrumento();
        private DataTable cleandt = new DataTable();

        public Visualizar()
        {
            InitializeComponent();
        }

        public Visualizar(Relatorio relatorio, Avaliacao avaliacao)
        {
            InitializeComponent();
            this.relatorio = relatorio;
            this.avaliacao = avaliacao;
            instrumento = Servico.BuscarInstrumento(avaliacao.Id_Instrumento);
            string sql = "SELECT id_campo, nome, tipo, '' FROM campo WHERE false = true ";
            cleandt = Servico.PopDataTable(sql);
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
            if (instrumento.Id_Instrumento == 0)
            {
                Util.Alert("Nenhum instrumento foi selecionado! (Id = 0)", MessageBoxIcon.Error);
                voltar(true);
                return;
            }

            lblTipo.Visible = true;
            lblTipoLegenda.Visible = true;
            lblNenhum.Visible = false;

            lblTipo.Text = instrumento.Tipo;

            string sql = "SELECT v.id_valor, c.nome, " +
                "CASE WHEN c.tipo = 'vint' THEN 'Nº Inteiro' WHEN c.tipo = 'vdate' THEN 'Data' WHEN c.tipo = 'vdouble' THEN 'Nº decimal' ELSE 'Texto' END, " +
                "CASE WHEN c.tipo = 'vint' THEN v.vint::VARCHAR WHEN c.tipo = 'vdate' THEN to_char(v.vdate, 'DD/MM/YYYY') WHEN c.tipo = 'vdouble' THEN REPLACE(v.vdouble::VARCHAR, '.', ',') ELSE vtext END " +
                "FROM valor AS v INNER JOIN campo AS c ON c.id_campo = v.id_campo " +
                "WHERE v.excluido = false AND c.excluido = false AND v.id_avaliacao = " + avaliacao.Id_Avaliacao + ";";

            dgvCampos.DataSource = Servico.PopDataTable(sql);
            ajustesDGV();
        }

        void voltar(bool ok)
        {
            if (ok)
            {
                this.DialogResult = DialogResult.OK;
            }
            else
            {
                this.DialogResult = DialogResult.Abort;
            }
        }
        
        void selecionarInstrumento()
        {
            //long id_ins;
            //int i = 0;
            //foreach(string item in cmbInstrumento.Items)
            //{ 
            //    int strindex = item.IndexOf(" - ");
            //    id_ins = Convert.ToInt64(item.Substring(0, strindex));
            //    if(id_ins == instrumento.Id_Instrumento)
            //    {
            //        cmbInstrumento.SelectedIndex = i;
            //        break;
            //    }
            //    i++;
            //}

            cmbInstrumento.Items.Clear();
            cmbInstrumento.Items.Add(instrumento.Id_Instrumento + " - " + instrumento.Nome);
            cmbInstrumento.SelectedIndex = 0;
            cmbInstrumento.Enabled = false;
        }

        void fillFields()
        {

            try
            {
                long id_campo;
                Campo campo;
                Valor valor;


                foreach (DataGridViewRow row in dgvCampos.Rows)
                {
                    try
                    {
                        Util.Alert(row.Cells[1].Value.ToString());
                        id_campo = Convert.ToInt64(row.Cells[0].Value);
                        campo = Servico.BuscarCampo(id_campo);

                        valor = Servico.BuscarValor(campo.Id_Campo, avaliacao.Id_Avaliacao);

                        row.Cells[3].Value = valor.GetValue(campo.Tipo).ToString();
                    }
                    catch (Exception ex)
                    {
                        Util.Alert("Algo deu errado!\nMais detalhes: " + ex.Message + " \nSource: " + ex.StackTrace, MessageBoxIcon.Error);
                    }

                }
            } catch(Exception ex)
            {
                Util.Alert("Algo deu errado!\nMais detalhes: " + ex.Message + " \nSource: " + ex.StackTrace, MessageBoxIcon.Error);
            }
}

        private void Visualizar_Load(object sender, EventArgs e)
        {
            if(avaliacao.Excluido)
            {
                if (!Util.Confirm("Avaliação excluída. \nDeseja recuperar o registro?"))
                {
                    voltar(true);
                    return;
                }
                else
                {
                    Servico.AvaliacaoExcluido(avaliacao, false);

                    avaliacao.Excluido = false;
                }
            }
            selecionarInstrumento();
            limpaDGV();
            atualizaCampos();
            //fillFields();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            voltar(true);
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            if(Util.Confirm("Deseja realmente fechar o sistema?"))
            {
                voltar(false);
            }
        }

        Campo campo;

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if(Util.Confirm("Deseja realmente salvar as alterações realizadas?"))
            {
                try
                {
                    Servico.AlterarAvaliacao(avaliacao);

                    long id_valor;

                    Valor valor;

                    string cellvalue;

                    foreach (DataGridViewRow row in dgvCampos.Rows)
                    {
                        id_valor = Convert.ToInt64(row.Cells[0].Value);
                        campo = Servico.BuscarCampoValor(id_valor);

                        cellvalue = row.Cells[3].Value.ToString();

                        valor = new Valor();
                        valor.Id_Avaliacao = avaliacao.Id_Avaliacao;
                        valor.Id_Campo = campo.Id_Campo;
                        valor.Id_Valor = id_valor;
                        valor.SetValue(campo.Tipo, cellvalue);

                        Servico.AlterarValor(valor);
                    }

                    Util.Alert("Avaliação alterada com sucesso!");
                    voltar(true);
                }
                catch (Exception ex)
                {
                    Util.Alert("Algo deu errado!\n\nMais detalhes: " + ex.Message + "\n\nCheque o campo " + campo.Nome, MessageBoxIcon.Error);
                }
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            voltar(true);
        }
    }
}
