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
    
    public partial class RiscoPortfolio
    {
        public string IdRiscoPortfolio { get; set; }
        public string CodRiscoPortfolio { get; set; }
        public string Estadoid { get; set; }
        public string RiscoId { get; set; }
        public string PortfolioId { get; set; }
        public Nullable<System.DateTime> DataCriacao { get; set; }
        public Nullable<System.DateTime> DataAtualizacao { get; set; }
    
        public virtual Estado Estado { get; set; }
        public virtual Portfolio Portfolio { get; set; }
        public virtual Risco Risco { get; set; }
    }
}