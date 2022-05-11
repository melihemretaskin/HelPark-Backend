using HelPark.Core.Models;
using HelPark.Core.Repository.Abstract;
using HelPark.Core.Settings;
using HelPark.DataAccess.Context;
using Microsoft.Extensions.Options;
using MongoDB.Bson;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace HelPark.DataAccess.Repository
{
    public class MongoRepositoryBase<TEntity> : IRepository<TEntity> where
        TEntity : BaseModel
    {
        private readonly MongoDbContext _context;
        private readonly IMongoCollection<TEntity> _collection;

        public MongoRepositoryBase(IOptions<MongoSettings> settings)
        {
            _context = new MongoDbContext(settings);
            _collection = _context.GetCollection<TEntity>();
        }

        public void InsertOne(TEntity entity)
        {
            _collection.InsertOne(entity);
        }

        public void InsertMany(List<TEntity> entityList)
        {
            _collection.InsertMany(entityList);
        }

        public void UpdateOne(TEntity entity)
        {
            _collection.ReplaceOne(item => item.Id == entity.Id, entity);
        }

        public void UpdateMany(List<TEntity> entityList)
        {
            //_collection.UpdateMany(entityList);
        }

        public GetManyResult<TEntity> AsQueryable()
        {
            var result = new GetManyResult<TEntity>();
            try
            {
                var data = _collection.AsQueryable().ToList();

                if (data != null)
                    result.Result = data;

            }
            catch (Exception e)
            {
                result.Message = $"AsQueryable (ex.Message)";
                result.Success = false;
                result.Result = null;
            }
            return result;
        }

        public async Task<GetManyResult<TEntity>> AsQueryableAsync()
        {
            var result = new GetManyResult<TEntity>();
            try
            {
                var data = await _collection.AsQueryable().ToListAsync();

                if (data != null)
                    result.Result = data;

            }
            catch (Exception e)
            {
                result.Message = $"AsQueryable (ex.Message)";
                result.Success = false;
                result.Result = null;
            }
            return result;
        }

        public GetManyResult<TEntity> FilterBy(Expression<Func<TEntity, bool>> filter)
        {
            var result = new GetManyResult<TEntity>();
            try
            {
                var data = _collection.Find(filter).ToList();

                if (data != null)
                    result.Result = data;

            }
            catch (Exception e)
            {
                result.Message = $"FilterBy (ex.Message)";
                result.Success = false;
                result.Result = null;
            }
            return result;
        }

        public async Task<GetManyResult<TEntity>> FilterByAsync(Expression<Func<TEntity, bool>> filter)
        {
            var result = new GetManyResult<TEntity>();
            try
            {
                var data = await _collection.Find(filter).ToListAsync();

                if (data != null)
                    result.Result = data;

            }
            catch (Exception e)
            {
                result.Message = $"FilterBy (ex.Message)";
                result.Success = false;
                result.Result = null;
            }
            return result;
        }

        public GetOneResult<TEntity> GetById(string id)
        {
            var result = new GetOneResult<TEntity>();
            try
            {
                var objectID = ObjectId.Parse(id);
                var filter = Builders<TEntity>.Filter.Eq("_id", objectID);
                var data = _collection.Find(filter).FirstOrDefault();
                if (data != null)
                    result.Entity = data;
            }
            catch (Exception e)
            {
                result.Message = $"GetById (ex.Message)";
                result.Success = false;
                result.Entity = null;
            }
            return result;

        }

        public async Task<GetOneResult<TEntity>> GetByIdAsync(string id)
        {
            var result = new GetOneResult<TEntity>();
            try
            {
                var objectID = ObjectId.Parse(id);
                var filter = Builders<TEntity>.Filter.Eq("_id", objectID);
                var data = await _collection.Find(filter).FirstOrDefaultAsync();
                if (data != null)
                    result.Entity = data;
            }
            catch (Exception e)
            {
                result.Message = $"GetById (ex.Message)";
                result.Success = false;
                result.Entity = null;
            }
            return result;

        }
    }
}
