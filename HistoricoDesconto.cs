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
    
    public partial class HistoricoDesconto
    {
        public string IdHistoricoDesconto { get; set; }
        public string IdDesconto { get; set; }
        public Nullable<double> TaxaDesconto { get; set; }
        public Nullable<System.DateTime> DataInicio { get; set; }
        public Nullable<System.DateTime> DataFim { get; set; }
        public string EstadoId { get; set; }
        public string TipoDescontoID { get; set; }
        public string PlanoProdutoID { get; set; }
        public string CodDesconto { get; set; }
        public Nullable<double> ValorMinPremioSimples { get; set; }
        public Nullable<double> ValorMaxPremioSimples { get; set; }
        public string PapelID { get; set; }
        public Nullable<System.DateTime> DataCriacao { get; set; }
        public Nullable<System.DateTime> DataAtualizacao { get; set; }
        public Nullable<double> TaxaMaxDesconto { get; set; }
        public Nullable<double> ValorMinDesconto { get; set; }
        public Nullable<double> ValorMaxDesconto { get; set; }
        public Nullable<bool> IsTaxa { get; set; }
        public string UltModificacaoPorID { get; set; }
        public string PrecarioProdutoID { get; set; }
    }
}
