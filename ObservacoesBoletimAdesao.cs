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
    
    public partial class ObservacoesBoletimAdesao
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ObservacoesBoletimAdesao()
        {
            this.BoletimAdesaoSaude = new HashSet<BoletimAdesaoSaude>();
        }
    
        public string IdObservacoesBoletimAdesao { get; set; }
        public string Observacao { get; set; }
        public Nullable<bool> Aprovado { get; set; }
        public string IntroduzidoPor { get; set; }
        public Nullable<System.DateTime> DataActualizacao { get; set; }
        public Nullable<System.DateTime> DataCriacao { get; set; }
        public string EstadoId { get; set; }
        public string CodObservacoesBoletimAdesao { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BoletimAdesaoSaude> BoletimAdesaoSaude { get; set; }
        public virtual Estado Estado { get; set; }
        public virtual Pessoa Pessoa { get; set; }
    }
}
