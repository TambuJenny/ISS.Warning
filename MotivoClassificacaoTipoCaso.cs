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
    
    public partial class MotivoClassificacaoTipoCaso
    {
        public string IdMotivoTipoCaso { get; set; }
        public string MotivoClassificacaoId { get; set; }
        public string TipoCasoId { get; set; }
        public string CodMotivoClassificacaoTipoCaso { get; set; }
        public string EstadoId { get; set; }
        public Nullable<System.DateTime> DataCriacao { get; set; }
        public Nullable<System.DateTime> DataAtualizacao { get; set; }
    
        public virtual Estado Estado { get; set; }
        public virtual MotivoClassificacao MotivoClassificacao { get; set; }
        public virtual TipoCaso TipoCaso { get; set; }
    }
}
