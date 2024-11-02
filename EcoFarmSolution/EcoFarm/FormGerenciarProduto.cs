using EcoFarm.@class;
using EcoFarm.@class.produto;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EcoFarm
{
    public partial class FormGerenciarProduto : Form
    {
        public FormGerenciarProduto()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            tabProdutos.SelectedIndex = 0;
            ListaProdutoBean bean = new ListaProdutoBean();
            bean.ControleTabela = tableProdutoLista.Controls;
            bean.adicionarProduto(txNome.Text, txDescricao.Text, txValor.Text);
            bean.gerarTabela();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
