using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcoFarm.@class.produto
{
    public class ListaProdutoBean
    {
        List<ItemListaProduto> listaProdutos = new List<ItemListaProduto>();
        private TableLayoutControlCollection controlTabelaProdutoItem = null;
        EditarProduto editar;

        public TableLayoutControlCollection ControleTabela { set { this.controlTabelaProdutoItem = value; } }
        internal EditarProduto Editar { get { return editar; } set { editar = value; } }

        public void adicionarProduto(String nome,String descricao, String valor)
        {
            ItemListaProduto produtoNovo = new ItemListaProduto();
            produtoNovo.Nome = nome;
            produtoNovo.Descricao = descricao;
            produtoNovo.Valor = valor;
            listaProdutos.Add(produtoNovo);

        }

        public void gerarTabela()
        {
            int countItens = 0;
            if(listaProdutos.Count < 1) {
                ItemListaProduto produto = new ItemListaProduto();
                produto.Nome = "Nenhum item adicionado";
                controlTabelaProdutoItem.Add(injetarForm(produto), 0, 0);
                return;
            }

            controlTabelaProdutoItem.Clear();
            listaProdutos.ForEach(produto => {
                produto.Codigo = countItens;
                controlTabelaProdutoItem.Add(injetarForm(produto), 0, countItens++);
            });
            

        }

        private Panel injetarForm(ItemListaProduto produto)
        {
            UtilForm util = new UtilForm();
            FormProdutoItemLista formProdutoItemLista = new FormProdutoItemLista();
            formProdutoItemLista.SetProduto(produto);
            formProdutoItemLista.SetItens();
            formProdutoItemLista.Editar = editar;
            //edit.abreTabEditar = selecionarTabProdutoCadastrar;            
            Panel desktop = gerarPanel(formProdutoItemLista.Width,formProdutoItemLista.Height);
            
            util.openForm(desktop, formProdutoItemLista,null);
            return desktop;
        }

        private Panel gerarPanel(int width, int heigt)
        {
            Panel panel3 = new Panel(); ;
            panel3.BackColor = Color.Silver;
            panel3.Size = new Size(width, heigt);
            panel3.TabIndex = 1;
            return panel3;
        }

       
    }
}
