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
    
    public partial class LimiteComissionamentoPlano
    {
        public string IdLimiteComissionamentoPlano { get; set; }
        public Nullable<double> PremioMin { get; set; }
        public Nullable<double> PremioMax { get; set; }
        public string ProvinciaPlanoId { get; set; }
        public string CanalPlanoId { get; set; }
        public string TipoSegmentoPlanoId { get; set; }
        public string SectorActividadePlanoId { get; set; }
        public string FidelizacaoPlanoId { get; set; }
        public string SectorActividadePlano { get; set; }
        public Nullable<double> TaxaPercentagem { get; set; }
        public Nullable<double> TaxaMin { get; set; }
        public Nullable<double> TaxaMax { get; set; }
        public Nullable<System.DateTime> DataCricao { get; set; }
        public Nullable<System.DateTime> DataAtualizacao { get; set; }
        public string EstadoId { get; set; }
    
        public virtual CanalPlano CanalPlano { get; set; }
        public virtual Estado Estado { get; set; }
        public virtual FidelizacaoPlano FidelizacaoPlano { get; set; }
        public virtual ProvinciaPlano ProvinciaPlano { get; set; }
        public virtual SectorActividadePlano SectorActividadePlano1 { get; set; }
        public virtual SectorActividadePlano SectorActividadePlano2 { get; set; }
        public virtual TipoSegmentoPlano TipoSegmentoPlano { get; set; }
    }
}
