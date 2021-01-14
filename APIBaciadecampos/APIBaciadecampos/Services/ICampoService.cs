using APIBaciadecampos.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APIBaciadecampos.Services
{
    public interface ICampoService
    {
        IEnumerable<Campo> GetAllItems();
        Campo Add(Campo novoItem);
        Campo GetById(int id);
        void Remove(int id);
    }
}
