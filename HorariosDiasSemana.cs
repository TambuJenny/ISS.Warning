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
    
    public partial class HorariosDiasSemana
    {
        public string idHorarioDiasSemana { get; set; }
        public string HorarioFuncionamentoId { get; set; }
        public string DiasSemanaId { get; set; }
        public string EstadoId { get; set; }
        public Nullable<System.DateTime> DataCriacao { get; set; }
        public Nullable<System.DateTime> DataAtualizacao { get; set; }
        public string codHorariosDiasSemana { get; set; }
    
        public virtual DiasSemana DiasSemana { get; set; }
        public virtual Estado Estado { get; set; }
        public virtual HorarioFuncionamento HorarioFuncionamento { get; set; }
    }
}
