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

  public partial class Venda
  {
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
    public Venda()
    {
      this.ItemVenda = new HashSet<ItemVenda>();
    }

    public int ID { get; set; }
    public int ID_Cliente { get; set; }
    public int ID_TipoVenda { get; set; }
    public System.DateTime DataVenda { get; set; }
    public decimal ValorTotal { get; set; }
    public string Status { get; set; }

    public virtual Cliente Cliente { get; set; }
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
    public virtual ICollection<ItemVenda> ItemVenda { get; set; }
    public virtual TipoVenda TipoVenda { get; set; }
  }
}
