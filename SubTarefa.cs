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
    
    public partial class SubTarefa
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public SubTarefa()
        {
            this.TarefasActividade = new HashSet<TarefasActividade>();
        }
    
        public string IdSubTarefa { get; set; }
        public string PCFid { get; set; }
        public string HierarquiaID { get; set; }
        public string Nome { get; set; }
        public string MetricaDisponivel { get; set; }
        public Nullable<int> IndiceDiferenca { get; set; }
        public string DetalhesMudanca { get; set; }
        public string TarefaID { get; set; }
        public string CodSubTarefa { get; set; }
        public Nullable<System.DateTime> DataCriacao { get; set; }
        public Nullable<System.DateTime> DataAtualizacao { get; set; }
        public string EstadoID { get; set; }
        public string UltModificacaoPorID { get; set; }
    
        public virtual Estado Estado { get; set; }
        public virtual Tarefa Tarefa { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TarefasActividade> TarefasActividade { get; set; }
    }
}
