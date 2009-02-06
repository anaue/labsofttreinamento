using System;
using System.Data;
using System.Configuration;
using System.Web;

namespace Prototipo3C_Entidade.Entidade
{
    public class Objeto 
    {

        public int ObjetoId { get; private set; }
        public string Nome { get; set; }
        public string Cor { get; set; }

        public Objeto(int objeto_id, string nome, string cor)
        {
            ObjetoId = objeto_id;
            Nome = nome;
            Cor = cor;
        }


    }
}
