using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Web;
using System.Web.Services;
using System.Web.Services.Protocols;

namespace Prototipo3C_WS
{
    /// <summary>
    /// Summary description for Service1
    /// </summary>
    [WebService(Namespace = "http://www.pece.org.br/")]
    public class Itens : System.Web.Services.WebService
    {

        [WebMethod(MessageName="IncluirRegistro")]
        public Response IncluirResgistro(Request _request )
        {
            Response _response = new Response();
            try
            {               
                if (_request != null)
                {
                    foreach (Objeto obj in _request.Objetos)
                    {

                        new Prototipo3C_BD.Repositorio.ObjetoRepository().CadastrarObjeto(new Prototipo3C_Entidade.Entidade.Objeto(obj.ObjId, obj.Nome,obj.Cor));
                    }
                    _response.StatusCode = 200;
                }
            }
            catch (Exception ex)
            {
                _response.StatusCode = 500;
                _response.ErrorMsg = string.Format("Erro no cadastro: {0}", ex.Message);
            }
            return _response;
        }

        [WebMethod(MessageName = "ObterRegistros")]
        public Response ObterRegistros()
        {
            Response _response = new Response();
            try
            {
                Prototipo3C_BD.Interfaces.IObjetoRepository repository = new Prototipo3C_BD.Repositorio.ObjetoRepository();
                 
                IList<Prototipo3C_Entidade.Entidade.Objeto> _lstObjetos = repository.ObterTodos();
                _response.Objetos = new List<Objeto>();
                foreach (Prototipo3C_Entidade.Entidade.Objeto _obj in _lstObjetos)
                {
                    Objeto _objeto = new Objeto(_obj.ObjetoId, _obj.Nome, _obj.Cor);
                    _response.Objetos.Add(_objeto);

                }
                    
            }
            catch (Exception ex)
            {
                _response.StatusCode = 500;
                _response.ErrorMsg = string.Format("Erro na solicitacao dos registros: {0}", ex.Message);
            }
            return _response;
        }
    }
}
