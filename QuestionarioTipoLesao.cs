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
    
    public partial class QuestionarioTipoLesao
    {
        public string IdQuestionarioTipoLesao { get; set; }
        public string PerguntaId { get; set; }
        public string IncapacidadeTemporariaId { get; set; }
        public string EstadoId { get; set; }
        public string CodQuestionarioTipoLesao { get; set; }
        public Nullable<System.DateTime> DataCriacao { get; set; }
        public Nullable<System.DateTime> DataAtualizacao { get; set; }
    
        public virtual Estado Estado { get; set; }
        public virtual IncapacidadeTemporaria IncapacidadeTemporaria { get; set; }
        public virtual Perguntas Perguntas { get; set; }
    }
}
