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
    
    public partial class CondicoesCoSeguro
    {
        public string IdCondicoesCoSeguro { get; set; }
        public string CaminhoDocumento { get; set; }
        public string CondicoesID { get; set; }
        public string CoSeguroID { get; set; }
        public Nullable<System.DateTime> DataCriacao { get; set; }
        public Nullable<System.DateTime> DataAtualizacao { get; set; }
        public string EstadoID { get; set; }
    
        public virtual Condicoes Condicoes { get; set; }
        public virtual CoSeguro CoSeguro { get; set; }
        public virtual Estado Estado { get; set; }
    }
}
