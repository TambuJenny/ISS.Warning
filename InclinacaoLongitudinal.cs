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
    
    public partial class InclinacaoLongitudinal
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public InclinacaoLongitudinal()
        {
            this.CriteriosSeguranca = new HashSet<CriteriosSeguranca>();
        }
    
        public string IdInclinacaoLongitudinal { get; set; }
        public Nullable<double> VelocidadeBase { get; set; }
        public Nullable<double> InclinacaoMaxima { get; set; }
        public string CodInclinacaoLongitudinal { get; set; }
        public string EstadoId { get; set; }
        public Nullable<System.DateTime> DataCriacao { get; set; }
        public Nullable<System.DateTime> DataAtualizacao { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CriteriosSeguranca> CriteriosSeguranca { get; set; }
        public virtual Estado Estado { get; set; }
    }
}
