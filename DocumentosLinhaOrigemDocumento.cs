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
    
    public partial class DocumentosLinhaOrigemDocumento
    {
        public string IdDocumentosLinhaOrigemDocumento { get; set; }
        public string DocumentosLinhaId { get; set; }
        public string OrigemDocumentoId { get; set; }
        public Nullable<System.DateTime> DataCriacao { get; set; }
        public Nullable<System.DateTime> DataAtualizacao { get; set; }
        public string EstadoId { get; set; }
    
        public virtual DocumentosLinha DocumentosLinha { get; set; }
        public virtual Estado Estado { get; set; }
        public virtual OrigemDocumento OrigemDocumento { get; set; }
    }
}
