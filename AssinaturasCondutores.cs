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
    
    public partial class AssinaturasCondutores
    {
        public string IdAssinaturasCondutores { get; set; }
        public string Assinatura { get; set; }
        public string ParticipacaoSinistroId { get; set; }
        public string EstadoId { get; set; }
        public Nullable<System.DateTime> DataCriacao { get; set; }
        public Nullable<System.DateTime> DataAtualizacao { get; set; }
        public string CondutorId { get; set; }
    
        public virtual Motorista Motorista { get; set; }
        public virtual Estado Estado { get; set; }
        public virtual ParticipacaoSinistro ParticipacaoSinistro { get; set; }
    }
}