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
    
    public partial class SubCategoriaItens
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public SubCategoriaItens()
        {
            this.ItensPergunta = new HashSet<ItensPergunta>();
        }
    
        public string IdSubCategoriaItens { get; set; }
        public string CodSubCategoriaItens { get; set; }
        public string Designacao { get; set; }
        public Nullable<System.DateTime> DataCriacao { get; set; }
        public Nullable<System.DateTime> DataAtualizacao { get; set; }
        public string CategoriaItensID { get; set; }
        public string EstadoID { get; set; }
    
        public virtual CategoriaItens CategoriaItens { get; set; }
        public virtual Estado Estado { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ItensPergunta> ItensPergunta { get; set; }
    }
}
