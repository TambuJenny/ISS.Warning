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
    
    public partial class CaracteristicaObjecto
    {
        public string IdCaracteristicaObjecto { get; set; }
        public string ObjectoId { get; set; }
        public Nullable<System.DateTime> DataCriacao { get; set; }
        public string Valor { get; set; }
        public Nullable<System.DateTime> DataAtualizacao { get; set; }
        public string EstadoId { get; set; }
        public string CaracteristicaClassificacaoId { get; set; }
    
        public virtual CaracteristicaClassificacao CaracteristicaClassificacao { get; set; }
        public virtual Estado Estado { get; set; }
        public virtual ObjectoSegurado ObjectoSegurado { get; set; }
    }
}
