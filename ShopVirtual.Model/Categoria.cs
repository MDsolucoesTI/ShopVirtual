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

  public partial class Categoria
  {
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
    public Categoria()
    {
      this.Produto = new HashSet<Produto>();
    }

    public int ID { get; set; }
    public string Nome { get; set; }

    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
    public virtual ICollection<Produto> Produto { get; set; }
  }
}
