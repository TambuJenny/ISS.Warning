//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ISS.Warning
{
    using System;
    using System.Collections.Generic;
    
    public partial class DocumentosPortfolio
    {
        public string IdDocumentosPortfolio { get; set; }
        public string DocumentoId { get; set; }
        public string PortfolioId { get; set; }
        public string CodDocumentos { get; set; }
        public string Estadoid { get; set; }
        public Nullable<System.DateTime> DataCriacao { get; set; }
        public Nullable<System.DateTime> DataAtualizacao { get; set; }
    
        public virtual Documentos Documentos { get; set; }
        public virtual Estado Estado { get; set; }
        public virtual Portfolio Portfolio { get; set; }
    }
}
