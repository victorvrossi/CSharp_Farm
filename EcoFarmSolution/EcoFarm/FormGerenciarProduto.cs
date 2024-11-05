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
        ListaProdutoBean bean = new ListaProdutoBean();
        EditarProduto editar = new EditarProduto();
        public FormGerenciarProduto()
        {
            InitializeComponent();
            editar.CodeEditar = tabProdutoEditar;
            bean.Editar=editar;
            bean.ControleTabela = tableProdutoLista.Controls;

        }

        private Size rootSize()
        {
            return new Size(898, 548);
        }


        private void button1_Click(object sender, EventArgs e)
        {
            tabProdutoListar();
            if (produtoEditar != null)
            {
                editar.editarSelecionado(txNome.Text, txDescricao.Text, txValor.Text);
                button1.Text = "Confirmar";
            }
            else
            {
                bean.adicionarProduto(txNome.Text, txDescricao.Text, txValor.Text);
            }



            txNome.Text = "";
            txDescricao.Text = "";
            txValor.Text = "";
            bean.gerarTabela();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        void tabProdutoListar()
        {
            tabProdutos.SelectedIndex = 0;
        }
        ItemListaProduto produtoEditar;
        void tabProdutoEditar(ItemListaProduto produto)
        {
            tabProdutos.SelectedIndex = 1;
            txNome.Text = produto.Nome;
            txDescricao.Text = produto.Descricao;
            txValor.Text = produto.Valor;
            produtoEditar = produto;
            button1.Text = "Confirmar edição";

        }
    }
}
