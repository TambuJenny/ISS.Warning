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
    
    public partial class FranquiaInvalidezTemporaria
    {
        public string IdFranquiaIncapacidadeTemporaria { get; set; }
        public string IdTaxaSinistralidade { get; set; }
        public Nullable<double> TaxaFranquia { get; set; }
        public string CodFranquia { get; set; }
        public Nullable<System.DateTime> DataCriacao { get; set; }
        public Nullable<System.DateTime> DataActualizacao { get; set; }
        public string EstadoId { get; set; }
    
        public virtual Estado Estado { get; set; }
        public virtual TaxaSinistralidade TaxaSinistralidade { get; set; }
    }
}
