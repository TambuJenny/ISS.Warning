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
    
    public partial class PesoAutomovel
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public PesoAutomovel()
        {
            this.Automovel = new HashSet<Automovel>();
        }
    
        public string IdPesoAutomovel { get; set; }
        public string Peso { get; set; }
        public string ClassificacaoAutomovelID { get; set; }
        public string CodPesoAutomovel { get; set; }
        public Nullable<System.DateTime> DataCriacao { get; set; }
        public Nullable<System.DateTime> DataAtualizacao { get; set; }
        public string EstadoID { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Automovel> Automovel { get; set; }
        public virtual ClassificacaoAutomovel ClassificacaoAutomovel { get; set; }
        public virtual Estado Estado { get; set; }
    }
}