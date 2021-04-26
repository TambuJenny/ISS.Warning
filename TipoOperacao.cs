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
    
    public partial class TipoOperacao
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TipoOperacao()
        {
            this.Agravamento = new HashSet<Agravamento>();
            this.ClassificacaoOperacao = new HashSet<ClassificacaoOperacao>();
            this.ContasAPagar = new HashSet<ContasAPagar>();
            this.Contrato = new HashSet<Contrato>();
            this.Desconto = new HashSet<Desconto>();
            this.Despesa = new HashSet<Despesa>();
            this.DespesaContrato = new HashSet<DespesaContrato>();
            this.Encargos = new HashSet<Encargos>();
            this.EncargosContrato = new HashSet<EncargosContrato>();
            this.Fraccionamento = new HashSet<Fraccionamento>();
            this.HistoricoOferta = new HashSet<HistoricoOferta>();
            this.Imposto = new HashSet<Imposto>();
            this.ImpostoContrato = new HashSet<ImpostoContrato>();
            this.MargemVendaProduto = new HashSet<MargemVendaProduto>();
            this.Movimento = new HashSet<Movimento>();
            this.Operacao = new HashSet<Operacao>();
            this.OperacoesPagamento = new HashSet<OperacoesPagamento>();
            this.PrecarioProduto = new HashSet<PrecarioProduto>();
            this.ReservasTecnicas = new HashSet<ReservasTecnicas>();
            this.ServicoContrato = new HashSet<ServicoContrato>();
            this.TipoAgravamento = new HashSet<TipoAgravamento>();
            this.TipoContratoTipoOperacao = new HashSet<TipoContratoTipoOperacao>();
            this.TipoOperacaoProcesso = new HashSet<TipoOperacaoProcesso>();
            this.TipoOperacaoPlano = new HashSet<TipoOperacaoPlano>();
        }
    
        public string IdTipoOperacao { get; set; }
        public string Designacao { get; set; }
        public string CodTipoOperacao { get; set; }
        public Nullable<int> TipoMovimento { get; set; }
        public Nullable<System.DateTime> DataCriacao { get; set; }
        public Nullable<System.DateTime> DataAtualizacao { get; set; }
        public string ValorRegraOperacao { get; set; }
        public string EstadoID { get; set; }
        public string UltModificacaoPorID { get; set; }
        public string CaminhoIcome { get; set; }
        public string PapelId { get; set; }
        public string SubContaCreditoId { get; set; }
        public string SubContaDebitoId { get; set; }
        public string TipoDocumentoId { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Agravamento> Agravamento { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ClassificacaoOperacao> ClassificacaoOperacao { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ContasAPagar> ContasAPagar { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Contrato> Contrato { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Desconto> Desconto { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Despesa> Despesa { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DespesaContrato> DespesaContrato { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Encargos> Encargos { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<EncargosContrato> EncargosContrato { get; set; }
        public virtual Estado Estado { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Fraccionamento> Fraccionamento { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HistoricoOferta> HistoricoOferta { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Imposto> Imposto { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ImpostoContrato> ImpostoContrato { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MargemVendaProduto> MargemVendaProduto { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Movimento> Movimento { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Operacao> Operacao { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OperacoesPagamento> OperacoesPagamento { get; set; }
        public virtual Papel Papel { get; set; }
        public virtual PlanoContas PlanoContas { get; set; }
        public virtual PlanoContas PlanoContas1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PrecarioProduto> PrecarioProduto { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ReservasTecnicas> ReservasTecnicas { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ServicoContrato> ServicoContrato { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TipoAgravamento> TipoAgravamento { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TipoContratoTipoOperacao> TipoContratoTipoOperacao { get; set; }
        public virtual TipoDocumentos TipoDocumentos { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TipoOperacaoProcesso> TipoOperacaoProcesso { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TipoOperacaoPlano> TipoOperacaoPlano { get; set; }
    }
}