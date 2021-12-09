//////////////////////////////////////////////////////////////////////////
// Criacao...........: 02/2016
// Sistema...........: Loja Virtual
// Analistas.........: Marilene Esquiavoni & Denny Paulista Azevedo Filho
// Desenvolvedores...: Marilene Esquiavoni & Denny Paulista Azevedo Filho
// Copyright.........: Marilene Esquiavoni & Denny Paulista Azevedo Filho
//////////////////////////////////////////////////////////////////////////

using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ShopVirtual.BLL;
using ShopVirtual.Model;

namespace ShopVirtual.Test
{
  [TestClass]
  //Não esquecer de colcoar a Sting de conexão no appconfig.
  public class ClienteBLLTest
  {
    [Priority(1)]
    [TestMethod]
    public void CriandoDados()
    {
      Cliente cli = new Cliente();

      cli.Nome = "Beltrano Alves";
      cli.EMAIL = "beltralves@pg1.com.br";
      cli.Senha = "123456";
      cli.DataCadastro = DateTime.Now;

      ClienteBLL cliEntra = new ClienteBLL();

      cliEntra.Add(cli);
      var cliDb = cliEntra.Localiza("beltralves@pg1.com.br");

      Assert.AreEqual(cliDb.Nome, "Beltrano Alves");
    }

    [Priority(2)]
    [TestMethod]
    public void AlterandoCliente()
    {
      string nomeCliAntes;
      ClienteBLL cliEntra = new ClienteBLL();

      var cli = cliEntra.Localiza("beltralves@pg1.com.br");

      nomeCliAntes = cli.Nome;

      cli.Nome = "Ciclano Castro";

      cliEntra.Update(cli);

      var cliDb = cliEntra.Localiza("beltralves@pg1.com.br");

      Assert.AreNotEqual(nomeCliAntes, cliDb.Nome);
    }

    [Priority(3)]
    [TestMethod]
    public void ExcluindoCliente()
    {
      ClienteBLL cliEntra = new ClienteBLL();
      var cli = cliEntra.Localiza("beltralves@pg1.com.br");

      cliEntra.Delete(cli);

      var cliDb = cliEntra.VerificarExistencia("beltralves@pg1.com.br");

      Assert.IsFalse(cliDb);
    }
  }
}
