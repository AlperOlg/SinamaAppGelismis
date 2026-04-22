using SinamaApp.Business.Abstract;
using SinamaApp.DataAccessLayer.Abstract;
using SinamaApp.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace SinamaApp.Business.Concrete
{
    public class SeansManager : GenericManager<Seans>, ISeansService
    {
        private readonly ISeansDAL _seansDAL;
        public SeansManager(ISeansDAL seansDAL) : base(seansDAL)
        {
            _seansDAL = seansDAL;
        }

        public async Task<List<Seans>> TSeanslariGetirDetayliAsync(Expression<Func<Seans, bool>> filter = null)
        {
            return await _seansDAL.SeanslariGetirDetayliAsync(filter);
        }
    }
}
