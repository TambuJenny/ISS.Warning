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
    
    public partial class RelatanteSugestao
    {
        public string IdRelatanteSugestao { get; set; }
        public string RelatanteId { get; set; }
        public string SugestaoId { get; set; }
        public string EstadoId { get; set; }
        public string CodRelatanteSugestao { get; set; }
        public Nullable<System.DateTime> DataCriacao { get; set; }
        public Nullable<System.DateTime> DataAtualizacao { get; set; }
        public string TipoRelatanteId { get; set; }
    
        public virtual Estado Estado { get; set; }
        public virtual Pessoa Pessoa { get; set; }
        public virtual Sugestoes Sugestoes { get; set; }
        public virtual TipoRelatante TipoRelatante { get; set; }
    }
}
