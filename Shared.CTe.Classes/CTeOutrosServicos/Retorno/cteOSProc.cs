using System;
using System.Xml.Serialization;
using CTe.Classes.Protocolo;
using DFe.Classes.Flags;
using DFe.Utils;

namespace CTe.CTeOSDocumento.CTe.CTeOS.Retorno
{
    [Serializable]
    [XmlRoot(Namespace = "http://www.portalfiscal.inf.br/cte",
        ElementName = "cteOSProc")]
    public class cteOSProc
    {
        [XmlAttribute]
        public VersaoServico versao { get; set; }

        public global::CTe.CTeOSClasses.CTeOS CTeOS { get; set; }

        public protCTe protCTe { get; set; }


        public static cteOSProc LoadXmlString(string xml)
        {
            return FuncoesXml.XmlStringParaClasse<cteOSProc>(xml);
        }

        public static cteOSProc LoadXmlArquivo(string caminhoArquivoXml)
        {
            return FuncoesXml.ArquivoXmlParaClasse<cteOSProc>(caminhoArquivoXml);
        }
    }
}