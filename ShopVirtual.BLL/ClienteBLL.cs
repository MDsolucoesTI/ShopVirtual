//////////////////////////////////////////////////////////////////////////
// Criacao...........: 02/2016
// Sistema...........: Loja Virtual
// Analistas.........: Marilene Esquiavoni & Denny Paulista Azevedo Filho
// Desenvolvedores...: Marilene Esquiavoni & Denny Paulista Azevedo Filho
// Copyright.........: Marilene Esquiavoni & Denny Paulista Azevedo Filho
//////////////////////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using ShopVirtual.Model;

namespace ShopVirtual.BLL
{
  public class ClienteBLL
  {
    //Efetua a conexão com ao BD, não esquecer de colcoar a Sting de conexão no appconfig.
    private LojaEntities _loja = new LojaEntities();

    public void Add(Cliente Entity)
    {
      //Executa o comando CREATE do SQL, com os dados do Objeto informado
      _loja.Cliente.Add(Entity);
      //Salva as alterações no BD
      _loja.SaveChanges();
    }

    public void Delete(Cliente Entity)
    {
      //localiza e Excliu o Objeto informado do DB
      _loja.Cliente.Remove(Entity);
      //Salva as alterações no BD
      _loja.SaveChanges();
    }

    public void Update(Cliente Entity)
    {
      //verifica a existência do Objeto a ser atualizado
      Cliente cli = _loja.Cliente.SingleOrDefault(c => c.ID == Entity.ID);
      //Se o objeto existe no BD, os valores são atualizados
      if (cli != null)
      {
        //atualiza os valores no BD
        _loja.Entry(Entity).CurrentValues.SetValues(Entity);
        //Salva as alterações no BD
        _loja.SaveChanges();
      }
    }

    //localiza o "Cliente" através do "Email", é utilizado uma expressão Lambda
    public Cliente Localiza(string email)
    {
      return Find(c => c.EMAIL.Trim().Equals(email)).FirstOrDefault();
    }

    //Retorna de uma lista (coleção) de "Clientes" através do uso de uma expressão lambda
    public IQueryable<Cliente> Find(Expression<Func<Cliente, bool>> where)
    {
      //preparo o retorno da coleção de "Clientes" em função da expressão dada
      return _loja.Cliente.Where(where);
    }

    //Retorna todos os "Clientes" existentes no BD
    public IQueryable<Cliente> GetAll()
    {
      //o retorno é feito através do método Take.
      //este método solicita a quantidade a ser retornada, para isso utilizamos o Count
      return _loja.Cliente.Take(_loja.Cliente.Count());
    }

    public Cliente Autentica(string email, string senha)
    {
      //localiza o Cliente com o email e senha fornecidos
      return Find(c => c.EMAIL.Trim().Equals(email) && c.Senha.Trim().Equals(senha)).FirstOrDefault();
    }

    public Cliente RecuperaSenha(string email)
    {
      //localiza o cliente através do email fornecido
      return Find(c => c.EMAIL.Trim().Equals(email)).FirstOrDefault();
    }

    public bool VerificarExistencia(string email)
    {
      int qtdCli = 0;
      //para verificar a existência de um cliente é utilizado o Count
      //com a restrição do e-mail forncedido
      qtdCli = Find(c => c.EMAIL.Trim().Equals(email)).Count();
      if (qtdCli > 0)
      {
        //Cliente existe
        return true;
      }
      else
      {
        //Cliente não existe
        return false;
      }
    }
  }
}
