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
    
    public partial class ReservasTecnicas
    {
        public string IdReserva { get; set; }
        public string Designacao { get; set; }
        public string CodReservasTecnicas { get; set; }
        public Nullable<System.DateTime> DataCriacao { get; set; }
        public Nullable<System.DateTime> DataAtualizacao { get; set; }
        public string EstadoID { get; set; }
        public bool IsTaxa { get; set; }
        public bool IsIndirecto { get; set; }
        public string CanalId { get; set; }
        public string UltModificacaoPorID { get; set; }
        public string MoedaId { get; set; }
        public string TipoProvisaoId { get; set; }
        public string LinhaProdutoId { get; set; }
        public string ApoliceId { get; set; }
        public Nullable<double> Taxa { get; set; }
        public string TipoOperacaoId { get; set; }
        public string TipoRamoSeguroId { get; set; }
        public string TipoProvisaoRamoSeguroId { get; set; }
        public Nullable<double> Valor { get; set; }
        public Nullable<double> ValorCobrado { get; set; }
    
        public virtual Apolice Apolice { get; set; }
        public virtual Canal Canal { get; set; }
        public virtual Estado Estado { get; set; }
        public virtual LinhaProduto LinhaProduto { get; set; }
        public virtual Moeda Moeda { get; set; }
        public virtual TipoProvisaoRamoSeguro TipoProvisaoRamoSeguro { get; set; }
        public virtual TipoProvisao TipoProvisao { get; set; }
        public virtual TipoRamoSeguro TipoRamoSeguro { get; set; }
        public virtual TipoOperacao TipoOperacao { get; set; }
    }
}
