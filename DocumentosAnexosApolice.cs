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
    
    public partial class DocumentosAnexosApolice
    {
        public string IdDocumentoAnexo { get; set; }
        public string Titulo { get; set; }
        public string CaminhoFicheiro { get; set; }
        public string ApoliceID { get; set; }
        public Nullable<System.DateTime> DataCriacao { get; set; }
        public Nullable<System.DateTime> DataAtualizacao { get; set; }
        public string EstadoID { get; set; }
        public string TipoDocumentosSubScricaoId { get; set; }
        public string CotacaoId { get; set; }
        public string DocumentosProcessoSubscricaoId { get; set; }
    
        public virtual Apolice Apolice { get; set; }
        public virtual Cotacao Cotacao { get; set; }
        public virtual DocumentosProcessoSubscricao DocumentosProcessoSubscricao { get; set; }
        public virtual Estado Estado { get; set; }
        public virtual TipoDocumentosSubScricao TipoDocumentosSubScricao { get; set; }
    }
}
