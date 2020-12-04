using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ETEC.sisdecontroledevalor.UI
{
    public partial class Primeiro_login : Form
    {
        public Primeiro_login()
        {
            InitializeComponent();
        }

        private void txtCad_Click(object sender, EventArgs e)
        {
            if (txtSenha.Text != txtCSenha.Text)
            {
                txtCSenha.Clear();
                txtCSenha.Focus();
                MessageBox.Show("A Confirmação de Senha não confere", "Erro na confirmação", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            DAO.BANCO dao = new DAO.BANCO();
            try
            {
               dao.cadastrarUsuario(txtNM.Text, cboSexo.Text, DateTime.Parse(mkdt.Text), mktel.Text, mkCel.Text, txtEmail.Text, txtUser.Text, txtSenha.Text, txtsenRec.Text);

                this.Hide();
                Form1 login = new Form1();
                login.Show();
            }
            catch(Exception erro)
            {
                MessageBox.Show("Não foi possível realizar o cadastro!");
                MessageBox.Show(erro.Message);
            }
        }

        private void mktel_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Primeiro_login primeiro = new Primeiro_login();
            primeiro.Show();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
