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
    
    public partial class BoletimAdesaoSaude
    {
        public string IdBoletimAdesaoSaude { get; set; }
        public Nullable<System.DateTime> DataInclusao { get; set; }
        public Nullable<System.DateTime> DataExclusao { get; set; }
        public Nullable<System.DateTime> DataAnulacao { get; set; }
        public string Proponente { get; set; }
        public string ApoliceId { get; set; }
        public string OutrosSegurosId { get; set; }
        public string ObservacoesBoletimAdesao { get; set; }
        public Nullable<System.DateTime> DataActualizacao { get; set; }
        public Nullable<System.DateTime> DataCriacao { get; set; }
        public string EstadoId { get; set; }
        public string CodBoletimAdesaoSaude { get; set; }
    
        public virtual Apolice Apolice { get; set; }
        public virtual Estado Estado { get; set; }
        public virtual ObservacoesBoletimAdesao ObservacoesBoletimAdesao1 { get; set; }
        public virtual OutrosSeguros OutrosSeguros { get; set; }
    }
}
