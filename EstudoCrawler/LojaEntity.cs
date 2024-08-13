using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstudoCrawler
{
    internal class LojaEntity: BaseEntity
    {
        public string nomeLoja { get; set; }

        public string? telefoneLoja { get; set; }

        public string localLoja { get; set; }

        public LojaEntity()
        {
            
        }

        public LojaEntity(string nomeLoja, string localLoja, string telefoneLoja)
        {
            this.nomeLoja = nomeLoja;
            this.telefoneLoja = telefoneLoja;
            this.localLoja = localLoja;
        }

        public override string ToString()
        {
            return $"Nome da loja: {this.nomeLoja}\n" +
                $"Telefone da loja: {this.telefoneLoja}\n" +
                $"Local da loja: {this.localLoja}";
        }
    }
}
