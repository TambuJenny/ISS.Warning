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
    
    public partial class ExclusoesCobertura
    {
        public string IdExclusoesCobertura { get; set; }
        public string CodExclusoesCobertura { get; set; }
        public Nullable<System.DateTime> DataCriacao { get; set; }
        public Nullable<System.DateTime> DataAtualizacao { get; set; }
        public string EstadoId { get; set; }
        public string CoberturaId { get; set; }
        public string ExclusaoId { get; set; }
    
        public virtual Cobertura Cobertura { get; set; }
        public virtual Exclusoes Exclusoes { get; set; }
    }
}