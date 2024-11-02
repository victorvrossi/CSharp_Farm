﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcoFarm.@class.produto
{
    public class ListaProdutoBean
    {
        List<ItemListaProduto> listaProdutos = new List<ItemListaProduto>();
        TableLayoutControlCollection controlTabelaProdutoItem;

        public TableLayoutControlCollection ControleTabela { set { this.controlTabelaProdutoItem = value; } }

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
            listaProdutos.ForEach(produto => {
                controlTabelaProdutoItem.Add(injetarForm(produto), 0, countItens++);
            });
            

        }

        private Panel injetarForm(ItemListaProduto produto)
        {
            UtilForm util = new UtilForm();
            FormProdutoItemLista formProdutoItemLista = new FormProdutoItemLista();
            formProdutoItemLista.SetProduto(produto);
            formProdutoItemLista.SetItens();
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