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
    
    public partial class RecorrenciaMesAno
    {
        public string IdRecorrenciaMesAno { get; set; }
        public string PadraoRecorrenciaId { get; set; }
        public Nullable<int> NumeroInMesOuAno { get; set; }
        public string DiaSemanaRecorrencia { get; set; }
        public Nullable<System.DateTime> DataCriacao { get; set; }
        public Nullable<System.DateTime> DataAtualizacao { get; set; }
        public string EstadoId { get; set; }
        public Nullable<int> RegenerarNovaTarefaNum { get; set; }
    
        public virtual Estado Estado { get; set; }
        public virtual PadraoRecorrencia PadraoRecorrencia { get; set; }
    }
}