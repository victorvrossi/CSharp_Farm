using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcoFarm.@class.produto
{
    internal class ItemListaProduto
{
        private String _nome;
        private String _descricao;
        private String _valor;
        private int _codigo;

        public String Nome { get { return _nome; } set { this._nome = value; } }

        public String Descricao { get { return _descricao; } set { this._descricao = value; } }

        public String Valor { get { return _valor; } set { this._valor = value; } }

        public int Codigo { get { return _codigo; } set { this._codigo = value; } }
    }
}
