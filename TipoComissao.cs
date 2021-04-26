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
    
    public partial class TipoComissao
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TipoComissao()
        {
            this.Comissao = new HashSet<Comissao>();
            this.ComissaoPlano = new HashSet<ComissaoPlano>();
        }
    
        public string IdTipoComissao { get; set; }
        public string Designacao { get; set; }
        public string SubContaID { get; set; }
        public string NaturezaMovimentoID { get; set; }
        public string CodTipoComissao { get; set; }
        public Nullable<System.DateTime> DataCriacao { get; set; }
        public Nullable<System.DateTime> DataAtualizacao { get; set; }
        public string EstadoID { get; set; }
        public string CaminhoIcone { get; set; }
        public string UltModificacaoPorID { get; set; }
        public bool Contabiliza { get; set; }
        public string MoedaId { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Comissao> Comissao { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ComissaoPlano> ComissaoPlano { get; set; }
        public virtual Estado Estado { get; set; }
        public virtual Moeda Moeda { get; set; }
        public virtual NaturezaMovimento NaturezaMovimento { get; set; }
        public virtual PlanoContas PlanoContas { get; set; }
    }
}