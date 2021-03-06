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
    
    public partial class Endereco
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Endereco()
        {
            this.Agencia = new HashSet<Agencia>();
            this.Armazem = new HashSet<Armazem>();
            this.Caixa = new HashSet<Caixa>();
            this.ComissaoPlano = new HashSet<ComissaoPlano>();
            this.CondicaoOperacao = new HashSet<CondicaoOperacao>();
            this.Construcao = new HashSet<Construcao>();
            this.ContaFinanceira = new HashSet<ContaFinanceira>();
            this.Contrato = new HashSet<Contrato>();
            this.Contrato1 = new HashSet<Contrato>();
            this.Contrato2 = new HashSet<Contrato>();
            this.ContratoPrestadorEmpresa = new HashSet<ContratoPrestadorEmpresa>();
            this.ContratoPrestadorEmpresa1 = new HashSet<ContratoPrestadorEmpresa>();
            this.ContratoPrestadorEmpresa2 = new HashSet<ContratoPrestadorEmpresa>();
            this.Cotacao = new HashSet<Cotacao>();
            this.Cotacao1 = new HashSet<Cotacao>();
            this.Empresa = new HashSet<Empresa>();
            this.EnderecoPessoa = new HashSet<EnderecoPessoa>();
            this.EnderecoPlano = new HashSet<EnderecoPlano>();
            this.Imovel = new HashSet<Imovel>();
            this.InformacaoBancaria = new HashSet<InformacaoBancaria>();
            this.Infraccoes = new HashSet<Infraccoes>();
            this.LocaisComissao = new HashSet<LocaisComissao>();
            this.LocalCarga = new HashSet<LocalCarga>();
            this.LocalCobranca = new HashSet<LocalCobranca>();
            this.LocalDescarga = new HashSet<LocalDescarga>();
            this.LocalizacaoInstalacoes = new HashSet<LocalizacaoInstalacoes>();
            this.Morada = new HashSet<Morada>();
            this.Newsletter = new HashSet<Newsletter>();
            this.PessoaProfissao = new HashSet<PessoaProfissao>();
            this.PostosAutoridade = new HashSet<PostosAutoridade>();
            this.PremiosRiscosSimples = new HashSet<PremiosRiscosSimples>();
            this.Sinistro = new HashSet<Sinistro>();
            this.TipoContratoEmpresa = new HashSet<TipoContratoEmpresa>();
            this.TipoRegime = new HashSet<TipoRegime>();
            this.LocalAplicacaoPlano = new HashSet<LocalAplicacaoPlano>();
        }
    
        public string IdEndereco { get; set; }
        public string RuaID { get; set; }
        public string TipoEnderecoID { get; set; }
        public Nullable<System.DateTime> DataCriacao { get; set; }
        public Nullable<System.DateTime> DataAtualizacao { get; set; }
        public string CidadeID { get; set; }
        public string EstadoID { get; set; }
        public string UltModificacaoPorID { get; set; }
        public string CodEndereco { get; set; }
        public string ContaFinanceiraId { get; set; }
        public string BairroId { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Agencia> Agencia { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Armazem> Armazem { get; set; }
        public virtual Bairro Bairro { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Caixa> Caixa { get; set; }
        public virtual Cidade Cidade { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ComissaoPlano> ComissaoPlano { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CondicaoOperacao> CondicaoOperacao { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Construcao> Construcao { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ContaFinanceira> ContaFinanceira { get; set; }
        public virtual ContaFinanceira ContaFinanceira1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Contrato> Contrato { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Contrato> Contrato1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Contrato> Contrato2 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ContratoPrestadorEmpresa> ContratoPrestadorEmpresa { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ContratoPrestadorEmpresa> ContratoPrestadorEmpresa1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ContratoPrestadorEmpresa> ContratoPrestadorEmpresa2 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Cotacao> Cotacao { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Cotacao> Cotacao1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Empresa> Empresa { get; set; }
        public virtual Estado Estado { get; set; }
        public virtual Rua Rua { get; set; }
        public virtual TipoEndereco TipoEndereco { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<EnderecoPessoa> EnderecoPessoa { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<EnderecoPlano> EnderecoPlano { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Imovel> Imovel { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<InformacaoBancaria> InformacaoBancaria { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Infraccoes> Infraccoes { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<LocaisComissao> LocaisComissao { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<LocalCarga> LocalCarga { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<LocalCobranca> LocalCobranca { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<LocalDescarga> LocalDescarga { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<LocalizacaoInstalacoes> LocalizacaoInstalacoes { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Morada> Morada { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Newsletter> Newsletter { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PessoaProfissao> PessoaProfissao { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PostosAutoridade> PostosAutoridade { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PremiosRiscosSimples> PremiosRiscosSimples { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Sinistro> Sinistro { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TipoContratoEmpresa> TipoContratoEmpresa { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TipoRegime> TipoRegime { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<LocalAplicacaoPlano> LocalAplicacaoPlano { get; set; }
    }
}
