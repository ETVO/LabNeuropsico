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
    public partial class Cadastro : Form
    {
        //Dictionary<int, object> campos = new Dictionary<int, object>();
        //int i = 1;
        //int camposMargin;
        //int camposHeight;
        //int camposX;

        DataTable cleandt = new DataTable();

        public Cadastro()
        {
            InitializeComponent();
            //camposMargin = 10;
            //camposHeight = 15;
            //camposHeight += (camposMargin * 2);
            //camposX = 16;
        }

        bool cons()
        {
            if (cmbTipoAval.Text == "") return false;
            if (txtNomeInstrumento.Text == "") return false;
            if (dgvCampos.Rows.Count == 0) return false;

            return true;
        }

        void ajustesDGV()
        {
            if (dgvCampos.Rows.Count == 0)
                lblNenhum.Visible = true;

        }

        void limpaDGV()
        {
            lblNenhum.Visible = true;
            dgvCampos.Rows.Clear();
            dgvCampos.Columns.Clear();

            dgvCampos.Columns.Add("Nome", "Nome");
            dgvCampos.Columns.Add("Tipo", "Tipo de Entrada");
        }

        bool cons_campos()
        {
            if (txtNomeCampo.Text == "") return false;
            if (cmbTipoCampo.Text == "") return false;

            return true;
        }

        void limpaCampos()
        {
            txtNomeCampo.Text = "";
            cmbTipoCampo.SelectedIndex = -1;
        }

        private void Cadastro_Load(object sender, EventArgs e)
        {
            //string sql = "SELECT nome, condicao FROM paciente WHERE false = true ";
            //cleandt = Servico.PopDataTable(sql);
            limpaDGV();
        }

        //private void OnClick(object sender, EventArgs e)
        //{
        //    foreach (KeyValuePair<int, object> ob in campos)
        //    {
        //        Util.Alert(ob.Key + " -> " + ob.Value);
        //    }
        //    Label label = sender as Label;
        //    int index = Convert.ToInt32(label.Tag);
        //    campos.Remove(index);
        //    label.Dispose();
        //    foreach (KeyValuePair<int, object> ob in campos)
        //    {
        //        Util.Alert(ob.Key + " -> " + ob.Value);
        //    }
        //}

        private void btnNovoCampo_Click(object sender, EventArgs e)
        {
            if(!cons_campos())
            {
                Util.Alert("Você deve preencher o nome e o tipo " +
                    "de entrada do campo a ser adicionado!");
            }
            else
            {
                if (dgvCampos.Rows.Count == 0)
                    lblNenhum.Visible = false;
                else
                {
                    foreach(DataGridViewRow row in dgvCampos.Rows)
                    {
                        if(row.Cells[0].Value.ToString() == txtNomeCampo.Text)
                        {
                            if (!Util.Confirm("Já existe um campo registrado com esse nome (" + txtNomeCampo.Text + ")!\nDeseja adicionar mesmo assim?"))
                            {
                                limpaCampos();
                                txtNomeCampo.Focus();
                                return;
                            }
                        }
                    }
                }

                List<object> novo = new List<object>();

                novo.Add(txtNomeCampo.Text);
                novo.Add(cmbTipoCampo.Text);

                dgvCampos.Rows.Add(novo.ToArray());

                limpaCampos();
                txtNomeCampo.Focus();
            }
            //var label = new Label();
            //i++;
            //label.Text = (i).ToString();
            //campos.Add(i, label);
            //int labelY = campos.Count * camposHeight;
            //label.Location = new Point(camposX, labelY);
            //label.Size = new Size(41, 15);
            //label.Tag = i.ToString();
            //label.Click += new System.EventHandler(OnClick);
            //panelCampos.Controls.Add(label);


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

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (!cons())
                Util.Alert("Alguns campos obrigatórios ficaram sem ser preenchidos!",
                    MessageBoxIcon.Error);
            else
            {
                Instrumento instrumento = new Instrumento();

                string nome = txtNomeInstrumento.Text;
                string tipo = cmbTipoAval.Text;

                instrumento.SetProperties(0, nome, tipo, false);

                if(Servico.ExisteInstrumento(nome))
                {
                    if (!Util.Confirm("Já existe um instrumento cadastrado com esse nome (" + nome + ")!\nDeseja cadastrar mesmo assim?"))
                        return;
                }

                long id_instrumento = Servico.SalvarInstrumentoId(instrumento);

                foreach(DataGridViewRow row in dgvCampos.Rows)
                {
                    Campo novo_campo = new Campo();
                    string nome_campo = row.Cells[0].Value.ToString();
                    string tipo_campo = row.Cells[1].Value.ToString();

                    if (tipo_campo == "Data") tipo_campo = "vdate";
                    else if (tipo_campo == "Número inteiro") tipo_campo = "vint";
                    else if (tipo_campo == "Número decimal") tipo_campo = "vdouble";
                    else tipo_campo = "vtext";

                    novo_campo.SetProperties(0, id_instrumento, nome_campo, tipo_campo, false);

                    Servico.SalvarCampo(novo_campo);
                }

                Util.Alert("Instrumento " + instrumento.Nome + " cadastrado com sucesso!", MessageBoxIcon.Information);
                Util.CleanFields(Controls);
                limpaDGV();
            }
        }

        private void btnExcluirTodos_Click(object sender, EventArgs e)
        {
            if(dgvCampos.Rows.Count > 0)
            {
                if (Util.Confirm("Deseja realmente excluir todos os campos registrados?"))
                {
                    limpaDGV();
                }
            }
        }

        private void btnExcluirCampo_Click(object sender, EventArgs e)
        {
            int index = 0;
            foreach(DataGridViewRow row in dgvCampos.Rows)
            {
                if(row.Selected)
                {
                    index = row.Index;
                    dgvCampos.Rows.RemoveAt(index);
                    break;
                }
            }

            ajustesDGV();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            if(Util.Confirm("Deseja realmente limpar o formulário e iniciar um novo cadastro?"))
            {
                Util.CleanFields(Controls);
                limpaDGV();
            }
        }
    }
}
