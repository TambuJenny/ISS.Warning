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
    
    public partial class ClassificacaoFormaTipoResseguro
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ClassificacaoFormaTipoResseguro()
        {
            this.Contrato = new HashSet<Contrato>();
            this.Resseguro = new HashSet<Resseguro>();
        }
    
        public string IdClassificacaoFormaTipoResseguro { get; set; }
        public Nullable<System.DateTime> DataCriacao { get; set; }
        public Nullable<System.DateTime> DataAtualizacao { get; set; }
        public string FormaClassificacaoTipoResseguroId { get; set; }
        public string FormaResseguroId { get; set; }
        public string CodClassificacaoFormaTipoResseguro { get; set; }
    
        public virtual FormaClassificacaoTipoResseguro FormaClassificacaoTipoResseguro { get; set; }
        public virtual FormaResseguro FormaResseguro { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Contrato> Contrato { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Resseguro> Resseguro { get; set; }
    }
}
