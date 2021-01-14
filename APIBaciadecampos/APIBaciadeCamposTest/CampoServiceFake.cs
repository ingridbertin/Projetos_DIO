using APIBaciadecampos.Models;
using APIBaciadecampos.Services;
using System;
using System.Collections.Generic;
using System.Linq;
namespace APIComprasTest
{
    public class CampoServiceFake : ICampoService
    {
        private readonly List<Campo> _campo;
        public CampoServiceFake()
        {
            _campo = new List<Campo>()
            {
                new Campo() { Id = 1, Nome = "Marlim",
                                   Area = 257.63, Operadora = "PETROBRAS" },
                new Campo() { Id = 2, Nome = "Albacora",
                                   Area = 454.93, Operadora = "PETROBRAS" },                
                new Campo() { Id = 3, Nome = "Papa-Terra",
                                   Area = 182.79 , Operadora = "PETROBRAS" },
                new Campo() { Id = 4, Nome = "Barracuda",
                                   Area = 233.00, Operadora = "PETROBRAS" },
                new Campo() { Id = 5, Nome = "Caratinga",
                                   Area = 260.00, Operadora = "PETROBRAS" },            };
        }
        public IEnumerable<Campo> GetAllItems()
        {
            return _campo;
        }
        public Campo Add(Campo novoItem)
        {
            novoItem.Id = GeraId();
            _campo.Add(novoItem);
            return novoItem;
        }
        public Campo GetById(int id)
        {
            return _campo.Where(a => a.Id == id)
                .FirstOrDefault();
        }
        public void Remove(int id)
        {
            var item = _campo.First(a => a.Id == id);
            _campo.Remove(item);
        }
        static int GeraId()
        {
            Random random = new Random();
            return random.Next(1, 100);
        }
    }
}