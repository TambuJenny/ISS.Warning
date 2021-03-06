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
    
    public partial class sp_Report_Cotacao_Automovel_Result
    {
        public string IdApolice { get; set; }
        public string RefApolice { get; set; }
        public string IdCotacao { get; set; }
        public string tomador { get; set; }
        public string NifTomador { get; set; }
        public string produtor { get; set; }
        public string cobrador { get; set; }
        public string NumeroCobrador { get; set; }
        public string NumeroProdutor { get; set; }
        public string NumeroTomador { get; set; }
        public string NomeMunicipio { get; set; }
        public string NomeBairro { get; set; }
        public string NomeRua { get; set; }
        public string tipoEndereco { get; set; }
        public string telemovelTomador { get; set; }
        public string telefoneTomador { get; set; }
        public string emailTomador { get; set; }
        public string telemovelProdutor { get; set; }
        public string telefoneProdutor { get; set; }
        public string emailProdutor { get; set; }
        public string telemovelCobrador { get; set; }
        public string telefoneCobrador { get; set; }
        public string emailCobrador { get; set; }
        public Nullable<double> PremioBruto { get; set; }
        public Nullable<double> ARSEG { get; set; }
        public Nullable<double> IVA { get; set; }
        public double Agravamentos { get; set; }
        public double Despesas { get; set; }
        public double Ofertas { get; set; }
        public double Comissoes { get; set; }
        public double AgravamentosPorIdade { get; set; }
        public double DescontosPorIdade { get; set; }
        public Nullable<double> Descontos { get; set; }
        public Nullable<double> Impostos { get; set; }
        public Nullable<double> ValorMinimoPremio { get; set; }
        public int NumOrdem { get; set; }
        public Nullable<double> EncargosAdministrativos { get; set; }
        public string mascaraTelefoneTomador { get; set; }
        public string mascaraTelefoneProdutor { get; set; }
        public string mascaraTelefoneCobrador { get; set; }
        public Nullable<System.DateTime> DataEmissaoCotacao { get; set; }
        public Nullable<System.DateTime> DataInicioApolice { get; set; }
        public Nullable<System.DateTime> DataExpiracaoApolice { get; set; }
        public Nullable<int> PrazoAceitacao { get; set; }
        public string plano { get; set; }
        public string planoId { get; set; }
        public string CodplanoProduto { get; set; }
        public string ramoSeguro { get; set; }
        public Nullable<System.DateTime> DataEmissaoApolice { get; set; }
        public string NumeroAta { get; set; }
        public Nullable<System.DateTime> DataInicio { get; set; }
        public Nullable<System.DateTime> DataExpiracao { get; set; }
        public string IdCoberturaPlano { get; set; }
        public Nullable<double> PremioTotal { get; set; }
        public Nullable<int> numDias { get; set; }
        public Nullable<int> mesDataInicio { get; set; }
        public Nullable<int> mesDataExpiracao { get; set; }
        public Nullable<int> anoDataInicio { get; set; }
        public Nullable<int> anoDataExpiracao { get; set; }
        public Nullable<System.DateTime> DataRenovacao_Apolice { get; set; }
        public Nullable<System.DateTime> DataRenovacao_Cotacao { get; set; }
        public string coberturaPlano { get; set; }
        public Nullable<double> PrecoCoberturaSelecionada { get; set; }
        public string NotaCobertura { get; set; }
        public string tipoCobertura { get; set; }
        public string moedaCoberturaPlano { get; set; }
        public string IdObjectoSegurado { get; set; }
        public string IdCoberturaSelecionada { get; set; }
        public string DesignacaoCanal { get; set; }
        public string IdCanal { get; set; }
        public string fracionamento { get; set; }
        public string pessoaContacto { get; set; }
        public string duracaoTipoContr { get; set; }
        public string Estado { get; set; }
        public string IdEstado { get; set; }
        public string actividadeContratada { get; set; }
        public string tipoSeguroGrupo { get; set; }
        public string TipoDeApolice { get; set; }
        public string IdCae { get; set; }
        public string Designacao { get; set; }
        public Nullable<double> FGA { get; set; }
        public string directorComercial { get; set; }
        public string ModeloAutomovel { get; set; }
        public string MatriculaAutomovel { get; set; }
        public Nullable<double> ValorFraccionadoApagar { get; set; }
        public string RefContaFinanceira { get; set; }
        public Nullable<double> JurosFraccionamento { get; set; }
        public string ReferenciaCotacao { get; set; }
        public Nullable<int> NumAutomovel { get; set; }
        public Nullable<double> PremioSimples { get; set; }
        public Nullable<double> PremioComercial { get; set; }
        public Nullable<double> franquia { get; set; }
        public Nullable<double> FraccionamentoMensal { get; set; }
        public Nullable<double> FraccionamentoTrimestral { get; set; }
        public Nullable<double> FraccionamentoSemestral { get; set; }
        public Nullable<double> FraccionamentoAnual { get; set; }
        public Nullable<double> TaxaImpostoIva { get; set; }
        public Nullable<double> TaxaDespesaARSEG { get; set; }
        public Nullable<double> TaxaDespesaFGA { get; set; }
        public Nullable<double> TaxaDespesaEncargos { get; set; }
        public Nullable<double> TaxaImpostoSelo { get; set; }
        public string NomePrograma { get; set; }
        public Nullable<int> NomeNumeroValidacaoAgt { get; set; }
        public string CodigoAgtTipoDocumento { get; set; }
        public string ArtigoMotivoIsencao { get; set; }
        public string DescricaoArtigoIsencaoIva { get; set; }
        public string TituloArtigo { get; set; }
        public string FonteArtigo { get; set; }
        public string BaseIncidenciaIva { get; set; }
        public string BaseIncidenciaArseg { get; set; }
        public string BaseIncidenciaDescontoFrota { get; set; }
        public string BaseIncidenciaDescontoInformadoPeloProdutor { get; set; }
        public string BaseIncidenciaEncargosAdministrativo { get; set; }
        public string BaseIncidenciaFGA { get; set; }
        public string TaxaDescontoFrota { get; set; }
        public string TaxaDescontoInformadoPeloProdutorn { get; set; }
        public string TaxaEncargosAdministrativo { get; set; }
        public Nullable<double> TaxaImpostoIva1 { get; set; }
        public Nullable<double> TaxaImpostoArseg { get; set; }
        public Nullable<double> TaxaImpostoFGA { get; set; }
        public string motivoAplicacaoIva { get; set; }
        public string UsuarioOperacao { get; set; }
        public string EnderecoGeolocalizaco { get; set; }
        public Nullable<double> DescontoFraccionamento { get; set; }
        public Nullable<double> comissoesFraccionamento { get; set; }
        public Nullable<double> DespesasFraccioanmento { get; set; }
        public Nullable<double> arsegFraccionamento { get; set; }
        public Nullable<double> premioSimplesFraccionamento { get; set; }
        public Nullable<double> premioComercialFraccionamento { get; set; }
        public Nullable<double> EncargosFraccionamento { get; set; }
        public Nullable<double> ImpostosFraccionamento { get; set; }
        public Nullable<double> IvaFraccionamento { get; set; }
        public Nullable<double> fgaFraccionamento { get; set; }
        public Nullable<double> JurosFraccionamento_Fraccionados { get; set; }
        public string formaLiquidacao { get; set; }
        public string formaContratacao { get; set; }
        public string CodFormaContratacao { get; set; }
        public string agencia { get; set; }
        public string MarcaAutomovel { get; set; }
        public string DesignacaoMoeda { get; set; }
        public string moeda { get; set; }
        public string ValorIncidenciaDescontoProdutor { get; set; }
        public string ValorIncidenciaDescontoDescontoFrota { get; set; }
        public Nullable<double> TaxaImpostoFracionamento { get; set; }
        public Nullable<double> TaxaDescontos { get; set; }
    }
}
