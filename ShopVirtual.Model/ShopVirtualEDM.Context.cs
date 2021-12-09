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
  using System.Data.Entity;
  using System.Data.Entity.Infrastructure;

  public partial class LojaEntities : DbContext
  {
    public LojaEntities() : base("name=LojaEntities")
    {

    }

    protected override void OnModelCreating(DbModelBuilder modelBuilder)
    {
      throw new UnintentionalCodeFirstException();
    }

    public virtual DbSet<Banner> Banner { get; set; }
    public virtual DbSet<Categoria> Categoria { get; set; }
    public virtual DbSet<Cliente> Cliente { get; set; }
    public virtual DbSet<Comentario> Comentario { get; set; }
    public virtual DbSet<Fabricante> Fabricante { get; set; }
    public virtual DbSet<ItemVenda> ItemVenda { get; set; }
    public virtual DbSet<Produto> Produto { get; set; }
    public virtual DbSet<TipoVenda> TipoVenda { get; set; }
    public virtual DbSet<Venda> Venda { get; set; }
  }
}
