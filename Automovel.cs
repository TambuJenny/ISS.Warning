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
    
    public partial class Automovel
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Automovel()
        {
            this.AnexosAutomovel = new HashSet<AnexosAutomovel>();
            this.AutomovelSistemaSeguranca = new HashSet<AutomovelSistemaSeguranca>();
            this.AutomovelEnvolvido = new HashSet<AutomovelEnvolvido>();
            this.AutomovelDadosAdicional = new HashSet<AutomovelDadosAdicional>();
            this.CaracteristicaAtutomovel = new HashSet<CaracteristicaAtutomovel>();
            this.DocumentosAutomovel = new HashSet<DocumentosAutomovel>();
            this.GPSAutomovel = new HashSet<GPSAutomovel>();
            this.Modificacao = new HashSet<Modificacao>();
            this.MotoristaAutomovel = new HashSet<MotoristaAutomovel>();
            this.Motorista = new HashSet<Motorista>();
            this.ObjectoEnvolvido = new HashSet<ObjectoEnvolvido>();
            this.ObjectoSegurado = new HashSet<ObjectoSegurado>();
            this.Passageiros = new HashSet<Passageiros>();
            this.Pneu = new HashSet<Pneu>();
            this.RespostaPergunta = new HashSet<RespostaPergunta>();
        }
    
        public string IdAutomovel { get; set; }
        public string TipoCaixaID { get; set; }
        public string ProprietarioID { get; set; }
        public string LadoVolanteID { get; set; }
        public string VelocidadeId { get; set; }
        public string Detalhe { get; set; }
        public string NivelDesempenhoID { get; set; }
        public string PaisMatriculaID { get; set; }
        public string MoedaID { get; set; }
        public string Matricula { get; set; }
        public string NumeroChassi { get; set; }
        public string ExemplarModeloID { get; set; }
        public string CilindragemAutomovelId { get; set; }
        public Nullable<System.DateTime> DataCriacao { get; set; }
        public Nullable<System.DateTime> DataAtualizacao { get; set; }
        public string EstadoID { get; set; }
        public string CodAutomovel { get; set; }
        public string CorId { get; set; }
        public string TipoMotorId { get; set; }
        public string TipoCorpoId { get; set; }
        public Nullable<System.DateTime> DataPrimeiraMatricula { get; set; }
        public Nullable<float> ValorEmNovo { get; set; }
        public Nullable<float> ValorActual { get; set; }
        public string ClassificacaoAutomovelId { get; set; }
        public string NumMotor { get; set; }
        public Nullable<System.DateTime> DataUltimoSinistroParticipado { get; set; }
        public string TipoUsoId { get; set; }
        public Nullable<int> AnoConstrucao { get; set; }
        public Nullable<double> Potencia { get; set; }
        public Nullable<int> NumLugares { get; set; }
        public string CaminhoFicheiro { get; set; }
        public string MoedaValorActualId { get; set; }
        public string TipoMatriculaID { get; set; }
        public Nullable<double> PesoReboque { get; set; }
        public Nullable<float> Tara { get; set; }
        public string PesoAutomovelID { get; set; }
        public string ClassificacaoTipoVeiculoId { get; set; }
        public string TipoMaterialId { get; set; }
        public Nullable<double> Comprimento { get; set; }
        public string TipoServicoId { get; set; }
        public string MedidaPneumatico { get; set; }
        public Nullable<int> NumCilindros { get; set; }
        public string Cilindrada { get; set; }
        public string NumQuadro { get; set; }
        public string DistanciaEntreEixos { get; set; }
        public Nullable<double> PesoBruto { get; set; }
        public Nullable<System.DateTime> UltimaAvaria { get; set; }
        public string SistemaTravagemId { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<AnexosAutomovel> AnexosAutomovel { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<AutomovelSistemaSeguranca> AutomovelSistemaSeguranca { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<AutomovelEnvolvido> AutomovelEnvolvido { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<AutomovelDadosAdicional> AutomovelDadosAdicional { get; set; }
        public virtual CilindragemAutomovel CilindragemAutomovel { get; set; }
        public virtual ClassificacaoAutomovel ClassificacaoAutomovel { get; set; }
        public virtual ClassificacaoTipoVeiculo ClassificacaoTipoVeiculo { get; set; }
        public virtual Cor Cor { get; set; }
        public virtual Estado Estado { get; set; }
        public virtual ExemplarModeloAutomovel ExemplarModeloAutomovel { get; set; }
        public virtual LadoVolante LadoVolante { get; set; }
        public virtual Moeda Moeda { get; set; }
        public virtual Moeda Moeda1 { get; set; }
        public virtual NivelDesempenho NivelDesempenho { get; set; }
        public virtual Pais Pais { get; set; }
        public virtual PesoAutomovel PesoAutomovel { get; set; }
        public virtual Pessoa Pessoa { get; set; }
        public virtual SistemaTravagem SistemaTravagem { get; set; }
        public virtual TipoCorpo TipoCorpo { get; set; }
        public virtual TipoCaixa TipoCaixa { get; set; }
        public virtual TipoMotor TipoMotor { get; set; }
        public virtual TipoMaterial TipoMaterial { get; set; }
        public virtual TipoMatricula TipoMatricula { get; set; }
        public virtual TipoServico TipoServico { get; set; }
        public virtual TipoUso TipoUso { get; set; }
        public virtual Velocidade Velocidade { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CaracteristicaAtutomovel> CaracteristicaAtutomovel { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DocumentosAutomovel> DocumentosAutomovel { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<GPSAutomovel> GPSAutomovel { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Modificacao> Modificacao { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MotoristaAutomovel> MotoristaAutomovel { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Motorista> Motorista { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ObjectoEnvolvido> ObjectoEnvolvido { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ObjectoSegurado> ObjectoSegurado { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Passageiros> Passageiros { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Pneu> Pneu { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RespostaPergunta> RespostaPergunta { get; set; }
    }
}
