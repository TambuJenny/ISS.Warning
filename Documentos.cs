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
    
    public partial class Documentos
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Documentos()
        {
            this.DocumentoProjecto = new HashSet<DocumentoProjecto>();
            this.DocumentosPortfolio = new HashSet<DocumentosPortfolio>();
            this.ProgramasDocumento = new HashSet<ProgramasDocumento>();
        }
    
        public string IdDocumentos { get; set; }
        public string Designacao { get; set; }
        public string Descricao { get; set; }
        public string CodDocumentos { get; set; }
        public string Estadoid { get; set; }
        public Nullable<System.DateTime> DataCriacao { get; set; }
        public Nullable<System.DateTime> DataAtualizacao { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DocumentoProjecto> DocumentoProjecto { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DocumentosPortfolio> DocumentosPortfolio { get; set; }
        public virtual Estado Estado { get; set; }
        public virtual Estado Estado1 { get; set; }
        public virtual Estado Estado2 { get; set; }
        public virtual Estado Estado3 { get; set; }
        public virtual Estado Estado4 { get; set; }
        public virtual Estado Estado5 { get; set; }
        public virtual Estado Estado6 { get; set; }
        public virtual Estado Estado7 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ProgramasDocumento> ProgramasDocumento { get; set; }
    }
}
