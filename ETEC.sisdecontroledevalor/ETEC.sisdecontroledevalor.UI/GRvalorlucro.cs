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
    public partial class GRvalorlucro : UserControl
    {
        public GRvalorlucro()
        {
            InitializeComponent();
        }
        //private void GerenciamentodeValores_Load(object sender, EventArgs e)
        //{
        //    try
        //    {
        //        DAO.BANCO dao = new DAO.BANCO();
        //        dgvProduto.DataSource = dao.retornarBancoProd();
        //        int cont = dgvProduto.RowCount - 1;
        //        for (int i = 0; i < cont; i++)
        //        {
        //            comboBox1.Items.Add(dgvProduto.Rows[i].Cells[1].Value.ToString());
        //        }
        //    }
        //    catch
        //    {

        //    }
        //}

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_TextChanged(object sender, EventArgs e)
        {
            try
            {
                comboBox1.ResetText();
                float preco = 0;
                int id = 0;
                DAO.BANCO dao = new DAO.BANCO();
                dgvProduto.DataSource = dao.retornarBancoProd();
                dgvProdItem.DataSource = dao.retornarBancoProdItem();
                int cont = dgvProduto.RowCount - 1;
                for (int i = 0; i < cont; i++)
                {

                    if (comboBox1.Text == dgvProduto.Rows[i].Cells[1].Value.ToString())
                    {
                        id = int.Parse(dgvProduto.Rows[i].Cells[0].Value.ToString());
                    }
                }
                int cont1 = dgvProdItem.RowCount - 1;
                if (id != 0)
                {
                    for (int i = 0; i < cont1; i++)
                    {
                        if (id == int.Parse(dgvProdItem.Rows[i].Cells[1].Value.ToString()))
                        {
                            ltbIngre.Items.Add(dgvProdItem.Rows[i].Cells[2].Value.ToString() + " - " + dgvProdItem.Rows[i].Cells[3].Value.ToString() + " - R$" + dgvProdItem.Rows[i].Cells[4].Value.ToString());
                            preco = preco + int.Parse(dgvProdItem.Rows[i].Cells[4].Value.ToString());
                            txtPrecoIng.Text = preco.ToString();
                        }
                    }

                }
            }
            catch
            {

            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Items item = new Items();
            float a = item.preco;
            float b = float.Parse(txtPrecoIng.Text);
            float r = b / a * 100;
            lucroPorcent.Text = r.ToString();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void GRvalorlucro_Load(object sender, EventArgs e)
        {
            try
            {
                DAO.BANCO dao = new DAO.BANCO();
                dgvProduto.DataSource = dao.retornarBancoProd();
                int cont = dgvProduto.RowCount - 1;
                for (int i = 0; i < cont; i++)
                {
                    comboBox1.Items.Add(dgvProduto.Rows[i].Cells[1].Value.ToString());
                }
            }
            catch
            {

            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void comboBox1_TextChanged_1(object sender, EventArgs e)
        {
            if (comboBox1.Text != "")
            {
                try
                {
                    ltbIngre.Items.Clear();
                    float preco = 0;
                    int id = 0;
                    DAO.BANCO dao = new DAO.BANCO();
                    dgvProduto.DataSource = dao.retornarBancoProd();
                    dgvProdItem.DataSource = dao.retornarBancoProdItem();
                    int cont = dgvProduto.RowCount - 1;
                    for (int i = 0; i < cont; i++)
                    {

                        if (comboBox1.Text == dgvProduto.Rows[i].Cells[1].Value.ToString())
                        {
                            id = int.Parse(dgvProduto.Rows[i].Cells[0].Value.ToString());
                            label12.Text = "R$"+ dgvProduto.Rows[i].Cells[2].Value.ToString();
                        }
                    }
                    int cont1 = dgvProdItem.RowCount - 1;
                    if (id != 0)
                    {
                        for (int i = 0; i < cont1; i++)
                        {
                            if (id == int.Parse(dgvProdItem.Rows[i].Cells[1].Value.ToString()))
                            {
                                ltbIngre.Items.Add(dgvProdItem.Rows[i].Cells[2].Value.ToString() + " - " + dgvProdItem.Rows[i].Cells[3].Value.ToString() + " - R$" + dgvProdItem.Rows[i].Cells[4].Value.ToString());
                                preco = preco + int.Parse(dgvProdItem.Rows[i].Cells[4].Value.ToString()) * int.Parse(dgvProdItem.Rows[i].Cells[3].Value.ToString());
                                txtPrecoIng.Text = preco.ToString();
                            }
                        }

                    }
                }
                catch
                {

                }
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            float preco = 0;
            DAO.BANCO dao = new DAO.BANCO();
            dgvProduto.DataSource = dao.retornarBancoProd();
            dgvProdItem.DataSource = dao.retornarBancoProdItem();
            int cont = dgvProduto.RowCount - 1;
            for (int i = 0; i < cont; i++)
            {

                if (comboBox1.Text == dgvProduto.Rows[i].Cells[1].Value.ToString())
                {
                    preco = int.Parse(dgvProduto.Rows[i].Cells[2].Value.ToString());
                    float a = preco;
                    float b = float.Parse(textBox1.Text);
                    float r = (a / 100) * b;
                    lucroPorcent.Text = r.ToString();
                }
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                comboBox1.Items.Clear();
                DAO.BANCO dao = new DAO.BANCO();
                dgvProduto.DataSource = dao.retornarBancoProd();
                int cont = dgvProduto.RowCount - 1;
                for (int i = 0; i < cont; i++)
                {
                    comboBox1.Items.Add(dgvProduto.Rows[i].Cells[1].Value.ToString());
                }
            }
            catch
            {

            }
        }
    }
}
