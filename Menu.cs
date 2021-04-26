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
    
    public partial class Menu
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Menu()
        {
            this.CanalMenu = new HashSet<CanalMenu>();
            this.Menu1 = new HashSet<Menu>();
            this.SubMenu = new HashSet<SubMenu>();
        }
    
        public string IdMenu { get; set; }
        public string Name { get; set; }
        public string Path { get; set; }
        public string PapelId { get; set; }
        public string DesignacaoModulo { get; set; }
        public string Icon { get; set; }
        public string Legenda { get; set; }
        public string LicencaId { get; set; }
        public Nullable<System.DateTime> DataCriacao { get; set; }
        public Nullable<System.DateTime> DataActualizacao { get; set; }
        public string EstadoId { get; set; }
        public string NivelPaiId { get; set; }
        public Nullable<int> NumOrdem { get; set; }
        public Nullable<bool> Collapse { get; set; }
        public string State { get; set; }
        public string Layout { get; set; }
        public string Component { get; set; }
        public string CodMenu { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CanalMenu> CanalMenu { get; set; }
        public virtual Estado Estado { get; set; }
        public virtual Licenca Licenca { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Menu> Menu1 { get; set; }
        public virtual Menu Menu2 { get; set; }
        public virtual Papel Papel { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SubMenu> SubMenu { get; set; }
    }
}