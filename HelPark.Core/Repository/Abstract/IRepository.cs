using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using HelPark.Core.Models;

namespace HelPark.Core.Repository.Abstract
{
    public interface IRepository<TEntity> where TEntity : BaseModel
    {
        void InsertOne(TEntity entity);
        void InsertMany(List<TEntity> entityList);
        GetManyResult<TEntity> AsQueryable();

        Task<GetManyResult<TEntity>> AsQueryableAsync();

        GetManyResult<TEntity> FilterBy(Expression<Func<TEntity, bool>> filter);

        Task<GetManyResult<TEntity>> FilterByAsync(Expression<Func<TEntity, bool>> filter);

        GetOneResult<TEntity> GetById(string id);

        Task<GetOneResult<TEntity>> GetByIdAsync(string id);

    }

}
