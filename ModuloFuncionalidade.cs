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
    
    public partial class ModuloFuncionalidade
    {
        public string IdModuloModuloFuncionalidade { get; set; }
        public string ModuloId { get; set; }
        public string CanalPerfilModuloId { get; set; }
        public string FuncionalidadeId { get; set; }
        public Nullable<System.DateTime> DataCriacao { get; set; }
        public Nullable<System.DateTime> DataAtualizacao { get; set; }
    
        public virtual CanalPerfilModulo CanalPerfilModulo { get; set; }
        public virtual Funcionalidade Funcionalidade { get; set; }
        public virtual Modulo Modulo { get; set; }
    }
}
