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
    
    public partial class Agencia
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Agencia()
        {
            this.AgenciaObjectivos = new HashSet<AgenciaObjectivos>();
            this.Balcao = new HashSet<Balcao>();
            this.BalcaoPlano = new HashSet<BalcaoPlano>();
            this.ContaFinanceira = new HashSet<ContaFinanceira>();
            this.Contrato = new HashSet<Contrato>();
            this.Denuncias = new HashSet<Denuncias>();
            this.ParticipacaoSinistro = new HashSet<ParticipacaoSinistro>();
            this.Pessoa = new HashSet<Pessoa>();
            this.Reclamacoes = new HashSet<Reclamacoes>();
            this.ResponsavelBalcao = new HashSet<ResponsavelBalcao>();
            this.SegmentoProduto = new HashSet<SegmentoProduto>();
            this.Sugestoes = new HashSet<Sugestoes>();
        }
    
        public string IdBalcao { get; set; }
        public Nullable<int> NumBalcao { get; set; }
        public string ContactoID { get; set; }
        public string EnderecoID { get; set; }
        public string CodBalcao { get; set; }
        public Nullable<System.DateTime> DataCriacao { get; set; }
        public Nullable<System.DateTime> DataAtualizacao { get; set; }
        public string EstadoID { get; set; }
        public string UltModificacaoPorID { get; set; }
        public string DistritoId { get; set; }
        public string EmpresaID { get; set; }
        public string NomeAgencia { get; set; }
        public string TipoGrupoId { get; set; }
        public string Email { get; set; }
    
        public virtual TipoGrupo TipoGrupo { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<AgenciaObjectivos> AgenciaObjectivos { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Balcao> Balcao { get; set; }
        public virtual Contacto Contacto { get; set; }
        public virtual Distrito Distrito { get; set; }
        public virtual Empresa Empresa { get; set; }
        public virtual Endereco Endereco { get; set; }
        public virtual Estado Estado { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BalcaoPlano> BalcaoPlano { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ContaFinanceira> ContaFinanceira { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Contrato> Contrato { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Denuncias> Denuncias { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ParticipacaoSinistro> ParticipacaoSinistro { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Pessoa> Pessoa { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Reclamacoes> Reclamacoes { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ResponsavelBalcao> ResponsavelBalcao { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SegmentoProduto> SegmentoProduto { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Sugestoes> Sugestoes { get; set; }
    }
}
