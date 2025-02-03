using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sistema2
{
    public partial class Form1 : Form
    {
        bool VerSenhaTxt = false;
        private string usuarioCorreto = "admin";
        private string senhaCorreta = "123456";

        public Form1()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void buttonLimpar_Click(object sender, EventArgs e)
        {
            textBoxUsuario.Text = string.Empty;
            textBoxSenha.Text = "";

            textBoxUsuario.Focus();
        }

        private void buttonMostrar_Click(object sender, EventArgs e)
        {
            if (VerSenhaTxt == false)
            {
                textBoxSenha.PasswordChar = '\0';
                VerSenhaTxt = true;
                buttonMostrar.Text = "Ocultar Senha";
            }
            else {
                textBoxSenha.PasswordChar = '*';
                VerSenhaTxt = false;
                buttonMostrar.Text = "Mostrar Senha";
            }
        }

        private void buttonEntrar_Click(object sender, EventArgs e)
        {
            string usuario = textBoxUsuario.Text;
            string senha = textBoxSenha.Text;

            if (usuario == usuarioCorreto && senha == senhaCorreta)
            {
                labelMensagem.Text = "Login Valido";
                labelMensagem.ForeColor = Color.Green;
                Menu form = new Menu();
                form.ShowDialog();

            }else
            {
                labelMensagem.Text = "Login Invalido";
                labelMensagem.ForeColor = Color.Red;
                textBoxUsuario.Text = "";
                textBoxSenha.Text = "";
                textBoxUsuario.Focus();
            }

        }
    }
}
