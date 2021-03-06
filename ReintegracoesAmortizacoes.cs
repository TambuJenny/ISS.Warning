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
    
    public partial class ReintegracoesAmortizacoes
    {
        public string IdReintegracoesAmortizacoes { get; set; }
        public string SeccaoCaeId { get; set; }
        public string SubSeccaoCaeId { get; set; }
        public string GrupoAmortizacaoId { get; set; }
        public string DesvalorizacaoId { get; set; }
        public Nullable<System.DateTime> DataCriacao { get; set; }
        public Nullable<System.DateTime> DataActualizacao { get; set; }
        public string SubGrupoAmortizacaoId { get; set; }
    
        public virtual Desvalorizacao Desvalorizacao { get; set; }
        public virtual GrupoAmortizacao GrupoAmortizacao { get; set; }
        public virtual SeccaoCAE SeccaoCAE { get; set; }
        public virtual SubGrupoAmortizacao SubGrupoAmortizacao { get; set; }
        public virtual SubSeccaoCae SubSeccaoCae { get; set; }
    }
}
