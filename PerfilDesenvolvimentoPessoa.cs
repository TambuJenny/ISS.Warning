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
    
    public partial class PerfilDesenvolvimentoPessoa
    {
        public string IdPerfilDesenvolvimentoPessoa { get; set; }
        public string PessoaId { get; set; }
        public string PerfilDesenvolvimentoID { get; set; }
        public Nullable<System.DateTime> DataCriacao { get; set; }
        public Nullable<System.DateTime> DataAtualizacao { get; set; }
        public string EstadoId { get; set; }
        public string CodPerfilDesenvolvimentoPessoa { get; set; }
    
        public virtual Estado Estado { get; set; }
        public virtual PerfilDesenvolvimento PerfilDesenvolvimento { get; set; }
        public virtual Pessoa Pessoa { get; set; }
    }
}
