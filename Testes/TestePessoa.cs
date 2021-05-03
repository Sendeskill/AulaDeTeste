using NUnit.Framework;
using Teste;

namespace Testes
{
    public class Tests
    {
        private Pessoa pessoa;


        [SetUp]
        public void Setup()
        {
            this.pessoa = new Pessoa();
        }

        [Test]
        public void Test1()
        {
            Assert.Pass();
        }
    }
}