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
    
    public partial class HistoricoContadoresRegistos
    {
        public string HistoricoContadoresRegistos1 { get; set; }
        public string CodContadoresRegistos { get; set; }
        public string Designacao { get; set; }
        public Nullable<int> NumRegisto { get; set; }
        public string Ano { get; set; }
        public Nullable<System.DateTime> DataCriacao { get; set; }
        public Nullable<System.DateTime> DataAtualizacao { get; set; }
        public string IdContadoresRegistos { get; set; }
        public string EstadoID { get; set; }
    
        public virtual Estado Estado { get; set; }
    }
}
