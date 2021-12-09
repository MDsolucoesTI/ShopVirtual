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

  public partial class Comentario
  {
    public int ID { get; set; }
    public string Nome { get; set; }
    public string EMail { get; set; }
    public string Descricao { get; set; }
    public int ID_Produto { get; set; }
    public int Nota { get; set; }

    public virtual Produto Produto { get; set; }
  }
}
