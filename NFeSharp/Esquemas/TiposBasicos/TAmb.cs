﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace NFeSharp.Esquemas.TiposBasicos
{
        
    /// <summary>
    /// Identificação do Ambiente
    /// </summary>
    [Serializable]
    [XmlType(Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public enum TAmb
    {        
        [XmlEnumAttribute("1")]
        Producao,
        
        [XmlEnumAttribute("2")]
        Homologacao,
    }
}
