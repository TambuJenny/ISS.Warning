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
    
    public partial class Comissionamento
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Comissionamento()
        {
            this.CanaisComissionamento = new HashSet<CanaisComissionamento>();
            this.CanalComissionamento = new HashSet<CanalComissionamento>();
            this.Comissao = new HashSet<Comissao>();
            this.ComissionamentoPlano = new HashSet<ComissionamentoPlano>();
            this.Contrato = new HashSet<Contrato>();
            this.ContratoComissionamento = new HashSet<ContratoComissionamento>();
            this.FidelizacaoComissionamento = new HashSet<FidelizacaoComissionamento>();
            this.ProvinciaComissionamento = new HashSet<ProvinciaComissionamento>();
            this.SectorActividadeComissionamento = new HashSet<SectorActividadeComissionamento>();
            this.TipoComissionamentoResseguro = new HashSet<TipoComissionamentoResseguro>();
            this.TipoSegmentosComissionamento = new HashSet<TipoSegmentosComissionamento>();
            this.TipoSegmentoComissionamento = new HashSet<TipoSegmentoComissionamento>();
            this.SubscricaoCessaoRetencao = new HashSet<SubscricaoCessaoRetencao>();
        }
    
        public string IdComissionamento { get; set; }
        public Nullable<double> Desconto { get; set; }
        public string CanalId { get; set; }
        public string SegmentoId { get; set; }
        public string EstadoId { get; set; }
        public string SectorActividadeId { get; set; }
        public Nullable<double> CapitalMin { get; set; }
        public Nullable<double> CapitalMax { get; set; }
        public string FormaPagamentoId { get; set; }
        public string PapelId { get; set; }
        public string PessoaId { get; set; }
        public string CaixaId { get; set; }
        public Nullable<double> TaxaComissionamento { get; set; }
        public Nullable<System.DateTime> DataInicio { get; set; }
        public Nullable<System.DateTime> DataFim { get; set; }
        public string PlanoProdutoId { get; set; }
        public Nullable<double> ComissaoMediacaoCobranca { get; set; }
        public Nullable<double> ComissaoMediacao { get; set; }
        public Nullable<double> ComissaoMediacaoAngariacao { get; set; }
        public Nullable<double> ComissaoCorretagem { get; set; }
        public Nullable<double> ComissaoMediacaoTotal { get; set; }
        public Nullable<double> DescontoMinimo { get; set; }
        public Nullable<double> ComissaoCorretagemCobranca { get; set; }
        public Nullable<double> ComissaoCorretagemAngariacao { get; set; }
        public Nullable<double> ComissaoCorretagemTotal { get; set; }
    
        public virtual Caixa Caixa { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CanaisComissionamento> CanaisComissionamento { get; set; }
        public virtual Canal Canal { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CanalComissionamento> CanalComissionamento { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Comissao> Comissao { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ComissionamentoPlano> ComissionamentoPlano { get; set; }
        public virtual Estado Estado { get; set; }
        public virtual FormaPagamento FormaPagamento { get; set; }
        public virtual Papel Papel { get; set; }
        public virtual Pessoa Pessoa { get; set; }
        public virtual PlanoProduto PlanoProduto { get; set; }
        public virtual SectorActividade SectorActividade { get; set; }
        public virtual SegmentoProduto SegmentoProduto { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Contrato> Contrato { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ContratoComissionamento> ContratoComissionamento { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FidelizacaoComissionamento> FidelizacaoComissionamento { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ProvinciaComissionamento> ProvinciaComissionamento { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SectorActividadeComissionamento> SectorActividadeComissionamento { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TipoComissionamentoResseguro> TipoComissionamentoResseguro { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TipoSegmentosComissionamento> TipoSegmentosComissionamento { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TipoSegmentoComissionamento> TipoSegmentoComissionamento { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SubscricaoCessaoRetencao> SubscricaoCessaoRetencao { get; set; }
    }
}
