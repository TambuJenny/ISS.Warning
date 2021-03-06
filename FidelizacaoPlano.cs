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
    
    public partial class FidelizacaoPlano
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public FidelizacaoPlano()
        {
            this.LimiteComissionamentoProdutor = new HashSet<LimiteComissionamentoProdutor>();
            this.LimiteComissionamentoPlano = new HashSet<LimiteComissionamentoPlano>();
        }
    
        public string IdFidelizacaoPlano { get; set; }
        public string FidelizacaoId { get; set; }
        public string PlanoProdutoId { get; set; }
        public Nullable<System.DateTime> DataCriacao { get; set; }
        public Nullable<System.DateTime> DataAtualizacao { get; set; }
        public string EstadoId { get; set; }
        public string PessoaId { get; set; }
    
        public virtual Estado Estado { get; set; }
        public virtual Fidelizacao Fidelizacao { get; set; }
        public virtual Pessoa Pessoa { get; set; }
        public virtual PlanoProduto PlanoProduto { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<LimiteComissionamentoProdutor> LimiteComissionamentoProdutor { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<LimiteComissionamentoPlano> LimiteComissionamentoPlano { get; set; }
    }
}
