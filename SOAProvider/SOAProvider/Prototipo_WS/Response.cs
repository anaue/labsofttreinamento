using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Prototipo3C_WS
{ 
    [XmlRoot(ElementName = "Msg_Resposta")]
    public class Response
    {
    
        public Response()
        {
        }
        
        private int _statusCode;
        [XmlElement(ElementName = "Cod_status")]
        public int StatusCode
        {
            get { return _statusCode; }
            set { _statusCode = value; }
        }


        private string _errorMsg;
        [XmlElement(ElementName = "Msg_erro",IsNullable=true)]
        public string ErrorMsg
        {
            get { return _errorMsg; }
            set { _errorMsg = value; }
        }

        private List<Objeto> _Objetos;

        [XmlArray(ElementName = "ColecaoObjetos",IsNullable=true)]
        public List<Objeto> Objetos
        {
            get { return _Objetos; }
            set { _Objetos = value; }
        }
    }
}
