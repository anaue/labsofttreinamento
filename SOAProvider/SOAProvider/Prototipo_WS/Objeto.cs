using System;
using System.Xml.Serialization;

namespace Prototipo3C_WS
{
    [XmlRoot(ElementName = "Objeto")]
    public class Objeto
    {
        private Objeto()
        {
        }

        private int _ObjId;
        [XmlElement(ElementName = "ObjId")]
        public int ObjId
        {
            get { return _ObjId; }
            set { _ObjId = value; }
        }
        private string _Nome;
        [XmlElement(ElementName = "Campo")]
        public string Nome
        {
            get { return _Nome; }
            set { _Nome = value; }
        }
        string _Cor;
        [XmlElement(ElementName = "Valor")]
        public string Cor
        {
            get { return _Cor; }
            set { _Cor = value; }
        }

        public Objeto(int objeto_id, string nome, string cor)
        {
            _ObjId = objeto_id;
            _Nome = nome;
            _Cor = cor;
        }


    }
}
