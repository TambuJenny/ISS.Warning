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
    
    public partial class TipoDesconto
    {
        public string IdTipoDesconto { get; set; }
        public string Designacao { get; set; }
        public string CodTipoDesconto { get; set; }
        public Nullable<System.DateTime> DataCriacao { get; set; }
        public Nullable<System.DateTime> DataAtualizacao { get; set; }
        public string EstadoID { get; set; }
        public string CaminhoIcone { get; set; }
        public string UltModificacaoPorID { get; set; }
        public bool Contabiliza { get; set; }
    
        public virtual Estado Estado { get; set; }
    }
}
