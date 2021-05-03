using NUnit.Framework;
using System;
using System.Collections.Generic;
using Teste;

namespace Testes
{
    public class Tests
    {
        private Pessoa pessoa;
        private List<Pessoa> pessoas = new List<Pessoa>();

        [SetUp]
        public void Setup()
        {
            this.pessoa = new Pessoa(1, "Glau", "123123", "123123", 28, DateTime.Now);
            this.pessoas.Add(this.pessoa);

            this.pessoa = new Pessoa(2, "Lucas", "2222222", "222222", 28, DateTime.Now);
            this.pessoas.Add(this.pessoa);

            this.pessoa = new Pessoa(3, "Rafa", "3333333", "333333", 28, DateTime.Now);
            this.pessoas.Add(this.pessoa);

            this.pessoa = new Pessoa();
        }

        [Test]
        public void SalvarPessoaValido()
        {
            pessoa.Id = 1;
            pessoa.Nome = "Glau";
            pessoa.CPF = "102930129";
            pessoa.RG = "1231231";
            pessoa.Idade = 18;
            pessoa.HoraNascimento = DateTime.Now;

            Assert.IsNotNull(pessoa.Id);
            Assert.IsNotNull(pessoa.Nome);
            Assert.IsNotNull(pessoa.CPF);
            Assert.IsNotNull(pessoa.RG);
            Assert.IsNotNull(pessoa.Idade);
            Assert.IsNotNull(pessoa.HoraNascimento);

            Assert.AreEqual(pessoa.SalvarPessoa(pessoa), "Ok");
        }

        [Test]
        public void SalvarPessoaInvalido()
        {
            pessoa.Id = 1;
            pessoa.Nome = "Glau";
            pessoa.CPF = "102930129";
            pessoa.RG = "1231231";
            pessoa.Idade = 18;
            pessoa.HoraNascimento = DateTime.Now;

            // para percorrer uma lista, da para usar o foreach()
            // depois de percorrer a lista, verificar se o nome ja existe com o nome passado aqui nesse metodo.

            Assert.IsNotNull(pessoa.Id);
            Assert.IsNotNull(pessoa.Nome);
            Assert.IsNotNull(pessoa.CPF);
            Assert.IsNotNull(pessoa.RG);
            Assert.IsNotNull(pessoa.Idade);
            Assert.IsNotNull(pessoa.HoraNascimento);

            Assert.AreEqual(pessoa.SalvarPessoa(pessoa), "Ok");
        }
    }
}