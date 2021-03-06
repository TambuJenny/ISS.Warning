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
    
    public partial class EstatutoOrganicoDepartamento
    {
        public string IdChefeDepartamento { get; set; }
        public string DepartamentoID { get; set; }
        public Nullable<System.DateTime> DataCriacao { get; set; }
        public Nullable<System.DateTime> DataAtualizacao { get; set; }
        public string EstadoID { get; set; }
        public string PessoaId { get; set; }
        public string FuncaoId { get; set; }
        public string CargoId { get; set; }
    
        public virtual Cargo Cargo { get; set; }
        public virtual Departamento Departamento { get; set; }
        public virtual Estado Estado { get; set; }
        public virtual Funcao Funcao { get; set; }
        public virtual Pessoa Pessoa { get; set; }
    }
}
