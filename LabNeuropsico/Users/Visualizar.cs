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

namespace LabNeuropsico.Users
{
    public partial class Visualizar : Form
    {
        Usuario usuario;
        public Visualizar()
        {
            InitializeComponent();
        }

        public Visualizar(Usuario usuario)
        {
            InitializeComponent();

            this.usuario = usuario;
        }

        void fillFields()
        {
            txtNome.Text = usuario.Nome;
            txtEmail.Text = usuario.Email;
            txtLogin.Text = usuario.Login;
            txtSenha.Text = "";
            int hospital = 0;

            if (usuario.Hospital == 'f') hospital = 1;
            if (usuario.Hospital == 'a') hospital = 2;

            cmbHospital.SelectedIndex = hospital;

            txtObs.Text = usuario.Obs;

            checkAdmin.Checked = usuario.Is_Admin;
        }

        void voltar()
        {
            this.Close();
        }

        bool cons()
        {
            if (txtNome.Text == "") return false;
            if (txtEmail.Text == "") return false;
            if (txtLogin.Text == "") return false;
            return true;
        }

        private void Visualizar_Load(object sender, EventArgs e)
        {
            if (usuario.Id_Usuario != 0)
                fillFields();
            else
                voltar();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            voltar();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (Util.Confirm("Deseja realmente excluir esse usuário?"))
            {
                Servico.UsuarioExcluido(usuario, true);
                voltar();
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (!cons())
                Util.Alert("Alguns campos obrigatórios ficaram sem ser preenchidos!",
                    MessageBoxIcon.Error);
            else
            {
                if (Util.Confirm("Deseja realmente salvar as alterações realizadas?"))
                {
                    string nome = txtNome.Text;
                    string email = txtEmail.Text;
                    string login = txtLogin.Text;
                    string senha = usuario.Senha;
                    if (txtSenha.Text != "")
                        senha = Util.Md5(txtSenha.Text);
                    string obs = txtObs.Text;
                    char hospital = Convert.ToChar(cmbHospital.Text.Substring(0, 1));
                    bool admin = checkAdmin.Checked;


                    usuario.SetProperties(usuario.Id_Usuario, nome, login, senha, email, hospital, obs, admin, false);
                    Servico.AlterarUsuario(usuario);
                    Util.Alert("Usuário " + nome + " alterado com sucesso!");

                    voltar();
                }
            }
        }
    }
}
