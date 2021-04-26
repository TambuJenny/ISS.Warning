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
    
    public partial class CilindragemAutomovel
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public CilindragemAutomovel()
        {
            this.Automovel = new HashSet<Automovel>();
        }
    
        public string IdCilindragemAutomovel { get; set; }
        public string Cilindragem { get; set; }
        public Nullable<double> PremioUCF { get; set; }
        public string ClassificacaoAutomovelID { get; set; }
        public string CodCilindragemAutomovel { get; set; }
        public Nullable<System.DateTime> DataCriacao { get; set; }
        public Nullable<System.DateTime> DataAtualizacao { get; set; }
        public string EstadoID { get; set; }
        public string MoedaId { get; set; }
        public Nullable<int> CilindragemMinima { get; set; }
        public Nullable<int> CilindragemMaxima { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Automovel> Automovel { get; set; }
        public virtual ClassificacaoAutomovel ClassificacaoAutomovel { get; set; }
        public virtual Estado Estado { get; set; }
        public virtual Moeda Moeda { get; set; }
    }
}