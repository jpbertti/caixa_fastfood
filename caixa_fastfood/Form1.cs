using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace caixa_fastfood
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja realemente sair?", "Sair", MessageBoxButtons.YesNo) == DialogResult.Yes) 
                Close();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            int codigo, quantidade;
            double valor_unitario;
            string nomeproduto;

            
            codigo = int.Parse(txtCodigo.Text);
            quantidade = int.Parse(txtQuantidade.Text);

            //case

            switch (codigo)
            {
                case 1:
                    nomeproduto = "Sanduiche de Presunto";
                    valor_unitario = 2.30 * quantidade;
                    MessageBox.Show($"{nomeproduto} {valor_unitario.ToString("C")}", "Valor Final");
                    break;
                    
                case 2:
                    nomeproduto = "Suco de Tamarindo";
                    valor_unitario = 1.5 * quantidade;
                    MessageBox.Show($"{nomeproduto} {valor_unitario.ToString("C")}", "Valor Final");
                    break;

                case 3:
                    nomeproduto = "Pastel de Vento";
                    valor_unitario = 1.30 * quantidade;
                    MessageBox.Show($"{nomeproduto} {valor_unitario.ToString("C")}", "Valor Final");
                    break;

                case 4:
                    nomeproduto = "Pão com Margarina";
                    valor_unitario = 0.70 * quantidade;
                    MessageBox.Show($"{nomeproduto} {valor_unitario.ToString("C")}", "Valor Final");
                    break ;

                default:
                    MessageBox.Show("Codigo de Produto inválido, tente outro código;", "Produto não localizado!");
                    break; 
            }

            //IF 


            if (codigo == 1)
            {
                nomeproduto = "Sanduiche de Presunto";
                valor_unitario = 2.30 * quantidade;
                MessageBox.Show($"{nomeproduto} { valor_unitario.ToString("C")}", "Valor Final");
            }
            else if (codigo == 2)
            {
                nomeproduto = "Suco de Tamarindo";
                valor_unitario = 1.5 * quantidade;
                MessageBox.Show($"{nomeproduto} {valor_unitario.ToString("C")}","Valor Final");
            }
            else if (codigo == 3)
            {
                nomeproduto = "Pastel de Vento";
                valor_unitario = 1.30 * quantidade;
                MessageBox.Show($"{nomeproduto} {valor_unitario.ToString("C")}", "Valor Final");
            }
            else if (codigo == 4)
            {
                nomeproduto = "Pão com Margarina";
                valor_unitario = 0.70 * quantidade;
                MessageBox.Show($"{nomeproduto} {valor_unitario.ToString("C")}", "Valor Final");
            }
            else
            {
                MessageBox.Show("Codigo de Produto inválido, tente outro código;", "Produto não localizado!");
            }
            
        }
    }
}
