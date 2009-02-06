using System;
using System.Data;
using System.Configuration;
using System.Collections.Generic;
using System.Web;
using Prototipo3C_Entidade;

namespace Prototipo3C_BD.Repositorio
{
    public class ObjetoRepository : Prototipo3C_BD.Interfaces.IObjetoRepository
    {
        static IList<Prototipo3C_Entidade.Entidade.Objeto> _objetos;

        public ObjetoRepository()
        {

            _objetos = new List<Prototipo3C_Entidade.Entidade.Objeto>
            {
                new Prototipo3C_Entidade.Entidade.Objeto(1, "Mesa", "Azul"),
                new Prototipo3C_Entidade.Entidade.Objeto(2, "SenhaGmail", "MalditoDevolvaASenha")
            };

        }

        public IList<Prototipo3C_Entidade.Entidade.Objeto> ObterTodos()
        {
            return _objetos;
        }

        public bool CadastrarObjeto(Prototipo3C_Entidade.Entidade.Objeto objeto)
        {
            _objetos.Add(objeto);

            return true;
        }


    }
}
