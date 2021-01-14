using MongoDB.Driver;
using petroleumAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace petroleumAPI.Services
{
    public class CampoService
    {
        private readonly IMongoCollection<Campos> _campos;
        public CampoService(IpetroleumDatabaseSettings settings)
        {
            var client = new MongoClient(settings.ConnectionString);
            var database = client.GetDatabase(settings.DatabaseName);

            _campos = database.GetCollection<Campos>(settings.petroleumCollectionName);
        }
        public List<Campos> Get() =>
        _campos.Find(campo => true).ToList();

        public Campos Get(string id) =>
            _campos.Find<Campos>(campo => campo.Id == id).FirstOrDefault();

        public Campos Create(Campos campo)
        {
            _campos.InsertOne(campo);
            return campo;
        }

        public void Update(string id, Campos campoIn) =>
            _campos.ReplaceOne(campo => campo.Id == id, campoIn);

        public void Remove(Campos campoIn) =>
            _campos.DeleteOne(campo => campo.Id == campoIn.Id);

        public void Remove(string id) =>
            _campos.DeleteOne(campo => campo.Id == id);

    }
}
