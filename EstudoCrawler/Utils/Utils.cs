using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstudoCrawler.Utils
{
    internal class Utils
    {
        public string FormatarValor(string? valor, string caracterParaLocalizar)
        {
            return valor.IndexOf(caracterParaLocalizar) == -1 ?
                             valor.Trim() :
                             valor.Substring(0, valor.IndexOf(caracterParaLocalizar)).Trim();
        }
    }
}
