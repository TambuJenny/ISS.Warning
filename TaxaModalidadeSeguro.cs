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
    
    public partial class TaxaModalidadeSeguro
    {
        public string IdTaxaModalidadeSeguro { get; set; }
        public string ModalidadeSeguroId { get; set; }
        public string TaxaId { get; set; }
        public Nullable<System.DateTime> DtaCriacao { get; set; }
        public Nullable<System.DateTime> DataAtualizacao { get; set; }
    
        public virtual ModalidadeSeguro ModalidadeSeguro { get; set; }
        public virtual Taxas Taxas { get; set; }
    }
}
