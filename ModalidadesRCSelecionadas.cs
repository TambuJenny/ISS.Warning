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
    
    public partial class ModalidadesRCSelecionadas
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ModalidadesRCSelecionadas()
        {
            this.Animais = new HashSet<Animais>();
        }
    
        public string IdModalidadesRCSelecionada { get; set; }
        public Nullable<int> NumEstabelecimento { get; set; }
        public Nullable<int> NumHabilitacoes { get; set; }
        public Nullable<int> NumEscritorios { get; set; }
        public Nullable<int> NumPessoas { get; set; }
        public Nullable<int> NumLugares { get; set; }
        public Nullable<int> NumPisos { get; set; }
        public Nullable<int> AnoConstrucao { get; set; }
        public Nullable<double> FrequenciaUtilizacao { get; set; }
        public Nullable<int> NumEmpregados { get; set; }
        public Nullable<double> ValorMonetarioMax { get; set; }
        public string TipoSalaEspetaculoID { get; set; }
        public string TipoEstabelecimentoID { get; set; }
        public string ClassificacaoAscensorID { get; set; }
        public string ModalidadeResponsabilidadeCivilID { get; set; }
        public string InstalacaoID { get; set; }
        public string TipoAntenaID { get; set; }
        public string ValorTipoAntenaID { get; set; }
        public string CodModalidadesRCSelecionadas { get; set; }
        public Nullable<System.DateTime> DataCriacao { get; set; }
        public Nullable<System.DateTime> DataAtualizacao { get; set; }
        public string EstadoID { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Animais> Animais { get; set; }
        public virtual ClassificacaoAscensoresMontaCarga ClassificacaoAscensoresMontaCarga { get; set; }
        public virtual Estado Estado { get; set; }
        public virtual Instalacoes Instalacoes { get; set; }
        public virtual LocalidadeAntena LocalidadeAntena { get; set; }
        public virtual ModalidadesResponsabilidadeCivil ModalidadesResponsabilidadeCivil { get; set; }
        public virtual TipoEstabelecimentoComercio TipoEstabelecimentoComercio { get; set; }
        public virtual TipoSalaEspetaculo TipoSalaEspetaculo { get; set; }
        public virtual ValoresTipoAntena ValoresTipoAntena { get; set; }
    }
}
