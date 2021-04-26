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
    
    public partial class Lesado
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Lesado()
        {
            this.DocumentosLesado = new HashSet<DocumentosLesado>();
            this.FotografiasLesoes = new HashSet<FotografiasLesoes>();
            this.LesaoLesado = new HashSet<LesaoLesado>();
        }
    
        public string IdLesado { get; set; }
        public Nullable<bool> RelacaoComResponsavelAcidente { get; set; }
        public string EspecificacaoRelacao { get; set; }
        public string EspecificacaoDanos { get; set; }
        public string TipoIntervencaoId { get; set; }
        public string TipoDanosId { get; set; }
        public string TipoRelacaoSeguradoId { get; set; }
        public string PessoaId { get; set; }
        public string SinistroId { get; set; }
        public string FornecedorId { get; set; }
        public Nullable<System.DateTime> DataInicioPeriodoIncapacidadeTemporario { get; set; }
        public string CaminhoBoletimExame { get; set; }
        public string CaminhoBoletimObito { get; set; }
        public string CaminhoRelatorioAutopsia { get; set; }
        public Nullable<System.DateTime> DataPrimeiroSocorro { get; set; }
        public Nullable<System.DateTime> DataCriacao { get; set; }
        public Nullable<System.DateTime> DataAtualizacao { get; set; }
        public string EstadoId { get; set; }
        public string UltModificacaoPorId { get; set; }
        public string CodLesado { get; set; }
        public Nullable<bool> IsFerido { get; set; }
        public string CaminhoFicheiro { get; set; }
        public string PapelLesadoId { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DocumentosLesado> DocumentosLesado { get; set; }
        public virtual Estado Estado { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FotografiasLesoes> FotografiasLesoes { get; set; }
        public virtual Pessoa Pessoa { get; set; }
        public virtual PapelLesado PapelLesado { get; set; }
        public virtual Pessoa Pessoa1 { get; set; }
        public virtual Sinistro Sinistro { get; set; }
        public virtual TipoDanos TipoDanos { get; set; }
        public virtual TipoIntervencao TipoIntervencao { get; set; }
        public virtual TipoRelacaoSegurado TipoRelacaoSegurado { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<LesaoLesado> LesaoLesado { get; set; }
    }
}