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
    
    public partial class Especialidade
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Especialidade()
        {
            this.CoberturaEspecialidade = new HashSet<CoberturaEspecialidade>();
            this.EspecialidadeAtosMedicos = new HashSet<EspecialidadeAtosMedicos>();
        }
    
        public string IdEspecialidade { get; set; }
        public string Designacao { get; set; }
        public string Observacao { get; set; }
        public string NumEspecialidade { get; set; }
        public string EstadoId { get; set; }
        public string CodEspecialidade { get; set; }
        public Nullable<System.DateTime> DataCriacao { get; set; }
        public Nullable<System.DateTime> DataAtualizacao { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CoberturaEspecialidade> CoberturaEspecialidade { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<EspecialidadeAtosMedicos> EspecialidadeAtosMedicos { get; set; }
        public virtual Estado Estado { get; set; }
    }
}
