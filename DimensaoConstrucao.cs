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
    
    public partial class DimensaoConstrucao
    {
        public string IdDimensaoConstrucao { get; set; }
        public string Dimensao { get; set; }
        public string Comprimento { get; set; }
        public string Largura { get; set; }
        public string Altura { get; set; }
        public string Profundidade { get; set; }
        public string ConstrucaoID { get; set; }
        public Nullable<System.DateTime> DataCriacao { get; set; }
        public Nullable<System.DateTime> DataAtualizacao { get; set; }
        public string EstadoID { get; set; }
    
        public virtual Construcao Construcao { get; set; }
        public virtual Estado Estado { get; set; }
    }
}