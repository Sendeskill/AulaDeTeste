using System;

namespace Teste
{
    public class Pessoa
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string CPF { get; set; }
        public string RG { get; set; }
        public int Idade { get; set; }
        public DateTime HoraNascimento { get; set; }


        public string SalvarPessoa(Pessoa pessoa)
        {
            if (pessoa != null)
            {
                return "Ok";
            }
            else
            {
                return "NOk";
            }
        }

        public string EditarPessoa(Pessoa pessoa)
        {
            if (pessoa != null)
            {
                return "Ok";
            }
            else
            {
                return "NOk";
            }
        }

        public string ExcluirPessoa(int id)
        {
            if (id != 0)
            {
                return "Ok";
            }
            else
            {
                return "NOk";
            }
        }
    }
}
