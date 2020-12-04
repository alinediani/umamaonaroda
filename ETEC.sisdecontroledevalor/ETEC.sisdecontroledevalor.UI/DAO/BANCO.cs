using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace ETEC.sisdecontroledevalor.UI.DAO
{
    class BANCO
    {
        public DataTable retornarBancoLogin()
        {
            MySqlConnection msc = new MySqlConnection();// conexão com o banco
            msc.ConnectionString = "server=localhost;User Id=root;password='';database=ControValores";
            msc.Open();
            MySqlDataAdapter msda = new MySqlDataAdapter("SELECT usu,sen FROM usuario;", msc);
            DataSet ds = new DataSet();
            msda.Fill(ds);
            msc.Close();
            return ds.Tables[0];
        }

        public DataTable retornarBancoUsuario()
        {
            MySqlConnection msc = new MySqlConnection();
            msc.ConnectionString = "server=localhost;User Id=root;password='';database=ControValores";
            msc.Open();
            MySqlDataAdapter msda = new MySqlDataAdapter("SELECT * FROM usuario;", msc);
            DataSet ds = new DataSet();
            msda.Fill(ds);
            msc.Close();
            return ds.Tables[0];
        }

        public void cadastrarUsuario(string nome, string sexo, DateTime dtn, string tel, string cel, string email, string usu, string sen, string senRec)

        {
            MySqlConnection msc = new MySqlConnection();
            msc.ConnectionString = "server=localhost;User Id=root;password='';database=ControValores";
            msc.Open();
            MySqlCommand mscommand = new MySqlCommand("INSERT INTO `controvalores`.`usuario` (`id`,`nm`,`sex`,`dtns`, `tel`,`email`,`usu`, `sen`, `senr`) VALUES ('" + nome + "','" + sexo + "', '" + dtn.ToString("yyyy-MM-dd") + "', '" + email + "', '" + tel + "', '" + cel + "', '" + usu + "', '" + sen + "', '" + senRec + "');");
            mscommand.Connection = msc; //use
            mscommand.ExecuteNonQuery(); //raio
            msc.Close();
        }

        public DataTable retornarBancoProd()
        {
            MySqlConnection msc = new MySqlConnection();
            msc.ConnectionString = "server=localhost;User Id=root;password='';database=ControValores";
            msc.Open();
            MySqlDataAdapter msda = new MySqlDataAdapter("SELECT * FROM cadprod;", msc);
            DataSet ds = new DataSet();
            msda.Fill(ds);
            msc.Close();
            return ds.Tables[0];
        }

        public DataTable retornarBancoProdItem()
        {
            MySqlConnection msc = new MySqlConnection();
            msc.ConnectionString = "server=localhost;User Id=root;password='';database=ControValores";
            msc.Open();
            MySqlDataAdapter msda = new MySqlDataAdapter("SELECT * FROM cadproditem;", msc);
            DataSet ds = new DataSet();
            msda.Fill(ds);
            msc.Close();
            return ds.Tables[0];
        }

        public void cadastrarProd(string nome, float preco)
        {
            MySqlConnection msc = new MySqlConnection();
            msc.ConnectionString = "server=localhost;User Id=root;password='';database=ControValores";
            msc.Open();
            MySqlCommand mscommand = new MySqlCommand("INSERT INTO `controvalores`.`cadprod` (`nmProd`, `preco`) VALUES ('" + nome + "','" + preco + "');");
            mscommand.Connection = msc; //use
            mscommand.ExecuteNonQuery(); //raio
            msc.Close();
        }

        public void cadastrarProdItem(int idProd, string nmProd, int quantidade, float preco)
        {
            MySqlConnection msc = new MySqlConnection();
            msc.ConnectionString = "server=localhost;User Id=root;password='';database=ControValores";
            msc.Open();
            MySqlCommand mscommand = new MySqlCommand("INSERT INTO `controvalores`.`cadproditem` (`idProd`, `nmProd`,`quantidade`,`preco`) VALUES ('" + idProd + "','" + nmProd + "','" + quantidade + "','" + preco + "');");
            mscommand.Connection = msc; //use
            mscommand.ExecuteNonQuery(); //raio
            msc.Close();
        }
    }
}
