using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace introducaoNet070824.entities // esse daqui é igual os pacotes em Java
{
    internal class Produto: BaseEntity
    {
        // por padrão o atributo é privado e para criar o getter e setter é só colocar o { get; set; } nele
        int Id { get; set; }
        string nome { get; set; }

        // para usar o construtor vazio é só usar o ctor (atalho)
        public Produto()
        {

        }

        public Produto(int id, string nome)
        {
            Id = id;
            this.nome = nome;
        }

        // aqui, para fazer o override, não usamos anotação

        public override string ToString()
        {
            return $"Id: {Id} e Nome: {nome}  ";
        }
    }
}
