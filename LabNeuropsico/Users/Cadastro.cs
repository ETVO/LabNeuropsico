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
    public partial class Cadastro : Form
    {
        public Cadastro()
        {
            InitializeComponent();
        }

        bool cons()
        {
            if (txtNome.Text == "") return false;
            if (txtEmail.Text == "") return false;
            if (txtLogin.Text == "") return false;
            if (txtSenha.Text == "") return false;
            return true;
        }

        void voltar()
        {
            Util.DisposeForm("Pacientes.Main");

            Main main = new Main();
            this.Hide();
            main.ShowDialog();
            this.Close();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (!cons())
                Util.Alert("Alguns campos obrigatórios ficaram sem ser preenchidos!",
                    MessageBoxIcon.Error);
            else
            {
                try
                {
                    string nome = txtNome.Text;
                    string email = txtEmail.Text;
                    string login = txtLogin.Text;
                    string senha = Util.Md5(txtSenha.Text);
                    string obs = txtObs.Text;
                    char hospital = (cmbHospital.SelectedIndex != -1) ? Convert.ToChar(cmbHospital.Text.Substring(0, 1)) : 'a';
                    bool admin = checkAdmin.Checked;


                    Usuario u = new Usuario();

                    u = Servico.BuscarUsuario(login);
                    if(u != null)
                    {
                        Util.Alert("Algo deu errado!\n\nMais detalhes: Esse login já existe! Tente novamente",
                         MessageBoxIcon.Error);
                        return;
                    }
                    u = new Usuario();

                    u.SetProperties(0, nome, login, senha, email, hospital, obs, admin, false);
                    Servico.SalvarUsuario(u);
                    Util.Alert("Usuário " + nome + " cadastrado com sucesso!");

                    Util.CleanFields(Controls);
                    voltar();
                }
                catch(Exception ex)
                {
                    Util.Alert("Algo deu errado!\n\nMais detalhes: " + ex.Message,
                        MessageBoxIcon.Error);
                }
            }
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

        private void btnNovo_Click(object sender, EventArgs e)
        {
            if (!Util.FieldsEmpty(Controls))
            {
                if (Util.Confirm("Deseja realmente limpar os campos e iniciar um novo cadastro?"))
                {
                    Util.CleanFields(Controls);
                }
            }
        }
    }
}
