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
    
    public partial class SubSubMenu
    {
        public string IdSubSubMenu { get; set; }
        public string Designacao { get; set; }
        public string Path { get; set; }
        public string Legenda { get; set; }
        public string SubMenuId { get; set; }
        public string DataCriacao { get; set; }
        public string DataActualizacao { get; set; }
    
        public virtual SubMenu SubMenu { get; set; }
    }
}
