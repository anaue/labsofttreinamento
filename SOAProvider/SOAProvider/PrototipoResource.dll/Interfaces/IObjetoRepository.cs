using System;
using System.Collections.Generic;
using System.Text;


namespace Prototipo3C_BD.Interfaces
{
    public interface IObjetoRepository
    {
        IList<Prototipo3C_Entidade.Entidade.Objeto> ObterTodos();


        bool CadastrarObjeto(Prototipo3C_Entidade.Entidade.Objeto objeto);
    }
}
