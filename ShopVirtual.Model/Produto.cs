//////////////////////////////////////////////////////////////////////////
// Criacao...........: 02/2016
// Sistema...........: Loja Virtual
// Analistas.........: Marilene Esquiavoni & Denny Paulista Azevedo Filho
// Desenvolvedores...: Marilene Esquiavoni & Denny Paulista Azevedo Filho
// Copyright.........: Marilene Esquiavoni & Denny Paulista Azevedo Filho
//////////////////////////////////////////////////////////////////////////

namespace ShopVirtual.Model
{
  using System;
  using System.Collections.Generic;

  public partial class Produto
  {
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
    public Produto()
    {
      this.Comentario = new HashSet<Comentario>();
      this.ItemVenda = new HashSet<ItemVenda>();
    }

    public int ID { get; set; }
    public string Nome { get; set; }
    public string Descricao { get; set; }
    public decimal Valor { get; set; }
    public System.DateTime DataCadastro { get; set; }
    public string Foto { get; set; }
    public string Destaque { get; set; }
    public int ID_Categoria { get; set; }
    public int ID_Fabricante { get; set; }
    public string Garantia { get; set; }
    public string Foto2 { get; set; }
    public string Foto3 { get; set; }
    public string Foto4 { get; set; }

    public virtual Categoria Categoria { get; set; }
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
    public virtual ICollection<Comentario> Comentario { get; set; }
    public virtual Fabricante Fabricante { get; set; }
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
    public virtual ICollection<ItemVenda> ItemVenda { get; set; }
  }
}
