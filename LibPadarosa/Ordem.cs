using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibPadarosa
{
    public class Ordem
    {
        
        public int id_categoria { get; set; }
        public string NomeProduto { get; set; }
        public double Preco { get; set; }
        public string CategoriaProduto { get; set; }
        public int Id { get; set;}
        public int IdFicha { get; set;}
        public int IdProduto { get; set;}
        public int Quantidade { get; set;}
        public int IdRespCadastro { get; set;}
        public bool Situacao { get; set;}

        
    }
}
