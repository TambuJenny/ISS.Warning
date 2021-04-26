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
    
    public partial class Produto
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Produto()
        {
            this.AgravamentoPessoa = new HashSet<AgravamentoPessoa>();
            this.CategoriaSujeitoDano = new HashSet<CategoriaSujeitoDano>();
            this.ClasseModalidadeSeguro = new HashSet<ClasseModalidadeSeguro>();
            this.CondicoesProduto = new HashSet<CondicoesProduto>();
            this.CrossSelling = new HashSet<CrossSelling>();
            this.CrossSelling1 = new HashSet<CrossSelling>();
            this.DescontoProduto = new HashSet<DescontoProduto>();
            this.DocumentosObrigatorioProduto = new HashSet<DocumentosObrigatorioProduto>();
            this.Exclusoes = new HashSet<Exclusoes>();
            this.Glossario = new HashSet<Glossario>();
            this.ImagemProduto = new HashSet<ImagemProduto>();
            this.IncapacidadeTemporaria = new HashSet<IncapacidadeTemporaria>();
            this.InformacaoSuporte = new HashSet<InformacaoSuporte>();
            this.InformacoesAdicionaisProduto = new HashSet<InformacoesAdicionaisProduto>();
            this.LinhaProduto = new HashSet<LinhaProduto>();
            this.Mapa = new HashSet<Mapa>();
            this.Mapas = new HashSet<Mapas>();
            this.MetricasProduto = new HashSet<MetricasProduto>();
            this.ObrigacoesProduto = new HashSet<ObrigacoesProduto>();
            this.PerguntasFrequentesProduto = new HashSet<PerguntasFrequentesProduto>();
            this.Perspicacia = new HashSet<Perspicacia>();
            this.PessoaTarefa = new HashSet<PessoaTarefa>();
            this.PremiosMinimos = new HashSet<PremiosMinimos>();
            this.QuadroDanos = new HashSet<QuadroDanos>();
            this.RelatorioProduto = new HashSet<RelatorioProduto>();
            this.Risco = new HashSet<Risco>();
            this.TarifasAutomovel = new HashSet<TarifasAutomovel>();
            this.TarifasPremioAutoAcidentesTrabalho = new HashSet<TarifasPremioAutoAcidentesTrabalho>();
            this.TarifasPremioAutoAT2 = new HashSet<TarifasPremioAutoAT2>();
            this.TipoCobertura = new HashSet<TipoCobertura>();
            this.VantagemProduto = new HashSet<VantagemProduto>();
            this.Tarifa = new HashSet<Tarifa>();
        }
    
        public string IdProduto { get; set; }
        public string Nome { get; set; }
        public string AmbitoProduto { get; set; }
        public string FinalidadeProduto { get; set; }
        public string SubContaID { get; set; }
        public string EstadoID { get; set; }
        public string PortfolioProdutoID { get; set; }
        public string MoedaID { get; set; }
        public string CaminhoURL { get; set; }
        public Nullable<bool> ResseguroObrigatorio { get; set; }
        public string CodProduto { get; set; }
        public Nullable<System.DateTime> DataCriacao { get; set; }
        public Nullable<System.DateTime> DataAtualizacao { get; set; }
        public Nullable<bool> SeguroObrigatorio { get; set; }
        public Nullable<bool> IsentoImposto { get; set; }
        public Nullable<bool> Comissionado { get; set; }
        public string CaminhoWeb { get; set; }
        public string UltModificacaoPorID { get; set; }
        public string NaturezaMovimentoId { get; set; }
        public bool Contabiliza { get; set; }
        public Nullable<System.DateTime> DataCancelamento { get; set; }
        public Nullable<System.DateTime> DataAnulacao { get; set; }
        public string IndicadorProdutoServicoID { get; set; }
        public string ActividadeEmpresaId { get; set; }
    
        public virtual ActividadeEmpresa ActividadeEmpresa { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<AgravamentoPessoa> AgravamentoPessoa { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CategoriaSujeitoDano> CategoriaSujeitoDano { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ClasseModalidadeSeguro> ClasseModalidadeSeguro { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CondicoesProduto> CondicoesProduto { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CrossSelling> CrossSelling { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CrossSelling> CrossSelling1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DescontoProduto> DescontoProduto { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DocumentosObrigatorioProduto> DocumentosObrigatorioProduto { get; set; }
        public virtual Estado Estado { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Exclusoes> Exclusoes { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Glossario> Glossario { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ImagemProduto> ImagemProduto { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<IncapacidadeTemporaria> IncapacidadeTemporaria { get; set; }
        public virtual IndicadorProdutoServico IndicadorProdutoServico { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<InformacaoSuporte> InformacaoSuporte { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<InformacoesAdicionaisProduto> InformacoesAdicionaisProduto { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<LinhaProduto> LinhaProduto { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Mapa> Mapa { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Mapas> Mapas { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MetricasProduto> MetricasProduto { get; set; }
        public virtual Moeda Moeda { get; set; }
        public virtual NaturezaMovimento NaturezaMovimento { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ObrigacoesProduto> ObrigacoesProduto { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PerguntasFrequentesProduto> PerguntasFrequentesProduto { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Perspicacia> Perspicacia { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PessoaTarefa> PessoaTarefa { get; set; }
        public virtual PlanoContas PlanoContas { get; set; }
        public virtual PortfolioProduto PortfolioProduto { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PremiosMinimos> PremiosMinimos { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<QuadroDanos> QuadroDanos { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RelatorioProduto> RelatorioProduto { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Risco> Risco { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TarifasAutomovel> TarifasAutomovel { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TarifasPremioAutoAcidentesTrabalho> TarifasPremioAutoAcidentesTrabalho { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TarifasPremioAutoAT2> TarifasPremioAutoAT2 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TipoCobertura> TipoCobertura { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<VantagemProduto> VantagemProduto { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Tarifa> Tarifa { get; set; }
    }
}