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
    
    public partial class ResponsavelBalcao
    {
        public string IdResponsavelBalcao { get; set; }
        public string ResponsavelID { get; set; }
        public string BalcaoID { get; set; }
        public Nullable<System.DateTime> DataCriacao { get; set; }
        public Nullable<System.DateTime> DataAtualizacao { get; set; }
        public string EstadoID { get; set; }
    
        public virtual Agencia Agencia { get; set; }
        public virtual Estado Estado { get; set; }
        public virtual Funcionario Funcionario { get; set; }
    }
}
