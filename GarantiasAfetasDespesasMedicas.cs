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
    
    public partial class GarantiasAfetasDespesasMedicas
    {
        public string GarantiasProdutoId { get; set; }
        public Nullable<double> DespesasApresentadas { get; set; }
        public Nullable<double> Comparticipacao { get; set; }
        public Nullable<System.DateTime> DataActualizacao { get; set; }
        public Nullable<System.DateTime> DataCriacao { get; set; }
        public string EstadoId { get; set; }
        public string ReembolsoDespesasMedicas { get; set; }
    
        public virtual Estado Estado { get; set; }
        public virtual GarantiasCobertura GarantiasCobertura { get; set; }
        public virtual ReembolsoDespesasMedicas ReembolsoDespesasMedicas1 { get; set; }
    }
}
