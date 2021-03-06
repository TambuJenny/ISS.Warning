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
    
    public partial class PortfolioProduto
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public PortfolioProduto()
        {
            this.ImagemProduto = new HashSet<ImagemProduto>();
            this.Produto = new HashSet<Produto>();
        }
    
        public string IdPortfolio { get; set; }
        public string EstadoID { get; set; }
        public string Designacao { get; set; }
        public string TipoRamoSeguroID { get; set; }
        public string CodPortfolioProduto { get; set; }
        public Nullable<System.DateTime> DataCriacao { get; set; }
        public Nullable<System.DateTime> DataAtualizacao { get; set; }
        public string SubContaID { get; set; }
        public string NaturezaMovimentoId { get; set; }
        public bool Contabiliza { get; set; }
        public string TipoPortfolioProdutoId { get; set; }
        public string CaminhoImagem { get; set; }
    
        public virtual Estado Estado { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ImagemProduto> ImagemProduto { get; set; }
        public virtual NaturezaMovimento NaturezaMovimento { get; set; }
        public virtual PlanoContas PlanoContas { get; set; }
        public virtual TipoPortfolioProduto TipoPortfolioProduto { get; set; }
        public virtual TipoRamoSeguro TipoRamoSeguro { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Produto> Produto { get; set; }
    }
}
