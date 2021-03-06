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
    
    public partial class TipoPagamento
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TipoPagamento()
        {
            this.Contrato = new HashSet<Contrato>();
            this.ContratoPrestadorEmpresa = new HashSet<ContratoPrestadorEmpresa>();
            this.Operacao = new HashSet<Operacao>();
            this.OperacoesPagamento = new HashSet<OperacoesPagamento>();
            this.SubTipoPagamento = new HashSet<SubTipoPagamento>();
            this.TipoPagamentoTipoContrato = new HashSet<TipoPagamentoTipoContrato>();
        }
    
        public string IdTipoPagamento { get; set; }
        public string Designacao { get; set; }
        public string EstadoId { get; set; }
        public System.DateTime DataCriacao { get; set; }
        public System.DateTime DataActualizacao { get; set; }
        public string CodTipoPagamento { get; set; }
        public Nullable<int> CodigoTipoPagamento { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Contrato> Contrato { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ContratoPrestadorEmpresa> ContratoPrestadorEmpresa { get; set; }
        public virtual Estado Estado { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Operacao> Operacao { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OperacoesPagamento> OperacoesPagamento { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SubTipoPagamento> SubTipoPagamento { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TipoPagamentoTipoContrato> TipoPagamentoTipoContrato { get; set; }
    }
}
