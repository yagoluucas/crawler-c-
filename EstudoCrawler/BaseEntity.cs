using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstudoCrawler
{
    internal class BaseEntity
    {
        private int id { get; set; }

        public BaseEntity()
        {
            
        }

        public BaseEntity(int id)
        {
            this.id = id;
        }

        public override string ToString()
        {
            return $"Id: {this.id}";
        }
    }
}
