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
    
    public partial class AspNetUserLogins
    {
        public string ProviderDisplayName { get; set; }
        public string UserId { get; set; }
        public Nullable<System.DateTime> DataEntrada { get; set; }
        public Nullable<System.DateTime> DataSaida { get; set; }
        public string LoginProvider { get; set; }
        public string EstadoId { get; set; }
    
        public virtual Estado Estado { get; set; }
        public virtual AspNetUsers AspNetUsers { get; set; }
    }
}