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
    
    public partial class ExemplarModeloAutomovel
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ExemplarModeloAutomovel()
        {
            this.Automovel = new HashSet<Automovel>();
        }
    
        public string IdExemplar { get; set; }
        public string Nome { get; set; }
        public string Referencia { get; set; }
        public Nullable<int> AnoFabrico { get; set; }
        public string ModeloAutomovelID { get; set; }
        public string CombustivelID { get; set; }
        public string CodExemplarModeloAutomovel { get; set; }
        public Nullable<System.DateTime> DataCriacao { get; set; }
        public Nullable<System.DateTime> DataAtualizacao { get; set; }
        public string EstadoID { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Automovel> Automovel { get; set; }
        public virtual Combustivel Combustivel { get; set; }
        public virtual Estado Estado { get; set; }
        public virtual ModeloAutomovel ModeloAutomovel { get; set; }
    }
}
