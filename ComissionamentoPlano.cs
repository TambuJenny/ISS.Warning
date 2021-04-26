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
    
    public partial class ComissionamentoPlano
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ComissionamentoPlano()
        {
            this.LimiteComissionamentoProdutor = new HashSet<LimiteComissionamentoProdutor>();
        }
    
        public string IdComissionamentoPlano { get; set; }
        public string PlanoProdutoId { get; set; }
        public Nullable<double> Desconto { get; set; }
        public string CanalPlanoId { get; set; }
        public string TipoSegmentoPlano { get; set; }
        public string SectorActividadePlanoId { get; set; }
        public Nullable<double> CapitalMin { get; set; }
        public Nullable<double> CapitalMax { get; set; }
        public string FormaPagamentoPlanoId { get; set; }
        public string PapelPlanoId { get; set; }
        public string PessoaId { get; set; }
        public Nullable<System.DateTime> DataInicio { get; set; }
        public Nullable<System.DateTime> DataFim { get; set; }
        public Nullable<System.DateTime> DataCriacao { get; set; }
        public Nullable<System.DateTime> DataAtualizacao { get; set; }
        public string EstadoId { get; set; }
        public Nullable<double> TaxaComissionamento { get; set; }
        public string ComissionamentoId { get; set; }
        public Nullable<double> TaxaAtribuir { get; set; }
        public Nullable<double> DescontoMin { get; set; }
        public Nullable<double> DescontoMax { get; set; }
        public Nullable<double> ComissaoAngariacao { get; set; }
        public Nullable<double> ComissaoMediacao { get; set; }
        public Nullable<double> ComissaoCorretagem { get; set; }
        public Nullable<double> ComissaoCobranca { get; set; }
    
        public virtual CanalPlano CanalPlano { get; set; }
        public virtual Comissionamento Comissionamento { get; set; }
        public virtual Estado Estado { get; set; }
        public virtual FormaPagamentoPlano FormaPagamentoPlano { get; set; }
        public virtual PapelPlano PapelPlano { get; set; }
        public virtual Pessoa Pessoa { get; set; }
        public virtual PlanoProduto PlanoProduto { get; set; }
        public virtual SectorActividadePlano SectorActividadePlano { get; set; }
        public virtual TipoSegmentoPlano TipoSegmentoPlano1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<LimiteComissionamentoProdutor> LimiteComissionamentoProdutor { get; set; }
    }
}