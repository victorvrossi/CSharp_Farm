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
    public partial class FormProdutoItemLista : Form
    {
        private EditarProduto editar;
        public FormProdutoItemLista()
        {
            InitializeComponent();
        }
        internal void SetItens()
        {
            lbNome.Text = produto.Nome;
            lbDescricao.Text = produto.Descricao;
            lbValor.Text = produto.Valor;
        }

        ItemListaProduto produto;

        internal EditarProduto Editar { get { return editar; } set { editar = value; } }

        internal void SetProduto(ItemListaProduto value) => this.produto = value;

        private void btEditar_Click(object sender, EventArgs e)
        {
            editar.selecionarProdutoParaEditar(produto);
        }


    }
}
