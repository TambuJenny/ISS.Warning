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
    
    public partial class DocumentosAutomovel
    {
        public string IdDocumentosAutomovel { get; set; }
        public string NomeDocumento { get; set; }
        public string TipoDocumento { get; set; }
        public Nullable<System.DateTime> DataCriacao { get; set; }
        public Nullable<System.DateTime> DataAtualizacao { get; set; }
        public string AutomovelID { get; set; }
        public string DocumentoURL { get; set; }
    
        public virtual Automovel Automovel { get; set; }
    }
}
