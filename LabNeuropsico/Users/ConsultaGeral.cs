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
using LabNeuropsico.Model.Session;

namespace LabNeuropsico.Users
{
    public partial class ConsultaGeral : Form
    {
        DataTable cleandt;

        public ConsultaGeral()
        {
            InitializeComponent();
        }

        void voltar()
        {
            Util.DisposeForm("Pacientes.Main");

            Main main = new Main();
            this.Hide();
            main.ShowDialog();
            this.Close();
        }

        void buscar()
        {
            lblNenhum.Visible = false;

            string sql = "SELECT id_usuario, nome, login, email, hospital, " +
                "CASE WHEN admin IS TRUE THEN 'Sim' ELSE 'Não' END, " +
                "CASE WHEN excluido IS TRUE THEN 'Excluído' ELSE 'Disponível' END " +
                "FROM usuario WHERE true ";

            string nome = txtNome.Text.ToLower();

            // Admin
            if (cmbAdmin.SelectedIndex == 0)
                sql += "AND admin = true ";
            if (cmbAdmin.SelectedIndex == 1)
                sql += "AND admin = false ";

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

            // LIKE nome
            sql += "AND lower(nome) LIKE '%" + nome + "%' ";

            // Mostrar pacientes excluídos?
            if (!checkExcluido.Checked)
                sql += "AND excluido = false ";

            // Ordenar por nome (A-Z)
            sql += "ORDER BY nome ASC ";

            dgvUsuarios.DataSource = Servico.PopDataTable(sql);
            ajustesDGV();
        }

        void limpaDGV()
        {
            dgvUsuarios.DataSource = cleandt;
            ajustesDGV();
        }

        void ajustesDGV()
        {
            List<string> colunas = new List<string>();
            colunas.Add("Id");
            colunas.Add("Nome");
            colunas.Add("Login");
            colunas.Add("E-mail");
            colunas.Add("Hospital");
            colunas.Add("Admin");
            colunas.Add("Status");

            for (int c = 0; c < colunas.Count; c++)
            {
                dgvUsuarios.Columns[c].HeaderText = colunas[c];

                if (colunas[c] == "Id")
                {
                    dgvUsuarios.Columns[c].Visible = false;
                }
            }

            char hospital;
            DataGridViewCell cell_hospital;

            for (int r = 0; r < dgvUsuarios.Rows.Count; r++)
            {
                cell_hospital = dgvUsuarios.Rows[r].Cells[4];
                hospital = Convert.ToChar(cell_hospital.Value);
                if (hospital == 'h') cell_hospital.Value = "HRAC";
                else if (hospital == 'f') cell_hospital.Value = "FOB";
                else cell_hospital.Value = "Ambos";
            }

            if (dgvUsuarios.Rows.Count == 0)
                lblNenhum.Visible = true;

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
            voltar();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            buscar();
        }

        private void ConsultaGeral_Load(object sender, EventArgs e)
        {
            string sql = "SELECT id_usuario, nome, login, email, hospital, " +
                "admin, excluido FROM usuario WHERE true = false";
            cleandt = Servico.PopDataTable(sql);
            limpaDGV();
            buscar();
        }

        string txtExc = "excluir";

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (Util.Confirm("Deseja realmente " + txtExc + " esse usuário?"))
            {
                long sel_id = 0;
                foreach (DataGridViewRow row in dgvUsuarios.Rows)
                {
                    if (row.Selected)
                    {
                        sel_id = Convert.ToInt64(row.Cells[0].Value);
                        break;
                    }
                }

                Usuario usuario;

                if (sel_id != 0)
                {
                    usuario = Servico.BuscarUsuario(sel_id);

                    if (usuario.Login == Session.Usuario.Login)
                    {
                        Util.Alert("ATENÇÃO!\n\n" +
                            "Você não pode excluir seu próprio registro!", MessageBoxIcon.Error);
                        return;
                    }

                    if (usuario.Excluido)
                    {
                        Servico.UsuarioExcluido(usuario, false);
                    }
                    else
                    {
                        Servico.UsuarioExcluido(usuario, true);
                    }

                    buscar();
                }
            }
        }

        private void btnVisualizar_Click(object sender, EventArgs e)
        {
            long sel_id = 0;
            foreach (DataGridViewRow row in dgvUsuarios.Rows)
            {
                if (row.Selected)
                {
                    sel_id = Convert.ToInt64(row.Cells[0].Value);
                    break;
                }
            }

            viewUsuario(sel_id);
        }

        private void dgvUsuarios_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;

            long sel_id = Convert.ToInt64(dgvUsuarios.Rows[index].Cells[0].Value);

            if (sel_id == 0) return;

            Usuario usuario = Servico.BuscarUsuario(sel_id);

            if (usuario.Excluido)
            {
                btnExcluir.Text = "Recuperar selecionado";
                txtExc = "recuperar";
            }
            else
            {
                btnExcluir.Text = "Excluir selecionado";
                txtExc = "excluir";
            }
        }

        private void dgvUsuarios_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            long sel_id = 0;
            Usuario usuario;

            if (e.RowIndex >= 0)
            {
                sel_id = Convert.ToInt64(dgvUsuarios.Rows[e.RowIndex].Cells[0].Value);

                viewUsuario(sel_id);
            }
        }

        void viewUsuario(long sel_id)
        {
            Usuario usuario;

            if (sel_id != 0)
            {
                usuario = Servico.BuscarUsuario(sel_id);

                if (usuario.Login == Session.Usuario.Login)
                {
                    Util.Alert("ATENÇÃO!\n\n" +
                        "Você não pode alterar seu próprio registro!", MessageBoxIcon.Error);
                    return;
                }

                if (usuario.Excluido)
                {
                    if (!Util.Confirm("Esse usuário está excluído. Para visualizá-lo, você deve recuperar o registro." +
                        "\n\nDeseja recuperar este usuário?"))
                        return;
                    else
                        Servico.UsuarioExcluido(usuario, false);
                }
                Util.DisposeForm("Users.Visualizar");

                Visualizar visualizar = new Visualizar(usuario);
                visualizar.ShowDialog();
                buscar();
            }
        }
    }
}
