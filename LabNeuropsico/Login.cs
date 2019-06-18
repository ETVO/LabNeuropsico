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

namespace LabNeuropsico
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        bool checkRoot()
        {
            if (txtLogin.Text == "root" && Util.Md5(txtSenha.Text) == "5a4092948705fa0a1b8886c75dd78a21")
                return true;
            return false;
        }

        void logon()
        {
            Util.DisposeForm("Index");

            Index index = new Index();
            this.Hide();
            index.ShowDialog();
            this.Close();
        }

        void protocoloLogin()
        {
            if(!String.IsNullOrWhiteSpace(txtLogin.Text))
            {
                if (checkRoot())
                {
                    Usuario root = new Usuario();
                    root.SetProperties(0, "Root", "root", "5a4092948705fa0a1b8886c75dd78a21",
                        "", 'a', "", true, false);
                    Session.SetSession(root);

                    logon();
                    return;
                }

                Usuario usuario = Servico.LoginUsuario(txtLogin.Text);

                if (usuario != null)
                {
                    if (usuario.Senha == Util.Md5(txtSenha.Text))
                    {
                        Session.SetSession(usuario);

                        logon();

                        return;
                    }
                    else
                    {
                        Util.Alert("Senha incorreta!", MessageBoxIcon.Error);
                    }
                }
                else
                {
                    Util.Alert("Usuário inexistente!", MessageBoxIcon.Error);
                }

                Util.CleanFields(Controls);
                txtLogin.Focus();
            }
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            if (Util.Confirm("Deseja realmente fechar o sistema?"))
            {
                this.Close();
            }
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            protocoloLogin();
        }

        private void txtSenha_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == '\r')
                protocoloLogin();
        }
    }
}
