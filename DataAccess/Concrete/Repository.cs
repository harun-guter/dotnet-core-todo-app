using Core.DataAccess;
using DataAccess.Constants;
using Entities.Abstract;
using MongoDB.Driver;
using MongoDB.Driver.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace DataAccess.Concrete
{
    public class Repository<TEntity> : IRepository<TEntity> where TEntity : class, IEntity, new()
    {
        private IMongoClient _client;
        private IMongoDatabase _database;
        private IMongoCollection<TEntity> _collection;
        private DateTime _date;

        public Repository()
        {
            _client = new MongoClient(DbSettings.ConnectionString);
            _database = _client.GetDatabase(DbSettings.Database);
            _collection = _database.GetCollection<TEntity>(typeof(TEntity).Name.ToLower() + "s");
            _date = DateTime.Now;
        }

        public TEntity Add(TEntity entity)
        {
            entity.Date = _date;
            _collection.InsertOne(entity);
            return entity;
        }

        public TEntity Delete(string id)
        {
            var entity = _collection.Find(x => x.Id == id).FirstOrDefault();
            _collection.DeleteOneAsync(x => x.Id == id);
            return entity;
        }

        public TEntity Get(string id)
        {
            return _collection.Find(x => x.Id == id).FirstOrDefault();
        }

        public IList<TEntity> GetList(Expression<Func<TEntity, bool>> filter = null)
        {
            return filter == null ?
                _collection.AsQueryable().ToList() :
                _collection.AsQueryable().Where(filter).ToList();
        }

        public TEntity Update(TEntity entity)
        {
            _collection.FindOneAndReplace(x => x.Id == entity.Id, entity);
            return entity;
        }
    }
}
