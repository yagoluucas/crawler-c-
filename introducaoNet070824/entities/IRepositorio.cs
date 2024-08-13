using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace introducaoNet070824.entities
{
    internal interface IRepositorio<T> where T:BaseEntity
    {
        void Adicionar(T entity);
        void Atualizar(T entity);
        void Excluir (T entity);
        List<T> Listar();
    }
}
