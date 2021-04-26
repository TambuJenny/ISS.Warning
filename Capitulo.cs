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
    
    public partial class Capitulo
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Capitulo()
        {
            this.Artigo = new HashSet<Artigo>();
        }
    
        public string IdCapitulo { get; set; }
        public string Designacao { get; set; }
        public string CondicoesID { get; set; }
        public string OBS { get; set; }
        public string CodCapitulo { get; set; }
        public Nullable<System.DateTime> DataCriacao { get; set; }
        public Nullable<System.DateTime> DataAtualizacao { get; set; }
        public string EstadoID { get; set; }
        public string UltModificacaoPorID { get; set; }
        public string NumCapitulo { get; set; }
        public string LinhaProdutoId { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Artigo> Artigo { get; set; }
        public virtual Condicoes Condicoes { get; set; }
        public virtual Estado Estado { get; set; }
        public virtual LinhaProduto LinhaProduto { get; set; }
    }
}