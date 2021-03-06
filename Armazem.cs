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
    
    public partial class Armazem
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Armazem()
        {
            this.Artigos = new HashSet<Artigos>();
            this.LocalCarga = new HashSet<LocalCarga>();
            this.LocalDescarga = new HashSet<LocalDescarga>();
            this.LocalizacaoArtigoArmazem = new HashSet<LocalizacaoArtigoArmazem>();
        }
    
        public string IdArmazem { get; set; }
        public string ProprietarioId { get; set; }
        public string EnderecoId { get; set; }
        public string CodArmazem { get; set; }
        public Nullable<System.DateTime> DataCriacao { get; set; }
        public Nullable<System.DateTime> DataAtualizacao { get; set; }
        public string EstadoId { get; set; }
    
        public virtual Endereco Endereco { get; set; }
        public virtual Estado Estado { get; set; }
        public virtual Pessoa Pessoa { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Artigos> Artigos { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<LocalCarga> LocalCarga { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<LocalDescarga> LocalDescarga { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<LocalizacaoArtigoArmazem> LocalizacaoArtigoArmazem { get; set; }
    }
}
