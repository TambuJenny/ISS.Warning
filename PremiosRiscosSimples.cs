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
    
    public partial class PremiosRiscosSimples
    {
        public string IdPremiosRiscosSimples { get; set; }
        public string ClassificacaoObjectoSeguro { get; set; }
        public string LocalidadeID { get; set; }
        public Nullable<double> Risco1 { get; set; }
        public Nullable<double> Risco2 { get; set; }
        public Nullable<double> Risco3 { get; set; }
        public Nullable<System.DateTime> DataCriacao { get; set; }
        public Nullable<System.DateTime> DataActualizacao { get; set; }
        public string CodPremiosRiscosSimples { get; set; }
        public string EstadoID { get; set; }
    
        public virtual Endereco Endereco { get; set; }
        public virtual Estado Estado { get; set; }
    }
}
