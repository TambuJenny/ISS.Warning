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
    
    public partial class Motorista
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Motorista()
        {
            this.AssinaturasCondutores = new HashSet<AssinaturasCondutores>();
            this.InqueritoMotorista = new HashSet<InqueritoMotorista>();
            this.SinalizacaoAplicavel = new HashSet<SinalizacaoAplicavel>();
            this.VestigiosAcidente = new HashSet<VestigiosAcidente>();
            this.MotoristaAutomovel = new HashSet<MotoristaAutomovel>();
        }
    
        public string IdMotorista { get; set; }
        public string PessoaId { get; set; }
        public string CodMotorista { get; set; }
        public string SinistroId { get; set; }
        public Nullable<System.DateTime> DataCriacao { get; set; }
        public string AutomovelId { get; set; }
        public Nullable<System.DateTime> DataAtualizacao { get; set; }
        public string EstadoId { get; set; }
        public string EstadoFisiologicoId { get; set; }
        public string CondutorFrequenteId { get; set; }
        public Nullable<bool> UtilizandoTelemovel { get; set; }
        public string DanosCorporais { get; set; }
        public string CartaConducaoId { get; set; }
        public string Observacoes { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<AssinaturasCondutores> AssinaturasCondutores { get; set; }
        public virtual Automovel Automovel { get; set; }
        public virtual CartaConducao CartaConducao { get; set; }
        public virtual CondutorFrequente CondutorFrequente { get; set; }
        public virtual Estado Estado { get; set; }
        public virtual EstadoFisiologico EstadoFisiologico { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<InqueritoMotorista> InqueritoMotorista { get; set; }
        public virtual Pessoa Pessoa { get; set; }
        public virtual Sinistro Sinistro { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SinalizacaoAplicavel> SinalizacaoAplicavel { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<VestigiosAcidente> VestigiosAcidente { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MotoristaAutomovel> MotoristaAutomovel { get; set; }
    }
}
