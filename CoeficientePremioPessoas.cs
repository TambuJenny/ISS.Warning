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
    
    public partial class CoeficientePremioPessoas
    {
        public string IdCoeficientePremioPessoas { get; set; }
        public Nullable<int> NumeroMax { get; set; }
        public Nullable<int> NumeroMin { get; set; }
        public Nullable<double> AgravamentoOuDesconto { get; set; }
        public string CodCoeficientePremioPessoas { get; set; }
        public Nullable<System.DateTime> DataActualizacao { get; set; }
        public Nullable<System.DateTime> DataCriacao { get; set; }
        public string EstadoId { get; set; }
        public string TipoCoberturaId { get; set; }
        public string CoberturaId { get; set; }
    
        public virtual Cobertura Cobertura { get; set; }
        public virtual Estado Estado { get; set; }
        public virtual Estado Estado1 { get; set; }
        public virtual TipoCobertura TipoCobertura { get; set; }
    }
}
