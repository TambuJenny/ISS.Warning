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
    
    public partial class RapelProdutor
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public RapelProdutor()
        {
            this.PapelProdutor = new HashSet<PapelProdutor>();
        }
    
        public string IdRapelProdutor { get; set; }
        public string CodRapelProdutor { get; set; }
        public string PessoaId { get; set; }
        public string PlanoProdutoId { get; set; }
        public string TipoRamoId { get; set; }
        public Nullable<System.DateTime> DataCriacao { get; set; }
        public Nullable<System.DateTime> DataAtualizacao { get; set; }
        public string EstadoId { get; set; }
        public Nullable<double> ValorMin { get; set; }
        public Nullable<double> ValorMax { get; set; }
        public string LimitesRapelId { get; set; }
    
        public virtual Estado Estado { get; set; }
        public virtual LimitesRapel LimitesRapel { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PapelProdutor> PapelProdutor { get; set; }
        public virtual Pessoa Pessoa { get; set; }
        public virtual PlanoProduto PlanoProduto { get; set; }
        public virtual TipoRamoSeguro TipoRamoSeguro { get; set; }
    }
}