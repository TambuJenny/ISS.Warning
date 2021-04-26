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
    
    public partial class Cotacao
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Cotacao()
        {
            this.Apolice = new HashSet<Apolice>();
            this.AutomovelDadosAdicional = new HashSet<AutomovelDadosAdicional>();
            this.Beneficiario = new HashSet<Beneficiario>();
            this.CoberturaSelecionada = new HashSet<CoberturaSelecionada>();
            this.Comissao = new HashSet<Comissao>();
            this.Construcao = new HashSet<Construcao>();
            this.CotacaoPlano = new HashSet<CotacaoPlano>();
            this.DescontoSeleccionado = new HashSet<DescontoSeleccionado>();
            this.DespesaSeleccionada = new HashSet<DespesaSeleccionada>();
            this.DetalheOperacao = new HashSet<DetalheOperacao>();
            this.DocumentosAnexosApolice = new HashSet<DocumentosAnexosApolice>();
            this.FraccionamentoValores = new HashSet<FraccionamentoValores>();
            this.FranquiaSeleccionado = new HashSet<FranquiaSeleccionado>();
            this.Instalacoes = new HashSet<Instalacoes>();
            this.MargemVendaSeleccionado = new HashSet<MargemVendaSeleccionado>();
            this.MembroAssegurado = new HashSet<MembroAssegurado>();
            this.ObjectoSegurado = new HashSet<ObjectoSegurado>();
            this.OutrosContratosApolice = new HashSet<OutrosContratosApolice>();
            this.PremioFraccionadoApolice = new HashSet<PremioFraccionadoApolice>();
            this.ProvinciaCobertura = new HashSet<ProvinciaCobertura>();
            this.RendimentosPessoa = new HashSet<RendimentosPessoa>();
            this.RespostaPergunta = new HashSet<RespostaPergunta>();
            this.Resseguro = new HashSet<Resseguro>();
            this.SimulacaoDependente = new HashSet<SimulacaoDependente>();
            this.Viagem = new HashSet<Viagem>();
            this.CotacaoDependente = new HashSet<CotacaoDependente>();
            this.Questionario = new HashSet<Questionario>();
        }
    
        public string IdCotacao { get; set; }
        public string OBS { get; set; }
        public Nullable<System.DateTime> DataEmissao { get; set; }
        public string EstadoID { get; set; }
        public string ProdutorID { get; set; }
        public string CanalID { get; set; }
        public string ActividadeContratadaID { get; set; }
        public string FraccionamentoID { get; set; }
        public string CaminhoFicheiro { get; set; }
        public string FormasCobrancaID { get; set; }
        public string BalcaoId { get; set; }
        public string PessoasAbrangidasID { get; set; }
        public string LugaresAutoAssegurarID { get; set; }
        public string FormaLiquidacaoPremioID { get; set; }
        public double PercentagemMinimaPremio { get; set; }
        public Nullable<double> ValorMinimoPremio { get; set; }
        public Nullable<double> PremioBase { get; set; }
        public Nullable<double> PremioSimples { get; set; }
        public Nullable<double> PremioRisco { get; set; }
        public Nullable<double> PremioComercial { get; set; }
        public Nullable<double> PremioTotal { get; set; }
        public Nullable<double> PremioBruto { get; set; }
        public Nullable<double> IVA { get; set; }
        public Nullable<double> ARSEG { get; set; }
        public Nullable<int> PrazoAceitacao { get; set; }
        public string FormaContratacaoID { get; set; }
        public string PrazoCurtoID { get; set; }
        public string DuracaoTipoContratoID { get; set; }
        public Nullable<System.DateTime> DataInicio { get; set; }
        public Nullable<System.DateTime> DataExpiracao { get; set; }
        public string QualidadeEmQueSeguraID { get; set; }
        public string TipoSeguroGrupoID { get; set; }
        public Nullable<System.DateTime> DataCriacao { get; set; }
        public Nullable<System.DateTime> DataAtualizacao { get; set; }
        public string UltModificacaoPorID { get; set; }
        public string CodCotacao { get; set; }
        public Nullable<System.DateTime> DataEntrada { get; set; }
        public Nullable<System.DateTime> DataAceitacao { get; set; }
        public string ResponsavelAceitacaoId { get; set; }
        public Nullable<bool> OutraSeguradora { get; set; }
        public string CobradorId { get; set; }
        public string PessoaContactoId { get; set; }
        public string TomadorId { get; set; }
        public string CotacaoId { get; set; }
        public string LocalCobrancaId { get; set; }
        public string LocalRiscoEmpresaId { get; set; }
        public Nullable<double> CapitalSeguro { get; set; }
        public string FranquiaId { get; set; }
        public string MoedaId { get; set; }
        public Nullable<double> LimiteResponsabilidade { get; set; }
        public Nullable<double> EncargosAdministrativos { get; set; }
        public string CentroResponsabilidadeId { get; set; }
        public Nullable<double> NumFraccao { get; set; }
        public string CentroCustoId { get; set; }
        public string TipoDocumentoId { get; set; }
        public string DocumentoParcelado { get; set; }
        public Nullable<double> Impostos { get; set; }
        public Nullable<double> Descontos { get; set; }
        public double Agravamentos { get; set; }
        public double Despesas { get; set; }
        public double Ofertas { get; set; }
        public double Comissoes { get; set; }
        public double AgravamentosPorIdade { get; set; }
        public double DescontosPorIdade { get; set; }
        public string PeriodoPlanoId { get; set; }
        public string FormaPagamentoId { get; set; }
        public string ModalidadeSeguroId { get; set; }
        public string ClassificacaoGrupoId { get; set; }
        public string TipoSeguroId { get; set; }
        public Nullable<int> NumFuncionarios { get; set; }
        public Nullable<double> MassaSalarial { get; set; }
        public string CaeId { get; set; }
        public int NumOrdem { get; set; }
        public string ReferenciaCotacao { get; set; }
        public Nullable<double> JurosFraccionamento { get; set; }
        public string NumeroActa { get; set; }
        public Nullable<System.DateTime> DataRenovacao { get; set; }
        public Nullable<double> FGA { get; set; }
        public string PlanoProdutoId { get; set; }
        public string TipoApoliceId { get; set; }
        public string PaisCoberturaId { get; set; }
        public string ProvinciaCoberturaId { get; set; }
        public Nullable<int> NumeroSegurado { get; set; }
        public Nullable<int> NumeroMenorIdade { get; set; }
        public Nullable<int> NumeroMaiorIdade { get; set; }
        public string ContratoId { get; set; }
        public Nullable<double> ValorFraccionamentoSelecionado { get; set; }
        public Nullable<double> TaxaDescontos { get; set; }
        public string UsuarioId { get; set; }
        public Nullable<int> NumeroIdoso { get; set; }
        public Nullable<double> EstimativaFactura { get; set; }
        public Nullable<bool> IsMembroSsegurado { get; set; }
        public string GeoLocalizacaoTransacaoId { get; set; }
        public string SeguradoraAnteriorId { get; set; }
        public string NumApoliceAnterior { get; set; }
        public Nullable<int> NumsinistrosParticipadosUltimoAno { get; set; }
        public Nullable<System.DateTime> DataUltimoSinistroParticipado { get; set; }
        public Nullable<double> ValorEmprestimo { get; set; }
        public Nullable<double> LimiteContrato { get; set; }
        public Nullable<bool> IsPersonalizado { get; set; }
        public string ReferenciaDocumento { get; set; }
    
        public virtual ActividadeContratada ActividadeContratada { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Apolice> Apolice { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<AutomovelDadosAdicional> AutomovelDadosAdicional { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Beneficiario> Beneficiario { get; set; }
        public virtual CAE CAE { get; set; }
        public virtual Canal Canal { get; set; }
        public virtual CentroCusto CentroCusto { get; set; }
        public virtual CentroResponsabilidade CentroResponsabilidade { get; set; }
        public virtual ClassificacaoGrupo ClassificacaoGrupo { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CoberturaSelecionada> CoberturaSelecionada { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Comissao> Comissao { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Construcao> Construcao { get; set; }
        public virtual Contrato Contrato { get; set; }
        public virtual Pessoa Pessoa { get; set; }
        public virtual DuracaoTipoContrato DuracaoTipoContrato { get; set; }
        public virtual Estado Estado { get; set; }
        public virtual FormaContratacao FormaContratacao { get; set; }
        public virtual FormaLiquidacaoPremio FormaLiquidacaoPremio { get; set; }
        public virtual FormaPagamento FormaPagamento { get; set; }
        public virtual FormasCobranca FormasCobranca { get; set; }
        public virtual Fraccionamento Fraccionamento { get; set; }
        public virtual Franquia Franquia { get; set; }
        public virtual GeoLocalizacaoTransacao GeoLocalizacaoTransacao { get; set; }
        public virtual Endereco Endereco { get; set; }
        public virtual Endereco Endereco1 { get; set; }
        public virtual LugaresAutoAssegurar LugaresAutoAssegurar { get; set; }
        public virtual ModalidadeSeguro ModalidadeSeguro { get; set; }
        public virtual Pais Pais { get; set; }
        public virtual PeriodoPlano PeriodoPlano { get; set; }
        public virtual PessoasAbrangidas PessoasAbrangidas { get; set; }
        public virtual PlanoProduto PlanoProduto { get; set; }
        public virtual PrazosCurtos PrazosCurtos { get; set; }
        public virtual Pessoa Pessoa1 { get; set; }
        public virtual Provincia Provincia { get; set; }
        public virtual QualidadeSegura QualidadeSegura { get; set; }
        public virtual Pessoa Pessoa2 { get; set; }
        public virtual TipoApolice TipoApolice { get; set; }
        public virtual TipoDocumentos TipoDocumentos { get; set; }
        public virtual TipoSeguro TipoSeguro { get; set; }
        public virtual TipoSeguroGrupo TipoSeguroGrupo { get; set; }
        public virtual Pessoa Pessoa3 { get; set; }
        public virtual Pessoa Pessoa4 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CotacaoPlano> CotacaoPlano { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DescontoSeleccionado> DescontoSeleccionado { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DespesaSeleccionada> DespesaSeleccionada { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DetalheOperacao> DetalheOperacao { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DocumentosAnexosApolice> DocumentosAnexosApolice { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FraccionamentoValores> FraccionamentoValores { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FranquiaSeleccionado> FranquiaSeleccionado { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Instalacoes> Instalacoes { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MargemVendaSeleccionado> MargemVendaSeleccionado { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MembroAssegurado> MembroAssegurado { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ObjectoSegurado> ObjectoSegurado { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OutrosContratosApolice> OutrosContratosApolice { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PremioFraccionadoApolice> PremioFraccionadoApolice { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ProvinciaCobertura> ProvinciaCobertura { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RendimentosPessoa> RendimentosPessoa { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RespostaPergunta> RespostaPergunta { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Resseguro> Resseguro { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SimulacaoDependente> SimulacaoDependente { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Viagem> Viagem { get; set; }
        public virtual Moeda Moeda { get; set; }
        public virtual Pessoa Pessoa5 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CotacaoDependente> CotacaoDependente { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Questionario> Questionario { get; set; }
    }
}