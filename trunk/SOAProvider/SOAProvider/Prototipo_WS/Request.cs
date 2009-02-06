using System;
using System.Xml.Serialization;
using System.Collections.Generic;

using Prototipo3C_Entidade.Entidade;

namespace Prototipo3C_WS
{
    [XmlRoot(ElementName = "Item")]
    public class Request
    {
        public Request()
        {
        }
       
        private List<Objeto> _Objetos;

        [XmlArray(ElementName = "ColecaoObjetos")]
        public List<Objeto> Objetos
        {
            get { return _Objetos; }
            set { _Objetos = value; }
        }
    

    }
}
