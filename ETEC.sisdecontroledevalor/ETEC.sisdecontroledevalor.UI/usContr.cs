using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ETEC.sisdecontroledevalor.UI
{
    public partial class usContr : UserControl
    {
        public usContr()
        {
            InitializeComponent();
        }
        List<Items> list = new List<Items>();

        private bool ValidarCampoString(string campoValidar, string nomeCampo)
        {
            if (campoValidar == "")
            {
                MessageBox.Show("Campo " + nomeCampo + " não está correto!");
                return false;
            }
            else
            {
                return true;
            }
        }

        private bool ValidarCampoInt(string campoValidar, string nomeCampo)
        {
            try
            {
                int.Parse(campoValidar);
                return true;
            }
            catch (Exception)
            {
                MessageBox.Show("Campo " + nomeCampo + " não está correto!");
                return false;
            }
        }

        private bool ValidarCampoFloat(string campoValidar, string nomeCampo)
        {
            try
            {
                int.Parse(campoValidar);
                return true;
            }
            catch (Exception)
            {
                MessageBox.Show("Campo " + nomeCampo + " não está correto!");
                return false;
            }
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(" Deseja mesmo sair? ", "Aplicação", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (ValidarCampoString(txtNomeIng.Text, "Nome(Ingrediente)") == false)
            {
                txtNomeIng.Clear();
                txtNomeIng.Focus();
                return;
            }
            if (ValidarCampoInt(txtQntdIng.Text, "Quantidade") == false)
            {
                txtQntdIng.Clear();
                txtQntdIng.Focus();
                return;
            }
            if (ValidarCampoFloat(txtPrecoIng.Text, "PreçoIngrediente)") == false)
            {
                txtPrecoIng.Clear();
                txtPrecoIng.Focus();
                return;
            }
            DAO.BANCO dao = new DAO.BANCO();
            dgvProduto.DataSource = dao.retornarBancoProd();
            Items item = new Items();
            item.idProd = dgvProduto.RowCount;
            item.nome = txtNomeIng.Text;
            item.preco = float.Parse(txtPrecoIng.Text);
            item.qntd = int.Parse(txtQntdIng.Text);
            list.Add(item);
            dgvIngredientes.DataSource = list.ToList();
            txtNomeIng.Clear();
            txtPrecoIng.Clear();
            txtQntdIng.Clear();
        }

        private void Cadastro_de_produtos_Load(object sender, EventArgs e)
        {
            DAO.BANCO dao = new DAO.BANCO();
            dgvProduto.DataSource = dao.retornarBancoProd();
            dgvProdItem.DataSource = dao.retornarBancoProdItem();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (ValidarCampoString(txtNM.Text, "Nome") == false)
            {
                txtNM.Clear();
                txtNM.Focus();
                return;
            }

            if (ValidarCampoFloat(txtPreco.Text, "Preço") == false)
            {
                txtPreco.Clear();
                txtPreco.Focus();
                return;
            }
            try
            {
                DAO.BANCO dao = new DAO.BANCO();
                dao.cadastrarProd(txtNM.Text, float.Parse(txtPreco.Text));
                dgvProduto.DataSource = dao.retornarBancoProd();
                for (int i = 0; i < dgvIngredientes.RowCount; i++)
                {
                    int idProd = int.Parse(dgvIngredientes.Rows[i].Cells[0].Value.ToString());
                    string nmProd = dgvIngredientes.Rows[i].Cells[1].Value.ToString();
                    float preco = float.Parse(dgvIngredientes.Rows[i].Cells[2].Value.ToString());
                    int quantidade = int.Parse(dgvIngredientes.Rows[i].Cells[3].Value.ToString());
                    dao.cadastrarProdItem(idProd, nmProd, quantidade, preco);
                }
            }
            catch
            {
                MessageBox.Show("Não foi possível efetuar o cadastro!","Erro",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
            }
            try
            {
                DAO.BANCO dao = new DAO.BANCO();
                dgvProduto.DataSource = dao.retornarBancoProd();
                dgvProdItem.DataSource = dao.retornarBancoProdItem();
                MessageBox.Show("Cadastro efetuado com sucesso!","Bem Sucedido",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
            catch
            {
                MessageBox.Show("Erro ao conectar com o banco ou servidor.","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            if (ValidarCampoString(txtNM.Text, "Nome") == false)
            {
                txtNM.Clear();
                txtNM.Focus();
                return;
            }

            if (ValidarCampoFloat(txtPreco.Text, "Preço") == false)
            {
                txtPreco.Clear();
                txtPreco.Focus();
                return;
            }
            try
            {
                DAO.BANCO dao = new DAO.BANCO();
                dao.cadastrarProd(txtNM.Text, float.Parse(txtPreco.Text));
                dgvProduto.DataSource = dao.retornarBancoProd();
                for (int i = 0; i < dgvIngredientes.RowCount; i++)
                {
                    int idProd = int.Parse(dgvIngredientes.Rows[i].Cells[0].Value.ToString());
                    string nmProd = dgvIngredientes.Rows[i].Cells[1].Value.ToString();
                    float preco = float.Parse(dgvIngredientes.Rows[i].Cells[2].Value.ToString());
                    int quantidade = int.Parse(dgvIngredientes.Rows[i].Cells[3].Value.ToString());
                    dao.cadastrarProdItem(idProd, nmProd, quantidade, preco);
                }
                dgvProduto.DataSource = dao.retornarBancoProd();
                dgvProdItem.DataSource = dao.retornarBancoProdItem();
                MessageBox.Show("Cadastro efetuado com sucesso!");
                txtNM.Clear();
                txtPreco.Clear();
            }
            catch
            {
                MessageBox.Show("Não foi possível efetuar o cadastro!");
            }
            dgvIngredientes.DataSource = null;
            list.Clear();
        }

        private void usContr_Load(object sender, EventArgs e)
        {
            DAO.BANCO dao = new DAO.BANCO();
            dgvProduto.DataSource = dao.retornarBancoProd();
            dgvProdItem.DataSource = dao.retornarBancoProdItem();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            dgvIngredientes.DataSource = null;
            list.Clear();
        }
    }
}
