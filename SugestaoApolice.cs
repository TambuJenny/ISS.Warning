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
    
    public partial class SugestaoApolice
    {
        public string IdSugestaoApolice { get; set; }
        public string ApoliceId { get; set; }
        public string SugestoesId { get; set; }
        public string EstadoId { get; set; }
        public string CodSugestaoApolice { get; set; }
        public Nullable<System.DateTime> DataCriacao { get; set; }
        public Nullable<System.DateTime> DataAtualizacao { get; set; }
    
        public virtual Apolice Apolice { get; set; }
        public virtual Estado Estado { get; set; }
        public virtual Sugestoes Sugestoes { get; set; }
    }
}
