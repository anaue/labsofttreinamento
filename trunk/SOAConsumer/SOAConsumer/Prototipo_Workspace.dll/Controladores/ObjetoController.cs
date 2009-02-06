using System;
using System.Data;
using System.Configuration;
using System.Collections.Generic;
using System.Web;
using Prototipo3C_Entidade.Entidade;
using Prototipo_Workspace.dll;

namespace Prototipo3C_Negocio.Controladores
{
    public class ObjetoController
    {

        public IList<Prototipo3C_Entidade.Entidade.Objeto> ObterObjetos()
        {
            Prototipo_Workspace.dll.Patrimonio.Itens wsPatrimonio;
            Prototipo_Workspace.dll.Patrimonio.Response response;
            List<Prototipo3C_Entidade.Entidade.Objeto> lstObj;

            lstObj = new List<Prototipo3C_Entidade.Entidade.Objeto>();
            wsPatrimonio = new Prototipo_Workspace.dll.Patrimonio.Itens();
            try
            {

                response = wsPatrimonio.ObterRegistros();
                if (response != null)
                {

                    foreach (Prototipo_Workspace.dll.Patrimonio.Objeto obj in response.ColecaoObjetos)
                    {
                        lstObj.Add(new Prototipo3C_Entidade.Entidade.Objeto(obj.ObjId,obj.Campo,obj.Valor));
                    }


                }
            }
            catch(Exception ex)
            {
                return lstObj;
            }


            return lstObj;
        }

        public bool CadastrarObjeto(Objeto objeto)
        {
            Prototipo_Workspace.dll.Patrimonio.Itens wsPatrimonio;
            Prototipo_Workspace.dll.Patrimonio.Response response;
            Prototipo_Workspace.dll.Patrimonio.Request request;

            wsPatrimonio = new Prototipo_Workspace.dll.Patrimonio.Itens();
            request = new Prototipo_Workspace.dll.Patrimonio.Request();

            request.ColecaoObjetos = new Prototipo_Workspace.dll.Patrimonio.Objeto[1];
            request.ColecaoObjetos[0] = new Prototipo_Workspace.dll.Patrimonio.Objeto();

            request.ColecaoObjetos[0].Campo = objeto.Nome;
            request.ColecaoObjetos[0].ObjId = objeto.ObjetoId;
            request.ColecaoObjetos[0].Valor = objeto.Cor;
            try
            {
                response = wsPatrimonio.IncluirResgistro(request);
            }
            catch (Exception ex)
            {
                return false;
            }

            return (response != null && response.Cod_status == 200);
        }


    }
}
