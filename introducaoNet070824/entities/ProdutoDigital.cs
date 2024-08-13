using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace introducaoNet070824.entities
{
    internal class ProdutoDigital
    {
        public string? url {  get; set; }

        public ProdutoDigital()
        {
            
        }

        public ProdutoDigital(string url)
        {
            this.url = url;
        }

        public override string ToString()
        {
            return $"url: {this.url}";
        }
    }
}
