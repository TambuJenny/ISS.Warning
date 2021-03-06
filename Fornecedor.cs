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
    
    public partial class Fornecedor
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Fornecedor()
        {
            this.Movimento = new HashSet<Movimento>();
            this.PropostasProjecto = new HashSet<PropostasProjecto>();
        }
    
        public string IdFornecedor { get; set; }
        public string PessoaId { get; set; }
        public string CodFornecedor { get; set; }
        public string SinistroId { get; set; }
        public Nullable<System.DateTime> DataCriacao { get; set; }
        public Nullable<System.DateTime> DataAtualizacao { get; set; }
        public string EstadoId { get; set; }
        public string ApoliceId { get; set; }
        public string SubClasseId { get; set; }
        public string NomeFornecedorEmpresa { get; set; }
    
        public virtual Apolice Apolice { get; set; }
        public virtual Estado Estado { get; set; }
        public virtual Pessoa Pessoa { get; set; }
        public virtual Sinistro Sinistro { get; set; }
        public virtual PlanoContas PlanoContas { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Movimento> Movimento { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PropostasProjecto> PropostasProjecto { get; set; }
    }
}
