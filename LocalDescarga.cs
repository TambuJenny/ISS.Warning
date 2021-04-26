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
    
    public partial class LocalDescarga
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public LocalDescarga()
        {
            this.VendaArtigo = new HashSet<VendaArtigo>();
        }
    
        public string IdLocalDescarga { get; set; }
        public Nullable<System.DateTime> DataRecepcao { get; set; }
        public string IdentificadorArmazemDestinoId { get; set; }
        public string LocalizacaoArtigoArmazemId { get; set; }
        public string EnderecoId { get; set; }
        public string CodLocalDescarga { get; set; }
        public Nullable<System.DateTime> DataCriacao { get; set; }
        public Nullable<System.DateTime> DataAtualizacao { get; set; }
        public string EstadoId { get; set; }
    
        public virtual Armazem Armazem { get; set; }
        public virtual Endereco Endereco { get; set; }
        public virtual Estado Estado { get; set; }
        public virtual LocalizacaoArtigoArmazem LocalizacaoArtigoArmazem { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<VendaArtigo> VendaArtigo { get; set; }
    }
}