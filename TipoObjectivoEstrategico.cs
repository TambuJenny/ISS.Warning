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
    
    public partial class TipoObjectivoEstrategico
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TipoObjectivoEstrategico()
        {
            this.PlanoObjectivoComercial = new HashSet<PlanoObjectivoComercial>();
        }
    
        public string IdTipoObjectivoEstrategico { get; set; }
        public string CodTipoObjectivo { get; set; }
        public string Designacao { get; set; }
        public string EstadoId { get; set; }
    
        public virtual Estado Estado { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PlanoObjectivoComercial> PlanoObjectivoComercial { get; set; }
    }
}