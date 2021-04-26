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
    
    public partial class Agenda
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Agenda()
        {
            this.ActividadesAgenda = new HashSet<ActividadesAgenda>();
            this.AgendaPlano = new HashSet<AgendaPlano>();
            this.ContratoAgenda = new HashSet<ContratoAgenda>();
        }
    
        public string IdAgenda { get; set; }
        public Nullable<System.DateTime> DataInicio { get; set; }
        public Nullable<System.DateTime> DataFim { get; set; }
        public string Designacao { get; set; }
        public string PessoaResponsavelID { get; set; }
        public Nullable<System.DateTime> DataCriacao { get; set; }
        public Nullable<System.DateTime> DataAtualizacao { get; set; }
        public string EstadoID { get; set; }
        public string UltModificacaoPorID { get; set; }
        public string CodAgenda { get; set; }
        public string TipoRelatanteId { get; set; }
        public Nullable<System.TimeSpan> HoraInicio { get; set; }
        public Nullable<System.TimeSpan> HoraFim { get; set; }
        public string Descricao { get; set; }
        public string PrioridadeId { get; set; }
        public string CaminhoFicheiro { get; set; }
        public string PadraoRecorrenciaId { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ActividadesAgenda> ActividadesAgenda { get; set; }
        public virtual Estado Estado { get; set; }
        public virtual PadraoRecorrencia PadraoRecorrencia { get; set; }
        public virtual Pessoa Pessoa { get; set; }
        public virtual Prioridade Prioridade { get; set; }
        public virtual TipoRelatante TipoRelatante { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<AgendaPlano> AgendaPlano { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ContratoAgenda> ContratoAgenda { get; set; }
    }
}