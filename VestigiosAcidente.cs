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
    
    public partial class VestigiosAcidente
    {
        public string IdVestigiosAcidente { get; set; }
        public string Designacao { get; set; }
        public string CodVestigiosAcidente { get; set; }
        public string MotoristaId { get; set; }
        public string TipoVestigioAcidenteId { get; set; }
        public string EstadoId { get; set; }
        public Nullable<System.DateTime> DataCriacao { get; set; }
        public Nullable<System.DateTime> DataAtualizacao { get; set; }
    
        public virtual Estado Estado { get; set; }
        public virtual Motorista Motorista { get; set; }
        public virtual TipoVestigioAcidente TipoVestigioAcidente { get; set; }
    }
}
