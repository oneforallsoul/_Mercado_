using MySql.Data.MySqlClient;
using Mysqlx;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.AccessControl;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace _Mercado_
{

    public partial class Form1 : Form
    {
        string registrar;
        string fk_venda;
        string unid;
        string id_venda;
        string valuetotal;


        public Form1()
        {
            InitializeComponent();
            Lista_Produtos();
            NEW_VENDA();

        }
        private void Value_Unid()
        {
            try
            {
                Variavel.conexao.Open();
                Variavel.comando.CommandText = "SELECT preco FROM tbl_produtos WHERE id = '" + registrar + "'";
                MySqlDataReader resultado = Variavel.comando.ExecuteReader();

                if (resultado.Read())
                {
                    unid = resultado.GetDouble(0).ToString();
                }
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }
            finally
            {
                Variavel.conexao.Close();
            }

        }
        private void Lista_Produtos()
        {
            try
            {
                Variavel.conexao.Open();
                Variavel.comando.CommandText = "SELECT * FROM tbl_produtos;";
                MySqlDataAdapter ADP = new MySqlDataAdapter(Variavel.comando);
                DataTable tbl = new DataTable();
                ADP.Fill(tbl);

                dataGridViewPRODUTOS.DataSource = tbl;
                dataGridViewPRODUTOS.Columns["id"].HeaderText = "código";
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);

            }
            finally
            {
                Variavel.conexao.Close();
            }

        }

        private void NEW_VENDA()
        {
            try
            {
                Variavel.conexao.Open();
                Variavel.comando.CommandText = "INSERT INTO tbl_vendas (data_compra, fk_funcionarios) VALUES (CURDATE()," + Variavel.id_func + ");";
                Variavel.comando.ExecuteNonQuery();

            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }
            finally
            {
                Variavel.conexao.Close();
            }
            
            try
            {
                Variavel.conexao.Open();
                Variavel.comando.CommandText = "SELECT MAX(id) FROM tbl_vendas;";
                MySqlDataReader resultado = Variavel.comando.ExecuteReader();

                if (resultado.Read())
                {
                    id_venda = resultado.GetInt32(0).ToString();
                }

            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }
            finally
            {
                Variavel.conexao.Close();
            }
        }

        private void buttonAdicionar_Click(object sender, EventArgs e)
        {
            vendas();
            string produto = dataGridViewPRODUTOS.CurrentRow.Cells[0].Value.ToString();

            if (textBoxUNIDADE.Text != "" && numericUpDown1.Text != "")
            {
                try
                {
                    Variavel.conexao.Open();
                    Variavel.comando.CommandText = "INSERT INTO tbl_itens_vendas (fk_produtos, fk_vendas, quantidade, valor_venda ) VALUES ('" + produto + "', '" + fk_venda + "', '" + numericUpDown1.Text + "', '" + textBoxUNIDADE.Text.Replace(",", ".") + "');";
                    Variavel.comando.ExecuteNonQuery();

                }
                catch (Exception erro)
                {
                    MessageBox.Show(erro.Message);
                }
                finally
                {
                    Variavel.conexao.Close();

                }
                Variavel.carrinho = Variavel.carrinho + (double.Parse(numericUpDown1.Value.ToString()) * double.Parse(textBoxUNIDADE.Text));
                textBoxTOTAL.Text = Variavel.carrinho.ToString();
            }

        }

        private void vendas()
        {
            try
            {
                Variavel.conexao.Open();
                Variavel.comando.CommandText = "SELECT MAX(id) FROM tbl_vendas";
                MySqlDataReader resultado = Variavel.comando.ExecuteReader();

                if (resultado.Read()) 
                { fk_venda = resultado.GetInt32(0).ToString();}
            }
            catch (Exception erro) {  MessageBox.Show(erro.Message); }

            finally {Variavel .conexao.Close();}
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            if (registrar.ToString().Length > 0 && numericUpDown1.Text != "")
            {
                Value_Unid();

                double unitario = double.Parse(unid);
                int quantidade = int.Parse(numericUpDown1.Value.ToString());
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Variavel.conexao.Open();
                Variavel.comando.CommandText = "UPDATE tbl_vendas SET valor_total = " + textBoxTOTAL.Text.Replace(",", ".") + " WHERE id = " + id_venda + ";";
                Variavel.comando.ExecuteReader();       

            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }
            finally
            {
                Variavel.conexao.Close();
            }
            MessageBox.Show("Compra efetuada com sucesso");
            Clear();
            id_venda = null;

            if (DialogResult.Yes == MessageBox.Show("Deseja iniciar uma nova venda? Caso não o aplicativo irá encerrar","Atenção",MessageBoxButtons.YesNo))
            {
                NEW_VENDA();
                Lista_Produtos();
                Clear();
            }
            else
            {
                this.Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Deseja realmente cancelar a compra?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            this.Close();
        }

        private void dataGridViewPRODUTOS_DoubleClick(object sender, EventArgs e)
        {
            registrar = dataGridViewPRODUTOS.CurrentRow.Cells[0].Value.ToString();

            textBoxUNIDADE.Text = dataGridViewPRODUTOS.CurrentRow.Cells[2].Value.ToString();
        }

        private void Clear()
        {
            textBoxTOTAL.Clear();
            numericUpDown1.Text = "0";
            textBoxUNIDADE.Clear();
        }
    }
}
