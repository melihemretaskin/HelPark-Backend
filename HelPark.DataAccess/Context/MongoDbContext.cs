using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HelPark.Core.Settings;
using Microsoft.Extensions.Options;
using MongoDB.Driver;

namespace HelPark.DataAccess.Context
{
    public class MongoDbContext
    {
        private readonly IMongoDatabase _database;

        public MongoDbContext(IOptions<MongoSettings> settings)
        {
            var client = new MongoClient(settings.Value.ConnectionString);
            _database = client.GetDatabase(settings.Value.Database);
        }
        public IMongoCollection<TEntity> GetCollection<TEntity> ()
        {
            return _database.GetCollection<TEntity>(typeof(TEntity).Name.Trim());
        }

        public IMongoDatabase GetDatabase()
        {
            return _database;
        }
    }
}
