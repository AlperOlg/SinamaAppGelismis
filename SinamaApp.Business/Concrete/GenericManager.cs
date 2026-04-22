using SinamaApp.Business.Abstract;
using SinamaApp.DataAccessLayer.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace SinamaApp.Business.Concrete
{
    public class GenericManager<TEntity> : IGenericService<TEntity>
    {
        protected readonly IEntityRepository<TEntity> _repository;
        public GenericManager(IEntityRepository<TEntity> repository)
        {
            _repository = repository;
        }
        public async Task<TEntity> TBirTaneGetirAsync(Expression<Func<TEntity, bool>> filter)
        {
            TEntity entity = await _repository.BirTaneGetirAsync(filter);
            if (entity == null) { throw new Exception("TBirTaneGetirAsnyc Metotu Null Döndürdü"); }
            return entity;
        }

        public async Task TEkleAsync(TEntity entity)
        {
            if (entity == null) { throw new Exception("TEkleAsync Metotunun Parametresi Null"); }
            await _repository.EkleAsync(entity);
        }   

        public async Task TGuncelleAsync(TEntity entity)
        {
            if (entity == null) { throw new Exception("TGuncelleAsync Metotunun Parametresi Null"); }
            await _repository.GuncelleAsync(entity);
        }

        public async Task<List<TEntity>> THepsiniGetirAsync(Expression<Func<TEntity, bool>> filter = null)
        {
            List<TEntity> entities = await _repository.HepsiniGetirAsync(filter);
            if(entities.Count <= 0) { throw new Exception("THepsiniGetirAsync Metotundan Hiçbir Değer Gelmedi "); }
            return entities;
        }

        public async Task TSilAsync(TEntity entity)
        {
            if (entity == null) { throw new Exception("TSilAsync Metotunun Parametresi Null"); }
            await _repository.SilAsync(entity);
        }
    }
}
