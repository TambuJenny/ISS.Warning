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
    
    public partial class ContaFinanceira
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ContaFinanceira()
        {
            this.Apolice = new HashSet<Apolice>();
            this.CartaoPagamento = new HashSet<CartaoPagamento>();
            this.Contacto = new HashSet<Contacto>();
            this.ContactoPessoaParteContrato = new HashSet<ContactoPessoaParteContrato>();
            this.ContaFinanceiraInformacaoBancaria = new HashSet<ContaFinanceiraInformacaoBancaria>();
            this.Contrato = new HashSet<Contrato>();
            this.Credito = new HashSet<Credito>();
            this.Endereco1 = new HashSet<Endereco>();
            this.InformacaoBancaria1 = new HashSet<InformacaoBancaria>();
            this.PartesContrato = new HashSet<PartesContrato>();
            this.PessoaParteContrato = new HashSet<PessoaParteContrato>();
            this.Sinistro = new HashSet<Sinistro>();
            this.Titularidade = new HashSet<Titularidade>();
            this.Titulo1 = new HashSet<Titulo>();
            this.ValorCativo1 = new HashSet<ValorCativo>();
            this.Saldo = new HashSet<Saldo>();
        }
    
        public string IdContaFinanceira { get; set; }
        public string RefContaFinanceira { get; set; }
        public string BalcaoId { get; set; }
        public string CanalID { get; set; }
        public string MoedaId { get; set; }
        public System.DateTime DataCriacao { get; set; }
        public Nullable<System.DateTime> DataAtualizacao { get; set; }
        public Nullable<System.DateTime> DataEncerramento { get; set; }
        public string EstadoId { get; set; }
        public string TipoContaId { get; set; }
        public string NomeConta { get; set; }
        public string CodContaFinanceira { get; set; }
        public string Apelido { get; set; }
        public string FormaMovimentoId { get; set; }
        public string Descricao { get; set; }
        public string TipoClienteId { get; set; }
        public string SufixoConta { get; set; }
        public Nullable<int> NumCliente { get; set; }
        public string GestorContaId { get; set; }
        public Nullable<int> LimiteConta { get; set; }
        public string InformacaoBancariaId { get; set; }
        public string ValorCativoId { get; set; }
        public string TituloId { get; set; }
        public string ApoliceId { get; set; }
        public string EnderecoId { get; set; }
        public string SubContaContabilisticaId { get; set; }
        public string FormaMovimentoContaFinanceira { get; set; }
        public int NumConta { get; set; }
        public string TipoPessoaId { get; set; }
        public string TitularDaContaId { get; set; }
        public string CaminhoFicheiro { get; set; }
        public string ProdutorId { get; set; }
        public string NumeroConta { get; set; }
        public string CaminhoDocumento { get; set; }
    
        public virtual Agencia Agencia { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Apolice> Apolice { get; set; }
        public virtual Apolice Apolice1 { get; set; }
        public virtual Canal Canal { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CartaoPagamento> CartaoPagamento { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Contacto> Contacto { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ContactoPessoaParteContrato> ContactoPessoaParteContrato { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ContaFinanceiraInformacaoBancaria> ContaFinanceiraInformacaoBancaria { get; set; }
        public virtual Endereco Endereco { get; set; }
        public virtual Estado Estado { get; set; }
        public virtual FormaMovimentoContaFinanceira FormaMovimentoContaFinanceira1 { get; set; }
        public virtual FormaMovimentoContaFinanceira FormaMovimentoContaFinanceira2 { get; set; }
        public virtual Pessoa Pessoa { get; set; }
        public virtual InformacaoBancaria InformacaoBancaria { get; set; }
        public virtual Moeda Moeda { get; set; }
        public virtual Pessoa Pessoa1 { get; set; }
        public virtual TipoCliente TipoCliente { get; set; }
        public virtual TipoConta TipoConta { get; set; }
        public virtual TipoPessoa TipoPessoa { get; set; }
        public virtual Pessoa Pessoa2 { get; set; }
        public virtual Titulo Titulo { get; set; }
        public virtual ValorCativo ValorCativo { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Contrato> Contrato { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Credito> Credito { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Endereco> Endereco1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<InformacaoBancaria> InformacaoBancaria1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PartesContrato> PartesContrato { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PessoaParteContrato> PessoaParteContrato { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Sinistro> Sinistro { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Titularidade> Titularidade { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Titulo> Titulo1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ValorCativo> ValorCativo1 { get; set; }
        public virtual PlanoContas PlanoContas { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Saldo> Saldo { get; set; }
    }
}
