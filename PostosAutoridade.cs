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
    
    public partial class PostosAutoridade
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public PostosAutoridade()
        {
            this.AutoridadesContactadas = new HashSet<AutoridadesContactadas>();
        }
    
        public string IdPostosAutoridade { get; set; }
        public string Designacao { get; set; }
        public string AutoridadeId { get; set; }
        public string EnderecoId { get; set; }
        public string EstadoId { get; set; }
        public string CodPostosAutoridade { get; set; }
        public Nullable<System.DateTime> DataCriacao { get; set; }
        public Nullable<System.DateTime> DataAtualizacao { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<AutoridadesContactadas> AutoridadesContactadas { get; set; }
        public virtual Endereco Endereco { get; set; }
        public virtual Estado Estado { get; set; }
        public virtual TipoAutoridade TipoAutoridade { get; set; }
    }
}
