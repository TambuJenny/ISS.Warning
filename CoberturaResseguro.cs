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
    
    public partial class CoberturaResseguro
    {
        public string IdCobertura { get; set; }
        public string CoberturaId { get; set; }
        public string ResseguroId { get; set; }
        public string EstadoId { get; set; }
        public string CodExcessoPerda { get; set; }
        public Nullable<System.DateTime> DataCriacao { get; set; }
        public Nullable<System.DateTime> DataActualizacao { get; set; }
        public string TipoContratoId { get; set; }
        public string PessoaId { get; set; }
        public Nullable<double> Taxa { get; set; }
        public string PlanoProdutoId { get; set; }
        public string ContratoId { get; set; }
        public string SubFormaResseguroId { get; set; }
        public string PartesContratoId { get; set; }
        public Nullable<double> ValorCedido { get; set; }
        public Nullable<double> ValorRetido { get; set; }
    
        public virtual Cobertura Cobertura { get; set; }
        public virtual Contrato Contrato { get; set; }
        public virtual Estado Estado { get; set; }
        public virtual PartesContrato PartesContrato { get; set; }
        public virtual Pessoa Pessoa { get; set; }
        public virtual PlanoProduto PlanoProduto { get; set; }
        public virtual Resseguro Resseguro { get; set; }
        public virtual SubFormaResseguro SubFormaResseguro { get; set; }
        public virtual TipoContrato TipoContrato { get; set; }
    }
}