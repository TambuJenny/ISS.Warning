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
    
    public partial class TipoConta
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TipoConta()
        {
            this.BonusTipoConta = new HashSet<BonusTipoConta>();
            this.Cliente = new HashSet<Cliente>();
            this.ContaFinanceira = new HashSet<ContaFinanceira>();
            this.DescontoTipoConta = new HashSet<DescontoTipoConta>();
            this.Despesa = new HashSet<Despesa>();
            this.DespesasTipoConta = new HashSet<DespesasTipoConta>();
            this.DocumentosTipoConta = new HashSet<DocumentosTipoConta>();
            this.DocumentosTipoContaFinanceira = new HashSet<DocumentosTipoContaFinanceira>();
            this.Encargos = new HashSet<Encargos>();
            this.EncargosTipoConta = new HashSet<EncargosTipoConta>();
            this.Imposto = new HashSet<Imposto>();
            this.ImpostoTipoConta = new HashSet<ImpostoTipoConta>();
            this.NotasTipoConta = new HashSet<NotasTipoConta>();
            this.PapelTipoConta = new HashSet<PapelTipoConta>();
            this.SubTipoConta = new HashSet<SubTipoConta>();
            this.TipoCartao = new HashSet<TipoCartao>();
            this.TipoContratoTipoConta = new HashSet<TipoContratoTipoConta>();
            this.ValorCativo = new HashSet<ValorCativo>();
        }
    
        public string IdTipoConta { get; set; }
        public string Designacao { get; set; }
        public string NaturezaMovimentoId { get; set; }
        public string SubContaId { get; set; }
        public string EstadoID { get; set; }
        public Nullable<System.DateTime> DataCriacao { get; set; }
        public Nullable<System.DateTime> DataActualizacao { get; set; }
        public string LinhProdutoId { get; set; }
        public string PapelId { get; set; }
        public string SubTipoContaId { get; set; }
        public int NumOrdem { get; set; }
        public string CodigoTipoConta { get; set; }
        public string ActividadeEmpresaId { get; set; }
    
        public virtual ActividadeEmpresa ActividadeEmpresa { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BonusTipoConta> BonusTipoConta { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Cliente> Cliente { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ContaFinanceira> ContaFinanceira { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DescontoTipoConta> DescontoTipoConta { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Despesa> Despesa { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DespesasTipoConta> DespesasTipoConta { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DocumentosTipoConta> DocumentosTipoConta { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DocumentosTipoContaFinanceira> DocumentosTipoContaFinanceira { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Encargos> Encargos { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<EncargosTipoConta> EncargosTipoConta { get; set; }
        public virtual Estado Estado { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Imposto> Imposto { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ImpostoTipoConta> ImpostoTipoConta { get; set; }
        public virtual LinhaProduto LinhaProduto { get; set; }
        public virtual NaturezaMovimento NaturezaMovimento { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<NotasTipoConta> NotasTipoConta { get; set; }
        public virtual Papel Papel { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PapelTipoConta> PapelTipoConta { get; set; }
        public virtual PlanoContas PlanoContas { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SubTipoConta> SubTipoConta { get; set; }
        public virtual SubTipoConta SubTipoConta1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TipoCartao> TipoCartao { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TipoContratoTipoConta> TipoContratoTipoConta { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ValorCativo> ValorCativo { get; set; }
    }
}
