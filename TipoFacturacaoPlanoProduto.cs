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
    
    public partial class TipoFacturacaoPlanoProduto
    {
        public string IdTipoFacturacao { get; set; }
        public string PlanoProdutoID { get; set; }
        public string TipoFacturacaoId { get; set; }
    
        public virtual PlanoProduto PlanoProduto { get; set; }
        public virtual TipoFacturacao TipoFacturacao { get; set; }
    }
}