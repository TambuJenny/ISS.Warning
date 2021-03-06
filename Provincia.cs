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
    
    public partial class Provincia
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Provincia()
        {
            this.Cidade = new HashSet<Cidade>();
            this.Cotacao = new HashSet<Cotacao>();
            this.DescontoProvincia = new HashSet<DescontoProvincia>();
            this.GeoLocalizacaoTransacao = new HashSet<GeoLocalizacaoTransacao>();
            this.LocaisCobertura = new HashSet<LocaisCobertura>();
            this.LocaisDesconto = new HashSet<LocaisDesconto>();
            this.LocaisEncargo = new HashSet<LocaisEncargo>();
            this.LocaisFranquia = new HashSet<LocaisFranquia>();
            this.LocaisImposto = new HashSet<LocaisImposto>();
            this.LocaisLimiteCompetencia = new HashSet<LocaisLimiteCompetencia>();
            this.LocaisOferta = new HashSet<LocaisOferta>();
            this.Municipio = new HashSet<Municipio>();
            this.ProvinciaCobertura = new HashSet<ProvinciaCobertura>();
            this.ProvinciaContrato = new HashSet<ProvinciaContrato>();
            this.ProvinciaPlano = new HashSet<ProvinciaPlano>();
            this.ProvinciaComissionamento = new HashSet<ProvinciaComissionamento>();
            this.ProvinciasLimitesComissionamentoProdutor = new HashSet<ProvinciasLimitesComissionamentoProdutor>();
            this.Viagem = new HashSet<Viagem>();
            this.Viagem1 = new HashSet<Viagem>();
        }
    
        public string IdProvincia { get; set; }
        public string NomeProvincia { get; set; }
        public string RegiaoID { get; set; }
        public string PaisID { get; set; }
        public string CodProvincia { get; set; }
        public Nullable<System.DateTime> DataCriacao { get; set; }
        public Nullable<System.DateTime> DataAtualizacao { get; set; }
        public string EstadoID { get; set; }
        public string UltModificacaoPorID { get; set; }
        public string TipoRegimeId { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Cidade> Cidade { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Cotacao> Cotacao { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DescontoProvincia> DescontoProvincia { get; set; }
        public virtual Estado Estado { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<GeoLocalizacaoTransacao> GeoLocalizacaoTransacao { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<LocaisCobertura> LocaisCobertura { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<LocaisDesconto> LocaisDesconto { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<LocaisEncargo> LocaisEncargo { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<LocaisFranquia> LocaisFranquia { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<LocaisImposto> LocaisImposto { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<LocaisLimiteCompetencia> LocaisLimiteCompetencia { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<LocaisOferta> LocaisOferta { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Municipio> Municipio { get; set; }
        public virtual Pais Pais { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ProvinciaCobertura> ProvinciaCobertura { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ProvinciaContrato> ProvinciaContrato { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ProvinciaPlano> ProvinciaPlano { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ProvinciaComissionamento> ProvinciaComissionamento { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ProvinciasLimitesComissionamentoProdutor> ProvinciasLimitesComissionamentoProdutor { get; set; }
        public virtual Regiao Regiao { get; set; }
        public virtual TipoRegime TipoRegime { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Viagem> Viagem { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Viagem> Viagem1 { get; set; }
    }
}
