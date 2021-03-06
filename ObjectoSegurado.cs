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
    
    public partial class ObjectoSegurado
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ObjectoSegurado()
        {
            this.CaracteristicaObjecto = new HashSet<CaracteristicaObjecto>();
            this.CoberturaSelecionada = new HashSet<CoberturaSelecionada>();
            this.Sinistro = new HashSet<Sinistro>();
        }
    
        public string IdObjectoSegurado { get; set; }
        public Nullable<System.DateTime> DataCriacao { get; set; }
        public Nullable<System.DateTime> DataAtualizacao { get; set; }
        public string EstadoId { get; set; }
        public string CotacaoId { get; set; }
        public string ClassificacaoId { get; set; }
        public string AutomovelId { get; set; }
        public Nullable<double> PremioSimples { get; set; }
        public Nullable<double> EncargosAdministrativos { get; set; }
        public Nullable<double> JurosFraccionamento { get; set; }
        public Nullable<double> PremioComercial { get; set; }
        public Nullable<double> Comissoes { get; set; }
        public Nullable<double> ARSEG { get; set; }
        public Nullable<double> IVA { get; set; }
        public Nullable<double> PremioTotal { get; set; }
        public Nullable<double> CapitalSeguro { get; set; }
        public Nullable<double> PremioCobrado { get; set; }
        public Nullable<double> PremioRisco { get; set; }
        public Nullable<double> Impostos { get; set; }
        public Nullable<double> Despesas { get; set; }
        public Nullable<double> Descontos { get; set; }
        public Nullable<double> FGA { get; set; }
        public string EstadoObjectoId { get; set; }
        public string MoedaId { get; set; }
        public string Deformacoes { get; set; }
        public string CaminhoFicheiro { get; set; }
        public Nullable<bool> IsDP { get; set; }
        public Nullable<bool> IsRC { get; set; }
        public string BI { get; set; }
    
        public virtual Automovel Automovel { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CaracteristicaObjecto> CaracteristicaObjecto { get; set; }
        public virtual Classificacao Classificacao { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CoberturaSelecionada> CoberturaSelecionada { get; set; }
        public virtual Cotacao Cotacao { get; set; }
        public virtual Estado Estado { get; set; }
        public virtual Estado Estado1 { get; set; }
        public virtual Moeda Moeda { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Sinistro> Sinistro { get; set; }
    }
}
