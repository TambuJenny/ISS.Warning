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
    
    public partial class TipoRamoSeguro
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TipoRamoSeguro()
        {
            this.DespesaContrato = new HashSet<DespesaContrato>();
            this.EncargosContrato = new HashSet<EncargosContrato>();
            this.Imposto = new HashSet<Imposto>();
            this.ImpostoContrato = new HashSet<ImpostoContrato>();
            this.OutraSeguradoraContrato = new HashSet<OutraSeguradoraContrato>();
            this.PortfolioProduto = new HashSet<PortfolioProduto>();
            this.RamoQualidadeSegura = new HashSet<RamoQualidadeSegura>();
            this.RapelProdutor = new HashSet<RapelProdutor>();
            this.ReservasTecnicas = new HashSet<ReservasTecnicas>();
            this.ServicoContrato = new HashSet<ServicoContrato>();
            this.TaxaLimiteRapelContrato = new HashSet<TaxaLimiteRapelContrato>();
            this.TipoDesvalorizacao = new HashSet<TipoDesvalorizacao>();
            this.TipoImposto = new HashSet<TipoImposto>();
        }
    
        public string IdTipo { get; set; }
        public string Designacao { get; set; }
        public string CodTipoRamoSeguro { get; set; }
        public Nullable<System.DateTime> DataCriacao { get; set; }
        public Nullable<System.DateTime> DataAtualizacao { get; set; }
        public string EstadoID { get; set; }
        public string CaminhoIcone { get; set; }
        public Nullable<double> Taxa { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DespesaContrato> DespesaContrato { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<EncargosContrato> EncargosContrato { get; set; }
        public virtual Estado Estado { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Imposto> Imposto { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ImpostoContrato> ImpostoContrato { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OutraSeguradoraContrato> OutraSeguradoraContrato { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PortfolioProduto> PortfolioProduto { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RamoQualidadeSegura> RamoQualidadeSegura { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RapelProdutor> RapelProdutor { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ReservasTecnicas> ReservasTecnicas { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ServicoContrato> ServicoContrato { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TaxaLimiteRapelContrato> TaxaLimiteRapelContrato { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TipoDesvalorizacao> TipoDesvalorizacao { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TipoImposto> TipoImposto { get; set; }
    }
}
