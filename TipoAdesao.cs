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
    
    public partial class TipoAdesao
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TipoAdesao()
        {
            this.CoeficientePremioAdesao = new HashSet<CoeficientePremioAdesao>();
            this.CoeficientePremioAdesao1 = new HashSet<CoeficientePremioAdesao>();
        }
    
        public string IdTipoAdesao { get; set; }
        public string Designacao { get; set; }
        public string CodTipoAdesao { get; set; }
        public Nullable<System.DateTime> DataActualizacao { get; set; }
        public Nullable<System.DateTime> DataCriacao { get; set; }
        public string EstadoId { get; set; }
        public string FormaContratacaoID { get; set; }
        public string AgravamentoId { get; set; }
    
        public virtual Agravamento Agravamento { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CoeficientePremioAdesao> CoeficientePremioAdesao { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CoeficientePremioAdesao> CoeficientePremioAdesao1 { get; set; }
        public virtual Estado Estado { get; set; }
        public virtual FormaContratacao FormaContratacao { get; set; }
    }
}
