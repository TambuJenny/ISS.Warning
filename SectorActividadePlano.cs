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
    
    public partial class SectorActividadePlano
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public SectorActividadePlano()
        {
            this.ComissionamentoPlano = new HashSet<ComissionamentoPlano>();
            this.CriterioPlano = new HashSet<CriterioPlano>();
            this.LimiteComissionamentoPlano = new HashSet<LimiteComissionamentoPlano>();
            this.LimiteComissionamentoPlano1 = new HashSet<LimiteComissionamentoPlano>();
            this.LimiteComissionamentoProdutor = new HashSet<LimiteComissionamentoProdutor>();
        }
    
        public string IdSectorActividadePlano { get; set; }
        public string PlanoProdutoId { get; set; }
        public Nullable<System.DateTime> DataCriacao { get; set; }
        public string SectorActividadeId { get; set; }
        public Nullable<System.DateTime> DataAtualizacao { get; set; }
        public string PessoaId { get; set; }
        public string EstadoId { get; set; }
        public string CodSectorActividadePlano { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ComissionamentoPlano> ComissionamentoPlano { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CriterioPlano> CriterioPlano { get; set; }
        public virtual Estado Estado { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<LimiteComissionamentoPlano> LimiteComissionamentoPlano { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<LimiteComissionamentoPlano> LimiteComissionamentoPlano1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<LimiteComissionamentoProdutor> LimiteComissionamentoProdutor { get; set; }
        public virtual Pessoa Pessoa { get; set; }
        public virtual PlanoProduto PlanoProduto { get; set; }
        public virtual SectorActividade SectorActividade { get; set; }
    }
}
