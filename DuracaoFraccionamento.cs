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
    
    public partial class DuracaoFraccionamento
    {
        public string IdDuracaoFraccionamento { get; set; }
        public string DuracaoTipoContratoId { get; set; }
        public Nullable<System.DateTime> DataCriacao { get; set; }
        public Nullable<System.DateTime> DataAtualizacao { get; set; }
        public string FraccionamentoPlanoId { get; set; }
    
        public virtual DuracaoTipoContrato DuracaoTipoContrato { get; set; }
        public virtual FraccionamentoPlano FraccionamentoPlano { get; set; }
    }
}
