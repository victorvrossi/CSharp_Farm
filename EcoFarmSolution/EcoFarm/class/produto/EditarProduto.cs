using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcoFarm.@class.produto
{
    internal class EditarProduto
    {
        internal Action<ItemListaProduto> CodeEditar;
        private Boolean editarKey;
        private ItemListaProduto selecionado;

        public EditarProduto()
        {
            editarKey = false;
        }


        internal void editarSelecionado(string text1, string text2, string text3)
        {
            selecionado.Nome = text1;
            selecionado.Descricao = text2;
            selecionado.Valor = text3;
        }

        internal bool isEditar()
        {
            return editarKey;
        }

        internal void selecionarProdutoParaEditar(ItemListaProduto produto)
        {
            this.selecionado=produto;
            CodeEditar.Invoke(produto);
        }
    }
}
