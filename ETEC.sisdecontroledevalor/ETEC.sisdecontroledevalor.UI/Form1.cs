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
    public partial class Form1 : Form
    {
        Menu mn = new Menu();
        
        public Form1()
        {
            InitializeComponent();
        }

       

        private void btnSair_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(" Deseja mesmo sair? ", "Aplicação", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txtUsu.Focus();
        }

        private void Form1_Shown(object sender, EventArgs e)
        {try
            {
                DAO.BANCO dao = new DAO.BANCO();
                dgvLogin.DataSource = dao.retornarBancoLogin();
                if (dgvLogin.RowCount == 1)// se a row do data grid tiver uma linha foca no usuario do form login
                {
                    if (dgvLogin.Rows[0].Cells[0].Value == null)// se o valor de rows do dgv for nulo abre o primeiro login
                    {
                        Primeiro_login p_l = new Primeiro_login();
                        p_l.Show();
                        this.Hide();
                    }

                }
                txtUsu.Focus();
            }
            catch
            {
                MessageBox.Show("Servidor não encontrado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit();
            }
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            try
            {
                DAO.BANCO dao = new DAO.BANCO();
                dgvLogin.DataSource = dao.retornarBancoLogin(); //verifica no banco insere ou seleciona
                int count = dgvLogin.RowCount;//conta as linhas rows do dgv
                for (int i = 0; i < count; i++)
                {
                    if (dgvLogin.Rows[i].Cells[0].Value.ToString() == txtUsu.Text && dgvLogin.Rows[i].Cells[1].Value.ToString() == txtSen.Text)
                    {
                        mn.Show();
                        this.Hide();
                        return;
                    }
                }
            }
            catch
            {
                txtUsu.Clear();
                txtSen.Clear();
                txtUsu.Focus();
                MessageBox.Show("Usuario ou Senha estão invalidos", "Invalido", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
    }

