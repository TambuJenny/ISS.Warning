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
    
    public partial class ExportacoesProdutosInstalacoes
    {
        public string IdExportacaoProdutosInstalacoes { get; set; }
        public Nullable<bool> ParaEUACanada { get; set; }
        public Nullable<double> EstimativaAnual { get; set; }
        public string CaminhoFicheiro { get; set; }
        public string MoedaID { get; set; }
        public string PaisID { get; set; }
        public string ProdutoInstalacaoID { get; set; }
        public string CodExportacoesProdutosInstalacoes { get; set; }
        public Nullable<System.DateTime> DataCriacao { get; set; }
        public Nullable<System.DateTime> DataAtualizacao { get; set; }
        public string EstadoID { get; set; }
    
        public virtual Estado Estado { get; set; }
        public virtual Moeda Moeda { get; set; }
        public virtual Pais Pais { get; set; }
        public virtual ProdutosInstalacoes ProdutosInstalacoes { get; set; }
    }
}