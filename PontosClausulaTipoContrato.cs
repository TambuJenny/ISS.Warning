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
    
    public partial class PontosClausulaTipoContrato
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public PontosClausulaTipoContrato()
        {
            this.SubPontosClausulaTipoContrato = new HashSet<SubPontosClausulaTipoContrato>();
        }
    
        public string IdPontosClausulaTipoContrato { get; set; }
        public string NumeroPonto { get; set; }
        public string Descricao { get; set; }
        public string ClausulaTipoContratoId { get; set; }
        public Nullable<System.DateTime> DataCriacao { get; set; }
        public Nullable<System.DateTime> DataActualizacao { get; set; }
        public Nullable<int> OrdenarPonto { get; set; }
    
        public virtual ClausulaTipoContrato ClausulaTipoContrato { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SubPontosClausulaTipoContrato> SubPontosClausulaTipoContrato { get; set; }
    }
}
